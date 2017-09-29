namespace WordBaseDownloader.Loaders {
	using System;
	using System.Collections.Generic;
	using System.IO;
	using System.Linq;
	using System.Net;
	using System.Threading.Tasks;
	using HtmlAgilityPack;
	using Models;

	public class WordHelpLoader : IWordLoader {
		public async Task<WordSetModel> LoadWord(string inputWord, int minLength) {
			var url = $"http://wordhelp.ru/comb/{inputWord}";
			var htmlDoc = await LoadHtmlDocAsync(url);
			var wordset = new List<WordModel>();
			var resultModel = new WordSetModel {
				Word = inputWord,
				WordSet = wordset
			};
			var words = htmlDoc.DocumentNode.SelectNodes("//ul[contains(@class, 'results')]/li/a")
				.Select(x => x.InnerText)
				.Where(x => x.Length >= minLength);
			foreach (var word in words) {
				try {
					var model = new WordModel {Word = word};
					var linkToDescription = $"http://wordhelp.ru/word/{word}";
					var doc = await LoadHtmlDocAsync(linkToDescription);
					Console.WriteLine(word);
					model.Sense = doc.DocumentNode.SelectSingleNode("//blockquote/p").InnerText;
					wordset.Add(model);
				}
				catch (Exception e) {
					// ignored
				}
			}

			return resultModel;
		}

		private static async Task<HtmlDocument> LoadHtmlDocAsync(string url) {
			var req = WebRequest.CreateHttp(url);
			req.UserAgent =
				"Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/51.0.2704.103 Safari/537.36";
			var response = await req.GetResponseAsync();
			string result;
			using (var reader = new StreamReader(response.GetResponseStream())) {
				result = reader.ReadToEnd();
			}
			var htmlDoc = new HtmlDocument();
			htmlDoc.LoadHtml(result);
			return htmlDoc;
		}
	}
}
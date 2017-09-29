namespace WordBaseDownloader
{
	using System.Collections.Generic;
	using Input;
	using Loaders;
	using Models;

	public class App {
		private readonly IWordLoader _wordLoader;

		public App(IWordLoader wordLoader) {
			_wordLoader = wordLoader;
		}
	    public IEnumerable<WordSetModel> Start(string inputDataFilePath) {
		    var inputParser = new InputFileParser();
		    var words = inputParser.Parse(inputDataFilePath);
			var res = new List<WordSetModel>();
		    foreach (var word in words) {
				var result = _wordLoader.LoadWord(word, 3).GetAwaiter().GetResult();
			    res.Add(result);
		    }
		    return res;
	    }
    }
}

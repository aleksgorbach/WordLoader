namespace WordBaseDownloader.Models {
	using System.Collections.Generic;

	public class WordSetModel {
		public string Word { get; set; }
		public IEnumerable<WordModel> WordSet { get; set; }
	}
}
namespace WordBaseDownloader.Input {
	using System.Collections.Generic;
	using System.IO;

	public class InputFileParser {
		public IEnumerable<string> Parse(string filePath) {
			var list = new List<string>();
			if (!File.Exists(filePath)) {
				return list;
			}
			using (var reader = new StreamReader(new FileStream(filePath, FileMode.Open))) {
				string line = reader.ReadLine();
				while (line != null) {
					list.Add(line.Trim());
					line = reader.ReadLine();
				}
			}
			return list;
		}
	}
}
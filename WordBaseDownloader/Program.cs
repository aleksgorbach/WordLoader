namespace WordBaseDownloader {
	using System;

	internal class Program {
		public static void Main(string[] args) {
			var app = new App(new WordHelpLoader());
			var result = app.Start(args[0]);
			foreach (var word in result) {
				Console.WriteLine($"{word.Word}:");
				foreach (var w in word.WordSet) {
					Console.WriteLine($"  {w.Word}: {w.Sense}");
				}
			}
			Console.ReadKey();
		}
	}
}
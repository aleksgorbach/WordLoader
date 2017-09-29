namespace WordBaseDownloader.Loaders
{
	using System.Threading.Tasks;
	using Models;

	public interface IWordLoader {
		Task<WordSetModel> LoadWord(string inputWord, int minLength);
	}
}

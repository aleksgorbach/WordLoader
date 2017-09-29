namespace WordBaseDownloader.Desktop {
	using System;
	using System.Windows.Forms;
	using Models;

	public partial class WordEditorControl : UserControl {
		public event Action<WordEditorControl> DeleteRequested;

		public WordEditorControl() {
			InitializeComponent();
		}

		public WordModel Word { get; set; }

		private void deleteButton_Click(object sender, EventArgs e) {
			DeleteRequested?.Invoke(this);
		}
	}
}
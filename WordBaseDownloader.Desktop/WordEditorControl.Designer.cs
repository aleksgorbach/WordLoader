namespace WordBaseDownloader.Desktop
{
	partial class WordEditorControl
	{
		/// <summary> 
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором компонентов

		/// <summary> 
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.word = new System.Windows.Forms.Label();
			this.sense = new System.Windows.Forms.RichTextBox();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// word
			// 
			this.word.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.word.AutoSize = true;
			this.word.Location = new System.Drawing.Point(31, 9);
			this.word.Name = "word";
			this.word.Size = new System.Drawing.Size(46, 13);
			this.word.TabIndex = 0;
			this.word.Text = "example";
			// 
			// sense
			// 
			this.sense.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.sense.Location = new System.Drawing.Point(111, 3);
			this.sense.Name = "sense";
			this.sense.ReadOnly = true;
			this.sense.Size = new System.Drawing.Size(207, 34);
			this.sense.TabIndex = 1;
			this.sense.Text = "";
			// 
			// deleteButton
			// 
			this.deleteButton.Location = new System.Drawing.Point(3, 4);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(22, 23);
			this.deleteButton.TabIndex = 2;
			this.deleteButton.Text = "x";
			this.deleteButton.UseVisualStyleBackColor = true;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// WordEditorControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.sense);
			this.Controls.Add(this.word);
			this.Name = "WordEditorControl";
			this.Size = new System.Drawing.Size(321, 44);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label word;
		private System.Windows.Forms.RichTextBox sense;
		private System.Windows.Forms.Button deleteButton;
	}
}

namespace WordBaseDownloader.Desktop
{
	partial class MainForm
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

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.panel1 = new System.Windows.Forms.Panel();
			this.openFileButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.downloadingProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.saveButton = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.Location = new System.Drawing.Point(13, 13);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(673, 391);
			this.panel1.TabIndex = 0;
			// 
			// openFileButton
			// 
			this.openFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.openFileButton.Location = new System.Drawing.Point(13, 410);
			this.openFileButton.Name = "openFileButton";
			this.openFileButton.Size = new System.Drawing.Size(133, 27);
			this.openFileButton.TabIndex = 1;
			this.openFileButton.Text = "Open File";
			this.openFileButton.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.downloadingProgressBar});
			this.statusStrip1.Location = new System.Drawing.Point(0, 440);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(698, 22);
			this.statusStrip1.TabIndex = 2;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// downloadingProgressBar
			// 
			this.downloadingProgressBar.Name = "downloadingProgressBar";
			this.downloadingProgressBar.Size = new System.Drawing.Size(200, 16);
			// 
			// saveButton
			// 
			this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.saveButton.Location = new System.Drawing.Point(453, 410);
			this.saveButton.Name = "saveButton";
			this.saveButton.Size = new System.Drawing.Size(233, 27);
			this.saveButton.TabIndex = 3;
			this.saveButton.Text = "Save";
			this.saveButton.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 462);
			this.Controls.Add(this.saveButton);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.openFileButton);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Words Downloader";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button openFileButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripProgressBar downloadingProgressBar;
		private System.Windows.Forms.Button saveButton;
	}
}


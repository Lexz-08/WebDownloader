namespace WebDownloader
{
	partial class Main
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
			this.lbl_FileURL = new CometUI.CometLabel();
			this.txt_FileURL = new CometUI.CometTextBox();
			this.lbl_SaveTo = new CometUI.CometLabel();
			this.btn_DownloadFile = new CometUI.CometFlatButton();
			this.prg_DownloadStatus = new CometUI.CometProgressBar();
			this.file_SaveTo = new CometUI.CometFileInput();
			this.SuspendLayout();
			// 
			// lbl_FileURL
			// 
			this.lbl_FileURL.AutoSize = true;
			this.lbl_FileURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_FileURL.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_FileURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_FileURL.Location = new System.Drawing.Point(12, 44);
			this.lbl_FileURL.Name = "lbl_FileURL";
			this.lbl_FileURL.Size = new System.Drawing.Size(61, 19);
			this.lbl_FileURL.TabIndex = 0;
			this.lbl_FileURL.Text = "File URL:";
			// 
			// txt_FileURL
			// 
			this.txt_FileURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.txt_FileURL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.txt_FileURL.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_FileURL.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.txt_FileURL.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.txt_FileURL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.txt_FileURL.Location = new System.Drawing.Point(79, 41);
			this.txt_FileURL.Multiline = false;
			this.txt_FileURL.Name = "txt_FileURL";
			this.txt_FileURL.Readonly = false;
			this.txt_FileURL.Size = new System.Drawing.Size(314, 26);
			this.txt_FileURL.TabIndex = 1;
			this.txt_FileURL.UnderlineBorder = false;
			this.txt_FileURL.UseSystemPasswordChar = false;
			// 
			// lbl_SaveTo
			// 
			this.lbl_SaveTo.AutoSize = true;
			this.lbl_SaveTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.lbl_SaveTo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.lbl_SaveTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.lbl_SaveTo.Location = new System.Drawing.Point(12, 76);
			this.lbl_SaveTo.Name = "lbl_SaveTo";
			this.lbl_SaveTo.Size = new System.Drawing.Size(58, 19);
			this.lbl_SaveTo.TabIndex = 2;
			this.lbl_SaveTo.Text = "Save To:";
			// 
			// btn_DownloadFile
			// 
			this.btn_DownloadFile.BorderWidth = 1;
			this.btn_DownloadFile.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_DownloadFile.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.btn_DownloadFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.btn_DownloadFile.Location = new System.Drawing.Point(277, 105);
			this.btn_DownloadFile.Name = "btn_DownloadFile";
			this.btn_DownloadFile.Size = new System.Drawing.Size(116, 28);
			this.btn_DownloadFile.TabIndex = 4;
			this.btn_DownloadFile.Text = "Download File";
			this.btn_DownloadFile.Click += new System.EventHandler(this.DownloadFile_Click);
			// 
			// prg_DownloadStatus
			// 
			this.prg_DownloadStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.prg_DownloadStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.prg_DownloadStatus.DefaultValue = 50D;
			this.prg_DownloadStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.prg_DownloadStatus.Location = new System.Drawing.Point(12, 105);
			this.prg_DownloadStatus.Maximum = 100D;
			this.prg_DownloadStatus.Minimum = 0D;
			this.prg_DownloadStatus.Name = "prg_DownloadStatus";
			this.prg_DownloadStatus.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			this.prg_DownloadStatus.Size = new System.Drawing.Size(259, 28);
			this.prg_DownloadStatus.TabIndex = 5;
			this.prg_DownloadStatus.Value = 0D;
			// 
			// file_SaveTo
			// 
			this.file_SaveTo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
			this.file_SaveTo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			this.file_SaveTo.Cursor = System.Windows.Forms.Cursors.Default;
			this.file_SaveTo.DefaultFilter = 1;
			this.file_SaveTo.DialogTitle = "Please choose a file to open...";
			this.file_SaveTo.FileChooserColor = System.Drawing.Color.DodgerBlue;
			this.file_SaveTo.FileFilter = "All Files|*.*";
			this.file_SaveTo.FocusedBorderColor = System.Drawing.Color.DodgerBlue;
			this.file_SaveTo.Font = new System.Drawing.Font("Segoe UI", 10F);
			this.file_SaveTo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			this.file_SaveTo.InputType = CometUI.CometFileInputType.SaveFile;
			this.file_SaveTo.Location = new System.Drawing.Point(79, 73);
			this.file_SaveTo.Name = "file_SaveTo";
			this.file_SaveTo.Size = new System.Drawing.Size(314, 26);
			this.file_SaveTo.TabIndex = 6;
			this.file_SaveTo.UnderlineBorder = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CanResize = false;
			this.ClientSize = new System.Drawing.Size(405, 145);
			this.Controls.Add(this.file_SaveTo);
			this.Controls.Add(this.prg_DownloadStatus);
			this.Controls.Add(this.btn_DownloadFile);
			this.Controls.Add(this.lbl_SaveTo);
			this.Controls.Add(this.txt_FileURL);
			this.Controls.Add(this.lbl_FileURL);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.MaximizeBox = false;
			this.MinimumSize = new System.Drawing.Size(233, 131);
			this.Name = "Form1";
			this.Text = "WebDownloader";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private CometUI.CometLabel lbl_FileURL;
		private CometUI.CometTextBox txt_FileURL;
		private CometUI.CometLabel lbl_SaveTo;
		private CometUI.CometFlatButton btn_DownloadFile;
		private CometUI.CometProgressBar prg_DownloadStatus;
		private CometUI.CometFileInput file_SaveTo;
	}
}


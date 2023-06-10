using CometUI;
using System;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WebDownloader
{
	public partial class Main : CometForm
	{
		public Main()
		{
			InitializeComponent();
		}

		private void DownloadFile_Click(object sender, EventArgs e)
		{
			if (Uri.TryCreate(txt_FileURL.Text, UriKind.Absolute, out Uri uri_Result) && uri_Result.Scheme == Uri.UriSchemeHttps)
			{
				using (WebClient client = new WebClient())
				{
					client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged);
					client.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_AsyncCompleted);

					client.DownloadFileAsync(new Uri(txt_FileURL.Text), file_SaveTo.File);
				}
			}
			else MessageBox.Show("File URL specified was invalid", "Invalid File URL",
				MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void WebClient_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			prg_DownloadStatus.Value = e.ProgressPercentage;
		}

		private void WebClient_AsyncCompleted(object sender, AsyncCompletedEventArgs e)
		{
			MessageBox.Show("File download completed successfully.", "Download Success",
				MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}

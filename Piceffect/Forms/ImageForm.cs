using System;
using System.Drawing;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class ImageForm : Form
	{
		public ImageForm(Bitmap image)
		{
			InitializeComponent();
			Picture.Image = image;
		}

		private void ImageForm_Resize(object sender, EventArgs e)
		{
			UpdateComponents();
		}

		private void UpdateComponents()
		{
			if (Picture.Image != null)
			{
				if (ClientSize.Width >= Picture.Image.Width && ClientSize.Height >= Picture.Image.Height || !RealSize.Checked)
				{
					PanelBox.AutoScroll = false;
					Picture.Dock = DockStyle.Fill;
					Picture.SizeMode = PictureBoxSizeMode.Zoom;
				}
				else
				{
					PanelBox.AutoScroll = true;
					Picture.Dock = DockStyle.None;
					Picture.SizeMode = PictureBoxSizeMode.AutoSize;
				}
			}
		}

		private void RealSize_Click(object sender, EventArgs e)
		{
			RealSize.Checked = !RealSize.Checked;
			UpdateComponents();
		}

		private void ImageForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.R:
						RealSize.PerformClick();
						break;
				}
			}
		}
	}
}

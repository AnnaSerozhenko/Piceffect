using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace Piceffect
{
	public partial class MainForm : Form
	{
		private bool Exit = true;
		private Dictionary<int, BitmapPair> images = new Dictionary<int, BitmapPair>();
		private int counter = 0;

		public MainForm()
		{
			InitializeComponent();
            CorrectionType.SelectedIndex = 0;
            Effect.SelectedIndex = 0;
		}

		private void OpenMI_Click(object sender, EventArgs e)
		{
			if (OpenFile.ShowDialog() == DialogResult.OK)
			{
				try
				{
					Bitmap image = new Bitmap(OpenFile.FileName);
					if (!image.RawFormat.Equals(ImageFormat.Bmp) && !image.RawFormat.Equals(ImageFormat.Jpeg))
						Message.Warning("Incorrect image format!", Text);
					else
					{
						images.Add(counter, new BitmapPair(image));
						//picture
						PictureBox picture = new PictureBox();
						picture.Name = "PB" + counter;
						picture.SizeMode = PictureBoxSizeMode.Zoom;
						picture.Dock = DockStyle.Fill;
						picture.Image = image;
						picture.ContextMenuStrip = ImageMenu;
						//tabpage for picture
						TabPage page = new TabPage(Path.GetFileName(OpenFile.FileName));
						page.Name = "TP" + counter;
						page.Controls.Add(picture);
						Tabs.TabPages.Add(page);
						++counter;
					}
				}
				catch (Exception exception)
				{
					Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
					Message.Warning("Couldn't open image!", Text);
				}
			}
		}

		private void AdminPanelMI_Click(object sender, EventArgs e)
		{
			AdminPanelForm adminPanel = new AdminPanelForm();
			adminPanel.ShowDialog();
		}

		private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			SettingsForm settings = new SettingsForm();
			settings.ShowDialog();
		}

        private void Main_Load(object sender, EventArgs e)
        {
			if (!Session.IsAdmin)
			{
				AdminPanelMI.Visible = false;
				SettingsMI.Visible = false;
			}
        }

		private void LogoutMI_Click(object sender, EventArgs e)
		{
			Session.Destroy();
			Owner.Show();
			Exit = false;
			Close();
		}

		private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (Exit) Application.Exit();
		}

		private void AccountMI_Click(object sender, EventArgs e)
		{
			AccountForm account = new AccountForm();
			account.ShowDialog();
		}

		private void Fullsize_Click(object sender, EventArgs e)
		{
			ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
			PictureBox box = (PictureBox)menu.SourceControl;
			int index = int.Parse(box.Name.Remove(0, 2));
			OpenFullsize(index);
		}

		private void OpenFullsize(int index)
		{
			ImageForm imageForm = new ImageForm(ShowMI.Checked && images[index].Result != null ? images[index].Result : images[index].Source);
			imageForm.ShowDialog();
		}

		private void CloseImage_Click(object sender, EventArgs e)
		{
			ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
			PictureBox box = (PictureBox)menu.SourceControl;
			int index = int.Parse(box.Name.Remove(0, 2));
			if (images[index].Result != null && Message.Info("Do you want to save changes?", Text, true) == DialogResult.Yes)
			{
				if (SaveFile.ShowDialog() == DialogResult.OK)
				{
					images[index].Result.Save(SaveFile.FileName);
					Message.Info("Image saved!", Text);
				}
			}
			else
			{
				images.Remove(index);
				Tabs.TabPages.RemoveByKey("TP" + index);
			}
		}

		private void ShowMI_Click(object sender, EventArgs e)
		{
			ShowMI.Checked = !ShowMI.Checked;
			foreach (TabPage page in Tabs.TabPages)
			{
				int index = int.Parse(page.Name.Remove(0, 2));
				((PictureBox)page.Controls["PB" + index]).Image = ShowMI.Checked && images[index].Result != null ? images[index].Result : images[index].Source;
			}
		}

		private void ProcessMI_Click(object sender, EventArgs e)
		{
			ProcessMI.Checked = !ProcessMI.Checked;
		}

		private void ResetChanges_Click(object sender, EventArgs e)
		{
			if (Message.Info("Do you really want to reset changes?", Text, true) == DialogResult.Yes)
			{
				ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
				PictureBox box = (PictureBox)menu.SourceControl;
				int index = int.Parse(box.Name.Remove(0, 2));
				images[index] = new BitmapPair(images[index].Source);
				box.Image = images[index].Source;
			}
		}

		private void SaveImage_Click(object sender, EventArgs e)
		{
			if (SaveFile.ShowDialog() == DialogResult.OK)
			{
				ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
				PictureBox box = (PictureBox)menu.SourceControl;
				int index = int.Parse(box.Name.Remove(0, 2));
				if (ShowMI.Checked && images[index].Result != null)
					images[index].Result.Save(SaveFile.FileName);
				else
					images[index].Source.Save(SaveFile.FileName);
				Message.Info("Image saved!", Text);
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control)
			{
				switch (e.KeyCode)
				{
					case Keys.A:
						Apply.PerformClick();
						break;
					case Keys.O:
						OpenMI.PerformClick();
						break;
					case Keys.F:
						if (Tabs.SelectedTab != null)
						{
							int index = int.Parse(Tabs.SelectedTab.Name.Remove(0, 2));
							OpenFullsize(index);
						}
						break;
				}
			}
		}

		private void Apply_Click(object sender, EventArgs e)
		{
			Message.Info("Apply!", Text);
		}
	}

	struct BitmapPair
	{
		public BitmapPair(Bitmap image)
		{
			Source = image;
			Result = null;
		}
		public Bitmap Source;
		public Bitmap Result;
	}
}

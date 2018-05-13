using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Text;

namespace Piceffect
{
	public partial class MainForm : Form
	{
		private bool Exit = true;
		private Dictionary<int, BitmapPair> images = new Dictionary<int, BitmapPair>();
		private Queue<int> queue = new Queue<int>();
		private int counter = 0;
		private Thread thread;

		public MainForm()
		{
			InitializeComponent();
            CorrectionType.SelectedIndex = 0;
            CurrentEffect.SelectedIndex = 0;
		}

		private void OpenMI_Click(object sender, EventArgs e)
		{
			if (OpenImage.ShowDialog() == DialogResult.OK)
			{
				bool success = true;
				foreach (string path in OpenImage.FileNames)
				{
					try
					{
						Bitmap image;
						using (FileStream stream = new FileStream(path, FileMode.Open))
							image = new Bitmap(stream);
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
							TabPage page = new TabPage(Path.GetFileName(path));
							page.Name = "TP" + counter;
							page.Controls.Add(picture);
							Tabs.TabPages.Add(page);
							++counter;
						}
					}
					catch (Exception exception)
					{
						Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
						success = false;
					}
				}
				if (!success) Message.Warning("Failed to open some images!", Text);
				UpdateUI();
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
			CorrectionType.SelectedIndex = 0;
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
			if (thread != null && thread.IsAlive)
			{
				Message.Warning("Can not exit before processing is complete!", Text);
				e.Cancel = true;
				return;
			}
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
			Bitmap image = ShowMI.Checked && images[index].Result != null ? images[index].Result : images[index].Source;
			ImageForm imageForm = new ImageForm(image);
			imageForm.ShowDialog();
		}

		private void CloseImage_Click(object sender, EventArgs e)
		{
			ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
			PictureBox box = (PictureBox)menu.SourceControl;
			int index = int.Parse(box.Name.Remove(0, 2));
			if (images[index].Result != null)
			{
				if (Message.Info("Do you want to save changes?", Text, true) == DialogResult.Yes)
				{
					if (SaveImageDialog.ShowDialog() == DialogResult.OK)
					{
						images[index].Result.Save(SaveImageDialog.FileName);
						Message.Info("Image saved!", Text);
					}
				}
			}
			images.Remove(index);
			Tabs.TabPages.RemoveByKey("TP" + index);
			UpdateUI();
		}

		private void ShowMI_Click(object sender, EventArgs e)
		{
			ShowMI.Checked = !ShowMI.Checked;
			foreach (TabPage page in Tabs.TabPages)
			{
				int index = int.Parse(page.Name.Remove(0, 2));
				Bitmap image = ShowMI.Checked && images[index].Result != null ? images[index].Result : images[index].Source;
				((PictureBox)page.Controls["PB" + index]).Image = image;
			}
		}

		private void ProcessMI_Click(object sender, EventArgs e)
		{
			ProcessMI.Checked = !ProcessMI.Checked;
		}

		private void ResetChanges_Click(object sender, EventArgs e)
		{
			ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
			PictureBox box = (PictureBox)menu.SourceControl;
			int index = int.Parse(box.Name.Remove(0, 2));
			Reset(index);
		}

		private void Reset(int index)
		{
			if (Message.Info("Do you really want to reset changes?", Text, true) == DialogResult.Yes)
			{
				images[index].Result = null;
				((PictureBox)Tabs.Controls.Find("PB" + index, true)[0]).Image = images[index].Source;
			}
		}

		private void SaveImage_Click(object sender, EventArgs e)
		{
			ContextMenuStrip menu = (ContextMenuStrip)((ToolStripMenuItem)sender).Owner;
			PictureBox box = (PictureBox)menu.SourceControl;
			int index = int.Parse(box.Name.Remove(0, 2));
			Save(index);
		}

		private void Save(int index)
		{
			if (SaveImageDialog.ShowDialog() == DialogResult.OK)
			{
				if (ShowMI.Checked && images[index].Result != null)
					images[index].Result.Save(SaveImageDialog.FileName);
				else
					images[index].Source.Save(SaveImageDialog.FileName);
				Message.Info("Image saved!", Text);
			}
		}

		private void MainForm_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && !(thread != null && thread.IsAlive))
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
					case Keys.S:
						if (Tabs.SelectedTab != null)
						{
							int index = int.Parse(Tabs.SelectedTab.Name.Remove(0, 2));
							Save(index);
						}
						break;
					case Keys.R:
						if (Tabs.SelectedTab != null)
						{
							int index = int.Parse(Tabs.SelectedTab.Name.Remove(0, 2));
							Reset(index);
						}
						break;
				}
			}
		}

		private void UpdateUI()
		{
			bool enabled = Tabs.TabCount > 0;
			UpdateUI(enabled);
		}

		private void UpdateUI(bool enabled)
		{
			Apply.Enabled = enabled;
			Parameters.Enabled = enabled;
			CurrentEffect.Enabled = enabled;
		}

		private int queueSize = 0;

		private void Apply_Click(object sender, EventArgs e)
		{
			queue.Clear();
			if (!ProcessMI.Checked) queue.Enqueue(int.Parse(Tabs.SelectedTab.Name.Remove(0, 2)));
			else
			{
				foreach (KeyValuePair<int, BitmapPair> image in images)
					queue.Enqueue(image.Key);
			}
			PauseButton.Enabled = true;
			StopButton.Enabled = true;
			MainMenu.Enabled = false;
			UpdateUI(false);
			SetEffects();
			queueSize = queue.Count;
			ProgressLabel.Text = "Processed: 0/" + queueSize;
			string effect = CurrentEffect.Text;
			if (effect.Equals("Correction")) effect = CorrectionType.Text + effect;
			Journal.Append(String.Format("{0} processed {1} image{2} using effect {3}", Session.Login, queue.Count, (queue.Count > 1 ? "s" : String.Empty), effect));
			thread = new Thread(() => Processing(effect));
			thread.Start();
		}

		private void Processing(string effect)
		{
			BaseFilter filter;
			SortedList<string, object> parameters = new SortedList<string, object>() { };
			switch (effect)
			{
				case "Wave":
					filter = new Wave();
					break;
				case "Glass":
					filter = new Glass();
					break;
				case "NonlinearCorrection":
					filter = new NonlinearCorrection();
					parameters.Add("coefficient", Effects.NonlinearCoefficient);
					filter.Init(parameters);
					break;
				case "Gamma":
					filter = new Gamma();
					parameters.Add("gamma", (float)Effects.Gamma / 10);
					filter.Init(parameters);
					break;
				case "Noise":
					filter = new Noise();
					parameters.Add("strength", Effects.NoiseStrength);
					parameters.Add("scale", (float)Effects.NoiseSize / 10);
					filter.Init(parameters);
					break;
				default:
					filter = new LinearCorrection();
					break;

			}
			while (queue.Count > 0)
			{
				int index = queue.Dequeue();
				filter.Source = new Bitmap(images[index].Result != null ? images[index].Result : images[index].Source);
				filter.StartHandle();
				images[index].Result = filter.Result;
				Invoke((MethodInvoker)(() =>
				{
					ProgressLabel.Text = "Processed: " + (queueSize - queue.Count) + "/" + queueSize;
					Bitmap image = ShowMI.Checked && images[index].Result != null ? images[index].Result : images[index].Source;
					((PictureBox)Tabs.Controls.Find("PB" + index, true)[0]).Image = image;
				}));
			}
			Invoke((MethodInvoker)(() => {
				PauseButton.Enabled = false;
				StopButton.Enabled = false;
				MainMenu.Enabled = true;
				UpdateUI(true);
			}));
		}

		private void CorrectionType_SelectedIndexChanged(object sender, EventArgs e)
		{
			CoefficientBox.Enabled = CorrectionType.Text.Equals("Nonlinear");
		}

		private void CoefficientBox_Scroll(object sender, EventArgs e)
		{
			CoefficientValue.Text = CoefficientBox.Value.ToString();
		}

		private void GammaBox_Scroll(object sender, EventArgs e)
		{
			GammaValue.Text = (GammaBox.Value / 10f).ToString("0.0");
		}

		private void StrengthBox_Scroll(object sender, EventArgs e)
		{
			StrengthValue.Text = StrengthBox.Value.ToString();
		}

		private void SizeBox_Scroll(object sender, EventArgs e)
		{
			SizeValue.Text = SizeBox.Value.ToString() + "%";
		}

		private void SetEffects()
		{
			Effects.NonlinearCoefficient = CoefficientBox.Value;
			Effects.Gamma = GammaBox.Value;
			Effects.NoiseStrength = StrengthBox.Value;
			Effects.NoiseSize = SizeBox.Value;
		}

		private void ExportMI_Click(object sender, EventArgs e)
		{
			if (SaveXML.ShowDialog() == DialogResult.OK)
			{
				Effects.Path = SaveXML.FileName;
				SetEffects();
				Effects.Export();
				Journal.Append(String.Format("{0} exported parameters", Session.Login));
				Message.Info("Parameters was exported!", Text);
			}
		}

		private void ImportMI_Click(object sender, EventArgs e)
		{
			if (OpenXML.ShowDialog() == DialogResult.OK)
			{
				Effects.Path = OpenXML.FileName;
				Effects.Import();
				if (Effects.NonlinearCoefficient > CoefficientBox.Maximum || Effects.NonlinearCoefficient < CoefficientBox.Minimum)
					Effects.NonlinearCoefficient = CoefficientBox.Value;
				if (Effects.Gamma > GammaBox.Maximum || Effects.Gamma < GammaBox.Minimum)
					Effects.Gamma = GammaBox.Value;
				if (Effects.NoiseStrength > StrengthBox.Maximum || Effects.NoiseStrength < StrengthBox.Minimum)
					Effects.NoiseStrength = StrengthBox.Value;
				if (Effects.NoiseSize > SizeBox.Maximum || Effects.NoiseSize < SizeBox.Minimum)
					Effects.NoiseSize = SizeBox.Value;
				CoefficientBox.Value = Effects.NonlinearCoefficient;
				CoefficientValue.Text = CoefficientBox.Value.ToString();
				GammaBox.Value = Effects.Gamma;
				GammaValue.Text = (GammaBox.Value / 10f).ToString("0.0");
				StrengthBox.Value = Effects.NoiseStrength;
				StrengthValue.Text = StrengthBox.Value.ToString();
				SizeBox.Value = Effects.NoiseSize;
				SizeValue.Text = SizeBox.Value.ToString() + "%";
				Journal.Append(String.Format("{0} imported parameters", Session.Login));
				Message.Info("Parameters was imported!", Text);
			}
		}

		private void CurrentEffect_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (CurrentEffect.Text)
			{
				case "Correction":
					Parameters.SelectTab("TabCorrection");
					break;
				case "Gamma":
					Parameters.SelectTab("TabGamma");
					break;
				case "Noise":
					Parameters.SelectTab("TabNoise");
					break;
			}
		}

		private void Parameters_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (Parameters.SelectedTab.Text)
			{
				case "Correction":
					CurrentEffect.SelectedItem = "Correction";
					break;
				case "Gamma":
					CurrentEffect.SelectedItem = "Gamma";
					break;
				case "Noise":
					CurrentEffect.SelectedItem = "Noise";
					break;
			}
		}

		private void ResetAllMI_Click(object sender, EventArgs e)
		{
			if (Message.Info("Do you really want to reset all changes?", Text, true) == DialogResult.Yes)
			{
				foreach (TabPage page in Tabs.TabPages)
				{
					int index = int.Parse(page.Name.Remove(0, 2));
					images[index].Result = null;
					Bitmap image = images[index].Source;
					((PictureBox)page.Controls["PB" + index]).Image = image;
				}
			}
		}

		private void StopButton_Click(object sender, EventArgs e)
		{
			if (thread != null && thread.IsAlive)
			{
				if (thread.ThreadState == ThreadState.Suspended) thread.Resume();
				thread.Abort();
			}
			PauseButton.Enabled = false;
			StopButton.Enabled = false;
			MainMenu.Enabled = true;
			UpdateUI(true);
		}

		private void PauseButton_Click(object sender, EventArgs e)
		{
			try
			{
				if (thread.ThreadState == ThreadState.Running)
				{
					PauseButton.Text = "Resume";
					thread.Suspend();
				}
				else
				{
					PauseButton.Text = "Pause";
					thread.Resume();
				}
			}
			catch (Exception exception)
			{
				Log.Append(exception.Message + Environment.NewLine + exception.StackTrace);
			}
		}

		private void AboutMI_Click(object sender, EventArgs e)
		{
			StringBuilder builder = new StringBuilder();
			builder.Append("Product: Piceffect v1.0");
			builder.Append(Environment.NewLine);
			builder.Append(Environment.NewLine);
			builder.Append("Company: Impleas");
			builder.Append(Environment.NewLine);
			builder.Append("Command: Dmitry Pyltsov, Yury Kapkov, Anna Serozhenko");
			builder.Append(Environment.NewLine);
			Message.Info(builder.ToString(), "About");
		}
	}

	class BitmapPair
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

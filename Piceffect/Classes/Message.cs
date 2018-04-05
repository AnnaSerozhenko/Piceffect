using System.Windows.Forms;

namespace Piceffect
{
	static class Message
	{
		public static DialogResult Warning(string text, string caption, bool question = false)
		{
			return MessageBox.Show(
				text,
				caption,
				question ? MessageBoxButtons.YesNo : MessageBoxButtons.OK,
				MessageBoxIcon.Warning
			);
		}

		public static DialogResult Info(string text, string caption, bool question = false)
		{
			return MessageBox.Show(
				text, 
				caption, 
				question ? MessageBoxButtons.YesNo : MessageBoxButtons.OK, 
				MessageBoxIcon.Information
			);
		}

		public static DialogResult Error(string text, string caption, bool question = false)
		{
			return MessageBox.Show(
				text,
				caption,
				question ? MessageBoxButtons.YesNo : MessageBoxButtons.OK,
				MessageBoxIcon.Error
			);
		}
	}
}

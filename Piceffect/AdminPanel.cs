using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piceffect
{
	public partial class AdminPanel : Form
	{
		public AdminPanel()
		{
			InitializeComponent();
		}

		private void AdminPanel_Load(object sender, EventArgs e)
		{
			Accounts.Rows.Add(new object[] { 1, "dmitrypyltsov", "01.03.2018", false });
			Accounts.Rows.Add(new object[] { 2, "yurykapkov", "28.02.2018", true });
		}
	}
}

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
			Accounts.Rows.Add(new object[] { 1, "dmitrypyltsov", "11.02.2018", "25.03.2018", false });
			Accounts.Rows.Add(new object[] { 2, "annaserozhenko", "17.02.2018", "23.03.2018", false });
			Accounts.Rows.Add(new object[] { 3, "yurykapkov", "28.02.2018", "20.03.2018", true });
		}
	}
}

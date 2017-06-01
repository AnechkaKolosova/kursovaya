using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
	public partial class contacts : Form
	{
		public contacts(Flat my)
		{
			InitializeComponent();
			this.textBox1.Text = my.UserDate.Name;
			this.textBox2.Text = Convert.ToString(my.UserDate.Number);
			this.textBox3.Text = my.UserDate.Mail;

		}


		
	}
}

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
	public partial class MyFlats : Form
	{
		public Flat My;
		public MyFlats(int index)
		{
			InitializeComponent();
			My = Form1.Itself.search[index];
			textBox1.Text = My.Adres.City;
			textBox2.Text = My.Adres.District;
			textBox3.Text = My.About.Type;
			textBox4.Text = Convert.ToString(My.About.Room);
			textBox5.Text = Convert.ToString(My.About.Floor);
			textBox6.Text = Convert.ToString(My.About.Place);
			textBox7.Text = Convert.ToString(My.About.Price);
			textBox8.Text = My.UserDate.Name;
			richTextBox1.Text = My.About.Description;

		}

		private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Hide();
			Form1 main = new Form1();
			main.ShowDialog();
			Close();
		}
		
		

		private void продатьToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Hide();
			Sell sell = new Sell();
			sell.ShowDialog();
			Close();
		}

		private void купитьToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			Hide();
			Buy buy = new Buy();
			buy.ShowDialog();
			Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			contacts s = new contacts(My);
			s.ShowDialog();

		}

		private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
		{
			
			System.Diagnostics.Process.Start(@"справка.txt");
		}
	}
}

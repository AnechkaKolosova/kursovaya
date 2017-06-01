using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WindowsFormsApplication5
{
	partial class Buy : Form
	{

		public void SearchResalt()
		{
			dataGridView1.Rows.Clear();

			foreach (Flat i in Search(comboBox2.Text, comboBox3.Text, comboBox1.Text, comboBox4.Text, comboBox5.Text,
				comboBox6.Text, comboBox9.Text, comboBox10.Text, comboBox7.Text, comboBox8.Text))
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}

		public void GetBaseFromFile()
		{
			if (openFileDialog1.ShowDialog() == DialogResult.Cancel) return;

			dataGridView1.Rows.Clear();
			string fname = openFileDialog1.FileName;
			string ftext = System.IO.File.ReadAllText(fname);

			string substring = "System.String[]";
			if (ftext.IndexOf(substring) != -1)
			{

				ftext = ftext.Remove(ftext.IndexOf(substring), substring.Length);
			}
			Form1.Itself.flats = JsonConvert.DeserializeObject<Base>(ftext);

			foreach (Flat i in Form1.Itself.flats)
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}

		public void GetMyBase()
		{
			

			dataGridView1.Rows.Clear();
			string fname = "base.txt";
			string ftext = System.IO.File.ReadAllText(fname);

			string substring = "System.String[]";
			if (ftext.IndexOf(substring) != -1)
			{

				ftext = ftext.Remove(ftext.IndexOf(substring), substring.Length);
			}
			Form1.Itself.flats = JsonConvert.DeserializeObject<Base>(ftext);

			foreach (Flat i in Form1.Itself.flats)
			{
				dataGridView1.Rows.Add(i.Adres.City, i.Adres.District, i.About.Type, i.About.Room, i.About.Floor, i.About.Place);
			}
		}

		public void GoToFlat()
		{
			Hide();
			MyFlats myflats = new MyFlats(dataGridView1.CurrentRow.Index);
			myflats.ShowDialog();
			Close();
		}

		public void GoToMain()
		{
			Hide();
			Form1 main = new Form1();
			main.ShowDialog();
			Close();
		}

		public void GoToBuy()
		{
			Hide();
			Buy buy = new Buy();
			buy.ShowDialog();
			Close();
		}

		public void GoToSell()
		{
			Hide();
			Sell sell = new Sell();
			sell.ShowDialog();
			Close();
		}

		public void CorrectInt(KeyPressEventArgs e)
		{
		   if (e.KeyChar >= '0' && e.KeyChar <= '9')
				{
					return;
				}
				if (Char.IsControl(e.KeyChar))
				{
					return;
				}

				else
				{
					e.Handled = true;
				}
			
		}
	}
}
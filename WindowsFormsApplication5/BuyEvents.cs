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
		//Search
		private void button1_Click(object sender, EventArgs e)
		{
			SearchResalt();
		}

		private void EditCombo(ComboBox c, List<string> l)
		{
			c.Items.Clear();
			foreach (string i in l)
			{
				c.Items.Add(i);
			}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			GetBaseFromFile();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			GetMyBase();
		}

		private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			GoToFlat();
		}
		private void главнаяToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GoToMain();
		}
		private void купитьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GoToBuy();
		}
		private void продатьToolStripMenuItem_Click(object sender, EventArgs e)
		{
			GoToSell();
		}
		private void comboBox4_KeyPress(object sender, KeyPressEventArgs e)
		{
			CorrectInt(e);
			try
			{
				if (Convert.ToInt32(comboBox4.Text) > 99) comboBox4.BackColor = Color.BlueViolet;
				else comboBox4.BackColor = Color.White;
				
			}
			catch
			{
				return;
			}
		}
		private void comboBox5_KeyPress(object sender, KeyPressEventArgs e)
		{
			CorrectInt(e);
			try
			{
				if (Convert.ToInt32(comboBox5.Text) > 99) comboBox5.BackColor = Color.BlueViolet;
				else comboBox5.BackColor = Color.White;
				
			}
			catch
			{
				return;
			}
		}
	}
}
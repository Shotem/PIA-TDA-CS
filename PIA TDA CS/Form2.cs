using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PIA_TDA_CS {
	public partial class Form2 : Form {
		public Form2() {
			InitializeComponent();
		}

		private void textBox2_TextChanged(object sender, EventArgs e) {

		}

		private void textBox3_TextChanged(object sender, EventArgs e) {

		}

		private void Form2_Load(object sender, EventArgs e) {
			button1.Select();
			richTextBox1.SelectAll();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;
			
		}

		private void button1_Click(object sender, EventArgs e) {
			this.Hide();
			this.Dispose();
		}

		private void textBox1_TextChanged(object sender, EventArgs e) {

		}

		private void textBox4_TextChanged(object sender, EventArgs e) {

		}

		private void richTextBox1_TextChanged(object sender, EventArgs e) {

		}
	}
}

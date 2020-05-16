using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PIA_TDA_CS {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
            
            
        }

		private void button1_Click(object sender, EventArgs e) {
			var ids = new List<string>();
			Regex regex;
			var line = primaryTextInput.Lines[0];
			regex = new Regex("^programa [a-z][a-z0-9]*;$");
			Console.WriteLine(regex.IsMatch(line));

			regex = new Regex("^iniciar$");
			line = primaryTextInput.Lines[1];
			Console.WriteLine(regex.IsMatch(line));

			Regex rLeer = new Regex("^leer [a-z][a-z0-9]*;$");
			Regex rImprimir = new Regex("^imprimir [a-z][a-z0-9]*;$");
			Regex rAsignar = new Regex("^[a-z][a-z0-9]*\\s?:=[a-z][a-z0-9]*$");
			var variables = new List<string>();
			for (int i = 2; i < primaryTextInput.Lines.Length-1; i++) {
				bool valid = false;
				string s;
				line = primaryTextInput.Lines[i];
				if (rLeer.IsMatch(line)) {
					s = line.Substring(line.IndexOf(' '), line.Length-line.IndexOf(';'));
					ids.Add(s);
					valid = true;
				}
				valid |= rImprimir.IsMatch(line);
				Console.WriteLine(valid);
			}
			regex = new Regex("^terminar.$");
			line = primaryTextInput.Lines[primaryTextInput.Lines.Length - 1];
			Console.WriteLine(regex.IsMatch(line));
			Console.WriteLine("====================");

		}
	}
}

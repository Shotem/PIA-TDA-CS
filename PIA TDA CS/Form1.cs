using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.IO;

namespace PIA_TDA_CS {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e) {
			Parser.MathParser p = new Parser.MathParser();
			/*
			var test = new string[] {
				"628+941^56-786",
				"240-582-(514)",
				"624*569/655^285*400",
				"395^204+253",
				"((925)^800-374+719)*132",
				"(554)*938",
				"827-(29)",
				"607*66",
				"(838*675/483)",
				"634^994",
				"(3/2)^(4/5)",
				"(4-5)^(1/2)",
				"(((1/2)-1)^(3/2))*((0-1)^(1/2)))",
				"((0-1)^(0-1))^(1/2)",
				"(2*(2-3))/(1-1)",
				"(2-(4/2))^((3^(4*(1/2))-(18/2))",
				"3*((2*2)/2)",
				"((3-4)*(4-7)*(7-3))^(3*(4/7))+3(7-4)",
				"1 +",
				"16+4^()",
				"8/0"
			};
			foreach (var s in test) {
				Console.WriteLine(p.Parse(s) + " " + s);
			}
			*/
		}

		private void button1_Click(object sender, EventArgs e) {

			Regex validID = new Regex("[a-z][a-z0-9]*");
			Regex validIDatEOL = new Regex("[a-z][a-z0-9]*;");
			List<string> ids = new List<string>();
			bool declaredProgram = false;
			bool startedProgram = false;
			bool validLine;

			foreach (string line in primaryTextInput.Lines) {
				validLine = false;
				string[] tokens = line.Split(new char[]{ ' ' });

				switch (tokens[0]) {
					case "programa":
						if (!declaredProgram) {
							declaredProgram = true;
							if (validIDatEOL.IsMatch(tokens[1])) {
								validLine = true;
							}
						} else {
							Console.WriteLine("Syntax Error: Program was aready defined");
						}
						break;

					case "iniciar":
						if (declaredProgram) {
							if (!startedProgram) {
								startedProgram = true;
								if (tokens.Length == 1) {
									
								}
							} else {
								// Syntax Error
								Console.WriteLine("Syntax Error: Program was already started");
							}
						} else {
							// Syntax Error
							Console.WriteLine("No se ha declarado el programa");
						}

						break;

					case "leer":
						// do something
						break;

					case "imprimir":
						// do something
						break;

					case "terminar.":
						//if ()
						break;

					default:
						// asignación?
						break;
				}
			}
		}

		private void button2_Click(object sender, EventArgs e) {
			var fileContent = string.Empty;
			var filePath = string.Empty;
			using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
				openFileDialog.InitialDirectory = "c:\\Users";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 2;
				openFileDialog.RestoreDirectory = true;

				if (openFileDialog.ShowDialog() == DialogResult.OK) {
					//Get the path of specified file
					filePath = openFileDialog.FileName;

					//Read the contents of the file into a stream
					var fileStream = openFileDialog.OpenFile();

					using (StreamReader reader = new StreamReader(fileStream)) {
						fileContent = reader.ReadToEnd();
					}
				}
			}
			primaryTextInput.Text = fileContent;
		}

		private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {

		}
	}

}



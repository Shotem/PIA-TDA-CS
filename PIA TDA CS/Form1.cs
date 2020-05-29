using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using AutocompleteMenuNS;

namespace PIA_TDA_CS {
	public partial class Form1 : Form {
		private static Form1 form = null;
		public Form1() {
			InitializeComponent();
			form = this;
		}

		private void Form1_Load(object sender, EventArgs e) {
			// For Testing purposes only
			/*
			PIA_TDA_CS.MathParser p = new PIA_TDA_CS.MathParser();
			p.ids.Add("a1");
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
				"8/0",
				"1",
				"a1"
			};
			foreach (var s in test) {
				Console.WriteLine(p.Parse(s) + " " + s);
			}*/

			autocompleteMenu1.AutoPopup = true;
			autocompleteMenu1.Items = new string[]{ "programa", "iniciar", "leer", "imprimir", "terminar."};
			primaryTextInput.Text = "programa ejemplo;" + Environment.NewLine +
				"iniciar" + Environment.NewLine +
				"leer a;" + Environment.NewLine +
				"leer b;" + Environment.NewLine +
				"c := a + b;" + Environment.NewLine +
				"imprimir c;" + Environment.NewLine +
				"terminar.";
			
		}

		private void button1_Click(object sender, EventArgs e) {
			var lines = primaryTextInput.Lines;
			Regex validID = new Regex("[a-z][a-z0-9]*");
			Regex validIDatEOL = new Regex("^[a-z][a-z0-9]*;$");
			PIA_TDA_CS.MathParser parser = new PIA_TDA_CS.MathParser();


			bool declaredProgram = false;
			bool startedProgram = false;
			bool valid = true;
			string[] tokens;
			primaryTextOutput.Text = "";

			if (primaryTextInput.Lines.Length == 0) {
				Output($"Favor de ingresar un programa");
				valid = false;
			} else if (primaryTextInput.Lines.Length < 3) {
				Output($"La estructura más pequeña para un programa es:");
				Output($"\tprograma [nombre];");
				Output($"\tiniciar");
				Output($"\tterminar.");
				valid = false;
			} else { 
				// Verificar Primera Linea
				if (lines[0] == "") {
					Output($"Error de sintaxis (linea 1): No puede haber lineas vacías");
					valid = false;
				} else {
					tokens = lines[0].Split(new char[] { ' ' });
					if (tokens[0] == "programa") {
						if (tokens.Length == 2) {
							if (validIDatEOL.IsMatch(tokens[1])) {
								declaredProgram = true;
							} else if (tokens[1].LastIndexOf(';') != tokens[1].Length - 1) {
								Output($"Error de sintaxis (linea 1): Se esperaba ';' al final de la linea");
								valid = false;
							} else {
								Output($"Error de sintaxis (linea 1): El nombre del programa es inválido");
								valid = false;
							}
						} else if (tokens.Length < 2) {
							Output($"Error de sintaxis (linea 1): Se esperaba nombre del programa");
							valid = false;
						} else {
							Output($"");
							valid = false;
						}
					} else {
						Output($"Error de léxico (linea 1): Se esperaba \"programa\", pero se encontró \"{tokens[0]}\"");
					}
				}
				

				// Verificar Segunda Linea
				if (lines[0] == "") {
					Output($"Error de sintaxis (linea 2): No puede haber lineas vacías");
					valid = false;
				} else {
					tokens = lines[1].Split(new char[] { ' ' });
					if (tokens[0] == "iniciar") {
						if (tokens.Length == 1) {
							startedProgram = true;
						} else {
							Output($"Error de Sintaxis (linea 2): Linea inválida. Se esperaba solo \"iniciar\"");
							valid = false;
						}
					} else {
						Output($"Error de Léxico (linea 2): Se esperaba \"iniciar\", pero se encontró \"{tokens[0]}\"");
						valid = false;
					}
				}
				

				// Verificar leer, escribir, asignar
				if (declaredProgram && startedProgram) {
					for (int i = 2; i < lines.Length - 1; i++) {

						tokens = lines[i].Split(new char[] { ' ' });
						parser.line = i + 1;
						if (lines[i].Trim() == "") {
							Output($"Error de sintaxis (linea {i + 1}): No puede haber lineas vacías");
							valid = false;
						} else {
							switch (tokens[0]) {
								case "programa":
									Output($"Error de sintaxis (linea {i + 1}): El programa ya ha sido definido");
									valid = false;
									break;

								case "iniciar":
									Output($"Error de sintaxis (linea {i + 1}): El programa ya ha sido iniciado");
									valid = false;
									break;

								case "leer":
									if (declaredProgram) {
										if (startedProgram) {

											var line = lines[i];

											if (line.Contains("  ")) {
												Output($"Error de sintaxis (linea {line}): No se admiten dobles espacios");
												valid = false;
											} else if (tokens[1].LastIndexOf(';') != tokens[1].Length - 1) {
												Output($"Error de sintaxis (linea {i + 1}): Se esperaba ';' al final de la linea");
												valid = false;
											} else {
												string id;

												id = line.Substring(line.IndexOf(" "), line.IndexOf(";") - line.IndexOf(" "));

												id = id.Trim();

												if (parser.reserved.Contains(id)) {
													Output($"Error de léxico (linea {i + 1}): No se puede usar palabras reservadas como identificador");
													valid = false;
												} else if (!parser.ids.Contains(id)) {
													parser.ids.Add(id);
												}
											}
											

										} else {
											Output($"Error de sintaxis (linea {i + 1}): No se ha iniciado el programa");
											Output("\tIntente iniciar el programa usando \"iniciar\"");
											valid = false;
										}
									} else {
										Output($"Error de sintaxis (linea {i + 1}): No se ha declarado el programa");
										Output("\tIntente declarar el programa usando \"programa [nombre]\"");
										valid = false;
									}
									break;

								case "imprimir":
									if (declaredProgram) {
										if (startedProgram) {
											// verificar que la id esté en p.ids (parser.ids.Contains([id]))
											var line = lines[i];
											string id;
											if (tokens[1].LastIndexOf(';') != tokens[1].Length - 1) {
												Output($"Error de sintaxis (linea {i + 1}): Se esperaba ';' al final de la linea");
												valid = false;
											} else {
												id = line.Substring(line.IndexOf(" "), line.IndexOf(";") - line.IndexOf(" "));
												id = id.Trim();

												if (parser.reserved.Contains(id)) {
													Output($"Error de léxico (linea {i + 1}): No se puede usar palabras reservadas como identificador");
													valid = false;
												} else if (!parser.ids.Contains(id)) {
													Form1.Output($"Error de léxico (linea {i + 1}): ID inválida en la expresión ({id})");
													valid = false;
												}
											}
											

											

										} else {
											Output($"Error de sintaxis (linea {i + 1}): No se ha iniciado el programa");
											Output("\tIntente iniciar el programa usando \"iniciar\"");
											valid = false;
										}
									} else {
										Output($"Error de sintaxis (linea {i + 1}): No se ha declarado el programa");
										Output($"\tIntente declarar el programa usando \"programa [nombre]\"");
										valid = false;
									}
									break;

								case "terminar.":
									if (declaredProgram) {
										if (startedProgram) {
											// veificar que no haya más cosas en la linea 
											if (!new Regex("^terminar.$").IsMatch(lines[i])) {
												Output($"Error de sintaxis (linea {i + 1}): Linea Inválida (debe ser de la forma \"terminar.\"");
												valid = false;
											}

										} else {
											Output($"Error de sintaxis (linea {i + 1}): No se ha iniciado el programa");
											Output("\tIntente iniciar el programa usando \"iniciar\"");
											valid = false;
										}
									} else {
										Output($"Error de sintaxis (linea {i + 1}): No se ha declarado el programa");
										Output("\tIntente declarar el programa usando \"programa [nombre]\"");
										valid = false;
									}
									break;

								default:
									if (new Regex("^[a-z][a-z0-9]*\\s?:=[\\s?a-z0-9+\\-*/^()]*[a-z0-9+\\-*/^()]\\s?;$").IsMatch(lines[i])) { // asignación?
										if (declaredProgram) {
											if (startedProgram) {
												var line = lines[i];
												string id;

												id = line.Remove(line.IndexOf(":"));

												id = id.Trim();

												if ( parser.reserved.Contains(id) ) {
													Output($"Error de léxico (linea {i + 1}): No se puede usar palabras reservadas como identificador");
													valid = false;
												} else {

													var ex = line.Substring(line.IndexOf("=") + 1, line.IndexOf(";") - line.IndexOf("=") - 1);
													if (!parser.Parse(ex)) {
														Output($"Expresión inválida (linea {i + 1}): {ex}");
														valid = false;
													}
													if (!parser.ids.Contains(id)) {
														parser.ids.Add(id);
													}
												}

												// El parser ya verifica que las ids de la expresión sean válidas y la manda a la lista de IDs
												// El parser ya verifica que no haya dobles espacios
												// El parser ya verifica que no haya "/0" o "/ 0"

											} else {

												Output($"Error de sintaxis (linea {i + 1}): No se ha iniciado el programa");
												Output("\tIntente iniciar el programa usando \"iniciar\"");
												valid = false;
											}
										} else {
											Output($"Error de sintaxis (linea {i + 1}): No se ha declarado el programa");
											Output("\tIntente declarar el programa usando \"programa [nombre]\"");
											valid = false;
										}
									} else if (lines[i].LastIndexOf(';') != lines[i].Length - 1) {
										Output($"Error de sintaxis (linea {i + 1}): Se esperaba ';' al final de la linea");
										valid = false;
									} else {
										Output($"Error de Sintáxis (linea {i + 1}): Linea inválida");
										Output($"\t{lines[i]}");
										valid = false;
									}
									break;
							}
						}
					}
				} else {
					valid = false;
				}

				// Verificar última línea
				if (lines[lines.Length - 1] == "") {
					Output($"Error de Sintaxis (linea {lines.Length}): No puede haber lineas vacías");
					valid = false;
				} else {
					tokens = lines[lines.Length - 1].Split(new char[] { ' ' });
					if (tokens[0] == "terminar.") {
						if (tokens.Length == 1) {
							startedProgram = true;
						} else if (tokens.Length < 1) {
							Output($"Error de Sintaxis (linea {lines.Length}): Se esperaba nombre del programa, pero se encontró \"{tokens[0]}\"");
							valid = false;
						} else if (tokens.Length > 1) {
							Output($"Error de Sintaxis (linea {lines.Length}): Linea inválida. Se esperaba solo \"terminar.\"");
							valid = false;
						}
					} else {
						Output($"Error de léxico (linea {lines.Length}): Se esperaba \"terminar.\", pero se encontró \"{tokens[0]}\"");
						valid = false;
					}
				}
			}
			

			Output((valid ? "Programa válido" : "Programa inválido"));
		}

		private void button2_Click(object sender, EventArgs e) {
			var fileContent = string.Empty;
			var filePath = string.Empty;
			using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
				openFileDialog.InitialDirectory = "c:\\Users";
				openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
				openFileDialog.FilterIndex = 1;
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

		public static void Output(string str) {
			form.primaryTextOutput.Text += str + Environment.NewLine;
		}

		private void primaryTextInput_TextChanged(object sender, EventArgs e) {
			lineCount.Text = "";
			for (int i = 0; i < primaryTextInput.Lines.Length; i++) {
				lineCount.Text += (i + 1).ToString() + Environment.NewLine;

			}

			var actual = primaryTextInput.SelectionStart;

			var words = new List<string> { "programa", "iniciar", "terminar.", "leer", "imprimir" };
			primaryTextInput.SelectAll();
			primaryTextInput.SelectionColor = Color.Black;


			foreach (var word in words) {
				var index = 0;
				do {
					index = primaryTextInput.Find(word, index, RichTextBoxFinds.WholeWord);
					if (index > -1) {
						primaryTextInput.Select(index, word.Length);
						primaryTextInput.SelectionColor = Color.Blue;
						index++;
					} else {

					}
				} while (index > -1);
			}
			primaryTextInput.Select(actual, 0);
		}
	}

}



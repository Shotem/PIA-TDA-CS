using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace PIA_TDA_CS {
	class MathParser {
		/* Gramática Independiente del Contexto
		 * S  -> A S'
		 * S' -> + W1 | - W1 | _	<-- (+ y - se juntaron en el program para utilizar menos funciones)
		 * W1 -> A S'
		 * A  -> B A'
		 * A' -> * W2 | / W2 | _	<-- (* y / se juntaron en el program para utilizar menos funciones)
		 * W2 -> B A'
		 * B  -> C B'
		 * B' -> ^ W3 | _
		 * W3 -> C B'
		 * C  -> ( W4 | k
		 * C' -> S )
		*/
		private enum TK { TK_NULL, TK_PLUS, TK_MINUS, TK_STAR, TK_SLASH, TK_LP, TK_RP, TK_POW, TK_CONST, TK_ID };
		private List<TK> tokens;
		public string programName;
		public List<string> ids = new List<string>();
		public List<string> reserved = new List<string> { "programa", "iniciar", "terminar", "leer", "imprimir", "terminar" };
		public int line;


		public bool Parse(string str) {
			this.tokens = Tokenizer(str);
			if (this.tokens.Contains(TK.TK_NULL) || this.tokens.Count == 0) return false;
			return _S();
		}

		private List<TK> Tokenizer(string str) {
			var tokenized = new List<TK>();
			if (!str.Contains("  ")) {
				str.Replace(" ", "");
				if (verifyDivBy0(str)) {
					if (!(new Regex("0\\s?\\^\\s?0").IsMatch(str))) {
						for (int i = 0; i < str.Length; i++) {
							TK token = TK.TK_NULL;
							str = str.Replace(" ", "");
							switch (str[i]) {
								case '+':
									token = TK.TK_PLUS;
									break;
								case '-':
									token = TK.TK_MINUS;
									break;
								case '*':
									token = TK.TK_STAR;
									break;
								case '/':
									token = TK.TK_SLASH;
									break;
								case '^':
									token = TK.TK_POW;
									break;
								case '(':
									token = TK.TK_LP;
									break;
								case ')':
									token = TK.TK_RP;
									break;
								default:
									if ('0' <= str[i] && str[i] <= '9') {
										int j = 0;
										while (i + j < str.Length && ('0' <= str[i + j] && str[i + j] <= '9')) {
											j++;
										}
										i += j - 1;
										token = TK.TK_CONST;
									} else if ('a' <= str[i] && str[i] <= 'z') {
										int j = 0;
										while (i + j < str.Length && (('a' <= str[i + j] && str[i + j] <= 'z') || ('0' <= str[i + j] && str[i + j] <= '9'))) {
											j++;
										}
										var id = str.Substring(i, j);
										i += j - 1;
										if (this.ids.Contains(id)) {
											token = TK.TK_ID;
										} else {

											Form1.Output($"Error de léxico (linea {line}): ID inválida en la expresión ({id})");
											token = TK.TK_NULL;
										}

									}
									break;
							}
							tokenized.Add(token);
							
							if (token == TK.TK_NULL) {
								Form1.Output($"Error de sintaxis (linea {line}): Caracter inválido en la expresión ({str[i]})");
								Form1.Output($"\tEn caso de ser una variable, verifique que se haya leído o se le haya asignado algo antes y que esté bien escrita.");
								tokenized.Add(TK.TK_NULL);
								// Syntax Error
							}
						}
					} else {
						Form1.Output($"Excepción Matemática (linea {line}): 0 ^ 0 no está definido");
						tokenized.Add(TK.TK_NULL);
					}
				} else {
					Form1.Output($"Excepción Matemática (linea {line}): División entre 0");
					tokenized.Add(TK.TK_NULL);
					// Syntax Error!
				}
			} else {
				Form1.Output($"Error de sintaxis (linea {line}): Dos espacios en la expresión matemática");
				
				tokenized.Add(TK.TK_NULL);
				// Syntax Error!
			}

			return tokenized;
		}


		/*
		 * 
		 * WARNING
		 * SPAGUETTI CODE BEYOND THIS POINT
		 * PROCEDE WITH CAUTION
		 * 
		 */

		public bool verifyDivBy0(string str) {
			//Console.WriteLine(str);

			Stack<TK> stack = new Stack<TK>(); 
			stack.Push(TK.TK_SLASH);

			while (str.Contains(" ")) {
				str = str.Remove(str.IndexOf(" "), 1);
			}
			//Console.WriteLine(str);
			int i = str.IndexOf("/"), j = 0;
			i++;
			if (i == str.Length || i == 0) {
				return true;
			} else {
				do {
					if (str[i] == '(') {
						stack.Push(TK.TK_LP);
					} else if (str[i] == ')') {
						if (stack.Peek() == TK.TK_LP) {
							stack.Pop();
						}
					} else if ( str[i] == '0') {
						while (i + j < str.Length && str[i+j] == '0') {
							j++;
						}
						i += j - 1;
					} else {
						return true;
					}
					i++;
				} while ( i < str.Length && stack.Peek() != TK.TK_SLASH );
				return false;
			}
		}


		private bool _X1() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_PLUS || this.tokens[0] == TK.TK_MINUS) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				return false;
			}
		}
		private bool _X2() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_STAR || this.tokens[0] == TK.TK_SLASH) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				return false;
			}
		}
		private bool _X3() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens.Count > 0 && this.tokens[0] == TK.TK_POW) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				return false;
			}
		}
		private bool _X4() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_LP) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				return false;
			}
		}
		private bool _K() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_CONST || this.tokens[0] == TK.TK_ID) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				Form1.Output($"Error de sintaxis (linea {line}): Se esperaba constante o identificador");
				return false;
			}
		}
		private bool _X5() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_RP ) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				Form1.Output($"Error de sintaxis (linea {line}): Se esperaba cierre de paréntesis");
				return false;
			}
		}
		// ==================================================
		private bool _S() {
			if (_A()) {
				if (_s()) {
					return true;
				}
			}
			return false;
		}
		private bool _s() {
			if (_X1()) {
				if (_W1()) {
					return true;
				}
			} else {
				return true;
			}
			return false;
		}
		private bool _W1() {
			if (_A()) {
				if (_s()) {
					return true;
				}
			}
			return false;
		}
		private bool _A() {
			if (_B()) {
				if (_a()) {
					return true;
				}
			}
			return false;
		}
		private bool _a() {
			if (_X2()) {
				if (_W2()) {
					return true;
				}
			} else {
				return true;
			}
			return false;
		}
		private bool _W2() {
			if (_B()) {
				if (_a()) {
					return true;
				}
			}
			return false;
		}
		private bool _B() {
			if (_C()) {
				if (_b()) {
					return true;
				}
			}
			return false;
		}
		private bool _b() {
			if (_X3()) {
				if (_W3()) {
					return true;
				}
			} else {
				return true;
			}
			return false;
		}
		private bool _W3() {
			if (_C()) {
				if (_b()) {
					return true;
				}
			}
			return false;
		}
		private bool _C() {
			if (_X4()) {
				if (_W4()) {
					return true;
				}
			} else if (_K()) {
				return true;
			}
			return false;
		}
		private bool _W4() {
		if (_S()) {
			if (_X5()) {
				return true;
			}
		}
		return false;
	}
	}

}

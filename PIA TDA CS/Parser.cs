using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parser {
	class Parser {
		/* Gramática Independiente del Contexto
		 * S  -> A S'
		 * S' -> + W1 | - W1 | _
		 * W1 -> A S'
		 * A  -> B A'
		 * A' -> * W2 | / W2 | _
		 * W2 -> B A'
		 * B  -> C B'
		 * B' -> ^ W3 | _
		 * W3 -> C B'
		 * C  -> ( W4 | k
		 * C' -> S )
		*/
		private enum TK { TK_NULL, TK_PLUS, TK_MINUS, TK_STAR, TK_SLASH, TK_LP, TK_RP, TK_POW, TK_CONST };
		private List<TK> tokens;

		public bool Parse(string str) {
			this.tokens = Tokenizer(str);
			if (this.tokens.Contains(TK.TK_NULL) || this.tokens.Count == 0) return false;
			return _S();
		}

		private List<TK> Tokenizer(string str) {
			var tokenized = new List<TK>();
			if (!str.Contains("  ")) {
				if (!str.Contains("/0")) {
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
								}
								break;
						}
						tokenized.Add(token);
						if (token == TK.TK_NULL) {
							Console.WriteLine($"Syntax Error: Invalid Character in Math Expression ({str[i]})");
							tokenized.Add(TK.TK_NULL);
							// Syntax Error
						}
					}
				} else {
					Console.WriteLine("__(Syntax / Lexical)__ Error: Divided by Cero");
					tokenized.Add(TK.TK_NULL);
					// Syntax Error!
				}
			} else {
				Console.WriteLine("Syntax Error: Double spaces somewhere in the string");
				tokenized.Add(TK.TK_NULL);
				// Syntax Error!
			}

			return tokenized;
		}

		// ==================================================

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
			if (this.tokens[0] == TK.TK_CONST) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
				return false;
			}
		}

		private bool _X5() {
			if (this.tokens.Count == 0) return false;
			if (this.tokens[0] == TK.TK_RP) {
				this.tokens.RemoveAt(0);
				return true;
			} else {
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

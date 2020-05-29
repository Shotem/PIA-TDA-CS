namespace PIA_TDA_CS {
	partial class Form1 {
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent() {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.primaryTextInput = new System.Windows.Forms.RichTextBox();
			this.primaryTextOutput = new System.Windows.Forms.TextBox();
			this.lineCount = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(45, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Programa";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(32, 181);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(292, 34);
			this.button1.TabIndex = 3;
			this.button1.Text = "Verificar Programa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 3;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.041096F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.9589F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 491F));
			this.tableLayoutPanel1.Controls.Add(this.primaryTextInput, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.primaryTextOutput, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.lineCount, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 2);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 258);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// primaryTextInput
			// 
			this.autocompleteMenu1.SetAutocompleteMenu(this.primaryTextInput, this.autocompleteMenu1);
			this.primaryTextInput.Location = new System.Drawing.Point(32, 3);
			this.primaryTextInput.Name = "primaryTextInput";
			this.primaryTextInput.Size = new System.Drawing.Size(292, 172);
			this.primaryTextInput.TabIndex = 6;
			this.primaryTextInput.Text = "";
			this.primaryTextInput.TextChanged += new System.EventHandler(this.primaryTextInput_TextChanged);
			// 
			// primaryTextOutput
			// 
			this.primaryTextOutput.AutoCompleteCustomSource.AddRange(new string[] {
            "programa",
            "iniciar",
            "terminar.",
            "leer",
            "imprimir"});
			this.autocompleteMenu1.SetAutocompleteMenu(this.primaryTextOutput, null);
			this.primaryTextOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.primaryTextOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.primaryTextOutput.Location = new System.Drawing.Point(330, 3);
			this.primaryTextOutput.Multiline = true;
			this.primaryTextOutput.Name = "primaryTextOutput";
			this.primaryTextOutput.ReadOnly = true;
			this.primaryTextOutput.Size = new System.Drawing.Size(485, 172);
			this.primaryTextOutput.TabIndex = 5;
			// 
			// lineCount
			// 
			this.lineCount.AutoCompleteCustomSource.AddRange(new string[] {
            "programa",
            "iniciar",
            "terminar.",
            "leer",
            "imprimir"});
			this.autocompleteMenu1.SetAutocompleteMenu(this.lineCount, null);
			this.lineCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.lineCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.lineCount.Location = new System.Drawing.Point(3, 3);
			this.lineCount.Multiline = true;
			this.lineCount.Name = "lineCount";
			this.lineCount.ReadOnly = true;
			this.lineCount.Size = new System.Drawing.Size(23, 172);
			this.lineCount.TabIndex = 6;
			this.lineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(32, 221);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(292, 34);
			this.button2.TabIndex = 4;
			this.button2.Text = "Abrir Archivo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(340, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "Notas del analizador";
			// 
			// autocompleteMenu1
			// 
			this.autocompleteMenu1.Colors = ((AutocompleteMenuNS.Colors)(resources.GetObject("autocompleteMenu1.Colors")));
			this.autocompleteMenu1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
			this.autocompleteMenu1.ImageList = null;
			this.autocompleteMenu1.Items = new string[0];
			this.autocompleteMenu1.TargetControlWrapper = null;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(843, 295);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox primaryTextOutput;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox lineCount;
		private System.Windows.Forms.RichTextBox primaryTextInput;
		private AutocompleteMenuNS.AutocompleteMenu autocompleteMenu1;
	}
}


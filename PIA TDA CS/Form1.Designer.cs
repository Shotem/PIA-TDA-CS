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
			this.lineCount = new System.Windows.Forms.TextBox();
			this.primaryTextOutput = new System.Windows.Forms.TextBox();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.button3 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.autocompleteMenu1 = new AutocompleteMenuNS.AutocompleteMenu();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(42, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Programa";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 3);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(169, 43);
			this.button1.TabIndex = 3;
			this.button1.TabStop = false;
			this.button1.Text = "Verificar Programa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 4;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.041096F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.9589F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 181F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 509F));
			this.tableLayoutPanel1.Controls.Add(this.primaryTextInput, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.lineCount, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.primaryTextOutput, 3, 0);
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 273F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1019, 273);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// primaryTextInput
			// 
			this.autocompleteMenu1.SetAutocompleteMenu(this.primaryTextInput, this.autocompleteMenu1);
			this.primaryTextInput.Location = new System.Drawing.Point(32, 3);
			this.primaryTextInput.Name = "primaryTextInput";
			this.primaryTextInput.Size = new System.Drawing.Size(292, 267);
			this.primaryTextInput.TabIndex = 6;
			this.primaryTextInput.TabStop = false;
			this.primaryTextInput.Text = "";
			this.primaryTextInput.TextChanged += new System.EventHandler(this.primaryTextInput_TextChanged);
			this.primaryTextInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.primaryTextInput_KeyDown);
			this.primaryTextInput.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.primaryTextInput_PreviewKeyDown);
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
			this.lineCount.Size = new System.Drawing.Size(23, 267);
			this.lineCount.TabIndex = 6;
			this.lineCount.TabStop = false;
			this.lineCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
			this.primaryTextOutput.Location = new System.Drawing.Point(512, 3);
			this.primaryTextOutput.Multiline = true;
			this.primaryTextOutput.Name = "primaryTextOutput";
			this.primaryTextOutput.ReadOnly = true;
			this.primaryTextOutput.Size = new System.Drawing.Size(499, 267);
			this.primaryTextOutput.TabIndex = 5;
			this.primaryTextOutput.TabStop = false;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.Controls.Add(this.checkBox1, 0, 5);
			this.tableLayoutPanel2.Controls.Add(this.button3, 0, 2);
			this.tableLayoutPanel2.Controls.Add(this.button2, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.button4, 0, 3);
			this.tableLayoutPanel2.Controls.Add(this.button5, 0, 4);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(331, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 6;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(175, 267);
			this.tableLayoutPanel2.TabIndex = 7;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(3, 248);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(132, 16);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.TabStop = false;
			this.checkBox1.Text = "Verificar \"On The GO\"";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(3, 101);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(169, 43);
			this.button3.TabIndex = 5;
			this.button3.TabStop = false;
			this.button3.Text = "Limpiar";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(3, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(169, 43);
			this.button2.TabIndex = 4;
			this.button2.TabStop = false;
			this.button2.Text = "Abrir Archivo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(3, 150);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(169, 43);
			this.button4.TabIndex = 6;
			this.button4.TabStop = false;
			this.button4.Text = "Estructura básica";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(3, 199);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(169, 43);
			this.button5.TabIndex = 7;
			this.button5.TabStop = false;
			this.button5.Text = "Info.";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(525, 9);
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
			this.ClientSize = new System.Drawing.Size(1043, 308);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "PIA - Equipo 6";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
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
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button button5;
	}
}


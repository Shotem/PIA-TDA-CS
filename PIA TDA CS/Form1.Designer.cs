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
			this.label1 = new System.Windows.Forms.Label();
			this.primaryTextInput = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.primaryTextOutput = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Programa";
			// 
			// primaryTextInput
			// 
			this.primaryTextInput.AutoCompleteCustomSource.AddRange(new string[] {
            "programa",
            "iniciar",
            "terminar.",
            "leer",
            "imprimir"});
			this.primaryTextInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.primaryTextInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.primaryTextInput.Location = new System.Drawing.Point(3, 3);
			this.primaryTextInput.Multiline = true;
			this.primaryTextInput.Name = "primaryTextInput";
			this.primaryTextInput.Size = new System.Drawing.Size(199, 221);
			this.primaryTextInput.TabIndex = 2;
			this.primaryTextInput.Text = "programa ejemplo;\r\niniciar\r\nleer a;\r\nleer b;\r\nc := a + b;\r\nimprimir c;\r\nterminar." +
    "";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(3, 230);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(199, 32);
			this.button1.TabIndex = 3;
			this.button1.Text = "Verificar Programa";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.primaryTextOutput, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.primaryTextInput, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.button1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.button2, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 25);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.97015F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.02985F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(410, 265);
			this.tableLayoutPanel1.TabIndex = 4;
			this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
			// 
			// primaryTextOutput
			// 
			this.primaryTextOutput.AutoCompleteCustomSource.AddRange(new string[] {
            "programa",
            "iniciar",
            "terminar.",
            "leer",
            "imprimir"});
			this.primaryTextOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.primaryTextOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
			this.primaryTextOutput.Location = new System.Drawing.Point(208, 3);
			this.primaryTextOutput.Multiline = true;
			this.primaryTextOutput.Name = "primaryTextOutput";
			this.primaryTextOutput.ReadOnly = true;
			this.primaryTextOutput.Size = new System.Drawing.Size(199, 221);
			this.primaryTextOutput.TabIndex = 5;
			this.primaryTextOutput.Text = "Aquí puede encontrar las notas del analizador";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(208, 230);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(199, 32);
			this.button2.TabIndex = 4;
			this.button2.Text = "Abrir Archivo";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(444, 302);
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
		private System.Windows.Forms.TextBox primaryTextInput;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox primaryTextOutput;
	}
}


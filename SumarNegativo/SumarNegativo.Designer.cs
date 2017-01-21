namespace SumarNegativo
{
    partial class SumarNegativo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DigiteNumero2textBox2 = new System.Windows.Forms.TextBox();
            this.DigiteNumero1textBox1 = new System.Windows.Forms.TextBox();
            this.DigiteNumero2label2 = new System.Windows.Forms.Label();
            this.DigiteNumero1label = new System.Windows.Forms.Label();
            this.Calcularbutton = new System.Windows.Forms.Button();
            this.Resultadolabel1 = new System.Windows.Forms.Label();
            this.ResultadotextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // DigiteNumero2textBox2
            // 
            this.DigiteNumero2textBox2.Location = new System.Drawing.Point(18, 126);
            this.DigiteNumero2textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.DigiteNumero2textBox2.Name = "DigiteNumero2textBox2";
            this.DigiteNumero2textBox2.Size = new System.Drawing.Size(105, 22);
            this.DigiteNumero2textBox2.TabIndex = 9;
            // 
            // DigiteNumero1textBox1
            // 
            this.DigiteNumero1textBox1.Location = new System.Drawing.Point(17, 52);
            this.DigiteNumero1textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.DigiteNumero1textBox1.Name = "DigiteNumero1textBox1";
            this.DigiteNumero1textBox1.Size = new System.Drawing.Size(105, 22);
            this.DigiteNumero1textBox1.TabIndex = 8;
            // 
            // DigiteNumero2label2
            // 
            this.DigiteNumero2label2.AutoSize = true;
            this.DigiteNumero2label2.Location = new System.Drawing.Point(14, 94);
            this.DigiteNumero2label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteNumero2label2.Name = "DigiteNumero2label2";
            this.DigiteNumero2label2.Size = new System.Drawing.Size(119, 17);
            this.DigiteNumero2label2.TabIndex = 7;
            this.DigiteNumero2label2.Text = "Segundo Numero";
            // 
            // DigiteNumero1label
            // 
            this.DigiteNumero1label.AutoSize = true;
            this.DigiteNumero1label.Location = new System.Drawing.Point(13, 20);
            this.DigiteNumero1label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteNumero1label.Name = "DigiteNumero1label";
            this.DigiteNumero1label.Size = new System.Drawing.Size(103, 17);
            this.DigiteNumero1label.TabIndex = 6;
            this.DigiteNumero1label.Text = "Primer Numero";
            // 
            // Calcularbutton
            // 
            this.Calcularbutton.Location = new System.Drawing.Point(173, 72);
            this.Calcularbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Calcularbutton.Name = "Calcularbutton";
            this.Calcularbutton.Size = new System.Drawing.Size(100, 28);
            this.Calcularbutton.TabIndex = 5;
            this.Calcularbutton.Text = "Calcular";
            this.Calcularbutton.UseVisualStyleBackColor = true;
            this.Calcularbutton.Click += new System.EventHandler(this.Calcularbutton_Click);
            // 
            // Resultadolabel1
            // 
            this.Resultadolabel1.AutoSize = true;
            this.Resultadolabel1.Location = new System.Drawing.Point(372, 52);
            this.Resultadolabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Resultadolabel1.Name = "Resultadolabel1";
            this.Resultadolabel1.Size = new System.Drawing.Size(72, 17);
            this.Resultadolabel1.TabIndex = 11;
            this.Resultadolabel1.Text = "Resultado";
            // 
            // ResultadotextBox
            // 
            this.ResultadotextBox.Location = new System.Drawing.Point(372, 76);
            this.ResultadotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ResultadotextBox.Name = "ResultadotextBox";
            this.ResultadotextBox.Size = new System.Drawing.Size(132, 22);
            this.ResultadotextBox.TabIndex = 10;
            // 
            // SumarNegativo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 177);
            this.Controls.Add(this.Resultadolabel1);
            this.Controls.Add(this.ResultadotextBox);
            this.Controls.Add(this.DigiteNumero2textBox2);
            this.Controls.Add(this.DigiteNumero1textBox1);
            this.Controls.Add(this.DigiteNumero2label2);
            this.Controls.Add(this.DigiteNumero1label);
            this.Controls.Add(this.Calcularbutton);
            this.Name = "SumarNegativo";
            this.Text = "Sumar Negativo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DigiteNumero2textBox2;
        private System.Windows.Forms.TextBox DigiteNumero1textBox1;
        private System.Windows.Forms.Label DigiteNumero2label2;
        private System.Windows.Forms.Label DigiteNumero1label;
        private System.Windows.Forms.Button Calcularbutton;
        private System.Windows.Forms.Label Resultadolabel1;
        private System.Windows.Forms.TextBox ResultadotextBox;
    }
}


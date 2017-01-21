namespace Capitulo_8
{
    partial class CadenaOraciones
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
            this.Resultado = new System.Windows.Forms.ListBox();
            this.CadenaOraciontextBox = new System.Windows.Forms.TextBox();
            this.DigiteCadenaOracionlabel1 = new System.Windows.Forms.Label();
            this.Precionarbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Resultado
            // 
            this.Resultado.FormattingEnabled = true;
            this.Resultado.ItemHeight = 16;
            this.Resultado.Location = new System.Drawing.Point(13, 134);
            this.Resultado.Margin = new System.Windows.Forms.Padding(4);
            this.Resultado.Name = "Resultado";
            this.Resultado.Size = new System.Drawing.Size(237, 84);
            this.Resultado.TabIndex = 9;
            // 
            // CadenaOraciontextBox
            // 
            this.CadenaOraciontextBox.Location = new System.Drawing.Point(13, 29);
            this.CadenaOraciontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CadenaOraciontextBox.Name = "CadenaOraciontextBox";
            this.CadenaOraciontextBox.Size = new System.Drawing.Size(345, 22);
            this.CadenaOraciontextBox.TabIndex = 8;
            // 
            // DigiteCadenaOracionlabel1
            // 
            this.DigiteCadenaOracionlabel1.AutoSize = true;
            this.DigiteCadenaOracionlabel1.Location = new System.Drawing.Point(13, 9);
            this.DigiteCadenaOracionlabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteCadenaOracionlabel1.Name = "DigiteCadenaOracionlabel1";
            this.DigiteCadenaOracionlabel1.Size = new System.Drawing.Size(117, 17);
            this.DigiteCadenaOracionlabel1.TabIndex = 7;
            this.DigiteCadenaOracionlabel1.Text = "Digite la  Oracion";
            // 
            // Precionarbutton
            // 
            this.Precionarbutton.Location = new System.Drawing.Point(13, 59);
            this.Precionarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Precionarbutton.Name = "Precionarbutton";
            this.Precionarbutton.Size = new System.Drawing.Size(123, 28);
            this.Precionarbutton.TabIndex = 6;
            this.Precionarbutton.Text = "Precionar";
            this.Precionarbutton.UseVisualStyleBackColor = true;
            this.Precionarbutton.Click += new System.EventHandler(this.Precionarbutton_Click);
            // 
            // CadenaOraciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 240);
            this.Controls.Add(this.Resultado);
            this.Controls.Add(this.CadenaOraciontextBox);
            this.Controls.Add(this.DigiteCadenaOracionlabel1);
            this.Controls.Add(this.Precionarbutton);
            this.Name = "CadenaOraciones";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Resultado;
        private System.Windows.Forms.TextBox CadenaOraciontextBox;
        private System.Windows.Forms.Label DigiteCadenaOracionlabel1;
        private System.Windows.Forms.Button Precionarbutton;
    }
}


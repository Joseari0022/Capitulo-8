namespace OrdenAlfabetico
{
    partial class OrdenAlfabetico
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
            this.CadenasOrdenadatextBox = new System.Windows.Forms.TextBox();
            this.ResultadoCadenaOrdenadasLabel = new System.Windows.Forms.Label();
            this.Ordenarbutton = new System.Windows.Forms.Button();
            this.CadenatextBox = new System.Windows.Forms.TextBox();
            this.DigiteCadenaLetralabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CadenasOrdenadatextBox
            // 
            this.CadenasOrdenadatextBox.Location = new System.Drawing.Point(17, 105);
            this.CadenasOrdenadatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CadenasOrdenadatextBox.Name = "CadenasOrdenadatextBox";
            this.CadenasOrdenadatextBox.Size = new System.Drawing.Size(360, 22);
            this.CadenasOrdenadatextBox.TabIndex = 9;
            // 
            // ResultadoCadenaOrdenadasLabel
            // 
            this.ResultadoCadenaOrdenadasLabel.AutoSize = true;
            this.ResultadoCadenaOrdenadasLabel.Location = new System.Drawing.Point(13, 84);
            this.ResultadoCadenaOrdenadasLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ResultadoCadenaOrdenadasLabel.Name = "ResultadoCadenaOrdenadasLabel";
            this.ResultadoCadenaOrdenadasLabel.Size = new System.Drawing.Size(125, 17);
            this.ResultadoCadenaOrdenadasLabel.TabIndex = 8;
            this.ResultadoCadenaOrdenadasLabel.Text = "Cadena Ordenada";
            // 
            // Ordenarbutton
            // 
            this.Ordenarbutton.Location = new System.Drawing.Point(228, 53);
            this.Ordenarbutton.Margin = new System.Windows.Forms.Padding(4);
            this.Ordenarbutton.Name = "Ordenarbutton";
            this.Ordenarbutton.Size = new System.Drawing.Size(100, 28);
            this.Ordenarbutton.TabIndex = 12;
            this.Ordenarbutton.Text = "Ordenar";
            this.Ordenarbutton.UseVisualStyleBackColor = true;
            this.Ordenarbutton.Click += new System.EventHandler(this.OrdenarAlfabeticamentebutton1_Click);
            // 
            // CadenatextBox
            // 
            this.CadenatextBox.Location = new System.Drawing.Point(17, 28);
            this.CadenatextBox.Margin = new System.Windows.Forms.Padding(4);
            this.CadenatextBox.Name = "CadenatextBox";
            this.CadenatextBox.Size = new System.Drawing.Size(164, 22);
            this.CadenatextBox.TabIndex = 11;
            // 
            // DigiteCadenaLetralabel1
            // 
            this.DigiteCadenaLetralabel1.AutoSize = true;
            this.DigiteCadenaLetralabel1.Location = new System.Drawing.Point(13, 9);
            this.DigiteCadenaLetralabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteCadenaLetralabel1.Name = "DigiteCadenaLetralabel1";
            this.DigiteCadenaLetralabel1.Size = new System.Drawing.Size(161, 17);
            this.DigiteCadenaLetralabel1.TabIndex = 10;
            this.DigiteCadenaLetralabel1.Text = "Digite Cadena de Letras";
            // 
            // OrdenAlfabetico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 146);
            this.Controls.Add(this.Ordenarbutton);
            this.Controls.Add(this.CadenatextBox);
            this.Controls.Add(this.DigiteCadenaLetralabel1);
            this.Controls.Add(this.CadenasOrdenadatextBox);
            this.Controls.Add(this.ResultadoCadenaOrdenadasLabel);
            this.Name = "OrdenAlfabetico";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CadenasOrdenadatextBox;
        private System.Windows.Forms.Label ResultadoCadenaOrdenadasLabel;
        private System.Windows.Forms.Button Ordenarbutton;
        private System.Windows.Forms.TextBox CadenatextBox;
        private System.Windows.Forms.Label DigiteCadenaLetralabel1;
    }
}


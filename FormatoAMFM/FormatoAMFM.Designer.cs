namespace FormatoAMFM
{
    partial class FormatoAMFM
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
            this.FormatoHoralabel3 = new System.Windows.Forms.Label();
            this.FormatoHoratextBox2 = new System.Windows.Forms.TextBox();
            this.DigiteHoratextBox = new System.Windows.Forms.TextBox();
            this.DigiteHoralabel = new System.Windows.Forms.Label();
            this.CambiarFormatobutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormatoHoralabel3
            // 
            this.FormatoHoralabel3.AutoSize = true;
            this.FormatoHoralabel3.Location = new System.Drawing.Point(32, 106);
            this.FormatoHoralabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FormatoHoralabel3.Name = "FormatoHoralabel3";
            this.FormatoHoralabel3.Size = new System.Drawing.Size(60, 17);
            this.FormatoHoralabel3.TabIndex = 14;
            this.FormatoHoralabel3.Text = "Formato";
            // 
            // FormatoHoratextBox2
            // 
            this.FormatoHoratextBox2.Location = new System.Drawing.Point(33, 139);
            this.FormatoHoratextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.FormatoHoratextBox2.Name = "FormatoHoratextBox2";
            this.FormatoHoratextBox2.Size = new System.Drawing.Size(59, 22);
            this.FormatoHoratextBox2.TabIndex = 11;
            // 
            // DigiteHoratextBox
            // 
            this.DigiteHoratextBox.Location = new System.Drawing.Point(14, 47);
            this.DigiteHoratextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DigiteHoratextBox.Name = "DigiteHoratextBox";
            this.DigiteHoratextBox.Size = new System.Drawing.Size(132, 22);
            this.DigiteHoratextBox.TabIndex = 10;
            // 
            // DigiteHoralabel
            // 
            this.DigiteHoralabel.AutoSize = true;
            this.DigiteHoralabel.Location = new System.Drawing.Point(13, 22);
            this.DigiteHoralabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DigiteHoralabel.Name = "DigiteHoralabel";
            this.DigiteHoralabel.Size = new System.Drawing.Size(79, 17);
            this.DigiteHoralabel.TabIndex = 9;
            this.DigiteHoralabel.Text = "Digite Hora";
            // 
            // CambiarFormatobutton
            // 
            this.CambiarFormatobutton.Location = new System.Drawing.Point(158, 81);
            this.CambiarFormatobutton.Margin = new System.Windows.Forms.Padding(4);
            this.CambiarFormatobutton.Name = "CambiarFormatobutton";
            this.CambiarFormatobutton.Size = new System.Drawing.Size(136, 28);
            this.CambiarFormatobutton.TabIndex = 8;
            this.CambiarFormatobutton.Text = "Cambiar Formato";
            this.CambiarFormatobutton.UseVisualStyleBackColor = true;
            this.CambiarFormatobutton.Click += new System.EventHandler(this.CambiarFormatobutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 298);
            this.Controls.Add(this.FormatoHoralabel3);
            this.Controls.Add(this.FormatoHoratextBox2);
            this.Controls.Add(this.DigiteHoratextBox);
            this.Controls.Add(this.DigiteHoralabel);
            this.Controls.Add(this.CambiarFormatobutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FormatoHoralabel3;
        private System.Windows.Forms.TextBox FormatoHoratextBox2;
        private System.Windows.Forms.TextBox DigiteHoratextBox;
        private System.Windows.Forms.Label DigiteHoralabel;
        private System.Windows.Forms.Button CambiarFormatobutton;
    }
}


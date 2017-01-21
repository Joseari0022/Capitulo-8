using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumarNegativo
{
    public partial class SumarNegativo : Form
    {
        public SumarNegativo()
        {
            InitializeComponent();
        }

        private void Calcularbutton_Click(object sender, EventArgs e)
        {
            int Resultado;
            int N1;
            int N2;

            N1 = Convert.ToInt32(DigiteNumero1textBox1.Text);
            N2 = Convert.ToInt32(DigiteNumero2textBox2.Text);

            Resultado = N1 + N2;

            if (Resultado > 0)
            {
                ResultadotextBox.Text = Convert.ToString(Resultado);
            }
            if (Resultado < 0)
            {
                ResultadotextBox.Text = '(' + Convert.ToString(Resultado) + ')';
            }
        }
    }
}

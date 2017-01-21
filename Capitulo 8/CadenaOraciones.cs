using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capitulo_8
{
    public partial class CadenaOraciones : Form
    {
        public CadenaOraciones()
        {
            InitializeComponent();
        }

        private void Precionarbutton_Click(object sender, EventArgs e)
        {
            String oracion;
            String[] resultado;
            int x = 0;

            oracion = CadenaOraciontextBox.Text;
            char[] delimitadores = { ' ', ' ', ' ', ' ' };
            resultado = oracion.Split(delimitadores);

            for (x = 0; x < resultado.Length; x++)
            {

                Resultado.Items.Add(resultado[x]);

            }
        }
    }
}

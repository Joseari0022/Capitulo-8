using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormatoAMFM
{
    public partial class FormatoAMFM : Form
    {
        DateTime hora = new DateTime();
        public FormatoAMFM()
        {
            InitializeComponent();
        }

        private void CambiarFormatobutton_Click(object sender, EventArgs e)
        {
            int digiteHora;
            String formato;
         
            digiteHora = int.Parse(DigiteHoratextBox.Text);
            hora.AddHours(digiteHora);
            //formato = String.Format(dateTimePicker;
            formato = String.Format("{0:hh}", digiteHora);
            FormatoHoratextBox2.Text = formato;
        }
    }
}

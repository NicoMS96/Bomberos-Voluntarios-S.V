using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bomberos
{
    public partial class formAnularPunto : Form
    {
        public string Observacion { get; set; }
        public formAnularPunto()
        {
            InitializeComponent();
        }

        private void btnAnularPunto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtObservacion.Text))
            {
                MessageBox.Show("Debe ingresar una observación.");
            }
            else
            {
                Observacion = txtObservacion.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

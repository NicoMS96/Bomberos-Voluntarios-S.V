using Logica;
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
    public partial class formEmergencia : Form
    {
        public formPrincipal contenedor { get; set; }
        EmergenciasLogica emergencias;
        public formEmergencia(formPrincipal Principal)
        {
            contenedor = Principal;
            InitializeComponent();
            emergencias = new EmergenciasLogica();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnNuevaEmergencia_Click(object sender, EventArgs e)
        {
            formAgregarModificarEmergencia FormAgregarEmergencia = new formAgregarModificarEmergencia("nueva");
            FormAgregarEmergencia.ShowDialog();
            ActualizarGrilla();
        }
        public void ActualizarGrilla()
        {
            dgvEmergencias.DataSource = emergencias.ObtenerEmergencias();
            dgvEmergencias.Columns[0].Visible = false;

            dgvEmergencias.Columns[1].Width = (int)(dgvEmergencias.Width * 0.1);
            dgvEmergencias.Columns[2].Width = (int)(dgvEmergencias.Width * 0.1);
            dgvEmergencias.Columns[3].Width = (int)(dgvEmergencias.Width * 0.45);
        }
        private void formEmergencia_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }
    }
}

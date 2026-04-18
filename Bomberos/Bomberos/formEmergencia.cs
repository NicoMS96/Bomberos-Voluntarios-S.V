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
        public Form1 contenedor { get; set; }
        EmergenciasLogica emergencias;
        public formEmergencia(Form1 Principal)
        {
            contenedor = Principal;
            InitializeComponent();
            emergencias = new EmergenciasLogica();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }

        private void btnNuevaEmergencia_Click(object sender, EventArgs e)
        {
            formAgregarModificarEmergencia FormAgregarEmergencia = new formAgregarModificarEmergencia("nueva");
            FormAgregarEmergencia.ShowDialog();
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

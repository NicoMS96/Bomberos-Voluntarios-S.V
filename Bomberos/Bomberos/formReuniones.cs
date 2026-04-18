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
    public partial class formReuniones : Form
    {
        public Form1 contenedor { get; set; }
        ReunionesLogica reuniones;
        public formReuniones(Form1 Contenedor)
        {
            contenedor = Contenedor;
            InitializeComponent();
            reuniones = new ReunionesLogica();
        }

        private void formReuniones_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
             
        }

        public void ActualizarGrilla()
        {
            dgvReuniones.DataSource = reuniones.ObtenerReuniones();
            dgvReuniones.Columns[0].Visible = false;

            dgvReuniones.Columns[1].Width = (int)(dgvReuniones.Width * 0.1);
            dgvReuniones.Columns[2].Width = (int)(dgvReuniones.Width * 0.1);
            dgvReuniones.Columns[3].Width = (int)(dgvReuniones.Width * 0.45);
        }
        private void btnInicio_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }

        private void btnNuevaReunion_Click(object sender, EventArgs e)
        {
            formAgregarModificarReunion reunion = new formAgregarModificarReunion("nueva",contenedor);
            reunion.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int idReunion = Convert.ToInt32(dgvReuniones.SelectedRows[0].Cells[0].Value);

            DialogResult resultado = MessageBox.Show("Esta por borrar una reunion, desea confirmar?", "Confirmacion", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int borrado = reuniones.EliminarReunion(idReunion);

                if (borrado > 0)
                {
                    MessageBox.Show("Reunion borrada correctamente.");
                    ActualizarGrilla();
                }
            }
        }
    }
}

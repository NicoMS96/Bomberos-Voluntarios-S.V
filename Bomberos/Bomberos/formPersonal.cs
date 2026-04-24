using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logica;

namespace Bomberos
{
    public partial class formPersonal : Form
    {
        BomberosLogica bomberosLogica;
        formPrincipal contenedor { get; set; }
        public formPersonal(formPrincipal principal)
        {
            contenedor = principal;
            InitializeComponent();
            bomberosLogica = new BomberosLogica();
            ActualizarGrilla();

        }

        private void btnNuevoBombero_Click(object sender, EventArgs e)
        {
            formAgregarModificarPersonal formAgregarPersonal = new formAgregarModificarPersonal(0);
            formAgregarPersonal.ShowDialog();
            ActualizarGrilla();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string accion = btnEliminar.Text == "ELIMINAR" ? "desactiva" : "activa";
            string mensaje = btnEliminar.Text == "ELIMINAR"
                ? "Está por desactivar a un bombero. ¿Está seguro?"
                : "Está por activar a un bombero. ¿Está seguro?";

            DialogResult resultado = MessageBox.Show(mensaje, "Confirmar acción", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                int id = Convert.ToInt32(dgvPersonal.SelectedRows[0].Cells[0].Value);
                int activo = btnEliminar.Text == "ELIMINAR" ? 0 : 1;

                bomberosLogica.AlternarActividad(activo, id);

                MessageBox.Show($"Bombero {accion}do exitosamente.", "Notificación");
            }
            else
            { 
                MessageBox.Show("La acción ha sido cancelada.", "Cancelado");
            }
            ActualizarGrilla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int codigoBombero = Convert.ToInt32(dgvPersonal.SelectedRows[0].Cells[0].Value);
            formAgregarModificarPersonal formAgregarPersonal = new formAgregarModificarPersonal(codigoBombero);
            formAgregarPersonal.ShowDialog();
            ActualizarGrilla(); 
        }

        private void formPersonal_Load(object sender, EventArgs e)
        {
            ActualizarGrilla();
        }

        public void ActualizarGrilla()
        {
            
            if (rdbActivo.Checked)
                dgvPersonal.DataSource = bomberosLogica.ObtenerBomberos(true);
            else
                dgvPersonal.DataSource = bomberosLogica.ObtenerBomberos(false);

             
            dgvPersonal.Columns[4].Visible = false;
            dgvPersonal.Columns[7].Visible = false;

        }

        private void rdbAsistInstitucion_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminar.Text = "ACTIVAR";
            ActualizarGrilla();
        }

        private void rdbAsistArea_CheckedChanged(object sender, EventArgs e)
        {
            btnEliminar.Text = "ELIMINAR";
            ActualizarGrilla();
        }

        private void formPersonal_Enter(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }

        private void formPersonal_Activated(object sender, EventArgs e)
        {
            ActualizarGrilla();

        }
    }
}

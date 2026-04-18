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
    public partial class formAreas : Form
    {
        public Form1 contenedor { get; set; }
        public string area { get; set; }
        TareasLogica tareas;

        public void AbrirFormulario(Form formulario)
        {
            pnlAreas.Controls.Clear();
            Form fh = formulario as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlAreas.Controls.Add(fh);
            pnlAreas.Tag = fh;
            fh.Show();
        }


        public formAreas(Form1 formPrincipal)
        {
            contenedor = formPrincipal;
            InitializeComponent();
            tareas = new TareasLogica();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }


        private void formAreas_Load(object sender, EventArgs e)
        {
             
        }


        private void pnlAreas_Paint(object sender, PaintEventArgs e)
        {

        }
        public void MostrarGrilla(int areaId)
        {
            dgvTareas.Visible = true; 
            btnAnularPunto.Visible = true;
            lblTitulo.Text = area;

            dgvTareas.DataSource = tareas.ObtenerTareas(areaId);

            dgvTareas.Columns[0].Width = (int)(dgvTareas.Width * 0.12);
            dgvTareas.Columns[1].Width = (int)(dgvTareas.Width * 0.2);
        }
 
      
        private void btnTaller_Click(object sender, EventArgs e)
        {
            area = "TALLER";
            MostrarGrilla(2);
        }

        private void btnFurrieles_Click(object sender, EventArgs e)
        {
            area = "FURRIELES"; 
            MostrarGrilla(4);
        }

        private void btnRoperia_Click(object sender, EventArgs e)
        {
            area = "ROPERIA"; 
            MostrarGrilla(5);
        }

        private void btnAutomotores_Click(object sender, EventArgs e)
        {
            area = "AUTOMOTORES";
            MostrarGrilla(6);
        }

        private void btnGuardias_Click(object sender, EventArgs e)
        {
            area = "GUARDIAS";
            MostrarGrilla(7);
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            area = "EDIFICIO";
            MostrarGrilla(1);
        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            area = "CAPACITACION";
            MostrarGrilla(3);
        }

        private void btnAnularPunto_Click(object sender, EventArgs e)
        {

        }
    }
}

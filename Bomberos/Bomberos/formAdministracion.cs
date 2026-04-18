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
    public partial class formAdministracion : Form
    {
        public Form1 contenedor { get; set; } 
        public formAdministracion(Form1 principal)
        { 
            contenedor = principal;
            InitializeComponent();
        }
        public void AbrirForm(Form form)
        {
            pnlPrincipal.Controls.Clear();
            Form fh = form as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(fh);
            pnlPrincipal.Tag = fh;
            fh.Show();
        }
        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }

        private void btnAsistArea_Click(object sender, EventArgs e)
        {

        }

        private void formAdministracion_Load(object sender, EventArgs e)
        { 
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }

        private void btnAsistencias_Click(object sender, EventArgs e)
        {
            AbrirForm(new formAsistencias());
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            AbrirForm(new formPersonal(contenedor));

        }
    }
}

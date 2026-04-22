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
        public int codigoBombero { get; set; }
        public formAdministracion(Form1 principal, int codigoBombero)
        {
            this.codigoBombero = codigoBombero;
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
            limpiarBotones(sender);

            //AbrirForm(new formAsistencias());
        }

        private void btnPersonal_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
            AbrirForm(new formPersonal(contenedor));

        }
        // Variable para trackear cuál está activo
        private Button btnActivo = null;
        private void limpiarBotones(object sender)
        {
            btnActivo = sender as Button;

            foreach (Button b in new[] { btnAsistencias, btnVolver, btnPersonal})
                b.Invalidate();

        }
        // ── Método reutilizable para el Paint ──
        private void PintarSidebarBtn(Button btn, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (btn == btnActivo)
            {
                // Fondo activo
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(138, 16, 16)), 0, 0, btn.Width, btn.Height);
                // Línea izquierda
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(255, 68, 68)), 0, 0, 3, btn.Height);
                // Texto
                e.Graphics.DrawString(btn.Text, btn.Font, new SolidBrush(Color.FromArgb(255, 224, 224)),
                    new RectangleF(10, 0, btn.Width - 10, btn.Height),
                    new StringFormat { LineAlignment = StringAlignment.Center });
            }
            else
            {
                // Fondo inactivo
                e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 40)), 0, 0, btn.Width, btn.Height);
                // Texto
                e.Graphics.DrawString(btn.Text, btn.Font, new SolidBrush(Color.FromArgb(168, 168, 168)),
                    new RectangleF(8, 0, btn.Width - 8, btn.Height),
                    new StringFormat { LineAlignment = StringAlignment.Center });
            }
        }
        private void btnVolver_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Fondo
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(37, 37, 40)), 0, 0, btn.Width, btn.Height);

            // Flecha ← 
            e.Graphics.DrawString("←", btn.Font, new SolidBrush(Color.FromArgb(168, 168, 168)),
                new RectangleF(8, 0, 20, btn.Height),
                new StringFormat { LineAlignment = StringAlignment.Center });

            // Texto VOLVER
            e.Graphics.DrawString("VOLVER", btn.Font, new SolidBrush(Color.FromArgb(168, 168, 168)),
                new RectangleF(28, 0, btn.Width - 28, btn.Height),
                new StringFormat { LineAlignment = StringAlignment.Center, Alignment = StringAlignment.Near });
        }

        private void btnVolver_Click_1(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formPrincipal(contenedor));
        }

        private void btnAsistencias_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnPersonal_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnAgregarModifTarea_Click(object sender, EventArgs e)
        { 

        }
    }
}

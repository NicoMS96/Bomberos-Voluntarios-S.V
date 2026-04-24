using Logica;
using Models;
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
        public formPrincipal contenedor { get; set; }
        public Bombero bombero;
        TareasLogica tareas;
        BomberosLogica bomberos;
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


        public formAreas(formPrincipal formPrincipal, Bombero bombero)
        {
            contenedor = formPrincipal;
            InitializeComponent();
            this.bombero = bombero;
            tareas = new TareasLogica();
            bomberos = new BomberosLogica();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
             
        }


        private void formAreas_Load(object sender, EventArgs e)
        {
            MostrarGrilla();
        }


        public void MostrarGrilla()
        {
            dgvTareas.Visible = true; 
           // lblTitulo.Text = bombero.Area.AreaNombre.ToString();

            dgvTareas.DataSource = tareas.ObtenerTareasAreas(bombero.Area.AreaId);
            btnAgregarTarea.Visible = true;
            dgvTareas.Columns[0].Width = (int)(dgvTareas.Width * 0.12);
            dgvTareas.Columns[1].Width = (int)(dgvTareas.Width * 0.2);
        }


        private void btnAnularPunto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            formAgregarModificarTarea tarea = new formAgregarModificarTarea(bombero); 
            tarea.ShowDialog();
        }

        #region CLICK BOTONES SideBar
        private void btnTaller_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        }

        private void btnFurrieles_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        }

        private void btnRoperia_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        }

        private void btnAutomotores_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        }

        private void btnGuardias_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);


        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            limpiarBotones(sender);
        } 


        private void btnEdificio_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        // Variable para trackear cuál está activo
        private Button btnActivo = null;
        private void limpiarBotones(object sender)
        {
            btnActivo = sender as Button;

            foreach (Button b in new[] { btnEdificio, btnTaller, btnCapacitacion,
                                  btnFurrieles, btnRoperia, btnAutomotores,
                                  btnGuardias })
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
         
        private void btnTaller_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnCapacitacion_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnFurrieles_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnRoperia_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
        }

        private void btnAutomotores_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e); 
        }

        private void btnGuardias_Paint(object sender, PaintEventArgs e)
        {
            PintarSidebarBtn(sender as Button, e);
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
        #endregion 
    }
}

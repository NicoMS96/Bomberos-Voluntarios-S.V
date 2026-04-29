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
using static Models.Enums;

namespace Bomberos
{
    public partial class formAreas : Form
    {
        public formPrincipal contenedor { get; set; } 
        public Bombero bombero;
        TareasLogica tareas; 
        private int areaActual;
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
            areaActual = bombero.Area.AreaId;
            tareas = new TareasLogica(); 
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void formAreas_Load(object sender, EventArgs e)
        {
            MostrarArea(bombero.Area.AreaId);
        }


        public void MostrarArea(int AreaId)
        {
            areaActual = AreaId;
            lblTitulo.Text = ((Areas)AreaId).ToString().ToUpper();

            btnAgregarTarea.Visible = false;
            btnAnularPunto.Visible = false;
            dgvTareas.Visible = false;

            var cat = (Categorias)bombero.Categoria.CategoriaId; 
            bool esPropia = AreaId == bombero.Area.AreaId;
            bool tienePermiso = bombero.Permisos;
            if (cat <= Categorias.Bombero && esPropia)
            {

                dgvTareas.Visible = true;
                btnAgregarTarea.Visible = true;

                if(cat == Categorias.Cadete && !tienePermiso)
                    btnAgregarTarea.Visible = false;
            }
            else
            {
                dgvTareas.Visible = true;
                if (esPropia || cat == Categorias.Jefe) 
                        btnAgregarTarea.Visible = true;
                    btnAgregarTarea.Visible = true;

                if (cat >= Categorias.Oficial)
                    btnAnularPunto.Visible = true;  
            }

            dgvTareas.DataSource = tareas.ObtenerTareasAreas(AreaId); 
            dgvTareas.Columns[0].Width = (int)(dgvTareas.Width * 0.12);
            dgvTareas.Columns[1].Width = (int)(dgvTareas.Width * 0.2);
        }
        

        private void btnAnularPunto_Click(object sender, EventArgs e)
        {
            if (dgvTareas.CurrentRow == null) return;

            int tareaId = Convert.ToInt32(dgvTareas.CurrentRow.Cells[0].Value);

            formAnularPunto formAnular = new formAnularPunto();
            if (formAnular.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    tareas.AnularPunto(tareaId, formAnular.Observacion, bombero.CodigoBombero);
                    MostrarArea(areaActual);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al anular punto: " + ex.Message);
                }
            }
        }

        private void btnAgregarTarea_Click(object sender, EventArgs e)
        {
            formAgregarModificarTarea tarea = new formAgregarModificarTarea(bombero, areaActual); 
            tarea.ShowDialog();
            MostrarArea(areaActual);
        }

        #region Click botones Sidebar
        private void btnTaller_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Taller); 
        }

        private void btnFurrieles_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Furrieles); 
        }

        private void btnRoperia_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Roperia); 
        }

        private void btnAutomotores_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Automotores); 
        }

        private void btnGuardias_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Guardias); 
        }

        private void btnEdificio_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Edificio);
        }

        private void btnCapacitacion_Click(object sender, EventArgs e)
        {
            BotonSeleccionado((Button)sender);
            MostrarArea((int)Areas.Capacitacion); 
        }

        // ── Método reutilizable para el Paint ──
        private void BotonSeleccionado(Button btn)
        {
            foreach (Button b in new[] { btnEdificio, btnTaller, btnCapacitacion,
                                  btnFurrieles, btnRoperia, btnAutomotores,
                                  btnGuardias })
                b.BackColor = Color.FromArgb(37, 37, 40);

            btn.BackColor = Color.FromArgb(138, 16, 16); 
        }
          
        #endregion 
    }
}

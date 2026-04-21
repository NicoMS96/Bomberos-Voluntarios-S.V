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
    public partial class formAgregarModificarTarea : Form
    {
        public string accion { get; set; }
        int areaId;
        int codigoBombero;
        TareasLogica tareas; 
        BomberosLogica bomberos;
        public formAgregarModificarTarea(int codigoBombero)
        {
            this.codigoBombero = codigoBombero;
            InitializeComponent();
            bomberos = new BomberosLogica();
            tareas = new TareasLogica(); 
        }

        private void formAgregarModificarTarea_Load(object sender, EventArgs e)
        {
            DataRow bombero = bomberos.ObtenerBombero(codigoBombero);
            string area = bombero["area"].ToString();
            areaId = Convert.ToInt32(bombero["areaId"]);

            lblTitulo.Text = "NUEVA TAREA EN " + area;

            AcomodarTitulo();
            CargarCmb();
        }
        public void CargarCmb()
        {
            cmbTareasPredeterminadas.DisplayMember = "tareaPredeterminada";
            cmbTareasPredeterminadas.ValueMember = "tareasPredeterminadaId";
            cmbTareasPredeterminadas.DataSource = tareas.ObtenerTareasPredeterminadas(areaId); 
        }
        public void AcomodarTitulo()
        {
            double mitadForm = this.Width / 2;
            double mitadTitulo = lblTitulo.Width / 2;

            double total = mitadForm - mitadTitulo;

            lblTitulo.Left = (int)total;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        { 
            int tareaPrId = Convert.ToInt32(cmbTareasPredeterminadas.SelectedValue);
            string detalles = txtTarea.Text;
             
            Tarea tarea = new Tarea()
            {
                TareasPredeterminadaId = tareaPrId,
                Observaciones = detalles,
                Fecha = DateTime.Now,
                CodigoBombero = codigoBombero,
                sumaPunto = 1
            };
             
            string error = tareas.GuardarTarea(tarea);
            if (error == null)
            {
                MessageBox.Show("Tarea registrada correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error: " + error);
            }
             
            this.Close(); 
        }

        private void formAgregarModificarTarea_Resize(object sender, EventArgs e)
        {
            AcomodarTitulo();
        }

        private void cmbTareasPredeterminadas_SelectedIndexChanged(object sender, EventArgs e)
        { 
            txtTarea.Enabled = Convert.ToInt32(cmbTareasPredeterminadas.SelectedValue) == 1 ? true : false;
            txtTarea.Text = "";
        }
    }
}

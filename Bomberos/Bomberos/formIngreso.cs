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
using Models;

namespace Bomberos
{
    public partial class formIngreso : Form
    {
        AsistenciasLogica asistencias;
        BomberosLogica bomberos;
        string accion;
        TareasLogica tareas;
        public formIngreso(string accion)
        {
            InitializeComponent();
            asistencias = new AsistenciasLogica();
            bomberos = new BomberosLogica();
            tareas = new TareasLogica();
            lblTitulo.Text = accion.ToUpper();
            this.accion = accion;
        }

        private void formIngreso_Load(object sender, EventArgs e)
        {

        }
        public bool validaciones(out int codigoBombero)
        {
             
            errorProvider1.Clear();
             
            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "El código no puede estar vacío.");
                codigoBombero = 0;  
                return false;
            }
             
            if (!int.TryParse(txtCodigo.Text, out codigoBombero))
            {
                errorProvider1.SetError(txtCodigo, "El código debe ser un número entero.");
                return false;
            }
             
            DataRow bombero = bomberos.ObtenerBombero(codigoBombero);
            if (bombero == null)
            {
                errorProvider1.SetError(txtCodigo, "No se encontró un bombero con el código ingresado.");
                return false;
            }
            if (Convert.ToInt32(bombero["activo"]) == 0)
            {
                errorProvider1.SetError(txtCodigo, "El codigo ingresado es de un bombero inactivo.");
                return false;
            }

            return true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (validaciones(out int codigoBombero))
                {
                    errorProvider1.Clear();
                    if (accion == "ingreso")
                        MarcarEntrada(codigoBombero);
                    else if (accion == "salida")
                        MarcarSalida(codigoBombero);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        public void MarcarSalida(int codigoBombero)
        {
            string mensajeError = asistencias.RegistrarSalida(codigoBombero);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                errorProvider1.SetError(txtCodigo, mensajeError);
            }
            else
            {
                MessageBox.Show("Salida registrada exitosamente.", "Confirmación");
            }
        }

        public void MarcarEntrada(int codigoBombero)
        {
            string mensajeError = asistencias.RegistrarAsistencia(codigoBombero);

            if (!string.IsNullOrEmpty(mensajeError))
            {
                errorProvider1.SetError(txtCodigo, mensajeError);
                return;
            }

            bool tareaPendiente = tareas.TareaPendiente(codigoBombero);

            if (tareaPendiente)
            {
                formAgregarModificarTarea tarea = new formAgregarModificarTarea(codigoBombero);
                tarea.ShowDialog();
            }
            else
            {
                MessageBox.Show("El bombero ingresó, no tiene tarea pendiente.");
            }
        }
    }
}

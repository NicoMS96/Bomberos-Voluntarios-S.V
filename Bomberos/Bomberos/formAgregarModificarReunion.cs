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
    public partial class formAgregarModificarReunion : Form
    {
        public string accion { get; set; }
        BomberosLogica bomberos;
        ReunionesLogica reuniones;
        Form1 contenedor { get; set; }
        public formAgregarModificarReunion(string accion, Form1 principal)
        {
            contenedor = principal;
            this.accion = accion;
            InitializeComponent();
            lblTitulo.Text = accion == "nueva" ? "NUEVA REUNION" : "MODIFICAR EMERGENCIA";
            bomberos = new BomberosLogica();
            reuniones = new ReunionesLogica();
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

        private void btnAsignarBombero_Click(object sender, EventArgs e)
        {
            if (validaciones(out int codigoBombero))
            {
                DataRow bombero = bomberos.ObtenerBombero(codigoBombero);

                if (!dtBomberos.AsEnumerable().Any(row => Convert.ToInt32(row["codigoBombero"]) == codigoBombero))
                { 
                    dtBomberos.Rows.Add(codigoBombero, bombero["nombre"] + " " + bombero["apellido"]);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCodigo, "El bombero ya está asignado.");
                }
            }

        }
        DataTable dtBomberos;
        private void formAgregarModificarReunion_Load(object sender, EventArgs e)
        {
            dtBomberos = new DataTable();
            dtBomberos.Columns.Add("codigoBombero", typeof(int));
            dtBomberos.Columns.Add("nombreApellido", typeof(string));

            lstAsisten.DisplayMember = "nombreApellido";
            lstAsisten.ValueMember = "codigoBombero";
            lstAsisten.DataSource = dtBomberos;
        }

        private void lstAsisten_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        public bool ValidarReunion()
        {
            if (lstAsisten.Items.Count == 0)
            {
                MessageBox.Show("No se puede guardar una reunión sin bomberos");
                return false;
            }

            if(txtTema.Text=="" || txtTema.Text == null)
            {
                MessageBox.Show("Debe haber un tema de reunión");
                return false;
            }
            return true;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarReunion())
            {
                try
                {
                    ReunionArea reunion = new ReunionArea()
                    {
                        Fecha = dtpFecha.Value.Date,
                        Hora = dtpHora.Value.TimeOfDay,
                        TemaReunion = txtTema.Text
                    };

                    int codigoReunion = reuniones.AgregarReunion(reunion);

                    foreach (var item in lstAsisten.Items)
                    {
                         
                        DataRowView rowView = item as DataRowView;
                        if (rowView != null)
                        {
                            int codigoBombero = Convert.ToInt32(rowView["codigoBombero"]);
                            reuniones.BomberosReunion(codigoReunion, codigoBombero);

                        }
                    }
                    formReuniones FormReuniones = new formReuniones(contenedor);
                    contenedor.AbrirFormulario(FormReuniones);
                    MessageBox.Show("Reunion registrada correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
        }
    }
}

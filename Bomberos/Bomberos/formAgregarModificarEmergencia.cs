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
    public partial class formAgregarModificarEmergencia : Form
    { 
        public string accion { get; set; }
        BomberosLogica bomberos;
        EmergenciasLogica emergencias;
        public formAgregarModificarEmergencia(string accion)
        {
            this.accion = accion;
            InitializeComponent();
            bomberos = new BomberosLogica();
            emergencias = new EmergenciasLogica();
        }
        DataTable dtBomberos;
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

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarReunion())
            {
                try
                {
                    Emergencia emergencia = new Emergencia()
                    {
                        FechaEntrada = dtpInicio.Value,
                        FechaSalida= dtpFinalizacion.Value,
                        Observacion=txtDetalles.Text
                    };

                    int codigoEmergencia = emergencias.AgregarEmergencia(emergencia);

                    foreach (var item in lstAsisten.Items)
                    {

                        DataRowView rowView = item as DataRowView;
                        if (rowView != null)
                        {
                            int codigoBombero = Convert.ToInt32(rowView["codigoBombero"]);
                            emergencias.BomberosEmergencias(codigoEmergencia, codigoBombero);
                        }
                    }
                    MessageBox.Show("Emergencia registrada correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }

        }
        public bool ValidarReunion()
        {
            if (lstAsisten.Items.Count == 0)
            {
                MessageBox.Show("No se puede guardar una emergencia sin bomberos");
                return false;
            }

            if (txtDetalles.Text == "" || txtDetalles.Text == null)
            {
                MessageBox.Show("Describa los detalles de la emergencia");
                return false;
            }
            return true;
        }

        private void formAgregarModificarEmergencia_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = accion == "nueva" ? "NUEVA EMERGENCIA" : "MODIFICAR EMERGENCIA";
            AcomodarTitulo();
            dtBomberos = new DataTable();
            dtBomberos.Columns.Add("codigoBombero", typeof(int));
            dtBomberos.Columns.Add("nombreApellido", typeof(string));

            lstAsisten.DisplayMember = "nombreApellido";
            lstAsisten.ValueMember = "codigoBombero";
            lstAsisten.DataSource = dtBomberos;
        }

        public void AcomodarTitulo()
        {
            double mitadForm = this.Width / 2;
            double mitadTitulo = lblTitulo.Width / 2;

            double total = mitadForm - mitadTitulo;

            lblTitulo.Left = (int)total;
        }


    }


}
        
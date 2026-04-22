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
            ConfigurarListaBomberos();
            bomberos = new BomberosLogica();
            emergencias = new EmergenciasLogica();
        }
        DataTable dtBomberos;
        private void btnAsignarBombero_Click(object sender, EventArgs e)
        {
            if (validaciones(out int codigoBombero))
            {
                 Bombero bombero = bomberos.ObtenerBombero(codigoBombero);

                if (!dtBomberos.AsEnumerable().Any(row => Convert.ToInt32(row["codigoBombero"]) == codigoBombero))
                {
                    dtBomberos.Rows.Add(codigoBombero, bombero.Nombre + " " + bombero.Apellido);
                    AgregarBomberoLista(codigoBombero, bombero.Nombre );
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

            Bombero bombero = bomberos.ObtenerBombero(codigoBombero);
            if (bombero == null)
            {
                errorProvider1.SetError(txtCodigo, "No se encontró un bombero con el código ingresado.");
                return false;
            }
            if (bombero.Activo)
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

                    foreach (DataGridViewRow row in dgvBomberos.Rows)
                    { 
                        if (row != null)
                        {
                            int codigoBombero = Convert.ToInt32(row.Cells[0].Value);
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
            if (dgvBomberos.Rows.Count == 0)
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

            /*lstAsisten.DisplayMember = "nombreApellido";
            lstAsisten.ValueMember = "codigoBombero";
            lstAsisten.DataSource = dtBomberos;*/
        }

        public void AcomodarTitulo()
        {
            double mitadForm = this.Width / 2;
            double mitadTitulo = lblTitulo.Width / 2;

            double total = mitadForm - mitadTitulo;

            lblTitulo.Left = (int)total;
        }
        private void AgregarBomberoLista(int codigo, string nombre)
        {
            dgvBomberos.Rows.Add(
                codigo.ToString().PadLeft(2, '0'),
                nombre,
                "QUITAR"
            );
        }
        #region CONFIG DGVBOMBEROS
        private void ConfigurarListaBomberos()
        {
            dgvBomberos.ColumnHeadersVisible = false; // sin headers
            dgvBomberos.RowHeadersVisible = false; // sin columna izquierda
            dgvBomberos.AllowUserToAddRows = false;
            dgvBomberos.AllowUserToDeleteRows = false;
            dgvBomberos.AllowUserToResizeRows = false;
            dgvBomberos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBomberos.MultiSelect = false;
            dgvBomberos.ScrollBars = ScrollBars.Vertical;
            dgvBomberos.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvBomberos.EnableHeadersVisualStyles = false;

            // Colores
            dgvBomberos.BackgroundColor = Color.FromArgb(43, 43, 46);
            dgvBomberos.GridColor = Color.FromArgb(68, 68, 72);
            dgvBomberos.DefaultCellStyle.BackColor = Color.FromArgb(58, 58, 63);
            dgvBomberos.DefaultCellStyle.ForeColor = Color.FromArgb(232, 232, 232);
            dgvBomberos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(107, 18, 18);
            dgvBomberos.DefaultCellStyle.SelectionForeColor = Color.FromArgb(255, 224, 224);
            dgvBomberos.DefaultCellStyle.Font = new Font("Segoe UI", 9f);
            dgvBomberos.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(50, 50, 55);

            // Columnas
            dgvBomberos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "codigo",
                Width = 40,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = Color.FromArgb(43, 43, 46),
                    ForeColor = Color.FromArgb(168, 168, 168),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    Font = new Font("Segoe UI", 8f)
                }
            });

            dgvBomberos.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            // Columna botón QUITAR
            dgvBomberos.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "quitar",
                Text = "QUITAR",
                UseColumnTextForButtonValue = true,
                Width = 70,
                DefaultCellStyle = new DataGridViewCellStyle()
                {
                    BackColor = Color.FromArgb(43, 43, 46),
                    ForeColor = Color.FromArgb(255, 112, 112),
                    Font = new Font("Segoe UI", 7.5f, FontStyle.Bold),
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                },
                FlatStyle = FlatStyle.Flat
            });
        }
        #endregion

        private void dgvBomberos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgvBomberos.Columns["quitar"].Index)
            {
                dgvBomberos.Rows.RemoveAt(e.RowIndex);
            }
        }
    }


}
        
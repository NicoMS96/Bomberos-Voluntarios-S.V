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
        formPrincipal contenedor { get; set; }
        public formAgregarModificarReunion(string accion, formPrincipal principal)
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

            Bombero bombero = bomberos.ObtenerBombero(codigoBombero);
            if (bombero == null)
            {
                errorProvider1.SetError(txtCodigo, "No se encontró un bombero con el código ingresado.");
                return false;
            }
            if (!bombero.Activo)
            {
                errorProvider1.SetError(txtCodigo, "El codigo ingresado es de un bombero inactivo.");
                return false;
            }

            return true;
        }
        List<Bombero> bomberosAsignados = new List<Bombero>();
        public void AgregarBomberoLista(int codigo, string nombre)
        {
            dgvBomberos.Rows.Add(
                codigo.ToString().PadLeft(2, '0'),
                nombre,
                "QUITAR"
            );

        }
        private void btnAsignarBombero_Click(object sender, EventArgs e)
        {
            if (validaciones(out int codigoBombero))
            {
                Bombero bombero = bomberos.ObtenerBombero(codigoBombero);

                if (!bomberosAsignados.Any(b => b.CodigoBombero == codigoBombero))
                {
                    bomberosAsignados.Add(bombero);
                    AgregarBomberoLista(codigoBombero, bombero.Nombre + " " + bombero.Apellido);
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(txtCodigo, "El bombero ya está asignado.");
                }
            }

        } 
        private void formAgregarModificarReunion_Load(object sender, EventArgs e)
        {
            ConfigurarListaBomberos();
        }

        private void lstAsisten_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }
        public bool ValidarReunion()
        {
            if (dgvBomberos.Rows.Count == 0)
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
            
        }

        private void btnGuardar2_Click(object sender, EventArgs e)
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

                    foreach(var b in bomberosAsignados)
                        reuniones.BomberosReunion(codigoReunion, b.CodigoBombero);
                     
                    MessageBox.Show("Reunion registrada correctamente.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error" + ex.Message);
                }

            }
            
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
                int codigo = Convert.ToInt32(dgvBomberos.Rows[e.RowIndex].Cells["codigo"].Value);
                bomberosAsignados.RemoveAll(b => b.CodigoBombero == codigo);
                dgvBomberos.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}

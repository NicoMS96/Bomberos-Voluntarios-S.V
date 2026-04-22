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
    public partial class formAgregarModificarPersonal : Form
    {
        string accion;
        BomberosLogica bomberos;
        Form1 contenedor { get; set; }
        formPersonal formPersonalOrigen { get; set; }

        int codigoBombero;
        public formAgregarModificarPersonal(string accion, int codigoBombero, Form1 principal, formPersonal origen)
        {
            contenedor = principal;
            this.codigoBombero = codigoBombero;
            this.accion = accion;
            this.formPersonalOrigen = origen;
            InitializeComponent();
            lblTitulo.Text = accion=="agregar" ? "NUEVO BOMBERO" : "MODIFICAR BOMBERO";
            bomberos = new BomberosLogica(); 
        }
         

        private void formAgregarModificarPersonal_Load(object sender, EventArgs e)
        {
            RellenarCmbs();

            if(accion=="modificar")
                RellenarCampos();
        }

        public bool Validacion()
        {
            ErrorP.Clear();

            bool validado = true;
            if (txtNombre.Text.Trim() == "")
            {
                ErrorP.SetError(txtNombre, "El campo no debe estar vacio");
                validado = false;
            }

            if (txtApellido.Text.Trim() == "")
            {
                ErrorP.SetError(txtApellido, "El campo no debe estar vacio");
                validado = false;
            }

            if (txtDni.Text.Trim() == "")
            {
                ErrorP.SetError(txtDni, "El campo no debe estar vacio");
                validado = false;
            }
            if (txtDni.TextLength < 7 || txtDni.TextLength > 9)
            {
                ErrorP.SetError(txtDni, "Ingrese un DNI correcto.");
                validado = false;
            }


            if (txtContrasena.Text.Trim() == "" && Convert.ToInt32(cmbCategoria.SelectedValue) < 4)
            {
                ErrorP.SetError(txtContrasena, "El campo no debe estar vacio");
                validado = false;
            }

            if (txtContrasena.Text.Trim() == "" && Convert.ToInt32(cmbCategoria.SelectedValue) == 4 && chkPermiso.Checked)
            {
                ErrorP.SetError(txtContrasena, "El campo no debe estar vacio");
                validado = false;
            }

            if (txtContrasena.Text.Trim().Length <= 6)
            {
                ErrorP.SetError(txtContrasena, "La contraseña debe tener mas de 6 carácteres");
                validado = false;
            }

            return validado;
        }

        public void RellenarCampos()
        {
            Bombero bombero = bomberos.ObtenerBombero(codigoBombero);

            txtNombre.Text = bombero.Nombre;
            txtApellido.Text = bombero.Apellido;
            txtDni.Text = bombero.Dni;
            txtContrasena.Text = bombero.Contrasena;

            chkPermiso.Checked = bombero.Permisos;
            if (chkPermiso.Checked)
                chkPermiso.Checked = true;
            else
                chkPermiso.Checked = false;

            cmbArea.SelectedValue =Convert.ToInt32(bombero.Area.AreaId);
            cmbCategoria.SelectedValue = Convert.ToInt32(bombero.Categoria.CategoriaId);

        }


        public void RellenarCmbs()
        {
            cmbCategoria.DisplayMember = "categoria";
            cmbCategoria.ValueMember = "categoriaId";
            cmbCategoria.DataSource = bomberos.ObtenerCategorias();

            cmbArea.DisplayMember = "area";
            cmbArea.ValueMember = "areaId";
            cmbArea.DataSource = bomberos.ObtenerAreas();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            if (Validacion())
            { 
                Bombero Bombero = new Bombero()
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Dni = txtDni.Text,
                    Contrasena = txtContrasena.Text, 
                    Activo = true,
                    Permisos = chkPermiso.Checked,
                    Categoria = new Categoria()
                    {
                         CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue)
                    },
                    Area = new Area()
                    {
                        AreaId = Convert.ToInt32(cmbArea.SelectedValue)
                    }
                };

                try
                {
                    if (accion == "agregar")
                    {
                        DialogResult resultado = MessageBox.Show("Está a punto de registra un nuevo bombero. ¿Confirma los datos?", "Confirmación de nuevo bombero", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            int confirma = bomberos.NuevoBombero(Bombero);
                            MessageBox.Show("Bombero registrado exitosamente.", "Notificación");
                            this.Close();
                        }
                    }

                    if (accion == "modificar")
                    {
                        DialogResult resultado = MessageBox.Show($"Está a punto de modificar al bombero con DNI {Bombero.Dni}. ¿Confirma los datos?", "Confirmación de modificación", MessageBoxButtons.YesNo);

                        if (resultado == DialogResult.Yes)
                        {
                            int confirma = bomberos.ModificarBombero(Bombero, codigoBombero);
                            MessageBox.Show("Bombero modificado exitosamente.", "Notificación");
                            this.Close(); 
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Hubo un error: " + ex.Message);
                }
            }
        }

        private void chkPermiso_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPermiso.Checked)
                txtContrasena.Enabled = true;
            else
                txtContrasena.Enabled = false;
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(cmbCategoria.SelectedValue) == 4)
            {
                chkPermiso.Visible = true; 
                txtContrasena.Enabled = false;
            }
            else
            {
                chkPermiso.Visible = false; 
                txtContrasena.Enabled = true;
            }

            if (accion == "agregar")
            {
                if (Convert.ToInt32(cmbCategoria.SelectedValue) == 4)
                {
                    chkPermiso.Checked = false;
                }
                else
                {
                    chkPermiso.Checked = true;
                } 
            }

        }
    }
}

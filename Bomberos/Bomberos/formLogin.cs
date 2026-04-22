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
    public partial class formLogin : Form
    {
        BomberosLogica bomberos;
        Form1 contenedor { get; set; }
        string modulo;
        public formLogin(string modulo, Form1 contenedor)
        {
            InitializeComponent();
            this.contenedor = contenedor;
            this.modulo = modulo;
            lblTitulo.Text = "INGRESAR A " + modulo;
            bomberos = new BomberosLogica();
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
            if (bombero == null && codigoBombero!=0)
            {
                errorProvider1.SetError(txtCodigo, "No se encontró un bombero con el código ingresado.");
                return false;
            }

            if (codigoBombero != 0)
            {
                if (bombero.Activo)
                {
                    errorProvider1.SetError(txtCodigo, "El codigo ingresado es de un bombero inactivo.");
                    return false;
                }
            }
             
            if (string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                errorProvider1.SetError(txtContrasena, "El campo contraseña no puede estar vacío.");
                codigoBombero = 0;
                return false;
            } 
            return true;
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (validaciones(out int codigoBombero))
            {
                DataTable dtBomberos = bomberos.ObtenerBomberos();
                if (dtBomberos.Rows.Count > 0)
                {
                    Bombero bombero = bomberos.ObtenerBombero(codigoBombero);

                    if (codigoBombero != 0)
                    {
                        if (bombero.Contrasena == txtContrasena.Text && bombero.CodigoBombero.ToString() == txtCodigo.Text)
                        {
                            if (bombero.Permisos || bombero.Categoria.CategoriaId < 4)
                            {
                                MessageBox.Show("Tiene los permisos necesarios");
                                if (modulo == "ADMINISTRACION")
                                    contenedor.AbrirFormulario(new formAdministracion(contenedor, codigoBombero));

                                if (modulo == "AREAS")
                                    contenedor.AbrirFormulario(new formAreas(contenedor, codigoBombero));

                                this.Close();

                            }
                            else
                            {
                                MessageBox.Show("No tiene los permisos necesarios.");
                            }
                        }
                    }
                }
                else
                {
                    if (txtCodigo.Text == 0.ToString() && txtContrasena.Text == "admin")
                    {
                        if (modulo == "ADMINISTRACION")
                            contenedor.AbrirFormulario(new formAdministracion(contenedor, codigoBombero));

                        MessageBox.Show("Al crear un usuario, el usuario temporal no podrà volver a acceder","ADVERTENCIA");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuario registrado, utilice el usuario temporal");
                    }
                }


            }
        }
    }
}

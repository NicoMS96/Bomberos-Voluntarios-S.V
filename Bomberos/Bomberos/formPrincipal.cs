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
    public partial class formPrincipal : Form
    {
        public Form1 contenedor { get; set; } 
        public formPrincipal(Form1 formPrincipal)
        {
            contenedor = formPrincipal;
            InitializeComponent();

        }
        private void formPrincipal_Load(object sender, EventArgs e)
        {  
            FechaHora();
        }
        
        private void btnAreas_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin("AREAS", contenedor);
            login.ShowDialog();
        }

        private void btnReuniones_Click(object sender, EventArgs e)
        {
             
            contenedor.AbrirFormulario(new formReuniones(contenedor));

        }


        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            formLogin login = new formLogin("ADMINISTRACION",contenedor);
            login.ShowDialog(); 
        }

        private void btnSemana_Click(object sender, EventArgs e)
        {
            contenedor.AbrirFormulario(new formEmergencia(contenedor));
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            formIngreso FormIngreso = new formIngreso("ingreso");
            FormIngreso.ShowDialog();
        }

        public void FechaHora()
        {
            timer1.Start();
            string mes = "", dia = "";

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    dia = "Lunes";
                    break;
                case DayOfWeek.Tuesday:
                    dia = "Martes";
                    break;
                case DayOfWeek.Wednesday:
                    dia = "Miércoles";
                    break;
                case DayOfWeek.Thursday:
                    dia = "Jueves";
                    break;
                case DayOfWeek.Friday:
                    dia = "Viernes";
                    break;
                case DayOfWeek.Saturday:
                    dia = "Sábado";
                    break;
                case DayOfWeek.Sunday:
                    dia = "Domingo";
                    break;
            }

            switch (DateTime.Now.Month)
            {
                case 1:
                    mes = "Enero";
                    break;
                case 2:
                    mes = "Febrero";
                    break;
                case 3:
                    mes = "Marzo";
                    break;
                case 4:
                    mes = "Abril";
                    break;
                case 5:
                    mes = "Mayo";
                    break;
                case 6:
                    mes = "Junio";
                    break;
                case 7:
                    mes = "Julio";
                    break;
                case 8:
                    mes = "Agosto";
                    break;
                case 9:
                    mes = "Septiembre";
                    break;
                case 10:
                    mes = "Octubre";
                    break;
                case 11:
                    mes = "Noviembre";
                    break;
                case 12:
                    mes = "Diciembre";
                    break;
            }
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
            lblDia.Text = dia + " " + DateTime.Now.ToString("dd")+ " de "+mes;

            double fecha = lblDia.Width / 2;
            double hora = lblHora.Width / 2;
            double pnl = pnlFecha.Width/2;
            lblDia.Left = (int)(pnl - fecha);
            lblHora.Left = (int)(pnl - hora);
        }
             

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnSalida_Click(object sender, EventArgs e)
        {
            formIngreso FormIngreso = new formIngreso("salida");
            FormIngreso.ShowDialog();
        }
        
    }
}

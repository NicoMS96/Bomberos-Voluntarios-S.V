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
    public partial class Form1 : Form
    { 
        public Form1()
        { 
            InitializeComponent();
        }
        public void AbrirFormulario(Form formulario)
        {
            pnlPrincipal.Controls.Clear();
            Form fh = formulario as Form;  
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPrincipal.Controls.Add(fh);
            pnlPrincipal.Tag = fh;
            fh.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AbrirFormulario(new formPrincipal(this)); 
        }
    }
}

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

namespace Bomberos
{
    public partial class formAsistencias : Form
    {
        AsistenciasLogica asistLogica;
        public formAsistencias()
        {
            InitializeComponent();
            asistLogica = new AsistenciasLogica();
        }
         

        public void Institucion()
        {
            
            // Obtienes la lista de asistencias desde la lógica
            var listaAsistencias = asistLogica.AsistenciaInsti();

            // Asignas la lista al DataGridView
            dgvAsistencias.DataSource = listaAsistencias;

            // Opcionalmente, puedes establecer un formato para las columnas
            dgvAsistencias.Columns["CodigoBombero"].HeaderText = "Código Bombero";
            dgvAsistencias.Columns["NombreCompleto"].HeaderText = "Nombre Completo";
            dgvAsistencias.Columns["FechaId"].HeaderText = "Fecha";
            dgvAsistencias.Columns["HorasTrabajadas"].HeaderText = "Horas Trabajadas";

            // Ajusta el tamaño de las columnas al contenido
            dgvAsistencias.AutoResizeColumns();
        }


        private void formAsistencias_Load(object sender, EventArgs e)
        {
            Institucion();
        }
    }
}

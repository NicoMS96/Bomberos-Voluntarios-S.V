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

        public void ejemplo()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("Nombre y Apellido");

            for (int i = 1; i <= 31; i++)
            {
                dt.Columns.Add(i.ToString());
            }


            dt.Columns.Add("Total Horas");


            dt.Columns.Add("Total Puntos");
            dt.Rows.Add("Juan Pérez", "1", "A", "1", "1", "0", "1", "A", "1", "1", "0", "1", "A", "1", "1", "0", "1", "A", "1", "1", "0", "1", "A", "1", "1", "0", "1", "A", "1", "1", "0", "1", 40, 19);
            dt.Rows.Add("Bombero 2", "0", "A", "1", "1", "0", "1", "A", "1", "0", "0", "1", "A", "A", "1", "0", "1", "A", "1", "A", "0", "1", "A", "1", "1", "1", "1", "A", "1", "1", "0", "1", 32, 16);
            dgvAsistencias.DataSource = dt;
            dgvAsistencias.Columns[0].Width = (int)(dgvAsistencias.Width * 0.10);
            for (int i = 1; i <= 31; i++)
            {
                dgvAsistencias.Columns[i].Width = (int)(dgvAsistencias.Width * 0.026);
                dgvAsistencias.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
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

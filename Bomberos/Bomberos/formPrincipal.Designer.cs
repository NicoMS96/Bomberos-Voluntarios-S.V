
namespace Bomberos
{
    partial class formPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalida = new System.Windows.Forms.Button();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.btnSemana = new System.Windows.Forms.Button();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnReuniones = new System.Windows.Forms.Button();
            this.btnAdministracion = new System.Windows.Forms.Button();
            this.btnAreas = new System.Windows.Forms.Button();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.pnlFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalida.Location = new System.Drawing.Point(850, 137);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(200, 71);
            this.btnSalida.TabIndex = 4;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Location = new System.Drawing.Point(642, 137);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(200, 71);
            this.btnIngreso.TabIndex = 5;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSemana.FlatAppearance.BorderSize = 0;
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSemana.Location = new System.Drawing.Point(642, 232);
            this.btnSemana.Name = "btnSemana";
            this.btnSemana.Size = new System.Drawing.Size(408, 71);
            this.btnSemana.TabIndex = 7;
            this.btnSemana.Text = "EMERGENCIA";
            this.btnSemana.UseVisualStyleBackColor = false;
            this.btnSemana.Click += new System.EventHandler(this.btnSemana_Click);
            // 
            // lblDia
            // 
            this.lblDia.AutoSize = true;
            this.lblDia.BackColor = System.Drawing.Color.Transparent;
            this.lblDia.Font = new System.Drawing.Font("Roboto Condensed", 30.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(142, 159);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(271, 49);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Domingo 27/08";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Roboto Condensed", 80.75F, System.Drawing.FontStyle.Bold);
            this.lblHora.Location = new System.Drawing.Point(52, 29);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(445, 130);
            this.lblHora.TabIndex = 3;
            this.lblHora.Text = "00:00:00";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnReuniones
            // 
            this.btnReuniones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnReuniones.FlatAppearance.BorderSize = 0;
            this.btnReuniones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReuniones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReuniones.Location = new System.Drawing.Point(489, 382);
            this.btnReuniones.Name = "btnReuniones";
            this.btnReuniones.Size = new System.Drawing.Size(240, 71);
            this.btnReuniones.TabIndex = 9;
            this.btnReuniones.Text = "REUNIONES DE AREAS";
            this.btnReuniones.UseVisualStyleBackColor = false;
            this.btnReuniones.Click += new System.EventHandler(this.btnReuniones_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministracion.Location = new System.Drawing.Point(810, 382);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(240, 71);
            this.btnAdministracion.TabIndex = 8;
            this.btnAdministracion.Text = "ADMINISTRACION";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreas.Location = new System.Drawing.Point(164, 382);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(240, 71);
            this.btnAreas.TabIndex = 6;
            this.btnAreas.Text = "AREAS";
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lblHora);
            this.pnlFecha.Controls.Add(this.lblDia);
            this.pnlFecha.Location = new System.Drawing.Point(78, 75);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(538, 288);
            this.pnlFecha.TabIndex = 10;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 571);
            this.Controls.Add(this.pnlFecha);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnReuniones);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPrincipal";
            this.Text = "formPrincipal";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalida;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Button btnSemana;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnReuniones;
        private System.Windows.Forms.Button btnAdministracion;
        private System.Windows.Forms.Button btnAreas;
        private System.Windows.Forms.Panel pnlFecha;
    }
}
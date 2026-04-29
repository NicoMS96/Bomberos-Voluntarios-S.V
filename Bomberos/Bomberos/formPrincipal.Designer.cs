
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
            this.PanelIzquierdo = new System.Windows.Forms.Panel();
            this.tableLayoutLogo = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBoxEscudo = new System.Windows.Forms.PictureBox();
            this.pictureBoxTextos = new System.Windows.Forms.PictureBox();
            this.PanelTopRojo = new System.Windows.Forms.Panel();
            this.PanelBotRojo = new System.Windows.Forms.Panel();
            this.pnlFecha.SuspendLayout();
            this.PanelIzquierdo.SuspendLayout();
            this.tableLayoutLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalida
            // 
            this.btnSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSalida.FlatAppearance.BorderSize = 0;
            this.btnSalida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSalida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalida.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSalida.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSalida.Location = new System.Drawing.Point(802, 274);
            this.btnSalida.Name = "btnSalida";
            this.btnSalida.Size = new System.Drawing.Size(200, 71);
            this.btnSalida.TabIndex = 4;
            this.btnSalida.Text = "SALIDA";
            this.btnSalida.UseVisualStyleBackColor = false;
            this.btnSalida.Click += new System.EventHandler(this.btnSalida_Click);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnIngreso.FlatAppearance.BorderSize = 0;
            this.btnIngreso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnIngreso.Location = new System.Drawing.Point(594, 274);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(200, 71);
            this.btnIngreso.TabIndex = 5;
            this.btnIngreso.Text = "INGRESO";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // btnSemana
            // 
            this.btnSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.btnSemana.FlatAppearance.BorderSize = 0;
            this.btnSemana.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.btnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSemana.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSemana.Location = new System.Drawing.Point(594, 351);
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
            this.lblDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblDia.Location = new System.Drawing.Point(142, 159);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(271, 49);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "Domingo 01/01";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Roboto Condensed", 80.75F, System.Drawing.FontStyle.Bold);
            this.lblHora.ForeColor = System.Drawing.Color.WhiteSmoke;
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
            this.btnReuniones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.btnReuniones.FlatAppearance.BorderSize = 0;
            this.btnReuniones.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(79)))));
            this.btnReuniones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReuniones.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnReuniones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnReuniones.Location = new System.Drawing.Point(657, 452);
            this.btnReuniones.Name = "btnReuniones";
            this.btnReuniones.Size = new System.Drawing.Size(220, 57);
            this.btnReuniones.TabIndex = 9;
            this.btnReuniones.Text = "REUNIONES DE AREAS";
            this.btnReuniones.UseVisualStyleBackColor = false;
            this.btnReuniones.Click += new System.EventHandler(this.btnReuniones_Click);
            // 
            // btnAdministracion
            // 
            this.btnAdministracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.btnAdministracion.FlatAppearance.BorderSize = 0;
            this.btnAdministracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(79)))));
            this.btnAdministracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministracion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAdministracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAdministracion.Location = new System.Drawing.Point(898, 452);
            this.btnAdministracion.Name = "btnAdministracion";
            this.btnAdministracion.Size = new System.Drawing.Size(211, 57);
            this.btnAdministracion.TabIndex = 8;
            this.btnAdministracion.Text = "ADMINISTRACION";
            this.btnAdministracion.UseVisualStyleBackColor = false;
            this.btnAdministracion.Click += new System.EventHandler(this.btnAdministracion_Click);
            // 
            // btnAreas
            // 
            this.btnAreas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(66)))));
            this.btnAreas.FlatAppearance.BorderSize = 0;
            this.btnAreas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(79)))));
            this.btnAreas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAreas.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnAreas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.btnAreas.Location = new System.Drawing.Point(439, 452);
            this.btnAreas.Name = "btnAreas";
            this.btnAreas.Size = new System.Drawing.Size(195, 57);
            this.btnAreas.TabIndex = 6;
            this.btnAreas.Text = "AREAS";
            this.btnAreas.UseVisualStyleBackColor = false;
            this.btnAreas.Click += new System.EventHandler(this.btnAreas_Click);
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lblHora);
            this.pnlFecha.Controls.Add(this.lblDia);
            this.pnlFecha.Location = new System.Drawing.Point(520, 22);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(538, 288);
            this.pnlFecha.TabIndex = 10;
            // 
            // PanelIzquierdo
            // 
            this.PanelIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(11)))));
            this.PanelIzquierdo.Controls.Add(this.tableLayoutLogo);
            this.PanelIzquierdo.Controls.Add(this.PanelTopRojo);
            this.PanelIzquierdo.Controls.Add(this.PanelBotRojo);
            this.PanelIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelIzquierdo.Location = new System.Drawing.Point(0, 0);
            this.PanelIzquierdo.Name = "PanelIzquierdo";
            this.PanelIzquierdo.Size = new System.Drawing.Size(310, 571);
            this.PanelIzquierdo.TabIndex = 11;
            // 
            // tableLayoutLogo
            // 
            this.tableLayoutLogo.ColumnCount = 1;
            this.tableLayoutLogo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutLogo.Controls.Add(this.pictureBoxEscudo, 0, 0);
            this.tableLayoutLogo.Controls.Add(this.pictureBoxTextos, 0, 1);
            this.tableLayoutLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutLogo.Location = new System.Drawing.Point(0, 8);
            this.tableLayoutLogo.Name = "tableLayoutLogo";
            this.tableLayoutLogo.RowCount = 2;
            this.tableLayoutLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutLogo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutLogo.Size = new System.Drawing.Size(310, 555);
            this.tableLayoutLogo.TabIndex = 2;
            // 
            // pictureBoxEscudo
            // 
            this.pictureBoxEscudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxEscudo.Image = global::Bomberos.Properties.Resources.escudo;
            this.pictureBoxEscudo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxEscudo.Name = "pictureBoxEscudo";
            this.pictureBoxEscudo.Size = new System.Drawing.Size(304, 327);
            this.pictureBoxEscudo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxEscudo.TabIndex = 0;
            this.pictureBoxEscudo.TabStop = false;
            // 
            // pictureBoxTextos
            // 
            this.pictureBoxTextos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTextos.Image = global::Bomberos.Properties.Resources.textos;
            this.pictureBoxTextos.Location = new System.Drawing.Point(3, 336);
            this.pictureBoxTextos.Name = "pictureBoxTextos";
            this.pictureBoxTextos.Size = new System.Drawing.Size(304, 216);
            this.pictureBoxTextos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTextos.TabIndex = 1;
            this.pictureBoxTextos.TabStop = false;
            // 
            // PanelTopRojo
            // 
            this.PanelTopRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelTopRojo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTopRojo.Location = new System.Drawing.Point(0, 0);
            this.PanelTopRojo.Name = "PanelTopRojo";
            this.PanelTopRojo.Size = new System.Drawing.Size(310, 8);
            this.PanelTopRojo.TabIndex = 1;
            // 
            // PanelBotRojo
            // 
            this.PanelBotRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.PanelBotRojo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PanelBotRojo.Location = new System.Drawing.Point(0, 563);
            this.PanelBotRojo.Name = "PanelBotRojo";
            this.PanelBotRojo.Size = new System.Drawing.Size(310, 8);
            this.PanelBotRojo.TabIndex = 0;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1264, 571);
            this.Controls.Add(this.PanelIzquierdo);
            this.Controls.Add(this.btnSalida);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.btnAreas);
            this.Controls.Add(this.btnSemana);
            this.Controls.Add(this.btnAdministracion);
            this.Controls.Add(this.btnReuniones);
            this.Controls.Add(this.pnlFecha);
            this.ForeColor = System.Drawing.Color.White;
            this.MinimumSize = new System.Drawing.Size(1280, 610);
            this.Name = "formPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOMBEROS VOLUNTARIOS S.V.";
            this.Load += new System.EventHandler(this.formPrincipal_Load);
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            this.PanelIzquierdo.ResumeLayout(false);
            this.tableLayoutLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEscudo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTextos)).EndInit();
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
        private System.Windows.Forms.Panel PanelIzquierdo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutLogo;
        private System.Windows.Forms.PictureBox pictureBoxEscudo;
        private System.Windows.Forms.PictureBox pictureBoxTextos;
        private System.Windows.Forms.Panel PanelTopRojo;
        private System.Windows.Forms.Panel PanelBotRojo;
    }
}
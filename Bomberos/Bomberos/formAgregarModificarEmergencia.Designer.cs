
namespace Bomberos
{
    partial class formAgregarModificarEmergencia
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
            this.btnAsignarBombero = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDetalles = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAsisten = new System.Windows.Forms.Label();
            this.dtpFinalizacion = new System.Windows.Forms.DateTimePicker();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dgvBomberos = new System.Windows.Forms.DataGridView();
            this.pnlSubtitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomberos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAsignarBombero
            // 
            this.btnAsignarBombero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAsignarBombero.FlatAppearance.BorderSize = 0;
            this.btnAsignarBombero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarBombero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarBombero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnAsignarBombero.Location = new System.Drawing.Point(229, 230);
            this.btnAsignarBombero.Name = "btnAsignarBombero";
            this.btnAsignarBombero.Size = new System.Drawing.Size(129, 44);
            this.btnAsignarBombero.TabIndex = 3;
            this.btnAsignarBombero.Text = "+ ASIGNAR";
            this.btnAsignarBombero.UseVisualStyleBackColor = false;
            this.btnAsignarBombero.Click += new System.EventHandler(this.btnAsignarBombero_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCodigo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.ForeColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(18, 248);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 29);
            this.txtCodigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label3.Location = new System.Drawing.Point(14, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "CODIGO DE BOMBERO";
            // 
            // txtDetalles
            // 
            this.txtDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDetalles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalles.ForeColor = System.Drawing.Color.White;
            this.txtDetalles.Location = new System.Drawing.Point(18, 137);
            this.txtDetalles.Multiline = true;
            this.txtDetalles.Name = "txtDetalles";
            this.txtDetalles.Size = new System.Drawing.Size(340, 69);
            this.txtDetalles.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label1.Location = new System.Drawing.Point(14, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "DETALLES DE LA EMERGENCIA";
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(378, 39);
            this.pnlSubtitulo.TabIndex = 17;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.lblTitulo.Location = new System.Drawing.Point(59, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(257, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVA EMERGENCIA";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(18, 501);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(340, 58);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "GUARDAR EMERGENCIA";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblAsisten
            // 
            this.lblAsisten.AutoSize = true;
            this.lblAsisten.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsisten.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.lblAsisten.Location = new System.Drawing.Point(14, 290);
            this.lblAsisten.Name = "lblAsisten";
            this.lblAsisten.Size = new System.Drawing.Size(192, 21);
            this.lblAsisten.TabIndex = 13;
            this.lblAsisten.Text = "BOMBEROS QUE ASISTEN";
            // 
            // dtpFinalizacion
            // 
            this.dtpFinalizacion.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFinalizacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.dtpFinalizacion.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpFinalizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpFinalizacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinalizacion.Location = new System.Drawing.Point(192, 73);
            this.dtpFinalizacion.Name = "dtpFinalizacion";
            this.dtpFinalizacion.Size = new System.Drawing.Size(167, 26);
            this.dtpFinalizacion.TabIndex = 41;
            this.dtpFinalizacion.Value = new System.DateTime(2024, 10, 1, 16, 6, 0, 0);
            // 
            // dtpInicio
            // 
            this.dtpInicio.CalendarForeColor = System.Drawing.Color.White;
            this.dtpInicio.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm";
            this.dtpInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicio.Location = new System.Drawing.Point(18, 73);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(155, 26);
            this.dtpInicio.TabIndex = 40;
            this.dtpInicio.Value = new System.DateTime(2024, 10, 1, 16, 6, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label2.Location = new System.Drawing.Point(188, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 38;
            this.label2.Text = "FINALIZACION";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(168)))), ((int)(((byte)(168)))));
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 21);
            this.label6.TabIndex = 38;
            this.label6.Text = "INICIO";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dgvBomberos
            // 
            this.dgvBomberos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(63)))));
            this.dgvBomberos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBomberos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBomberos.Location = new System.Drawing.Point(18, 313);
            this.dgvBomberos.Name = "dgvBomberos";
            this.dgvBomberos.Size = new System.Drawing.Size(340, 177);
            this.dgvBomberos.TabIndex = 4;
            this.dgvBomberos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBomberos_CellClick);
            // 
            // formAgregarModificarEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(43)))), ((int)(((byte)(46)))));
            this.ClientSize = new System.Drawing.Size(378, 571);
            this.Controls.Add(this.dtpFinalizacion);
            this.Controls.Add(this.dtpInicio);
            this.Controls.Add(this.dgvBomberos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlSubtitulo);
            this.Controls.Add(this.txtDetalles);
            this.Controls.Add(this.btnAsignarBombero);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAsisten);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "formAgregarModificarEmergencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5";
            this.Load += new System.EventHandler(this.formAgregarModificarEmergencia_Load);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBomberos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAsignarBombero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDetalles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAsisten;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFinalizacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dgvBomberos;
    }
}
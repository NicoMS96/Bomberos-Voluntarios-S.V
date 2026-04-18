
namespace Bomberos
{
    partial class formAgregarModificarReunion
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
            this.txtTema = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAsignarBombero = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblAsisten = new System.Windows.Forms.Label();
            this.lstAsisten = new System.Windows.Forms.ListBox();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSubtitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTema
            // 
            this.txtTema.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTema.Location = new System.Drawing.Point(10, 137);
            this.txtTema.Multiline = true;
            this.txtTema.Name = "txtTema";
            this.txtTema.Size = new System.Drawing.Size(341, 75);
            this.txtTema.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(7, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "TEMA DE REUNION";
            // 
            // btnAsignarBombero
            // 
            this.btnAsignarBombero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAsignarBombero.FlatAppearance.BorderSize = 0;
            this.btnAsignarBombero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsignarBombero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarBombero.Location = new System.Drawing.Point(223, 218);
            this.btnAsignarBombero.Name = "btnAsignarBombero";
            this.btnAsignarBombero.Size = new System.Drawing.Size(129, 58);
            this.btnAsignarBombero.TabIndex = 27;
            this.btnAsignarBombero.Text = "ASIGNAR BOMBERO";
            this.btnAsignarBombero.UseVisualStyleBackColor = false;
            this.btnAsignarBombero.Click += new System.EventHandler(this.btnAsignarBombero_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCodigo.Location = new System.Drawing.Point(10, 250);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 26);
            this.txtCodigo.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(8, 221);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "CODIGO DE BOMBERO";
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(363, 39);
            this.pnlSubtitulo.TabIndex = 28;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(94, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(180, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVA REUNION";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(10, 433);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(341, 58);
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "GUARDAR REUNION";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblAsisten
            // 
            this.lblAsisten.AutoSize = true;
            this.lblAsisten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblAsisten.Location = new System.Drawing.Point(7, 284);
            this.lblAsisten.Name = "lblAsisten";
            this.lblAsisten.Size = new System.Drawing.Size(233, 20);
            this.lblAsisten.TabIndex = 30;
            this.lblAsisten.Text = "BOMBEROS QUE ASISTEN: ";
            // 
            // lstAsisten
            // 
            this.lstAsisten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lstAsisten.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstAsisten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lstAsisten.ForeColor = System.Drawing.Color.White;
            this.lstAsisten.FormattingEnabled = true;
            this.lstAsisten.ItemHeight = 20;
            this.lstAsisten.Location = new System.Drawing.Point(10, 307);
            this.lstAsisten.Name = "lstAsisten";
            this.lstAsisten.Size = new System.Drawing.Size(341, 120);
            this.lstAsisten.TabIndex = 31;
            this.lstAsisten.SelectedIndexChanged += new System.EventHandler(this.lstAsisten_SelectedIndexChanged);
            // 
            // dtpHora
            // 
            this.dtpHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(176, 69);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.Size = new System.Drawing.Size(176, 26);
            this.dtpHora.TabIndex = 35;
            this.dtpHora.Value = new System.DateTime(2024, 12, 11, 0, 0, 0, 0);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(12, 69);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(146, 26);
            this.dtpFecha.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(172, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "HORA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(8, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 34;
            this.label2.Text = "FECHA";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formAgregarModificarReunion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(363, 503);
            this.Controls.Add(this.dtpHora);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstAsisten);
            this.Controls.Add(this.lblAsisten);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.pnlSubtitulo);
            this.Controls.Add(this.btnAsignarBombero);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTema);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formAgregarModificarReunion";
            this.Load += new System.EventHandler(this.formAgregarModificarReunion_Load);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTema;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAsignarBombero;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblAsisten;
        private System.Windows.Forms.ListBox lstAsisten;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
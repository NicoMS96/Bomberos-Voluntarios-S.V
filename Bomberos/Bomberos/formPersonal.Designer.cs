
namespace Bomberos
{
    partial class formPersonal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvPersonal = new System.Windows.Forms.DataGridView();
            this.btnNuevoBombero = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.rdbInactivos = new System.Windows.Forms.RadioButton();
            this.rdbActivo = new System.Windows.Forms.RadioButton();
            this.pnlSubtitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(1011, 39);
            this.pnlSubtitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(457, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(120, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PERSONAL";
            // 
            // dgvPersonal
            // 
            this.dgvPersonal.AllowUserToAddRows = false;
            this.dgvPersonal.AllowUserToDeleteRows = false;
            this.dgvPersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonal.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dgvPersonal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPersonal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPersonal.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonal.EnableHeadersVisualStyles = false;
            this.dgvPersonal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvPersonal.Location = new System.Drawing.Point(6, 74);
            this.dgvPersonal.MultiSelect = false;
            this.dgvPersonal.Name = "dgvPersonal";
            this.dgvPersonal.ReadOnly = true;
            this.dgvPersonal.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dgvPersonal.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersonal.Size = new System.Drawing.Size(999, 372);
            this.dgvPersonal.TabIndex = 16;
            // 
            // btnNuevoBombero
            // 
            this.btnNuevoBombero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevoBombero.FlatAppearance.BorderSize = 0;
            this.btnNuevoBombero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoBombero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoBombero.Location = new System.Drawing.Point(837, 452);
            this.btnNuevoBombero.Name = "btnNuevoBombero";
            this.btnNuevoBombero.Size = new System.Drawing.Size(168, 71);
            this.btnNuevoBombero.TabIndex = 18;
            this.btnNuevoBombero.Text = "NUEVO BOMBERO";
            this.btnNuevoBombero.UseVisualStyleBackColor = false;
            this.btnNuevoBombero.Click += new System.EventHandler(this.btnNuevoBombero_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(180, 452);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(168, 71);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(6, 452);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(168, 71);
            this.btnModificar.TabIndex = 18;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // rdbInactivos
            // 
            this.rdbInactivos.AutoSize = true;
            this.rdbInactivos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbInactivos.Location = new System.Drawing.Point(903, 45);
            this.rdbInactivos.Name = "rdbInactivos";
            this.rdbInactivos.Size = new System.Drawing.Size(98, 21);
            this.rdbInactivos.TabIndex = 19;
            this.rdbInactivos.TabStop = true;
            this.rdbInactivos.Text = "INACTIVOS";
            this.rdbInactivos.UseVisualStyleBackColor = true;
            this.rdbInactivos.CheckedChanged += new System.EventHandler(this.rdbAsistInstitucion_CheckedChanged);
            // 
            // rdbActivo
            // 
            this.rdbActivo.AutoSize = true;
            this.rdbActivo.Checked = true;
            this.rdbActivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbActivo.Location = new System.Drawing.Point(814, 45);
            this.rdbActivo.Name = "rdbActivo";
            this.rdbActivo.Size = new System.Drawing.Size(85, 21);
            this.rdbActivo.TabIndex = 20;
            this.rdbActivo.TabStop = true;
            this.rdbActivo.Text = "ACTIVOS";
            this.rdbActivo.UseVisualStyleBackColor = true;
            this.rdbActivo.CheckedChanged += new System.EventHandler(this.rdbAsistArea_CheckedChanged);
            // 
            // formPersonal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1011, 532);
            this.Controls.Add(this.rdbInactivos);
            this.Controls.Add(this.rdbActivo);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNuevoBombero);
            this.Controls.Add(this.dgvPersonal);
            this.Controls.Add(this.pnlSubtitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPersonal";
            this.Text = "formPersonal";
            this.Activated += new System.EventHandler(this.formPersonal_Activated);
            this.Load += new System.EventHandler(this.formPersonal_Load);
            this.Enter += new System.EventHandler(this.formPersonal_Enter);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvPersonal;
        private System.Windows.Forms.Button btnNuevoBombero;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.RadioButton rdbInactivos;
        private System.Windows.Forms.RadioButton rdbActivo;
    }
}
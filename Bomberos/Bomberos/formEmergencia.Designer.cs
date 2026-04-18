
namespace Bomberos
{
    partial class formEmergencia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvEmergencias = new System.Windows.Forms.DataGridView();
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnNuevaEmergencia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencias)).BeginInit();
            this.pnlSubtitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvEmergencias
            // 
            this.dgvEmergencias.AllowUserToAddRows = false;
            this.dgvEmergencias.AllowUserToDeleteRows = false;
            this.dgvEmergencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmergencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dgvEmergencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvEmergencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEmergencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEmergencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEmergencias.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvEmergencias.EnableHeadersVisualStyles = false;
            this.dgvEmergencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvEmergencias.Location = new System.Drawing.Point(12, 59);
            this.dgvEmergencias.MultiSelect = false;
            this.dgvEmergencias.Name = "dgvEmergencias";
            this.dgvEmergencias.ReadOnly = true;
            this.dgvEmergencias.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.dgvEmergencias.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEmergencias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEmergencias.Size = new System.Drawing.Size(1240, 423);
            this.dgvEmergencias.TabIndex = 15;
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(1264, 39);
            this.pnlSubtitulo.TabIndex = 16;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(566, 8);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(146, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "EMERGENCIA";
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnVolver.FlatAppearance.BorderSize = 0;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(1084, 488);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(168, 71);
            this.btnVolver.TabIndex = 17;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnNuevaEmergencia
            // 
            this.btnNuevaEmergencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnNuevaEmergencia.FlatAppearance.BorderSize = 0;
            this.btnNuevaEmergencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevaEmergencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevaEmergencia.Location = new System.Drawing.Point(910, 488);
            this.btnNuevaEmergencia.Name = "btnNuevaEmergencia";
            this.btnNuevaEmergencia.Size = new System.Drawing.Size(168, 71);
            this.btnNuevaEmergencia.TabIndex = 17;
            this.btnNuevaEmergencia.Text = "NUEVA EMERGENCIA";
            this.btnNuevaEmergencia.UseVisualStyleBackColor = false;
            this.btnNuevaEmergencia.Click += new System.EventHandler(this.btnNuevaEmergencia_Click);
            // 
            // formEmergencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1264, 571);
            this.Controls.Add(this.btnNuevaEmergencia);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pnlSubtitulo);
            this.Controls.Add(this.dgvEmergencias);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formEmergencia";
            this.Text = "formEmergencia";
            this.Load += new System.EventHandler(this.formEmergencia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmergencias)).EndInit();
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEmergencias;
        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnNuevaEmergencia;
    }
}
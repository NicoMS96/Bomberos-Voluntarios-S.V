
namespace Bomberos
{
    partial class formAsistencias
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
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAsistencias = new System.Windows.Forms.DataGridView();
            this.rdbAsistInstitucion = new System.Windows.Forms.RadioButton();
            this.rdbAsistArea = new System.Windows.Forms.RadioButton();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSubtitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).BeginInit();
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
            this.lblTitulo.Location = new System.Drawing.Point(402, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(184, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ADMINISTRACION";
            // 
            // dgvAsistencias
            // 
            this.dgvAsistencias.AllowUserToDeleteRows = false;
            this.dgvAsistencias.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvAsistencias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAsistencias.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.dgvAsistencias.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAsistencias.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAsistencias.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAsistencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsistencias.EnableHeadersVisualStyles = false;
            this.dgvAsistencias.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dgvAsistencias.Location = new System.Drawing.Point(6, 84);
            this.dgvAsistencias.MultiSelect = false;
            this.dgvAsistencias.Name = "dgvAsistencias";
            this.dgvAsistencias.RowHeadersVisible = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.dgvAsistencias.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAsistencias.Size = new System.Drawing.Size(999, 474);
            this.dgvAsistencias.TabIndex = 15;
            // 
            // rdbAsistInstitucion
            // 
            this.rdbAsistInstitucion.AutoSize = true;
            this.rdbAsistInstitucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbAsistInstitucion.Location = new System.Drawing.Point(805, 55);
            this.rdbAsistInstitucion.Name = "rdbAsistInstitucion";
            this.rdbAsistInstitucion.Size = new System.Drawing.Size(208, 21);
            this.rdbAsistInstitucion.TabIndex = 16;
            this.rdbAsistInstitucion.TabStop = true;
            this.rdbAsistInstitucion.Text = "ASISTENCIA A INSTITUCION";
            this.rdbAsistInstitucion.UseVisualStyleBackColor = true;
            // 
            // rdbAsistArea
            // 
            this.rdbAsistArea.AutoSize = true;
            this.rdbAsistArea.Checked = true;
            this.rdbAsistArea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.rdbAsistArea.Location = new System.Drawing.Point(639, 55);
            this.rdbAsistArea.Name = "rdbAsistArea";
            this.rdbAsistArea.Size = new System.Drawing.Size(159, 21);
            this.rdbAsistArea.TabIndex = 17;
            this.rdbAsistArea.TabStop = true;
            this.rdbAsistArea.Text = "ASISTENCIA A AREA";
            this.rdbAsistArea.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBox3.Location = new System.Drawing.Point(101, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(160, 26);
            this.textBox3.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(12, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "NOMBRE";
            // 
            // formAsistencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1011, 570);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rdbAsistInstitucion);
            this.Controls.Add(this.rdbAsistArea);
            this.Controls.Add(this.dgvAsistencias);
            this.Controls.Add(this.pnlSubtitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formAsistencias";
            this.Text = "formAsistencias";
            this.Load += new System.EventHandler(this.formAsistencias_Load);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsistencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvAsistencias;
        private System.Windows.Forms.RadioButton rdbAsistInstitucion;
        private System.Windows.Forms.RadioButton rdbAsistArea;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
    }
}
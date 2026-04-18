
namespace Bomberos
{
    partial class formAgregarModificarTarea
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTareasPredeterminadas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlSubtitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 357);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(412, 58);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "GUARDAR TAREA";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtTarea
            // 
            this.txtTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtTarea.Location = new System.Drawing.Point(12, 140);
            this.txtTarea.Multiline = true;
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(412, 196);
            this.txtTarea.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(9, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "TAREA";
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(436, 39);
            this.pnlSubtitulo.TabIndex = 22;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(41, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "NUEVA TAREA EN AUTOMOTORES";
            // 
            // cmbTareasPredeterminadas
            // 
            this.cmbTareasPredeterminadas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTareasPredeterminadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbTareasPredeterminadas.FormattingEnabled = true;
            this.cmbTareasPredeterminadas.Location = new System.Drawing.Point(12, 75);
            this.cmbTareasPredeterminadas.Name = "cmbTareasPredeterminadas";
            this.cmbTareasPredeterminadas.Size = new System.Drawing.Size(412, 28);
            this.cmbTareasPredeterminadas.TabIndex = 32;
            this.cmbTareasPredeterminadas.SelectedIndexChanged += new System.EventHandler(this.cmbTareasPredeterminadas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(9, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "TAREAS PREDETERMINADAS";
            // 
            // formAgregarModificarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(436, 427);
            this.Controls.Add(this.cmbTareasPredeterminadas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTarea);
            this.Controls.Add(this.pnlSubtitulo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formAgregarModificarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formAgregarModificarTarea_Load);
            this.Resize += new System.EventHandler(this.formAgregarModificarTarea_Resize);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTareasPredeterminadas;
        private System.Windows.Forms.Label label4;
    }
}
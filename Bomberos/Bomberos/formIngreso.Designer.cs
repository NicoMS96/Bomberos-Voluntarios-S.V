
namespace Bomberos
{
    partial class formIngreso
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
            this.pnlSubtitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblIngreso = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlSubtitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSubtitulo
            // 
            this.pnlSubtitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlSubtitulo.Controls.Add(this.lblTitulo);
            this.pnlSubtitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubtitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlSubtitulo.Name = "pnlSubtitulo";
            this.pnlSubtitulo.Size = new System.Drawing.Size(248, 39);
            this.pnlSubtitulo.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(80, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(81, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "SALIDA";
            // 
            // lblIngreso
            // 
            this.lblIngreso.AutoSize = true;
            this.lblIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblIngreso.Location = new System.Drawing.Point(22, 60);
            this.lblIngreso.Name = "lblIngreso";
            this.lblIngreso.Size = new System.Drawing.Size(198, 20);
            this.lblIngreso.TabIndex = 9;
            this.lblIngreso.Text = "CODIGO DE BOMBERO";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCodigo.Location = new System.Drawing.Point(26, 92);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(194, 26);
            this.txtCodigo.TabIndex = 10;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(58, 133);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(129, 49);
            this.btnIngresar.TabIndex = 12;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formIngreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(248, 204);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblIngreso);
            this.Controls.Add(this.pnlSubtitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "formIngreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "INGRESO";
            this.Load += new System.EventHandler(this.formIngreso_Load);
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblIngreso;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
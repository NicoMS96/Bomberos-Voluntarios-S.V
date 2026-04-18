
namespace Bomberos
{
    partial class formLogin
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
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblVerificar = new System.Windows.Forms.Label();
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
            this.pnlSubtitulo.Size = new System.Drawing.Size(347, 39);
            this.pnlSubtitulo.TabIndex = 30;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(314, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "INGRESAR A ADMINISTRACION";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtCodigo.Location = new System.Drawing.Point(11, 80);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(324, 26);
            this.txtCodigo.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(9, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "CODIGO DE BOMBERO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(9, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "CONTRASEÑA";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txtContrasena.Location = new System.Drawing.Point(11, 146);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(324, 26);
            this.txtContrasena.TabIndex = 32;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.Location = new System.Drawing.Point(54, 219);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(235, 58);
            this.btnIngresar.TabIndex = 33;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lblVerificar.Location = new System.Drawing.Point(7, 185);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(0, 20);
            this.lblVerificar.TabIndex = 31;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // formLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(347, 289);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.lblVerificar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlSubtitulo);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(363, 328);
            this.MinimumSize = new System.Drawing.Size(363, 328);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlSubtitulo.ResumeLayout(false);
            this.pnlSubtitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlSubtitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblVerificar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
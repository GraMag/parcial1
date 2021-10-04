
namespace Formularios
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxUsuario = new System.Windows.Forms.TextBox();
            this.txtBxPassword = new System.Windows.Forms.TextBox();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblInvitado = new System.Windows.Forms.Label();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnEmpLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBxUsuario
            // 
            this.txtBxUsuario.Location = new System.Drawing.Point(65, 32);
            this.txtBxUsuario.Name = "txtBxUsuario";
            this.txtBxUsuario.PlaceholderText = "Ingresar usuario";
            this.txtBxUsuario.Size = new System.Drawing.Size(285, 27);
            this.txtBxUsuario.TabIndex = 0;
            // 
            // txtBxPassword
            // 
            this.txtBxPassword.Location = new System.Drawing.Point(65, 79);
            this.txtBxPassword.Name = "txtBxPassword";
            this.txtBxPassword.PasswordChar = '*';
            this.txtBxPassword.PlaceholderText = "Ingresar contraseña";
            this.txtBxPassword.Size = new System.Drawing.Size(285, 27);
            this.txtBxPassword.TabIndex = 1;
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(132, 120);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(169, 47);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblInvitado
            // 
            this.lblInvitado.AutoSize = true;
            this.lblInvitado.Font = new System.Drawing.Font("Segoe UI", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblInvitado.Location = new System.Drawing.Point(12, 186);
            this.lblInvitado.Name = "lblInvitado";
            this.lblInvitado.Size = new System.Drawing.Size(107, 12);
            this.lblInvitado.TabIndex = 3;
            this.lblInvitado.Text = "Ingresar como invitado";
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Location = new System.Drawing.Point(364, 158);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(32, 28);
            this.btnAdminLogin.TabIndex = 4;
            this.btnAdminLogin.Text = "A";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // btnEmpLogin
            // 
            this.btnEmpLogin.Location = new System.Drawing.Point(364, 120);
            this.btnEmpLogin.Name = "btnEmpLogin";
            this.btnEmpLogin.Size = new System.Drawing.Size(32, 32);
            this.btnEmpLogin.TabIndex = 5;
            this.btnEmpLogin.Text = "E";
            this.btnEmpLogin.UseVisualStyleBackColor = true;
            this.btnEmpLogin.Click += new System.EventHandler(this.btnEmpLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(414, 207);
            this.ControlBox = false;
            this.Controls.Add(this.btnEmpLogin);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.lblInvitado);
            this.Controls.Add(this.btnEntrar);
            this.Controls.Add(this.txtBxPassword);
            this.Controls.Add(this.txtBxUsuario);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxUsuario;
        private System.Windows.Forms.TextBox txtBxPassword;
        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblInvitado;
        private System.Windows.Forms.Button btnEmpLogin;
        private System.Windows.Forms.Button btnAdminLogin;
    }
}


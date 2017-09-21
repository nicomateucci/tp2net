namespace UI.Desktop
{
    partial class Login
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
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.Label();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(102, 426);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(86, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            this.btnIngresar.DragEnter += new System.Windows.Forms.DragEventHandler(this.btnIngresar_DragEnter);
            // 
            // txtUsuario
            // 
            this.txtUsuario.AutoSize = true;
            this.txtUsuario.Location = new System.Drawing.Point(99, 283);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(99, 13);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Nombre de usuario:";
            this.txtUsuario.Click += new System.EventHandler(this.Luser_Click);
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Location = new System.Drawing.Point(99, 354);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(61, 13);
            this.lblPwd.TabIndex = 2;
            this.lblPwd.Text = "Contraseña";
            this.lblPwd.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblUsuario.Location = new System.Drawing.Point(102, 311);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(172, 20);
            this.lblUsuario.TabIndex = 3;
            // 
            // txtPwd
            // 
            this.txtPwd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtPwd.Location = new System.Drawing.Point(102, 380);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(172, 20);
            this.txtPwd.TabIndex = 4;
            this.txtPwd.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBienvenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenido.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBienvenido.Location = new System.Drawing.Point(99, 231);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(133, 24);
            this.lblBienvenido.TabIndex = 5;
            this.lblBienvenido.Text = "Iniciar sesion";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblError.Location = new System.Drawing.Point(102, 469);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(161, 13);
            this.lblError.TabIndex = 6;
            this.lblError.Text = "Usuario o contraseña incorrecta.";
            this.lblError.Visible = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 741);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblBienvenido);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.lblPwd);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Name = "Login";
            this.Text = "Login";
            this.Enter += new System.EventHandler(this.Login_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Login_KeyDown);
            this.Controls.SetChildIndex(this.btnIngresar, 0);
            this.Controls.SetChildIndex(this.txtUsuario, 0);
            this.Controls.SetChildIndex(this.lblPwd, 0);
            this.Controls.SetChildIndex(this.lblUsuario, 0);
            this.Controls.SetChildIndex(this.txtPwd, 0);
            this.Controls.SetChildIndex(this.lblBienvenido, 0);
            this.Controls.SetChildIndex(this.lblError, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label txtUsuario;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox lblUsuario;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.Label lblError;
    }
}
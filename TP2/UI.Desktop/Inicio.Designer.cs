namespace UI.Desktop
{
    partial class Inicio
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblBienbenidaUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBienvenida.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(76, 112);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(232, 24);
            this.lblBienvenida.TabIndex = 2;
            this.lblBienvenida.Text = "Bienvenido a SysBox:";
            // 
            // lblBienbenidaUsuario
            // 
            this.lblBienbenidaUsuario.AutoSize = true;
            this.lblBienbenidaUsuario.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblBienbenidaUsuario.Font = new System.Drawing.Font("Arial", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienbenidaUsuario.Location = new System.Drawing.Point(302, 112);
            this.lblBienbenidaUsuario.Name = "lblBienbenidaUsuario";
            this.lblBienbenidaUsuario.Size = new System.Drawing.Size(73, 24);
            this.lblBienbenidaUsuario.TabIndex = 3;
            this.lblBienbenidaUsuario.Text = "---------";
            this.lblBienbenidaUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 696);
            this.Controls.Add(this.lblBienbenidaUsuario);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.Controls.SetChildIndex(this.lblBienvenida, 0);
            this.Controls.SetChildIndex(this.lblBienbenidaUsuario, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblBienbenidaUsuario;
    }
}
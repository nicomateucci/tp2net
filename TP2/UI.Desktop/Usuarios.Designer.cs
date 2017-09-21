namespace UI.Desktop
{
    partial class Usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.tableLayoutUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStripUsuarios = new System.Windows.Forms.ToolStrip();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tableLayoutUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).BeginInit();
            this.toolStripUsuarios.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tableLayoutUsuarios);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1024, 472);
            this.toolStripContainer1.ContentPanel.Load += new System.EventHandler(this.toolStripContainer1_ContentPanel_Load);
            this.toolStripContainer1.Location = new System.Drawing.Point(-2, 98);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1024, 500);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStripUsuarios);
            // 
            // tableLayoutUsuarios
            // 
            this.tableLayoutUsuarios.ColumnCount = 2;
            this.tableLayoutUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutUsuarios.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutUsuarios.Controls.Add(this.dataGridViewUsuarios, 0, 0);
            this.tableLayoutUsuarios.Controls.Add(this.btnActualizar, 0, 1);
            this.tableLayoutUsuarios.Controls.Add(this.btnSalir, 1, 1);
            this.tableLayoutUsuarios.Location = new System.Drawing.Point(0, 3);
            this.tableLayoutUsuarios.Name = "tableLayoutUsuarios";
            this.tableLayoutUsuarios.RowCount = 2;
            this.tableLayoutUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutUsuarios.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutUsuarios.Size = new System.Drawing.Size(1024, 469);
            this.tableLayoutUsuarios.TabIndex = 0;
            // 
            // dataGridViewUsuarios
            // 
            this.dataGridViewUsuarios.AllowUserToAddRows = false;
            this.dataGridViewUsuarios.AllowUserToDeleteRows = false;
            this.dataGridViewUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutUsuarios.SetColumnSpan(this.dataGridViewUsuarios, 2);
            this.dataGridViewUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewUsuarios.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsuarios.Name = "dataGridViewUsuarios";
            this.dataGridViewUsuarios.ReadOnly = true;
            this.dataGridViewUsuarios.Size = new System.Drawing.Size(1018, 434);
            this.dataGridViewUsuarios.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnActualizar.Location = new System.Drawing.Point(865, 443);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(946, 443);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // toolStripUsuarios
            // 
            this.toolStripUsuarios.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripUsuarios.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton2,
            this.tsbtnEditar,
            this.tsbtnSalir});
            this.toolStripUsuarios.Location = new System.Drawing.Point(3, 0);
            this.toolStripUsuarios.Name = "toolStripUsuarios";
            this.toolStripUsuarios.Size = new System.Drawing.Size(162, 28);
            this.toolStripUsuarios.TabIndex = 0;
            this.toolStripUsuarios.Text = "toolStrip1";
            // 
            // tsbtnSalir
            // 
            this.tsbtnSalir.AutoSize = false;
            this.tsbtnSalir.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tsbtnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnSalir.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbtnSalir.ForeColor = System.Drawing.Color.White;
            this.tsbtnSalir.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnSalir.Image")));
            this.tsbtnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnSalir.Name = "tsbtnSalir";
            this.tsbtnSalir.Size = new System.Drawing.Size(50, 25);
            this.tsbtnSalir.Text = "Salir";
            this.tsbtnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // tsbtnEditar
            // 
            this.tsbtnEditar.AutoSize = false;
            this.tsbtnEditar.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tsbtnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbtnEditar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.tsbtnEditar.ForeColor = System.Drawing.Color.White;
            this.tsbtnEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEditar.Image")));
            this.tsbtnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnEditar.Name = "tsbtnEditar";
            this.tsbtnEditar.Size = new System.Drawing.Size(50, 25);
            this.tsbtnEditar.Text = "Editar";
            this.tsbtnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.toolStripButton2.ForeColor = System.Drawing.Color.White;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(50, 25);
            this.toolStripButton2.Text = "Nuevo";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 696);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            this.Controls.SetChildIndex(this.toolStripContainer1, 0);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tableLayoutUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.toolStripUsuarios.ResumeLayout(false);
            this.toolStripUsuarios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStrip toolStripUsuarios;
        private System.Windows.Forms.TableLayoutPanel tableLayoutUsuarios;
        private System.Windows.Forms.DataGridView dataGridViewUsuarios;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ToolStripButton tsbtnSalir;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton tsbtnEditar;
    }
}
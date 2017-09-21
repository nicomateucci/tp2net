namespace UI.Desktop
{
    partial class ApplicationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.toolStripContainer2 = new System.Windows.Forms.ToolStripContainer();
            this.tstripBase = new System.Windows.Forms.ToolStripContainer();
            this.menuStripBase = new System.Windows.Forms.MenuStrip();
            this.btnMenuStrip1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.detallesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.toolStripContainer2.SuspendLayout();
            this.tstripBase.TopToolStripPanel.SuspendLayout();
            this.tstripBase.SuspendLayout();
            this.menuStripBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1016, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 597);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1016, 96);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tstripBase, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1022, 696);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1022, 671);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1022, 696);
            this.toolStripContainer1.TabIndex = 2;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer2
            // 
            // 
            // toolStripContainer2.ContentPanel
            // 
            this.toolStripContainer2.ContentPanel.Size = new System.Drawing.Size(1022, 671);
            this.toolStripContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer2.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer2.Name = "toolStripContainer2";
            this.toolStripContainer2.Size = new System.Drawing.Size(1022, 696);
            this.toolStripContainer2.TabIndex = 2;
            this.toolStripContainer2.Text = "toolStripContainer2";
            // 
            // tstripBase
            // 
            // 
            // tstripBase.ContentPanel
            // 
            this.tstripBase.ContentPanel.Size = new System.Drawing.Size(1016, 456);
            this.tstripBase.ContentPanel.Load += new System.EventHandler(this.toolStripContainer3_ContentPanel_Load);
            this.tstripBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tstripBase.Location = new System.Drawing.Point(3, 103);
            this.tstripBase.Name = "tstripBase";
            this.tstripBase.Size = new System.Drawing.Size(1016, 488);
            this.tstripBase.TabIndex = 2;
            this.tstripBase.Text = "toolStripContainer3";
            // 
            // tstripBase.TopToolStripPanel
            // 
            this.tstripBase.TopToolStripPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.tstripBase.TopToolStripPanel.Controls.Add(this.menuStripBase);
            // 
            // menuStripBase
            // 
            this.menuStripBase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStripBase.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStripBase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnMenuStrip1});
            this.menuStripBase.Location = new System.Drawing.Point(0, 0);
            this.menuStripBase.Name = "menuStripBase";
            this.menuStripBase.ShowItemToolTips = true;
            this.menuStripBase.Size = new System.Drawing.Size(1016, 32);
            this.menuStripBase.TabIndex = 0;
            this.menuStripBase.Text = "menuStrip1";
            this.menuStripBase.UseWaitCursor = true;
            this.menuStripBase.Visible = false;
            // 
            // btnMenuStrip1
            // 
            this.btnMenuStrip1.AutoSize = false;
            this.btnMenuStrip1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMenuStrip1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cuentaToolStripMenuItem,
            this.detallesToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.btnMenuStrip1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnMenuStrip1.Name = "btnMenuStrip1";
            this.btnMenuStrip1.Size = new System.Drawing.Size(120, 28);
            this.btnMenuStrip1.Text = "Usuario";
            this.btnMenuStrip1.Visible = false;
            // 
            // cuentaToolStripMenuItem
            // 
            this.cuentaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cuentaToolStripMenuItem.Name = "cuentaToolStripMenuItem";
            this.cuentaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cuentaToolStripMenuItem.Text = "Cuenta";
            // 
            // detallesToolStripMenuItem
            // 
            this.detallesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.detallesToolStripMenuItem.Name = "detallesToolStripMenuItem";
            this.detallesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.detallesToolStripMenuItem.Text = "Detalles";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // ApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1022, 696);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.toolStripContainer1);
            this.Controls.Add(this.toolStripContainer2);
            this.Name = "ApplicationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ApplicationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.toolStripContainer2.ResumeLayout(false);
            this.toolStripContainer2.PerformLayout();
            this.tstripBase.TopToolStripPanel.ResumeLayout(false);
            this.tstripBase.TopToolStripPanel.PerformLayout();
            this.tstripBase.ResumeLayout(false);
            this.tstripBase.PerformLayout();
            this.menuStripBase.ResumeLayout(false);
            this.menuStripBase.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer2;
        protected System.Windows.Forms.ToolStripContainer tstripBase;
        private System.Windows.Forms.ToolStripMenuItem cuentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detallesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        protected System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        protected internal System.Windows.Forms.MenuStrip menuStripBase;
        protected internal System.Windows.Forms.ToolStripMenuItem btnMenuStrip1;
    }
}
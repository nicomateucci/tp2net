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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.habilitadoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cambiaclaveDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.idpersonaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tp2_netDataSet = new UI.Desktop.tp2_netDataSet();
            this.tableLayoutUsuarios = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewUsuarios = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.toolStripUsuarios = new System.Windows.Forms.ToolStrip();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.tsbtnEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbtnSalir = new System.Windows.Forms.ToolStripButton();
            this.usuariosTableAdapter = new UI.Desktop.tp2_netDataSetTableAdapters.usuariosTableAdapter();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).BeginInit();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.dataGridView1);
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.claveDataGridViewTextBoxColumn,
            this.habilitadoDataGridViewCheckBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cambiaclaveDataGridViewCheckBoxColumn,
            this.idpersonaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1024, 472);
            this.dataGridView1.TabIndex = 1;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            // 
            // claveDataGridViewTextBoxColumn
            // 
            this.claveDataGridViewTextBoxColumn.DataPropertyName = "clave";
            this.claveDataGridViewTextBoxColumn.HeaderText = "clave";
            this.claveDataGridViewTextBoxColumn.Name = "claveDataGridViewTextBoxColumn";
            // 
            // habilitadoDataGridViewCheckBoxColumn
            // 
            this.habilitadoDataGridViewCheckBoxColumn.DataPropertyName = "habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.HeaderText = "habilitado";
            this.habilitadoDataGridViewCheckBoxColumn.Name = "habilitadoDataGridViewCheckBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidoDataGridViewTextBoxColumn
            // 
            this.apellidoDataGridViewTextBoxColumn.DataPropertyName = "apellido";
            this.apellidoDataGridViewTextBoxColumn.HeaderText = "apellido";
            this.apellidoDataGridViewTextBoxColumn.Name = "apellidoDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // cambiaclaveDataGridViewCheckBoxColumn
            // 
            this.cambiaclaveDataGridViewCheckBoxColumn.DataPropertyName = "cambia_clave";
            this.cambiaclaveDataGridViewCheckBoxColumn.HeaderText = "cambia_clave";
            this.cambiaclaveDataGridViewCheckBoxColumn.Name = "cambiaclaveDataGridViewCheckBoxColumn";
            // 
            // idpersonaDataGridViewTextBoxColumn
            // 
            this.idpersonaDataGridViewTextBoxColumn.DataPropertyName = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.HeaderText = "id_persona";
            this.idpersonaDataGridViewTextBoxColumn.Name = "idpersonaDataGridViewTextBoxColumn";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.tp2_netDataSet;
            // 
            // tp2_netDataSet
            // 
            this.tp2_netDataSet.DataSetName = "tp2_netDataSet";
            this.tp2_netDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.toolStripUsuarios.Size = new System.Drawing.Size(193, 28);
            this.toolStripUsuarios.TabIndex = 0;
            this.toolStripUsuarios.Text = "toolStrip1";
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
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.tsbtnSalir.Click += new System.EventHandler(this.tsbtnSalir_Click);
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tp2_netDataSet)).EndInit();
            this.tableLayoutUsuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsuarios)).EndInit();
            this.toolStripUsuarios.ResumeLayout(false);
            this.toolStripUsuarios.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private tp2_netDataSet tp2_netDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private tp2_netDataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn habilitadoDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cambiaclaveDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpersonaDataGridViewTextBoxColumn;
    }
}
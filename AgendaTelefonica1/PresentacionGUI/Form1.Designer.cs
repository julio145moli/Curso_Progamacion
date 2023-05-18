namespace PresentacionGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btMostrar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.texTelefono = new System.Windows.Forms.TextBox();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.Fecha = new System.Windows.Forms.Label();
            this.Telefono = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.listFamiliar = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbContcFamiliar = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbFiltro = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textFiltrar = new System.Windows.Forms.TextBox();
            this.btFiltrar = new System.Windows.Forms.Button();
            this.btCapturar = new System.Windows.Forms.Button();
            this.cbDispositivos = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btGrabar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lbContcFamiliar);
            this.groupBox1.Controls.Add(this.listFamiliar);
            this.groupBox1.Controls.Add(this.btGrabar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btMostrar);
            this.groupBox1.Controls.Add(this.cbDispositivos);
            this.groupBox1.Controls.Add(this.btSalir);
            this.groupBox1.Controls.Add(this.btCapturar);
            this.groupBox1.Controls.Add(this.btGuardar);
            this.groupBox1.Controls.Add(this.btNuevo);
            this.groupBox1.Controls.Add(this.dateTime);
            this.groupBox1.Controls.Add(this.texTelefono);
            this.groupBox1.Controls.Add(this.textNombre);
            this.groupBox1.Controls.Add(this.textId);
            this.groupBox1.Controls.Add(this.Fecha);
            this.groupBox1.Controls.Add(this.Telefono);
            this.groupBox1.Controls.Add(this.Id);
            this.groupBox1.Controls.Add(this.Nombre);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 530);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar";
            // 
            // btMostrar
            // 
            this.btMostrar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btMostrar.Location = new System.Drawing.Point(91, 209);
            this.btMostrar.Name = "btMostrar";
            this.btMostrar.Size = new System.Drawing.Size(129, 23);
            this.btMostrar.TabIndex = 11;
            this.btMostrar.Text = "MOSTRAR LISTA";
            this.btMostrar.UseVisualStyleBackColor = true;
            this.btMostrar.Click += new System.EventHandler(this.btMostrar_Click);
            // 
            // btSalir
            // 
            this.btSalir.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSalir.Location = new System.Drawing.Point(213, 169);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(97, 23);
            this.btSalir.TabIndex = 10;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(110, 169);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(97, 23);
            this.btGuardar.TabIndex = 9;
            this.btGuardar.Text = "GUARDAR";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(7, 169);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(97, 23);
            this.btNuevo.TabIndex = 8;
            this.btNuevo.Text = "NUEVO";
            this.btNuevo.UseVisualStyleBackColor = true;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTime.Location = new System.Drawing.Point(113, 106);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(148, 20);
            this.dateTime.TabIndex = 7;
            // 
            // texTelefono
            // 
            this.texTelefono.Location = new System.Drawing.Point(113, 83);
            this.texTelefono.Name = "texTelefono";
            this.texTelefono.Size = new System.Drawing.Size(148, 20);
            this.texTelefono.TabIndex = 6;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(113, 61);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(148, 20);
            this.textNombre.TabIndex = 5;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(113, 39);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(148, 20);
            this.textId.TabIndex = 4;
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(32, 111);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(47, 15);
            this.Fecha.TabIndex = 3;
            this.Fecha.Text = "FECHA";
            // 
            // Telefono
            // 
            this.Telefono.AutoSize = true;
            this.Telefono.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefono.Location = new System.Drawing.Point(32, 88);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(72, 15);
            this.Telefono.TabIndex = 2;
            this.Telefono.Text = "TELEFONO";
            // 
            // Id
            // 
            this.Id.AutoSize = true;
            this.Id.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id.Location = new System.Drawing.Point(32, 44);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(20, 15);
            this.Id.TabIndex = 1;
            this.Id.Text = "ID";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nombre.Location = new System.Drawing.Point(32, 66);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(60, 15);
            this.Nombre.TabIndex = 0;
            this.Nombre.Text = "NOMBRE";
            // 
            // listFamiliar
            // 
            this.listFamiliar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listFamiliar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listFamiliar.FormattingEnabled = true;
            this.listFamiliar.Location = new System.Drawing.Point(53, 308);
            this.listFamiliar.Name = "listFamiliar";
            this.listFamiliar.Size = new System.Drawing.Size(176, 186);
            this.listFamiliar.TabIndex = 1;
            this.listFamiliar.SelectedIndexChanged += new System.EventHandler(this.listFamiliar_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(10, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 204);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(6, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(702, 582);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(694, 556);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Informacion General";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbContcFamiliar
            // 
            this.lbContcFamiliar.AutoSize = true;
            this.lbContcFamiliar.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContcFamiliar.Location = new System.Drawing.Point(41, 290);
            this.lbContcFamiliar.Name = "lbContcFamiliar";
            this.lbContcFamiliar.Size = new System.Drawing.Size(179, 15);
            this.lbContcFamiliar.TabIndex = 3;
            this.lbContcFamiliar.Text = "LISTA CONTACTO FAMILIAR";
            this.lbContcFamiliar.Click += new System.EventHandler(this.lbContcFamiliar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbFiltro);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.textFiltrar);
            this.tabPage2.Controls.Add(this.btFiltrar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(694, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Listado General";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // lbFiltro
            // 
            this.lbFiltro.AutoSize = true;
            this.lbFiltro.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFiltro.Location = new System.Drawing.Point(515, 38);
            this.lbFiltro.Name = "lbFiltro";
            this.lbFiltro.Size = new System.Drawing.Size(52, 15);
            this.lbFiltro.TabIndex = 3;
            this.lbFiltro.Text = "FILTRO";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cId,
            this.cNombre,
            this.cTelefono,
            this.cFecha});
            this.dataGridView1.Location = new System.Drawing.Point(18, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(449, 547);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cId
            // 
            this.cId.HeaderText = "ID";
            this.cId.Name = "cId";
            this.cId.ReadOnly = true;
            // 
            // cNombre
            // 
            this.cNombre.HeaderText = "NOMBRE";
            this.cNombre.Name = "cNombre";
            this.cNombre.ReadOnly = true;
            // 
            // cTelefono
            // 
            this.cTelefono.HeaderText = "TELEFONO";
            this.cTelefono.Name = "cTelefono";
            this.cTelefono.ReadOnly = true;
            // 
            // cFecha
            // 
            this.cFecha.HeaderText = "FECHA";
            this.cFecha.Name = "cFecha";
            this.cFecha.ReadOnly = true;
            // 
            // textFiltrar
            // 
            this.textFiltrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFiltrar.Location = new System.Drawing.Point(518, 56);
            this.textFiltrar.Multiline = true;
            this.textFiltrar.Name = "textFiltrar";
            this.textFiltrar.Size = new System.Drawing.Size(109, 24);
            this.textFiltrar.TabIndex = 1;
            // 
            // btFiltrar
            // 
            this.btFiltrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFiltrar.Location = new System.Drawing.Point(533, 86);
            this.btFiltrar.Name = "btFiltrar";
            this.btFiltrar.Size = new System.Drawing.Size(80, 24);
            this.btFiltrar.TabIndex = 0;
            this.btFiltrar.Text = "FILTRAR";
            this.btFiltrar.UseVisualStyleBackColor = true;
            // 
            // btCapturar
            // 
            this.btCapturar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCapturar.Location = new System.Drawing.Point(586, 380);
            this.btCapturar.Name = "btCapturar";
            this.btCapturar.Size = new System.Drawing.Size(77, 23);
            this.btCapturar.TabIndex = 9;
            this.btCapturar.Text = "CAPTURAR";
            this.btCapturar.UseVisualStyleBackColor = true;
            this.btCapturar.Click += new System.EventHandler(this.btCapturar_Click);
            // 
            // cbDispositivos
            // 
            this.cbDispositivos.FormattingEnabled = true;
            this.cbDispositivos.Location = new System.Drawing.Point(344, 11);
            this.cbDispositivos.Name = "cbDispositivos";
            this.cbDispositivos.Size = new System.Drawing.Size(236, 21);
            this.cbDispositivos.TabIndex = 10;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(344, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 231);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Camara";
            // 
            // btGrabar
            // 
            this.btGrabar.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGrabar.Location = new System.Drawing.Point(586, 132);
            this.btGrabar.Name = "btGrabar";
            this.btGrabar.Size = new System.Drawing.Size(77, 23);
            this.btGrabar.TabIndex = 12;
            this.btGrabar.Text = "GRABAR";
            this.btGrabar.UseVisualStyleBackColor = true;
            this.btGrabar.Click += new System.EventHandler(this.btGrabar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(10, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 204);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.pictureBox2);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(344, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(236, 230);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Camara";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(717, 636);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "ContactoFamiliar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.TextBox texTelefono;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Label Telefono;
        private System.Windows.Forms.Label Id;
        private System.Windows.Forms.Label Nombre;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ListBox listFamiliar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btMostrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbFiltro;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cId;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn cTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn cFecha;
        private System.Windows.Forms.TextBox textFiltrar;
        private System.Windows.Forms.Button btFiltrar;
        private System.Windows.Forms.Label lbContcFamiliar;
        private System.Windows.Forms.Button btCapturar;
        private System.Windows.Forms.ComboBox cbDispositivos;
        private System.Windows.Forms.Button btGrabar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


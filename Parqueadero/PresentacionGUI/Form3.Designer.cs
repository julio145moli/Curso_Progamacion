namespace PresentacionGUI
{
    partial class ReporteSistemas
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
            this.gbReportes = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbReportes = new System.Windows.Forms.Label();
            this.btAtras1 = new System.Windows.Forms.Button();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parqueadero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoVehiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbReportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReportes
            // 
            this.gbReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gbReportes.Controls.Add(this.dataGridView1);
            this.gbReportes.Location = new System.Drawing.Point(12, 54);
            this.gbReportes.Name = "gbReportes";
            this.gbReportes.Size = new System.Drawing.Size(822, 436);
            this.gbReportes.TabIndex = 0;
            this.gbReportes.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Cargo,
            this.Parqueadero,
            this.TipoVehiculo,
            this.Placa});
            this.dataGridView1.Location = new System.Drawing.Point(66, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(690, 419);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbReportes
            // 
            this.lbReportes.AutoSize = true;
            this.lbReportes.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbReportes.Location = new System.Drawing.Point(236, 19);
            this.lbReportes.Name = "lbReportes";
            this.lbReportes.Size = new System.Drawing.Size(366, 32);
            this.lbReportes.TabIndex = 1;
            this.lbReportes.Text = "REPORTES DEL SISTEMA";
            // 
            // btAtras1
            // 
            this.btAtras1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras1.Location = new System.Drawing.Point(12, 496);
            this.btAtras1.Name = "btAtras1";
            this.btAtras1.Size = new System.Drawing.Size(75, 31);
            this.btAtras1.TabIndex = 2;
            this.btAtras1.Text = "Atras";
            this.btAtras1.UseVisualStyleBackColor = true;
            this.btAtras1.Click += new System.EventHandler(this.btAtras1_Click);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "NOMBRES";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "APELLIDOS";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "CARGOS";
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // Parqueadero
            // 
            this.Parqueadero.HeaderText = "PARQUEADEROS";
            this.Parqueadero.Name = "Parqueadero";
            this.Parqueadero.ReadOnly = true;
            // 
            // TipoVehiculo
            // 
            this.TipoVehiculo.HeaderText = "TIPO VEHICULO";
            this.TipoVehiculo.Name = "TipoVehiculo";
            this.TipoVehiculo.ReadOnly = true;
            // 
            // Placa
            // 
            this.Placa.HeaderText = "PLACA";
            this.Placa.Name = "Placa";
            this.Placa.ReadOnly = true;
            // 
            // ReporteSistemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(846, 535);
            this.Controls.Add(this.btAtras1);
            this.Controls.Add(this.lbReportes);
            this.Controls.Add(this.gbReportes);
            this.Name = "ReporteSistemas";
            this.Text = "REPORTES DEL SISTEMA";
            this.gbReportes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReportes;
        private System.Windows.Forms.Label lbReportes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btAtras1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parqueadero;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoVehiculo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
    }
}
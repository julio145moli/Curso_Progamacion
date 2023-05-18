﻿namespace PresentacionGUI
{
    partial class RegistroUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroUsuario));
            this.lbRegistro = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbParqueadero = new System.Windows.Forms.Label();
            this.lbVehiculo = new System.Windows.Forms.Label();
            this.lbPlaca = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textApellido = new System.Windows.Forms.TextBox();
            this.textPlaca = new System.Windows.Forms.TextBox();
            this.cbCargo = new System.Windows.Forms.ComboBox();
            this.cbParqueadero = new System.Windows.Forms.ComboBox();
            this.cbVehiculo = new System.Windows.Forms.ComboBox();
            this.brRegistrar = new System.Windows.Forms.Button();
            this.btRetirar = new System.Windows.Forms.Button();
            this.btRegistros = new System.Windows.Forms.Button();
            this.btAtras = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegistro
            // 
            this.lbRegistro.AutoSize = true;
            this.lbRegistro.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegistro.Location = new System.Drawing.Point(43, 30);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(321, 32);
            this.lbRegistro.TabIndex = 0;
            this.lbRegistro.Text = "REGISTRAR USUARIO";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(45, 105);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(76, 22);
            this.lbNombre.TabIndex = 1;
            this.lbNombre.Text = "Nombre";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(44, 141);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(77, 22);
            this.lbApellido.TabIndex = 2;
            this.lbApellido.Text = "Apellido";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCargo.Location = new System.Drawing.Point(45, 172);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(62, 22);
            this.lbCargo.TabIndex = 3;
            this.lbCargo.Text = "Cargo";
            // 
            // lbParqueadero
            // 
            this.lbParqueadero.AutoSize = true;
            this.lbParqueadero.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbParqueadero.Location = new System.Drawing.Point(44, 203);
            this.lbParqueadero.Name = "lbParqueadero";
            this.lbParqueadero.Size = new System.Drawing.Size(116, 22);
            this.lbParqueadero.TabIndex = 4;
            this.lbParqueadero.Text = "Parqueadero";
            // 
            // lbVehiculo
            // 
            this.lbVehiculo.AutoSize = true;
            this.lbVehiculo.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVehiculo.Location = new System.Drawing.Point(45, 234);
            this.lbVehiculo.Name = "lbVehiculo";
            this.lbVehiculo.Size = new System.Drawing.Size(122, 22);
            this.lbVehiculo.TabIndex = 5;
            this.lbVehiculo.Text = "Tipo Vehiculo";
            // 
            // lbPlaca
            // 
            this.lbPlaca.AutoSize = true;
            this.lbPlaca.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPlaca.Location = new System.Drawing.Point(45, 265);
            this.lbPlaca.Name = "lbPlaca";
            this.lbPlaca.Size = new System.Drawing.Size(56, 22);
            this.lbPlaca.TabIndex = 6;
            this.lbPlaca.Text = "Placa";
            // 
            // textNombre
            // 
            this.textNombre.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNombre.Location = new System.Drawing.Point(191, 108);
            this.textNombre.Multiline = true;
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(173, 20);
            this.textNombre.TabIndex = 7;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            this.textNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textNombre_KeyPress);
            // 
            // textApellido
            // 
            this.textApellido.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textApellido.Location = new System.Drawing.Point(191, 141);
            this.textApellido.Multiline = true;
            this.textApellido.Name = "textApellido";
            this.textApellido.Size = new System.Drawing.Size(173, 20);
            this.textApellido.TabIndex = 8;
            this.textApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textApellido_KeyPress);
            // 
            // textPlaca
            // 
            this.textPlaca.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textPlaca.Location = new System.Drawing.Point(191, 265);
            this.textPlaca.Multiline = true;
            this.textPlaca.Name = "textPlaca";
            this.textPlaca.Size = new System.Drawing.Size(173, 20);
            this.textPlaca.TabIndex = 9;
            // 
            // cbCargo
            // 
            this.cbCargo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCargo.FormattingEnabled = true;
            this.cbCargo.Items.AddRange(new object[] {
            "Particular",
            "Estudiante",
            "Docente",
            "Administrativo"});
            this.cbCargo.Location = new System.Drawing.Point(191, 172);
            this.cbCargo.Name = "cbCargo";
            this.cbCargo.Size = new System.Drawing.Size(173, 23);
            this.cbCargo.TabIndex = 10;
            // 
            // cbParqueadero
            // 
            this.cbParqueadero.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbParqueadero.FormattingEnabled = true;
            this.cbParqueadero.Items.AddRange(new object[] {
            "Bloque P",
            "Bloque I",
            "Bloque H",
            "Bloque B",
            "Bloque A"});
            this.cbParqueadero.Location = new System.Drawing.Point(191, 203);
            this.cbParqueadero.Name = "cbParqueadero";
            this.cbParqueadero.Size = new System.Drawing.Size(173, 23);
            this.cbParqueadero.TabIndex = 11;
            // 
            // cbVehiculo
            // 
            this.cbVehiculo.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbVehiculo.FormattingEnabled = true;
            this.cbVehiculo.Items.AddRange(new object[] {
            "Bicicleta",
            "Moto",
            "Carro",
            "Camioneta"});
            this.cbVehiculo.Location = new System.Drawing.Point(191, 234);
            this.cbVehiculo.Name = "cbVehiculo";
            this.cbVehiculo.Size = new System.Drawing.Size(173, 23);
            this.cbVehiculo.TabIndex = 12;
            this.cbVehiculo.SelectedIndexChanged += new System.EventHandler(this.cbVehiculo_SelectedIndexChanged);
            // 
            // brRegistrar
            // 
            this.brRegistrar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brRegistrar.Location = new System.Drawing.Point(48, 321);
            this.brRegistrar.Name = "brRegistrar";
            this.brRegistrar.Size = new System.Drawing.Size(153, 30);
            this.brRegistrar.TabIndex = 13;
            this.brRegistrar.Text = "Registrar Vehiculo";
            this.brRegistrar.UseVisualStyleBackColor = true;
            this.brRegistrar.Click += new System.EventHandler(this.brRegistrar_Click);
            // 
            // btRetirar
            // 
            this.btRetirar.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRetirar.Location = new System.Drawing.Point(211, 321);
            this.btRetirar.Name = "btRetirar";
            this.btRetirar.Size = new System.Drawing.Size(153, 30);
            this.btRetirar.TabIndex = 14;
            this.btRetirar.Text = "Retirar Vehiculo";
            this.btRetirar.UseVisualStyleBackColor = true;
            this.btRetirar.Click += new System.EventHandler(this.btRetirar_Click);
            // 
            // btRegistros
            // 
            this.btRegistros.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRegistros.Location = new System.Drawing.Point(119, 357);
            this.btRegistros.Name = "btRegistros";
            this.btRegistros.Size = new System.Drawing.Size(174, 30);
            this.btRegistros.TabIndex = 15;
            this.btRegistros.Text = "Registro Del Sistema";
            this.btRegistros.UseVisualStyleBackColor = true;
            this.btRegistros.Click += new System.EventHandler(this.btRegistros_Click);
            // 
            // btAtras
            // 
            this.btAtras.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtras.Location = new System.Drawing.Point(12, 412);
            this.btAtras.Name = "btAtras";
            this.btAtras.Size = new System.Drawing.Size(91, 29);
            this.btAtras.TabIndex = 16;
            this.btAtras.Text = "Atras";
            this.btAtras.UseVisualStyleBackColor = true;
            this.btAtras.Click += new System.EventHandler(this.btAtras_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(410, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // RegistroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(576, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btAtras);
            this.Controls.Add(this.btRegistros);
            this.Controls.Add(this.btRetirar);
            this.Controls.Add(this.brRegistrar);
            this.Controls.Add(this.cbVehiculo);
            this.Controls.Add(this.cbParqueadero);
            this.Controls.Add(this.cbCargo);
            this.Controls.Add(this.textPlaca);
            this.Controls.Add(this.textApellido);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lbPlaca);
            this.Controls.Add(this.lbVehiculo);
            this.Controls.Add(this.lbParqueadero);
            this.Controls.Add(this.lbCargo);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbRegistro);
            this.Name = "RegistroUsuario";
            this.Text = "REGISTRO USUARIO";
            this.Load += new System.EventHandler(this.RegistroUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegistro;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.Label lbCargo;
        private System.Windows.Forms.Label lbParqueadero;
        private System.Windows.Forms.Label lbVehiculo;
        private System.Windows.Forms.Label lbPlaca;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textApellido;
        private System.Windows.Forms.TextBox textPlaca;
        private System.Windows.Forms.ComboBox cbCargo;
        private System.Windows.Forms.ComboBox cbParqueadero;
        private System.Windows.Forms.ComboBox cbVehiculo;
        private System.Windows.Forms.Button brRegistrar;
        private System.Windows.Forms.Button btRetirar;
        private System.Windows.Forms.Button btRegistros;
        private System.Windows.Forms.Button btAtras;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
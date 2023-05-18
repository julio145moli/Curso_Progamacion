namespace ALCALDIA
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
            this.Lugar = new System.Windows.Forms.GroupBox();
            this.Municipio = new System.Windows.Forms.RadioButton();
            this.Departamento = new System.Windows.Forms.RadioButton();
            this.Agregar = new System.Windows.Forms.GroupBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.Eliminar = new System.Windows.Forms.Button();
            this.Adicionar = new System.Windows.Forms.Button();
            this.Listas = new System.Windows.Forms.GroupBox();
            this.ListaDepartamentos = new System.Windows.Forms.ListBox();
            this.ListaMunicipios = new System.Windows.Forms.ListBox();
            this.btIzquierdo = new System.Windows.Forms.Button();
            this.btDerecho = new System.Windows.Forms.Button();
            this.Limpiar = new System.Windows.Forms.Button();
            this.Lugar.SuspendLayout();
            this.Agregar.SuspendLayout();
            this.Listas.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lugar
            // 
            this.Lugar.Controls.Add(this.Municipio);
            this.Lugar.Controls.Add(this.Departamento);
            this.Lugar.Location = new System.Drawing.Point(85, 51);
            this.Lugar.Name = "Lugar";
            this.Lugar.Size = new System.Drawing.Size(254, 226);
            this.Lugar.TabIndex = 0;
            this.Lugar.TabStop = false;
            this.Lugar.Text = "LUGAR";
            this.Lugar.Enter += new System.EventHandler(this.Lugar_Enter);
            // 
            // Municipio
            // 
            this.Municipio.AutoSize = true;
            this.Municipio.Location = new System.Drawing.Point(54, 124);
            this.Municipio.Name = "Municipio";
            this.Municipio.Size = new System.Drawing.Size(81, 17);
            this.Municipio.TabIndex = 1;
            this.Municipio.TabStop = true;
            this.Municipio.Text = "MUNICIPIO";
            this.Municipio.UseVisualStyleBackColor = true;
            this.Municipio.CheckedChanged += new System.EventHandler(this.Municipio_CheckedChanged);
            // 
            // Departamento
            // 
            this.Departamento.AutoSize = true;
            this.Departamento.Location = new System.Drawing.Point(54, 70);
            this.Departamento.Name = "Departamento";
            this.Departamento.Size = new System.Drawing.Size(115, 17);
            this.Departamento.TabIndex = 0;
            this.Departamento.TabStop = true;
            this.Departamento.Text = "DEPARTAMENTO";
            this.Departamento.UseVisualStyleBackColor = true;
            this.Departamento.CheckedChanged += new System.EventHandler(this.Departamento_CheckedChanged);
            // 
            // Agregar
            // 
            this.Agregar.Controls.Add(this.txtValor);
            this.Agregar.Controls.Add(this.Valor);
            this.Agregar.Controls.Add(this.Eliminar);
            this.Agregar.Controls.Add(this.Adicionar);
            this.Agregar.Location = new System.Drawing.Point(471, 51);
            this.Agregar.Name = "Agregar";
            this.Agregar.Size = new System.Drawing.Size(254, 226);
            this.Agregar.TabIndex = 1;
            this.Agregar.TabStop = false;
            this.Agregar.Text = "AGREGAR";
            this.Agregar.Enter += new System.EventHandler(this.Agregar_Enter);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(112, 70);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(116, 20);
            this.txtValor.TabIndex = 3;
            this.txtValor.TextChanged += new System.EventHandler(this.txtValor_TextChanged);
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valor.Location = new System.Drawing.Point(35, 74);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(50, 15);
            this.Valor.TabIndex = 2;
            this.Valor.Text = "VALOR";
            this.Valor.Click += new System.EventHandler(this.Valor_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Location = new System.Drawing.Point(154, 168);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(74, 25);
            this.Eliminar.TabIndex = 1;
            this.Eliminar.Text = "ELIMINAR";
            this.Eliminar.UseVisualStyleBackColor = true;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // Adicionar
            // 
            this.Adicionar.Location = new System.Drawing.Point(38, 168);
            this.Adicionar.Name = "Adicionar";
            this.Adicionar.Size = new System.Drawing.Size(74, 25);
            this.Adicionar.TabIndex = 0;
            this.Adicionar.Text = "ADICIONAR";
            this.Adicionar.UseVisualStyleBackColor = true;
            this.Adicionar.Click += new System.EventHandler(this.Adicionar_Click);
            // 
            // Listas
            // 
            this.Listas.Controls.Add(this.ListaDepartamentos);
            this.Listas.Controls.Add(this.ListaMunicipios);
            this.Listas.Controls.Add(this.btIzquierdo);
            this.Listas.Controls.Add(this.btDerecho);
            this.Listas.Location = new System.Drawing.Point(85, 302);
            this.Listas.Name = "Listas";
            this.Listas.Size = new System.Drawing.Size(640, 349);
            this.Listas.TabIndex = 2;
            this.Listas.TabStop = false;
            this.Listas.Text = "LISTAS";
            this.Listas.Enter += new System.EventHandler(this.Listas_Enter);
            // 
            // ListaDepartamentos
            // 
            this.ListaDepartamentos.FormattingEnabled = true;
            this.ListaDepartamentos.Location = new System.Drawing.Point(35, 42);
            this.ListaDepartamentos.Name = "ListaDepartamentos";
            this.ListaDepartamentos.Size = new System.Drawing.Size(190, 238);
            this.ListaDepartamentos.TabIndex = 4;
            this.ListaDepartamentos.SelectedIndexChanged += new System.EventHandler(this.ListaDepartamentos_SelectedIndexChanged);
            // 
            // ListaMunicipios
            // 
            this.ListaMunicipios.FormattingEnabled = true;
            this.ListaMunicipios.Location = new System.Drawing.Point(411, 42);
            this.ListaMunicipios.Name = "ListaMunicipios";
            this.ListaMunicipios.Size = new System.Drawing.Size(190, 238);
            this.ListaMunicipios.TabIndex = 3;
            this.ListaMunicipios.SelectedIndexChanged += new System.EventHandler(this.ListaMunicipios_SelectedIndexChanged);
            // 
            // btIzquierdo
            // 
            this.btIzquierdo.Location = new System.Drawing.Point(291, 165);
            this.btIzquierdo.Name = "btIzquierdo";
            this.btIzquierdo.Size = new System.Drawing.Size(60, 25);
            this.btIzquierdo.TabIndex = 2;
            this.btIzquierdo.Text = "<<--";
            this.btIzquierdo.UseVisualStyleBackColor = true;
            this.btIzquierdo.Click += new System.EventHandler(this.btIzquierdo_Click);
            // 
            // btDerecho
            // 
            this.btDerecho.Location = new System.Drawing.Point(291, 119);
            this.btDerecho.Name = "btDerecho";
            this.btDerecho.Size = new System.Drawing.Size(60, 25);
            this.btDerecho.TabIndex = 1;
            this.btDerecho.Text = "-->>";
            this.btDerecho.UseVisualStyleBackColor = true;
            this.btDerecho.Click += new System.EventHandler(this.btDerecho_Click);
            // 
            // Limpiar
            // 
            this.Limpiar.Location = new System.Drawing.Point(337, 683);
            this.Limpiar.Name = "Limpiar";
            this.Limpiar.Size = new System.Drawing.Size(74, 25);
            this.Limpiar.TabIndex = 3;
            this.Limpiar.Text = "LIMPIAR";
            this.Limpiar.UseVisualStyleBackColor = true;
            this.Limpiar.Click += new System.EventHandler(this.Limpiar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 740);
            this.Controls.Add(this.Limpiar);
            this.Controls.Add(this.Listas);
            this.Controls.Add(this.Agregar);
            this.Controls.Add(this.Lugar);
            this.Name = "Form1";
            this.Text = "ALCALDIA";
            this.Lugar.ResumeLayout(false);
            this.Lugar.PerformLayout();
            this.Agregar.ResumeLayout(false);
            this.Agregar.PerformLayout();
            this.Listas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Lugar;
        private System.Windows.Forms.RadioButton Municipio;
        private System.Windows.Forms.RadioButton Departamento;
        private System.Windows.Forms.GroupBox Agregar;
        private System.Windows.Forms.Label Valor;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Adicionar;
        private System.Windows.Forms.GroupBox Listas;
        private System.Windows.Forms.ListBox ListaDepartamentos;
        private System.Windows.Forms.ListBox ListaMunicipios;
        private System.Windows.Forms.Button btIzquierdo;
        private System.Windows.Forms.Button btDerecho;
        private System.Windows.Forms.Button Limpiar;
        private System.Windows.Forms.TextBox txtValor;
    }
}


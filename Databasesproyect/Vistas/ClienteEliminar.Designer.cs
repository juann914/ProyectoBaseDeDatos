namespace Databasesproyect
{
    partial class ClienteEliminar
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
            this.gpCodigo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.gpEliminar = new System.Windows.Forms.GroupBox();
            this.dataGridClientes = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpCodigo.SuspendLayout();
            this.gpEliminar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCodigo
            // 
            this.gpCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpCodigo.Controls.Add(this.label1);
            this.gpCodigo.Controls.Add(this.txtCodigo);
            this.gpCodigo.Controls.Add(this.btnCancelar);
            this.gpCodigo.Controls.Add(this.btnAceptar);
            this.gpCodigo.Location = new System.Drawing.Point(12, 12);
            this.gpCodigo.Name = "gpCodigo";
            this.gpCodigo.Size = new System.Drawing.Size(896, 207);
            this.gpCodigo.TabIndex = 10;
            this.gpCodigo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(245, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el id del cliente";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(236, 73);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(365, 33);
            this.txtCodigo.TabIndex = 1;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCancelar.Location = new System.Drawing.Point(462, 128);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(130, 59);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAceptar.Location = new System.Drawing.Point(236, 128);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(135, 59);
            this.btnAceptar.TabIndex = 2;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // gpEliminar
            // 
            this.gpEliminar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.gpEliminar.Controls.Add(this.dataGridClientes);
            this.gpEliminar.Controls.Add(this.button2);
            this.gpEliminar.Controls.Add(this.label2);
            this.gpEliminar.Controls.Add(this.button1);
            this.gpEliminar.Location = new System.Drawing.Point(12, 251);
            this.gpEliminar.Name = "gpEliminar";
            this.gpEliminar.Size = new System.Drawing.Size(896, 278);
            this.gpEliminar.TabIndex = 11;
            this.gpEliminar.TabStop = false;
            this.gpEliminar.Text = "groupBox1";
            this.gpEliminar.Visible = false;
            // 
            // dataGridClientes
            // 
            this.dataGridClientes.AllowUserToOrderColumns = true;
            this.dataGridClientes.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProducto,
            this.CodigoBarra,
            this.Nombre,
            this.Precio,
            this.Marca});
            this.dataGridClientes.Location = new System.Drawing.Point(6, 11);
            this.dataGridClientes.Name = "dataGridClientes";
            this.dataGridClientes.RowHeadersWidth = 51;
            this.dataGridClientes.RowTemplate.Height = 24;
            this.dataGridClientes.Size = new System.Drawing.Size(884, 78);
            this.dataGridClientes.TabIndex = 4;
            this.dataGridClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridClientes_CellContentClick);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button2.Location = new System.Drawing.Point(480, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 59);
            this.button2.TabIndex = 7;
            this.button2.Text = "No";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 58);
            this.label2.TabIndex = 5;
            this.label2.Text = "Se eliminara este cliente, ¿Estas seguro?\r\n\r\n";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.button1.Location = new System.Drawing.Point(236, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 59);
            this.button1.TabIndex = 6;
            this.button1.Text = "Si";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdUsuario";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.Width = 125;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.HeaderText = "Nombre";
            this.CodigoBarra.MinimumWidth = 6;
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Apellidos";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Correo";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "RFC";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // ClienteEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(920, 531);
            this.Controls.Add(this.gpEliminar);
            this.Controls.Add(this.gpCodigo);
            this.Name = "ClienteEliminar";
            this.Text = "ClienteEliminar";
            this.gpCodigo.ResumeLayout(false);
            this.gpCodigo.PerformLayout();
            this.gpEliminar.ResumeLayout(false);
            this.gpEliminar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox gpEliminar;
        private System.Windows.Forms.DataGridView dataGridClientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
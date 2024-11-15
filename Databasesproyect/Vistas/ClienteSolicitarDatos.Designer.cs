namespace Databasesproyect.Vistas
{
    partial class ClienteSolicitarDatos
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
            this.gpCode = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridUser = new System.Windows.Forms.DataGridView();
            this.IdProductoddd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gpCode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // gpCode
            // 
            this.gpCode.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.gpCode.Controls.Add(this.button1);
            this.gpCode.Controls.Add(this.btnAcpetar);
            this.gpCode.Controls.Add(this.btnCancelar);
            this.gpCode.Controls.Add(this.txtCodigo);
            this.gpCode.Controls.Add(this.label1);
            this.gpCode.Location = new System.Drawing.Point(12, 12);
            this.gpCode.Name = "gpCode";
            this.gpCode.Size = new System.Drawing.Size(940, 174);
            this.gpCode.TabIndex = 7;
            this.gpCode.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 48);
            this.button1.TabIndex = 4;
            this.button1.Text = "Ver todos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(619, 90);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(106, 48);
            this.btnAcpetar.TabIndex = 2;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(202, 90);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Regresar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(554, 21);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(287, 29);
            this.txtCodigo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por id:";
            // 
            // dataGridUser
            // 
            this.dataGridUser.AllowUserToOrderColumns = true;
            this.dataGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdProductoddd,
            this.CodigoBarra,
            this.Nombre,
            this.Precio,
            this.Marca});
            this.dataGridUser.Location = new System.Drawing.Point(12, 197);
            this.dataGridUser.Name = "dataGridUser";
            this.dataGridUser.RowHeadersWidth = 51;
            this.dataGridUser.RowTemplate.Height = 24;
            this.dataGridUser.Size = new System.Drawing.Size(916, 241);
            this.dataGridUser.TabIndex = 8;
            // 
            // IdProductoddd
            // 
            this.IdProductoddd.HeaderText = "IdUsuario";
            this.IdProductoddd.MinimumWidth = 6;
            this.IdProductoddd.Name = "IdProductoddd";
            this.IdProductoddd.Width = 125;
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
            this.Nombre.HeaderText = "Apellido";
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
            // ClienteSolicitarDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 450);
            this.Controls.Add(this.dataGridUser);
            this.Controls.Add(this.gpCode);
            this.Name = "ClienteSolicitarDatos";
            this.Text = "ClienteSolicitarDatos";
            this.gpCode.ResumeLayout(false);
            this.gpCode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAcpetar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProductoddd;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
    }
}
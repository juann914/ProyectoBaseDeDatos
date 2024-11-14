namespace Databasesproyect
{
    partial class ProductoEditar
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnAcpetar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpProducto = new System.Windows.Forms.GroupBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.gpCode = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpProducto.SuspendLayout();
            this.gpCode.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce codigo del producto a editar:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(357, 14);
            this.txtCodigo.Multiline = true;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(287, 29);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAcpetar
            // 
            this.btnAcpetar.Location = new System.Drawing.Point(199, 82);
            this.btnAcpetar.Name = "btnAcpetar";
            this.btnAcpetar.Size = new System.Drawing.Size(106, 48);
            this.btnAcpetar.TabIndex = 2;
            this.btnAcpetar.Text = "Aceptar";
            this.btnAcpetar.UseVisualStyleBackColor = true;
            this.btnAcpetar.Click += new System.EventHandler(this.btnAcpetar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(378, 82);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 48);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpProducto
            // 
            this.gpProducto.Controls.Add(this.button2);
            this.gpProducto.Controls.Add(this.button1);
            this.gpProducto.Controls.Add(this.txtNombre);
            this.gpProducto.Controls.Add(this.txtDes);
            this.gpProducto.Controls.Add(this.txtPrecio);
            this.gpProducto.Controls.Add(this.label4);
            this.gpProducto.Controls.Add(this.label3);
            this.gpProducto.Controls.Add(this.label2);
            this.gpProducto.Controls.Add(this.lblProducto);
            this.gpProducto.Location = new System.Drawing.Point(15, 222);
            this.gpProducto.Name = "gpProducto";
            this.gpProducto.Size = new System.Drawing.Size(719, 297);
            this.gpProducto.TabIndex = 4;
            this.gpProducto.TabStop = false;
            this.gpProducto.Visible = false;
            this.gpProducto.Enter += new System.EventHandler(this.gpProducto_Enter);
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Microsoft YaHei", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProducto.Location = new System.Drawing.Point(303, 18);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(0, 25);
            this.lblProducto.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Precio: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre: ";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(163, 58);
            this.txtPrecio.Multiline = true;
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(217, 32);
            this.txtPrecio.TabIndex = 4;
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(163, 112);
            this.txtDes.Multiline = true;
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(217, 32);
            this.txtDes.TabIndex = 5;
            this.txtDes.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 170);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(217, 32);
            this.txtNombre.TabIndex = 6;
            // 
            // gpCode
            // 
            this.gpCode.Controls.Add(this.btnAcpetar);
            this.gpCode.Controls.Add(this.btnCancelar);
            this.gpCode.Controls.Add(this.txtCodigo);
            this.gpCode.Controls.Add(this.label1);
            this.gpCode.Location = new System.Drawing.Point(30, 31);
            this.gpCode.Name = "gpCode";
            this.gpCode.Size = new System.Drawing.Size(679, 174);
            this.gpCode.TabIndex = 5;
            this.gpCode.TabStop = false;
            this.gpCode.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(163, 245);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 46);
            this.button1.TabIndex = 7;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(363, 245);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 46);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProductoEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 531);
            this.Controls.Add(this.gpCode);
            this.Controls.Add(this.gpProducto);
            this.Name = "ProductoEditar";
            this.Text = "ProductoEditar";
            this.gpProducto.ResumeLayout(false);
            this.gpProducto.PerformLayout();
            this.gpCode.ResumeLayout(false);
            this.gpCode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnAcpetar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDes;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.GroupBox gpCode;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}
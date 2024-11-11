namespace Databasesproyect
{
    partial class Ventas
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
            this.butAgregar = new System.Windows.Forms.Button();
            this.butBorrar = new System.Windows.Forms.Button();
            this.butEditar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laTotal = new System.Windows.Forms.Label();
            this.laIVA = new System.Windows.Forms.Label();
            this.laSubtotal = new System.Windows.Forms.Label();
            this.laDesc = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.Clave = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataVenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripción = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butAgregarC = new System.Windows.Forms.Button();
            this.butAgreC = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // butAgregar
            // 
            this.butAgregar.Location = new System.Drawing.Point(20, 370);
            this.butAgregar.Name = "butAgregar";
            this.butAgregar.Size = new System.Drawing.Size(75, 23);
            this.butAgregar.TabIndex = 2;
            this.butAgregar.Text = "Agregar";
            this.butAgregar.UseVisualStyleBackColor = true;
            this.butAgregar.Click += new System.EventHandler(this.butAgregar_Click);
            // 
            // butBorrar
            // 
            this.butBorrar.Location = new System.Drawing.Point(129, 370);
            this.butBorrar.Name = "butBorrar";
            this.butBorrar.Size = new System.Drawing.Size(75, 23);
            this.butBorrar.TabIndex = 3;
            this.butBorrar.Text = "Borrar";
            this.butBorrar.UseVisualStyleBackColor = true;
            this.butBorrar.Click += new System.EventHandler(this.butBorrar_Click);
            // 
            // butEditar
            // 
            this.butEditar.Location = new System.Drawing.Point(228, 370);
            this.butEditar.Name = "butEditar";
            this.butEditar.Size = new System.Drawing.Size(75, 23);
            this.butEditar.TabIndex = 4;
            this.butEditar.Text = "Editar";
            this.butEditar.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(353, 405);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Total Venta";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 405);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Salir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.laTotal);
            this.groupBox1.Controls.Add(this.laIVA);
            this.groupBox1.Controls.Add(this.laSubtotal);
            this.groupBox1.Controls.Add(this.laDesc);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(579, 322);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 126);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Totales";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // laTotal
            // 
            this.laTotal.AutoSize = true;
            this.laTotal.Location = new System.Drawing.Point(144, 93);
            this.laTotal.Name = "laTotal";
            this.laTotal.Size = new System.Drawing.Size(41, 13);
            this.laTotal.TabIndex = 15;
            this.laTotal.Text = "label12";
            // 
            // laIVA
            // 
            this.laIVA.AutoSize = true;
            this.laIVA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.laIVA.Location = new System.Drawing.Point(144, 71);
            this.laIVA.Name = "laIVA";
            this.laIVA.Size = new System.Drawing.Size(41, 13);
            this.laIVA.TabIndex = 14;
            this.laIVA.Text = "label11";
            // 
            // laSubtotal
            // 
            this.laSubtotal.AutoSize = true;
            this.laSubtotal.Location = new System.Drawing.Point(144, 48);
            this.laSubtotal.Name = "laSubtotal";
            this.laSubtotal.Size = new System.Drawing.Size(41, 13);
            this.laSubtotal.TabIndex = 13;
            this.laSubtotal.Text = "label10";
            // 
            // laDesc
            // 
            this.laDesc.AutoSize = true;
            this.laDesc.Location = new System.Drawing.Point(144, 23);
            this.laDesc.Name = "laDesc";
            this.laDesc.Size = new System.Drawing.Size(35, 13);
            this.laDesc.TabIndex = 12;
            this.laDesc.Text = "label9";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(48, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(30, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Total";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "IVA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "SubTotal";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "%Desc.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre Cliente";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(20, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(155, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Correo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(155, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "RFC";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(158, 34);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(20, 74);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(158, 74);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 17;
            // 
            // dataVentas
            // 
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Clave,
            this.DataVenta,
            this.Marca,
            this.Descripción,
            this.Precio,
            this.Importe});
            this.dataVentas.Location = new System.Drawing.Point(12, 111);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.RowHeadersWidth = 51;
            this.dataVentas.Size = new System.Drawing.Size(645, 208);
            this.dataVentas.TabIndex = 18;
            this.dataVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Clave
            // 
            this.Clave.HeaderText = "Clave";
            this.Clave.MinimumWidth = 6;
            this.Clave.Name = "Clave";
            this.Clave.Width = 125;
            // 
            // DataVenta
            // 
            this.DataVenta.HeaderText = "Cantidad";
            this.DataVenta.MinimumWidth = 6;
            this.DataVenta.Name = "DataVenta";
            this.DataVenta.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.Width = 125;
            // 
            // Descripción
            // 
            this.Descripción.HeaderText = "Descripción";
            this.Descripción.MinimumWidth = 6;
            this.Descripción.Name = "Descripción";
            this.Descripción.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.Width = 125;
            // 
            // Importe
            // 
            this.Importe.HeaderText = "Importe";
            this.Importe.MinimumWidth = 6;
            this.Importe.Name = "Importe";
            this.Importe.Width = 125;
            // 
            // butAgregarC
            // 
            this.butAgregarC.Location = new System.Drawing.Point(288, 35);
            this.butAgregarC.Name = "butAgregarC";
            this.butAgregarC.Size = new System.Drawing.Size(75, 23);
            this.butAgregarC.TabIndex = 19;
            this.butAgregarC.Text = "Agregar";
            this.butAgregarC.UseVisualStyleBackColor = true;
            // 
            // butAgreC
            // 
            this.butAgreC.Location = new System.Drawing.Point(279, 33);
            this.butAgreC.Name = "butAgreC";
            this.butAgreC.Size = new System.Drawing.Size(75, 23);
            this.butAgreC.TabIndex = 19;
            this.butAgreC.Text = "Agregar";
            this.butAgreC.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.butAgreC);
            this.Controls.Add(this.dataVentas);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butEditar);
            this.Controls.Add(this.butBorrar);
            this.Controls.Add(this.butAgregar);
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button butAgregar;
        private System.Windows.Forms.Button butBorrar;
        private System.Windows.Forms.Button butEditar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label laTotal;
        private System.Windows.Forms.Label laIVA;
        private System.Windows.Forms.Label laSubtotal;
        private System.Windows.Forms.Label laDesc;
        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Clave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripción;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.Button butAgregarC;
        private System.Windows.Forms.Button butAgreC;
    }
}
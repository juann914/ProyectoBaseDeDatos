﻿namespace Databasesproyect
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
            this.butGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.laTotal = new System.Windows.Forms.Label();
            this.laIVA = new System.Windows.Forms.Label();
            this.laSubtotal = new System.Windows.Forms.Label();
            this.laDesc = new System.Windows.Forms.Label();
            this.teDes = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textCorreo = new System.Windows.Forms.TextBox();
            this.textApellidos = new System.Windows.Forms.TextBox();
            this.textRFC = new System.Windows.Forms.TextBox();
            this.butAgregarC = new System.Windows.Forms.Button();
            this.butAgreC = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataVentas = new System.Windows.Forms.DataGridView();
            this.textCodigo = new System.Windows.Forms.TextBox();
            this.Código = new System.Windows.Forms.Label();
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
            // butGuardar
            // 
            this.butGuardar.Location = new System.Drawing.Point(20, 415);
            this.butGuardar.Name = "butGuardar";
            this.butGuardar.Size = new System.Drawing.Size(91, 23);
            this.butGuardar.TabIndex = 5;
            this.butGuardar.Text = "Nuevo/Guardar";
            this.butGuardar.UseVisualStyleBackColor = true;
            this.butGuardar.Click += new System.EventHandler(this.button1_Click);
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
            this.groupBox1.Controls.Add(this.teDes);
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
            this.laTotal.Size = new System.Drawing.Size(0, 13);
            this.laTotal.TabIndex = 15;
            // 
            // laIVA
            // 
            this.laIVA.AutoSize = true;
            this.laIVA.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.laIVA.Location = new System.Drawing.Point(144, 71);
            this.laIVA.Name = "laIVA";
            this.laIVA.Size = new System.Drawing.Size(0, 13);
            this.laIVA.TabIndex = 14;
            // 
            // laSubtotal
            // 
            this.laSubtotal.AutoSize = true;
            this.laSubtotal.Location = new System.Drawing.Point(144, 48);
            this.laSubtotal.Name = "laSubtotal";
            this.laSubtotal.Size = new System.Drawing.Size(0, 13);
            this.laSubtotal.TabIndex = 13;
            this.laSubtotal.Click += new System.EventHandler(this.laSubtotal_Click);
            // 
            // laDesc
            // 
            this.laDesc.AutoSize = true;
            this.laDesc.Location = new System.Drawing.Point(144, 23);
            this.laDesc.Name = "laDesc";
            this.laDesc.Size = new System.Drawing.Size(0, 13);
            this.laDesc.TabIndex = 12;
            // 
            // teDes
            // 
            this.teDes.Location = new System.Drawing.Point(48, 19);
            this.teDes.Name = "teDes";
            this.teDes.Size = new System.Drawing.Size(30, 20);
            this.teDes.TabIndex = 11;
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
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(20, 35);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 11;
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
            // textCorreo
            // 
            this.textCorreo.Location = new System.Drawing.Point(158, 34);
            this.textCorreo.Name = "textCorreo";
            this.textCorreo.Size = new System.Drawing.Size(100, 20);
            this.textCorreo.TabIndex = 15;
            // 
            // textApellidos
            // 
            this.textApellidos.Location = new System.Drawing.Point(20, 74);
            this.textApellidos.Name = "textApellidos";
            this.textApellidos.Size = new System.Drawing.Size(100, 20);
            this.textApellidos.TabIndex = 16;
            // 
            // textRFC
            // 
            this.textRFC.Location = new System.Drawing.Point(158, 74);
            this.textRFC.Name = "textRFC";
            this.textRFC.Size = new System.Drawing.Size(100, 20);
            this.textRFC.TabIndex = 17;
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
            this.butAgreC.Location = new System.Drawing.Point(273, 32);
            this.butAgreC.Name = "butAgreC";
            this.butAgreC.Size = new System.Drawing.Size(75, 23);
            this.butAgreC.TabIndex = 19;
            this.butAgreC.Text = "Agregar";
            this.butAgreC.UseVisualStyleBackColor = true;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // dataVentas
            // 
            this.dataVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataVentas.Location = new System.Drawing.Point(12, 111);
            this.dataVentas.Name = "dataVentas";
            this.dataVentas.RowHeadersWidth = 51;
            this.dataVentas.Size = new System.Drawing.Size(645, 208);
            this.dataVentas.TabIndex = 18;
            this.dataVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textCodigo
            // 
            this.textCodigo.Location = new System.Drawing.Point(20, 345);
            this.textCodigo.Name = "textCodigo";
            this.textCodigo.Size = new System.Drawing.Size(100, 20);
            this.textCodigo.TabIndex = 20;
            // 
            // Código
            // 
            this.Código.AutoSize = true;
            this.Código.Location = new System.Drawing.Point(17, 329);
            this.Código.Name = "Código";
            this.Código.Size = new System.Drawing.Size(40, 13);
            this.Código.TabIndex = 21;
            this.Código.Text = "Código";
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Código);
            this.Controls.Add(this.textCodigo);
            this.Controls.Add(this.butAgreC);
            this.Controls.Add(this.dataVentas);
            this.Controls.Add(this.textRFC);
            this.Controls.Add(this.textApellidos);
            this.Controls.Add(this.textCorreo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.butGuardar);
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
        private System.Windows.Forms.Button butGuardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox teDes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textCorreo;
        private System.Windows.Forms.TextBox textApellidos;
        private System.Windows.Forms.TextBox textRFC;
        private System.Windows.Forms.Label laTotal;
        private System.Windows.Forms.Label laIVA;
        private System.Windows.Forms.Label laSubtotal;
        private System.Windows.Forms.Label laDesc;
        private System.Windows.Forms.Button butAgregarC;
        private System.Windows.Forms.Button butAgreC;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataVentas;
        private System.Windows.Forms.TextBox textCodigo;
        private System.Windows.Forms.Label Código;
    }
}
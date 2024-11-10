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
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpEliminar = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.gpEliminar.SuspendLayout();
            this.gpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresa el id del cliente ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(166, 57);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(215, 22);
            this.txtId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(142, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 54);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(313, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 54);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpEliminar
            // 
            this.gpEliminar.Controls.Add(this.button4);
            this.gpEliminar.Controls.Add(this.button3);
            this.gpEliminar.Controls.Add(this.lblEliminar);
            this.gpEliminar.Location = new System.Drawing.Point(12, 238);
            this.gpEliminar.Name = "gpEliminar";
            this.gpEliminar.Size = new System.Drawing.Size(611, 229);
            this.gpEliminar.TabIndex = 4;
            this.gpEliminar.TabStop = false;
            this.gpEliminar.Text = "groupBox1";
            this.gpEliminar.Visible = false;
            this.gpEliminar.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 128);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(106, 54);
            this.button4.TabIndex = 4;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 128);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 54);
            this.button3.TabIndex = 3;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(35, 28);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(0, 25);
            this.lblEliminar.TabIndex = 1;
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.label1);
            this.gpCliente.Controls.Add(this.txtId);
            this.gpCliente.Controls.Add(this.button2);
            this.gpCliente.Controls.Add(this.button1);
            this.gpCliente.Location = new System.Drawing.Point(12, 12);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(611, 190);
            this.gpCliente.TabIndex = 5;
            this.gpCliente.TabStop = false;
            this.gpCliente.Text = "groupBox2";
            // 
            // ClienteEliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 465);
            this.Controls.Add(this.gpCliente);
            this.Controls.Add(this.gpEliminar);
            this.Name = "ClienteEliminar";
            this.Text = "ClienteEliminar";
            this.gpEliminar.ResumeLayout(false);
            this.gpEliminar.PerformLayout();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox gpEliminar;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
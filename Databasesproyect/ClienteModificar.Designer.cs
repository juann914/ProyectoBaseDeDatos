namespace Databasesproyect
{
    partial class ClienteModificar
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
            this.gpId = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gpCliente = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.gpId.SuspendLayout();
            this.gpCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpId
            // 
            this.gpId.Controls.Add(this.button2);
            this.gpId.Controls.Add(this.button1);
            this.gpId.Controls.Add(this.txtId);
            this.gpId.Controls.Add(this.label1);
            this.gpId.Location = new System.Drawing.Point(41, 28);
            this.gpId.Name = "gpId";
            this.gpId.Size = new System.Drawing.Size(700, 205);
            this.gpId.TabIndex = 0;
            this.gpId.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introdue el id del cliente a modificar :\r\n";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(395, 41);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(188, 29);
            this.txtId.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(395, 116);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gpCliente
            // 
            this.gpCliente.Controls.Add(this.button4);
            this.gpCliente.Controls.Add(this.button3);
            this.gpCliente.Controls.Add(this.lblNombre);
            this.gpCliente.Controls.Add(this.txtCorreo);
            this.gpCliente.Controls.Add(this.txtApellidos);
            this.gpCliente.Controls.Add(this.txtNombre);
            this.gpCliente.Controls.Add(this.label4);
            this.gpCliente.Controls.Add(this.label3);
            this.gpCliente.Controls.Add(this.label2);
            this.gpCliente.Location = new System.Drawing.Point(41, 256);
            this.gpCliente.Name = "gpCliente";
            this.gpCliente.Size = new System.Drawing.Size(710, 256);
            this.gpCliente.TabIndex = 1;
            this.gpCliente.TabStop = false;
            this.gpCliente.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellidos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Correo:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(131, 75);
            this.txtNombre.Multiline = true;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(241, 29);
            this.txtNombre.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(131, 114);
            this.txtApellidos.Multiline = true;
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(241, 29);
            this.txtApellidos.TabIndex = 5;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(131, 155);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(241, 29);
            this.txtCorreo.TabIndex = 6;
            this.txtCorreo.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(211, 31);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "Nombre:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(115, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 44);
            this.button3.TabIndex = 8;
            this.button3.Text = "Aceptar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 206);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 44);
            this.button4.TabIndex = 9;
            this.button4.Text = "Cancelar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // ClienteModificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 524);
            this.Controls.Add(this.gpCliente);
            this.Controls.Add(this.gpId);
            this.Name = "ClienteModificar";
            this.Text = "ClienteModificar";
            this.gpId.ResumeLayout(false);
            this.gpId.PerformLayout();
            this.gpCliente.ResumeLayout(false);
            this.gpCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.GroupBox gpCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
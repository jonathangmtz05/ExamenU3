namespace ExamenU3
{
    partial class Cambios
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.RichTextBox();
            this.txtdescripcion = new System.Windows.Forms.RichTextBox();
            this.txtnp = new System.Windows.Forms.RichTextBox();
            this.txtprecio = new System.Windows.Forms.RichTextBox();
            this.txtcantidad = new System.Windows.Forms.RichTextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.Actualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Precio";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stock";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 305);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Fecha Registro";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtid
            // 
            this.txtid.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtid.Location = new System.Drawing.Point(93, 53);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(125, 27);
            this.txtid.TabIndex = 6;
            this.txtid.Text = "";
            this.txtid.TextChanged += new System.EventHandler(this.txtid_TextChanged);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtdescripcion.Location = new System.Drawing.Point(202, 151);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(173, 27);
            this.txtdescripcion.TabIndex = 7;
            this.txtdescripcion.Text = "";
            this.txtdescripcion.TextChanged += new System.EventHandler(this.txtdescripcion_TextChanged);
            // 
            // txtnp
            // 
            this.txtnp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtnp.Location = new System.Drawing.Point(248, 93);
            this.txtnp.Name = "txtnp";
            this.txtnp.Size = new System.Drawing.Size(154, 27);
            this.txtnp.TabIndex = 8;
            this.txtnp.Text = "";
            this.txtnp.TextChanged += new System.EventHandler(this.txtnp_TextChanged);
            // 
            // txtprecio
            // 
            this.txtprecio.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtprecio.Location = new System.Drawing.Point(144, 210);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(213, 27);
            this.txtprecio.TabIndex = 9;
            this.txtprecio.Text = "";
            this.txtprecio.TextChanged += new System.EventHandler(this.txtprecio_TextChanged);
            // 
            // txtcantidad
            // 
            this.txtcantidad.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtcantidad.Location = new System.Drawing.Point(144, 258);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(213, 27);
            this.txtcantidad.TabIndex = 10;
            this.txtcantidad.Text = "";
            this.txtcantidad.TextChanged += new System.EventHandler(this.txtcantidad_TextChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(227, 305);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 22);
            this.dtpFecha.TabIndex = 11;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.Location = new System.Drawing.Point(43, 354);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(110, 35);
            this.Actualizar.TabIndex = 12;
            this.Actualizar.Text = "actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(170, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(269, 354);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(109, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cerrar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cambios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(439, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtprecio);
            this.Controls.Add(this.txtnp);
            this.Controls.Add(this.txtdescripcion);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Cambios";
            this.Text = "Cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox txtid;
        private System.Windows.Forms.RichTextBox txtdescripcion;
        private System.Windows.Forms.RichTextBox txtnp;
        private System.Windows.Forms.RichTextBox txtprecio;
        private System.Windows.Forms.RichTextBox txtcantidad;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
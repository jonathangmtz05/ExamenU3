namespace ExamenU3
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
            this.butinsertar = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.butPrueba = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // butinsertar
            // 
            this.butinsertar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butinsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butinsertar.Location = new System.Drawing.Point(25, 12);
            this.butinsertar.Name = "butinsertar";
            this.butinsertar.Size = new System.Drawing.Size(147, 33);
            this.butinsertar.TabIndex = 0;
            this.butinsertar.Text = "Insertar";
            this.butinsertar.UseVisualStyleBackColor = false;
            this.butinsertar.Click += new System.EventHandler(this.butinsertar_Click);
            // 
            // butSalir
            // 
            this.butSalir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSalir.Location = new System.Drawing.Point(193, 12);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(149, 33);
            this.butSalir.TabIndex = 1;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(866, 387);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // butPrueba
            // 
            this.butPrueba.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.butPrueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPrueba.Location = new System.Drawing.Point(369, 12);
            this.butPrueba.Name = "butPrueba";
            this.butPrueba.Size = new System.Drawing.Size(143, 33);
            this.butPrueba.TabIndex = 3;
            this.butPrueba.Text = "Prueba";
            this.butPrueba.UseVisualStyleBackColor = false;
            this.butPrueba.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(550, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "imprimir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.butPrueba);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butinsertar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Form1_Activated);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butinsertar;
        private System.Windows.Forms.Button butSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button butPrueba;
        private System.Windows.Forms.Button button1;
    }
}


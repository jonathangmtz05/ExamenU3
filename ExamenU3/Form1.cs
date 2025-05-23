using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenU2;

namespace ExamenU3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Actualizar()
        {
            Datos obj = new Datos();
            DataSet ds = new DataSet();
            ds = obj.consulta("SELECT ID, Nombre, Descripcion, Precio, Stock, FechaRegistro FROM Producto");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }
        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos obj = new Datos();
            bool f = obj.prueba();
            if (f)
            {
                MessageBox.Show("Conexion Exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexion");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cambios cam = new Cambios(
                dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString(),
                dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString()
            );
            cam.ShowDialog();
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void butinsertar_Click(object sender, EventArgs e)
        {
            Altas insertar = new Altas();
            insertar.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CrystalReport crystal = new CrystalReport();
            crystal.Show();
        }
    }
}

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
    public partial class Cambios : Form
    {
        public Cambios(string id, string nombre, string descripcion, string precio, string Stock,string dtp)
        {
            InitializeComponent();
            txtid.Text = id;
            txtnp.Text = nombre;
            txtdescripcion.Text = descripcion;
            txtprecio.Text = precio;
            txtcantidad.Text = Stock;
            dtpFecha.Text = dtp;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool f = datos.comando("UPDATE Producto SET Nombre = '"
                + txtnp.Text + "', Descripcion = '"
                + txtdescripcion.Text + "', Precio = "
                + txtprecio.Text + ", Stock = "
                + txtcantidad.Text + ", FechaRegistro = '"
                + dtpFecha.Value.ToString("yyyy-MM-dd") +
                "' WHERE ID = " + txtid.Text);
            if (f == true)
            {
                MessageBox.Show("Actualizado correctamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al actualizar");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos = new Datos();
            bool borrarProd = datos.comando("DELETE FROM Producto WHERE ID = " + txtid.Text);

            if (borrarProd)
            {
                MessageBox.Show("Producto borrado correctamente", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al borrar el producto", "SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtcantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnp_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

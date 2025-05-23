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
    public partial class Altas : Form
    {
        public Altas()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                Datos datos = new Datos();
                bool f = datos.comando("INSERT INTO Producto (Nombre, Descripcion, Precio, Stock, FechaRegistro) VALUES ('"
                    + txtnp.Text + "', '"
                    + txtdescripcion.Text + "', "
                    + txtprecio.Text + ", "
                    + txtcantidad.Text + ", '"
                    + dtpFecha.Value.ToString("yyyy-MM-dd") +
                    "')");
                if (f)
                {
                    MessageBox.Show("Insertado correctamente");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error al insertar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar: " + ex.Message);
            }
        }

        private void txtdescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtprecio_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

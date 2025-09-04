using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraH
{
    //
 
    public partial class Form1 : Form
    {
        //Lista para guardar el historial de operaicones
        List<Operacion> historial = new List<Operacion>();
        public Form1()
        {
            InitializeComponent();
        }

        //Metos para obtener numeros y validar
        private bool ObtenerNumeros(out double n1, out double n2)
        {
            n1 = 0;
            n2 = 0;
           

            if (string.IsNullOrWhiteSpace(txtNumero1.Text) || string.IsNullOrWhiteSpace(txtNumero2.Text))
            {
                MessageBox.Show("Por favor ingrese ambos numero.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            try
            {
                n1 = Convert.ToDouble(txtNumero1.Text);
                n2 = Convert.ToDouble(txtNumero2.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("Ingrese valores numericos validos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void ActualizarInterfaz()
        {
            dgvHistorial.DataSource = null;
            dgvHistorial.DataSource = historial;
            lbEstado.Text = "Operaciones realizadas: " + historial.Count;
        }
        private void sUMAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                double resultado = n1 + n2;
                lbResultado.Text = "Resultado: " + resultado;

                historial.Add(new Operacion { Numero1 = n1, Numero2 = n2, Tipo = "Suma", Resultado = resultado });
                ActualizarInterfaz();
            }
        }

        //Evento para resta
        private void rESTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                double resultado = n1 - n2;
                lbResultado.Text = "Resultado: " + resultado;

                historial.Add(new Operacion { Numero1 = n1, Numero2 = n2, Tipo = "Resta", Resultado = resultado });
                ActualizarInterfaz();
            }
        }

        //Evento para divison
        private void dIVISIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                if (n2 == 0)
                {
                    MessageBox.Show("No se puede dividir entre cero. ", " Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double resultado = n1 / n2;
                lbResultado.Text = "Resultado: " + resultado;

                historial.Add(new Operacion { Numero1 = n1, Numero2 = n2, Tipo = "Divison", Resultado = resultado });
                ActualizarInterfaz();
            }
        }

        //Evento para multiplicar
        private void mULTIPLICACIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ObtenerNumeros(out double n1, out double n2))
            {
                double resultado = n1 * n2;
                lbResultado.Text = "Resultado: " + resultado;

                historial.Add(new Operacion { Numero1 = n1, Numero2 = n2, Tipo = "Multipliacion", Resultado = resultado });
                ActualizarInterfaz();
            }
        }
    }
}

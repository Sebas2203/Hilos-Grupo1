using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hilos_Grupo1
{
    public partial class Proyecto_Hilos : Form
    {

        //array de numeros del 1 al 20
        double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        public Proyecto_Hilos()
        {
            InitializeComponent();
        }

        //Metodos de botones

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUNCIONA DE LA SIGUIENTE MANERA." +
                            "1. Se ejecutan los procesos uno por uno." +
                            "2. Se ejecutan por hilos de forma consecutiva.");
        }
        private void btnLimpiar_CLick(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.Columns.Clear();
                dataGridView2.Columns.Clear();
                dataGridView3.Columns.Clear();
                dataGridView4.Columns.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al limpiar los datos: " + ex.Message);
            }
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                ListaNumeros();
                Factorial();
                Potencia();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar los procesos: " + ex.Message);
            }
        }

        //datagriedView

        public void ListaNumeros()
        {
            dataGridView1.DataSource = numbers.Select(n => new { Number = n }).ToList();
        }

        public void Factorial()
        {
            var impares = numbers
                .Where(n => n % 2 != 0)
                .Select(n => new
                {
                    Factorial = $"{(int)n}! = {CalcularFactorial((int)n)}"
                })
                .ToList();

            dataGridView2.DataSource = impares;
        }

        private long CalcularFactorial(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }

        public void Potencia()
        {
            var pares = numbers
                .Where(n => n % 2 == 0)
                .Select(n => new
                {
                    Potencia = $"{n} ^ 2 = {Math.Pow(n, 2)}"
                })
                .ToList();

            dataGridView3.DataSource = pares;
        }

    }
}

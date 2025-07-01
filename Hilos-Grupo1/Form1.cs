using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hilos_Grupo1
{
    public partial class Proyecto_Hilos : Form
    {
        double[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
                              11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        Thread hiloPares;
        Thread hiloImpares;

        volatile bool paresTerminados = false;
        volatile bool imparesTerminados = false;

        public Proyecto_Hilos()
        {
            InitializeComponent();
        }

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("FUNCIONAMIENTO:\n" +
                            "1. Se ejecutan dos hilos en paralelo.\n" +
                            "2. Hilo 1 calcula potencias de pares.\n" +
                            "3. Hilo 2 calcula factoriales de impares.\n" +
                            "4. Muestra la tabla de multiplicar del número actual.");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
            dataGridView4.DataSource = null;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (!paresTerminados || !imparesTerminados)
            {
                MessageBox.Show("Alguno de los hilos sigue en ejecución. Espere que terminen.");
                return;
            }
            this.Close();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            paresTerminados = false;
            imparesTerminados = false;

            dataGridView1.DataSource = numbers.Select(n => new { Numero = n }).ToList();

            hiloPares = new Thread(Potencia);
            hiloImpares = new Thread(Factorial);

            hiloPares.Start();
            hiloImpares.Start();
        }

        public void Factorial()
        {
            var impares = numbers.Where(n => n % 2 != 0).ToList();
            var resultados = new DataTable();
            resultados.Columns.Add("Factorial", typeof(string));

            foreach (var n in impares)
            {
                long factorial = CalcularFactorial((int)n);
                string resultado = $"{(int)n}! = {factorial}";
                resultados.Rows.Add(resultado);

                MostrarTabla(n);
                ActualizarEstado(n, "Impar");
                Thread.Sleep(1000);
            }

            dataGridView2.Invoke((MethodInvoker)(() =>
            {
                dataGridView2.DataSource = resultados;
            }));

            imparesTerminados = true;

            this.Invoke((MethodInvoker)(() =>
            {
                MessageBox.Show("Proceso de impares terminado con éxito.");
            }));
        }

        public void Potencia()
        {
            var pares = numbers.Where(n => n % 2 == 0).ToList();
            var resultados = new DataTable();
            resultados.Columns.Add("Potencia", typeof(string));

            foreach (var n in pares)
            {
                double potencia = Math.Pow(n, 2);
                string resultado = $"{n} ^ 2 = {potencia}";
                resultados.Rows.Add(resultado);

                MostrarTabla(n);
                ActualizarEstado(n, "Par");
                Thread.Sleep(1000);
            }

            dataGridView3.Invoke((MethodInvoker)(() =>
            {
                dataGridView3.DataSource = resultados;
            }));

            paresTerminados = true;

            this.Invoke((MethodInvoker)(() =>
            {
                MessageBox.Show("Proceso de pares terminado con éxito.");
            }));
        }

        private long CalcularFactorial(int n)
        {
            long resultado = 1;
            for (int i = 2; i <= n; i++)
                resultado *= i;
            return resultado;
        }

        private void MostrarTabla(double numero)
        {
            var tabla = new DataTable();
            tabla.Columns.Add($"Tabla del {numero}", typeof(string));
            for (int i = 1; i <= 10; i++)
                tabla.Rows.Add($"{numero} x {i} = {numero * i}");

            dataGridView4.Invoke((MethodInvoker)(() =>
            {
                dataGridView4.DataSource = tabla;
            }));
        }

        private void ActualizarEstado(double numero, string tipo)
        {
            this.Invoke((MethodInvoker)(() =>
            {
                this.Text = $"Procesando: {numero} - {tipo} - Hilo ID: {Thread.CurrentThread.ManagedThreadId}";
            }));
        }
    }
}


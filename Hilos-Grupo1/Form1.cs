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

        private readonly object lockUI = new object();

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

        //boton salir 

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
            var resultados = new DataTable();
            resultados.Columns.Add("Factorial", typeof(string));

            for (int i = 0; i < numbers.Length; i++)
            {
                
                Thread.Sleep(1000);
                double n = numbers[i];
                if (n % 2 != 0)
                {
                    long factorial = CalcularFactorial((int)n);
                    string resultado = $"{(int)n}! = {factorial}";
                    resultados.Rows.Add(resultado);

                    ActualizarEstado(n, "Impar");
                    
                }
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
            var resultados = new DataTable();
            resultados.Columns.Add("Potencia", typeof(string));

            foreach (double n in numbers)
            {
                MostrarTabla(n);
                Thread.Sleep(1000);
                if (n % 2 == 0) // Si es par
                {
                    double potencia = Math.Pow(n, 2);
                    string resultado = $"{n} ^ 2 = {potencia}";
                    resultados.Rows.Add(resultado);

                    ActualizarEstado(n, "Par");
                }
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
            lock (lockUI)
                this.Invoke((MethodInvoker)(() =>
            {
                TXT_BOX_PSCNUM.Text = numero.ToString();
                TXT_BOX_PSCTIPO.Text = tipo;
                TXT_BOX_PSCHILO.Text = Thread.CurrentThread.ManagedThreadId.ToString();
            }));
        }
    }
}


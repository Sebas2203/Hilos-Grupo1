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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hilos_Grupo1
{
    public partial class Proyecto_Hilos : Form
    {

        //array de numeros del 1 al 20
        double[] Lista_numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
        //creacion de un temporizador e indice para generar tablas
        Timer temporizador;
        int indiceActual = 0;

        public Proyecto_Hilos()
        {
            InitializeComponent();
        }

        //Metodos de botones

        private void BtnAyuda_Click(object sender, EventArgs e)
        {
            string mensaje =
                            "FUNCIONAMIENTO:\n\n" +
                            "1️- Se ejecutan los procesos uno por uno.\n" +
                            "2️- Se ejecutan por hilos de forma consecutiva.\n\n" +
                            "Recuerde verificar cada proceso antes de continuar.";

            MessageBox.Show(
                mensaje,
                "Ayuda del Sistema",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
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
            {   //Se hace una instancia de la función timer que permite crear pausas en la ejecución del código funciona con MS.
                temporizador = new Timer();
                temporizador.Interval = 1000;//tiempo que dura cada pausa
                temporizador.Tick += Temporizador_Tick;
                temporizador.Start();
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
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.CurrentCell = null;
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dataGridView1.DataSource = Lista_numeros.Select(n => new { Numeros = n }).ToList();
        }

        public void Factorial()
        {
            var impares = Lista_numeros
                .Where(n => n % 2 != 0)
                .Select(n => new
                { 
                    Factorial = $"{(int)n} != {CalcularFactorial((int)n)}"
                })
                .ToList();

            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.MultiSelect = false;
            dataGridView2.RowHeadersVisible = false;
            dataGridView2.EnableHeadersVisualStyles = false;
            dataGridView2.CurrentCell = null;
            dataGridView2.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
            var pares = Lista_numeros
                .Where(n => n % 2 == 0)
                .Select(n => new
                {
                    Potencia = $"{n} ^ 2 = {Math.Pow(n, 2)}"
                })
                .ToList();
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.MultiSelect = false;
            dataGridView3.RowHeadersVisible = false;
            dataGridView3.EnableHeadersVisualStyles = false;
            dataGridView3.CurrentCell = null;
            dataGridView3.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView3.DataSource = pares;
        }

        //Metodo del temporizador
        private void Temporizador_Tick(object sender, EventArgs e)
        {
            if (indiceActual >= Lista_numeros.Length) //se utiliza el array como rango para el indice actual.
            {
                temporizador.Stop();
                return;
            }

            Generartablas(Lista_numeros[indiceActual]);
            indiceActual++;
        }
        
        public void Generartablas(double numero)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add($"Tabla del {numero}", typeof(string));

            for (int i = 1; i <= 10; i++)
            {
                DataRow fila = dt.NewRow();
                double resultado = numero * i;
                fila[0] = $"{numero} * {i:D2} = {resultado:000}";
                dt.Rows.Add(fila);
            }

            // Mostrar en DataGridView
            dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView4.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView4.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView4.MultiSelect = false;
            dataGridView4.RowHeadersVisible = false;
            dataGridView4.EnableHeadersVisualStyles = false;
            dataGridView4.CurrentCell = null;
            dataGridView4.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView4.DataSource = dt;
        }

    }
}

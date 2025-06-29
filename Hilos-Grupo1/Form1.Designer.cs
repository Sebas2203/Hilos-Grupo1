namespace Hilos_Grupo1
{
    partial class Form1
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
            this.lbProcesandoNumero = new System.Windows.Forms.Label();
            this.lbProcesandoHilo = new System.Windows.Forms.Label();
            this.lbTipo = new System.Windows.Forms.Label();
            this.lbTipoNumEnt = new System.Windows.Forms.Label();
            this.lbFactorialNumImpares = new System.Windows.Forms.Label();
            this.lbPotenciasNumPares = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEjecutar = new System.Windows.Forms.Button();
            this.lbResultado1 = new System.Windows.Forms.Label();
            this.lbResultado2 = new System.Windows.Forms.Label();
            this.lbResultado3 = new System.Windows.Forms.Label();
            this.lbResultado4 = new System.Windows.Forms.Label();
            this.lbResultProcesandoNum = new System.Windows.Forms.Label();
            this.lbResProcesandoHilo = new System.Windows.Forms.Label();
            this.lbResTipo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbProcesandoNumero
            // 
            this.lbProcesandoNumero.AutoSize = true;
            this.lbProcesandoNumero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcesandoNumero.Location = new System.Drawing.Point(12, 32);
            this.lbProcesandoNumero.Name = "lbProcesandoNumero";
            this.lbProcesandoNumero.Size = new System.Drawing.Size(158, 20);
            this.lbProcesandoNumero.TabIndex = 0;
            this.lbProcesandoNumero.Text = "Procesando Número:";
            this.lbProcesandoNumero.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbProcesandoHilo
            // 
            this.lbProcesandoHilo.AutoSize = true;
            this.lbProcesandoHilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProcesandoHilo.Location = new System.Drawing.Point(12, 71);
            this.lbProcesandoHilo.Name = "lbProcesandoHilo";
            this.lbProcesandoHilo.Size = new System.Drawing.Size(129, 20);
            this.lbProcesandoHilo.TabIndex = 1;
            this.lbProcesandoHilo.Text = "Procesando Hilo:";
            // 
            // lbTipo
            // 
            this.lbTipo.AutoSize = true;
            this.lbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipo.Location = new System.Drawing.Point(398, 39);
            this.lbTipo.Name = "lbTipo";
            this.lbTipo.Size = new System.Drawing.Size(43, 20);
            this.lbTipo.TabIndex = 2;
            this.lbTipo.Text = "Tipo:";
            // 
            // lbTipoNumEnt
            // 
            this.lbTipoNumEnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTipoNumEnt.Location = new System.Drawing.Point(52, 114);
            this.lbTipoNumEnt.Name = "lbTipoNumEnt";
            this.lbTipoNumEnt.Size = new System.Drawing.Size(100, 70);
            this.lbTipoNumEnt.TabIndex = 3;
            this.lbTipoNumEnt.Text = "Lista de Números Enteros";
            this.lbTipoNumEnt.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbFactorialNumImpares
            // 
            this.lbFactorialNumImpares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactorialNumImpares.Location = new System.Drawing.Point(209, 114);
            this.lbFactorialNumImpares.Name = "lbFactorialNumImpares";
            this.lbFactorialNumImpares.Size = new System.Drawing.Size(100, 65);
            this.lbFactorialNumImpares.TabIndex = 4;
            this.lbFactorialNumImpares.Text = "Factorial de Números Impares";
            this.lbFactorialNumImpares.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbPotenciasNumPares
            // 
            this.lbPotenciasNumPares.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPotenciasNumPares.Location = new System.Drawing.Point(357, 114);
            this.lbPotenciasNumPares.Name = "lbPotenciasNumPares";
            this.lbPotenciasNumPares.Size = new System.Drawing.Size(125, 60);
            this.lbPotenciasNumPares.TabIndex = 5;
            this.lbPotenciasNumPares.Text = "Potencias de Números Pares";
            this.lbPotenciasNumPares.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(517, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 60);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tablas de Números";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(509, 415);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(97, 23);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnEjecutar
            // 
            this.btnEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjecutar.Location = new System.Drawing.Point(402, 415);
            this.btnEjecutar.Name = "btnEjecutar";
            this.btnEjecutar.Size = new System.Drawing.Size(93, 23);
            this.btnEjecutar.TabIndex = 8;
            this.btnEjecutar.Text = "Ejecutar";
            this.btnEjecutar.UseVisualStyleBackColor = true;
            // 
            // lbResultado1
            // 
            this.lbResultado1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbResultado1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado1.ForeColor = System.Drawing.SystemColors.Control;
            this.lbResultado1.Location = new System.Drawing.Point(24, 196);
            this.lbResultado1.Name = "lbResultado1";
            this.lbResultado1.Size = new System.Drawing.Size(141, 215);
            this.lbResultado1.TabIndex = 9;
            // 
            // lbResultado2
            // 
            this.lbResultado2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbResultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado2.ForeColor = System.Drawing.SystemColors.Control;
            this.lbResultado2.Location = new System.Drawing.Point(171, 196);
            this.lbResultado2.Name = "lbResultado2";
            this.lbResultado2.Size = new System.Drawing.Size(141, 215);
            this.lbResultado2.TabIndex = 10;
            // 
            // lbResultado3
            // 
            this.lbResultado3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbResultado3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado3.ForeColor = System.Drawing.SystemColors.Control;
            this.lbResultado3.Location = new System.Drawing.Point(318, 196);
            this.lbResultado3.Name = "lbResultado3";
            this.lbResultado3.Size = new System.Drawing.Size(141, 215);
            this.lbResultado3.TabIndex = 11;
            // 
            // lbResultado4
            // 
            this.lbResultado4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbResultado4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultado4.ForeColor = System.Drawing.SystemColors.Control;
            this.lbResultado4.Location = new System.Drawing.Point(465, 196);
            this.lbResultado4.Name = "lbResultado4";
            this.lbResultado4.Size = new System.Drawing.Size(141, 215);
            this.lbResultado4.TabIndex = 12;
            // 
            // lbResultProcesandoNum
            // 
            this.lbResultProcesandoNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResultProcesandoNum.Location = new System.Drawing.Point(176, 29);
            this.lbResultProcesandoNum.Name = "lbResultProcesandoNum";
            this.lbResultProcesandoNum.Size = new System.Drawing.Size(100, 23);
            this.lbResultProcesandoNum.TabIndex = 13;
            // 
            // lbResProcesandoHilo
            // 
            this.lbResProcesandoHilo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResProcesandoHilo.Location = new System.Drawing.Point(176, 68);
            this.lbResProcesandoHilo.Name = "lbResProcesandoHilo";
            this.lbResProcesandoHilo.Size = new System.Drawing.Size(100, 23);
            this.lbResProcesandoHilo.TabIndex = 14;
            // 
            // lbResTipo
            // 
            this.lbResTipo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResTipo.Location = new System.Drawing.Point(447, 36);
            this.lbResTipo.Name = "lbResTipo";
            this.lbResTipo.Size = new System.Drawing.Size(100, 23);
            this.lbResTipo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 450);
            this.Controls.Add(this.lbResTipo);
            this.Controls.Add(this.lbResProcesandoHilo);
            this.Controls.Add(this.lbResultProcesandoNum);
            this.Controls.Add(this.lbResultado4);
            this.Controls.Add(this.lbResultado3);
            this.Controls.Add(this.lbResultado2);
            this.Controls.Add(this.lbResultado1);
            this.Controls.Add(this.btnEjecutar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbPotenciasNumPares);
            this.Controls.Add(this.lbFactorialNumImpares);
            this.Controls.Add(this.lbTipoNumEnt);
            this.Controls.Add(this.lbTipo);
            this.Controls.Add(this.lbProcesandoHilo);
            this.Controls.Add(this.lbProcesandoNumero);
            this.Name = "Form1";
            this.Text = "Operaciones con Hilos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProcesandoNumero;
        private System.Windows.Forms.Label lbProcesandoHilo;
        private System.Windows.Forms.Label lbTipo;
        private System.Windows.Forms.Label lbTipoNumEnt;
        private System.Windows.Forms.Label lbFactorialNumImpares;
        private System.Windows.Forms.Label lbPotenciasNumPares;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEjecutar;
        private System.Windows.Forms.Label lbResultado1;
        private System.Windows.Forms.Label lbResultado2;
        private System.Windows.Forms.Label lbResultado3;
        private System.Windows.Forms.Label lbResultado4;
        private System.Windows.Forms.Label lbResultProcesandoNum;
        private System.Windows.Forms.Label lbResProcesandoHilo;
        private System.Windows.Forms.Label lbResTipo;
    }
}


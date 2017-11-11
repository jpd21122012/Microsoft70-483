using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace AppHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        delegate void CambiarProgresoHandler(int valor);
        void CambiarProgreso(int valor)
        {
            if (this.InvokeRequired)
            {
                CambiarProgresoHandler del = new CambiarProgresoHandler(CambiarProgreso);
                object[] param = new object[] { valor};
                this.Invoke(del,param);
            }
            else
            {
                progressBar1.Value = valor;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            //CambiarProgreso(50);
            Thread hilo = new Thread(new ThreadStart(correrProceso));
            hilo.Start();
        }
        void correrProceso()
        {
            //CheckForIllegalCrossThreadCalls = false;

            for (int i = 1; i <= progressBar1.Maximum; i++)
            {
                Thread.Sleep(200);
                CambiarProgreso(i);
            }
            Console.WriteLine("Proceso Finalizado");
        }

        private void btnMensaje_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mensaje !!!");
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Musica;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Instrumento ins;
        public Vehiculo ve;
        public IFuncion fun;
        public Form1()
        {
            ins = new Guitarra();
            ve = new Vehiculo();
            fun = new Vehiculo();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show(ve.Encender());
            MessageBox.Show(fun.Encender());
            //ins = new Violin();
            //MessageBox.Show(ins.Tocar());
        }
    }
}
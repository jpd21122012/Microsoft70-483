using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Presentation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Assembly assembly = Assembly.LoadFile(Application.StartupPath + "\\AssemblyLibrary.dll");
            Type[] type = assembly.GetTypes();
            foreach (Type item in type)
            {
                if (item.IsClass)
                {
                    lstClasses.Items.Add(item.ToString());
                    var fieldInfo = item.GetField(item.ToString());

                }
            }
            System.Threading.Thread.Sleep(2000);
            FieldInfo[] field = type[0].GetFields();
            foreach (var item in field)
            {
                lstAttributes.Items.Add(item.Name);
            }
        }
    }
}
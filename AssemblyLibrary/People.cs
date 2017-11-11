using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssemblyLibrary
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public People(string name)
        {
            this.Name = name;
        }
        public void Greet()
        {
            MessageBox.Show("Hello");
        }
        public void Greet(string name)
        {
            MessageBox.Show("Hello " + name);
        }
    }
    public class Human
    {
        public char Gender { get; set; }
        public bool State { get; set; }
        public string Name()
        {
            return "Man";
        }
    }
    public enum Names
    {
        Juan, Pedro, Andreu
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    class Program
    {
        /// <summary>
        /// Delegado: Es un apuntador a una funcion, es un tipo de dato, almacena
        /// direcciones de memoria
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i;
            i = 10;
            string s;
            s = "hola mundo";
            Money m;
            m = null;
            Product p;
            p = new Product();
            OutOfMoneyHandler handler;
            handler = ShowMessage;
            ShowMessageHandler sms;
            sms = ShowMessage;
            sms += ShowMessage;
            sms.Invoke();
            sms();
        }
        static void ShowMessage()
        {
            Console.WriteLine("Hello, world!");
        }
        static void ShowMessage(string message) {
            Console.WriteLine(message);
        }
        static void ShowMessage(Money message,EventArgs e)
        {
            Console.WriteLine(message);
        }

        delegate void ShowMessageHandler();
        delegate void ShowMessageHandler2(string s);
        public delegate void OutOfMoneyHandler(Money money, EventArgs args);

     //public void HandleOutOfMoney(delegate OutOfBeansHandler) { }
     public void HandleOutOfMoney(Money c, EventArgs e) { }
     //public Money HandleOutOfMoney(EventArgs e)
     //public Money HandleOutOfMoney(Money money, EventArgs args) { }
     public void HandleOutOfMoney1(Money m, EventArgs e) { }
}
    class Product { }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FristProjectPipline
{
    internal class Program
    {
        public void Add()
        {
            int a, b, c;
            a = 10;
            b = 20;
            c = a + b;
            Console.WriteLine("Addition=" +c);
        }
        public void Sub()
        {
            int a, b, c;
            a = 50;
            b = 20;
            c = a - b;
            Console.WriteLine("Sub=" + c);
        }
        static void Main(string[] args)
        {
            Program p= new Program();   
            p.Add();
            p.Sub();
            Console.ReadLine();
        }
    }
}

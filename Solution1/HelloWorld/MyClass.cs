using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class MyClass
    {
        private string text;

        public MyClass(string text)
        {
            this.text = text;
        }

        public void printText()
        {
            Console.WriteLine(text);
        }
    }
}

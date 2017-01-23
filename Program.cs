using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication6
{
    class shapes
    {
        private int width, height;
        public void rectangle(int width,int height)
        {
            this.width = width;
            this.height = height;
        }

        public void square(int width)
        {
            this.width = width;
        }

        public void circle(int width)
        {
            this.width = width;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter the shape to be added");
            string userinput=Console.ReadLine();
            if(userinput=="Rectangle")
            {
                shapes input = new shapes();
                Console.WriteLine("Enter the width");
                input.rectangle=Console.ReadLine()
            }

        }
    }
}

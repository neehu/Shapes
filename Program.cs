using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;



namespace ConsoleApplication6
{
    class shapes
    {
        private int width, height;
        public void rectangle(int width, int height)
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
        public void display(string user, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write("The size of the {0} is {1}x{2}",user, width, height);
        }

        static void Main(string[] args)
        {
            int x, y,width,height;
            Console.WriteLine("Enter the location");
            x = Convert.ToInt32(Console.ReadLine());
            y = Convert.ToInt32(Console.ReadLine());
            shapes input = new shapes();
            Console.WriteLine("Enter the shape to be added");
            Console.WriteLine("Rectangle,Circle,Square");
            string userinput = Console.ReadLine();
            if (userinput == "Rectangle")
            {

                Console.WriteLine("Enter the width and height");
                width = (Convert.ToInt32(Console.ReadLine()));
                height=(Convert.ToInt32(Console.ReadLine()));
                input.rectangle(width, height);
            }

            if (userinput == "Circle")
            {

                Console.WriteLine("Enter the width");
                width=(Convert.ToInt32(Console.ReadLine()));
                input.circle(width);
            }

            if (userinput == "Square")
            {

                Console.WriteLine("Enter the width");
                height=(Convert.ToInt32(Console.ReadLine()));
                input.square(height);
            }
            input.display(userinput, x, y);
            Console.ReadKey();
        }
    }

}
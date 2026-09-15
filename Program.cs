using System;
using System.Security.Cryptography.X509Certificates;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine($"The current time is {DateTime.Now}");
            Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ... \n");
            Console.WriteLine("Invoice: 1021\t\tComplete!");
            Console.WriteLine("Invoice: 1022\t\tComplete!");
            Console.Write("\nOutput Directory:\t");
            Console.Write(@"c:\invoices");
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            // User command to run an application
            Console.WriteLine(@"c:\invoices\app.exe -j");

            string projectName = "ACME";

            string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";
            Console.WriteLine("indows" + 1 + 1);
            Console.WriteLine(5 / 10);
            int result = 3 + 1 * 5 / 2;
            Console.WriteLine($"Result: {result}");
            Console.Write("\n\nView English output: \n\t");
            Console.WriteLine(@$"c:Exercise\{projectName}\data.txt");
            Console.Write($"\n\n{russianMessage}: \n\t");
            Console.WriteLine(@$"c:\Exercise\{projectName}\ru-Ru\data.txt");

            */

            House jonsonHome = new House();
            jonsonHome._kitchen = new Blind();
            jonsonHome._livingRoom = new Blind();


            House johnsonHome = new House();
            johnsonHome._owner = "Johnson Family";
            johnsonHome._kitchen._color = "White";
            johnsonHome._kitchen._width = 2.5;
            johnsonHome._kitchen._height = 1.5;

            johnsonHome._livingRoom._color = "white";
            johnsonHome._livingRoom._height = 3.5;
            johnsonHome._livingRoom._width = 4.5;

            Console.WriteLine("Johnson Family's Kitchen Blind:");
            johnsonHome._kitchen.Display();
            Console.WriteLine("Johnson Family's Living Room Blind:");
            johnsonHome._livingRoom.Display();







        }

    }


    public class Blind
    {
        public string _color = "";
        public double _width;
        public double _height;



        public double GetArea()
        {
            return _height * _width;
        }

        public void Display()
        {
            Console.WriteLine($"color: \t{_color}");
            Console.WriteLine($"area: \t{GetArea()}");
        }



    }

    public class House
    {
        public string _owner = "";
        public Blind _kitchen = new Blind();
        public Blind _livingRoom = new Blind();


    }



}
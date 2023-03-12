using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //Bai 2.1
            //Point point1 = new Point();
            //Console.WriteLine("Nhap vao toa do 2 diem (x, y):");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //Point point2 = new Point(x, y);
            //Console.WriteLine("Toa do diem A: ({0}, {1})", point1.x, point1.y);
            //Console.WriteLine("Toa do diem B: ({0}, {1})", point2.x, point2.y);
            //Console.WriteLine("Khoang cach giua hai diem A va B: " + point1.Distance(point2));

            //Bai 2.2
            //Circle circle = new Circle();
            //Console.WriteLine("Chu vi duong tron: " +  circle.GetPerimeter());
            //Console.WriteLine("Dien tich duong tron: " + circle.GetArea());
            //Console.WriteLine("Nhap vao ban kinh:");
            //int r = Convert.ToInt32(Console.ReadLine());
            //circle.SetRadius(r);
            //Console.WriteLine("Ban kinh duong tron: " + circle.GetRadius());
            //Console.WriteLine("Chu vi duong tron: " + circle.GetPerimeter());
            //Circle circle2 = new Circle(10);
            //Console.WriteLine("Ban kinh duong tron 2: " + circle2.GetRadius());
            //Console.WriteLine("Chu vi duong tron 2: " + circle2.GetPerimeter());
            //Console.WriteLine("Ban kinh duong tron 2: " + circle2.GetArea());

            //Bai 2.3
            Chuoi chuoi = new Chuoi("Ta Huynh Dat", 10, 10, 12, 0);
            chuoi.MoveString();
                

            //Bai 2.4
            //Adult adult = new Adult();
            //adult.Read();
            //adult.Print();
            //adult.HealthStatus();

            //Bai 2.5
            //Student student = new Student();
            //student.Read();
            //student.Write();

            //Bai 2.6
            //Time time = new Time();
            //time.NextSecond();
            //Console.WriteLine("{0}:{1}:{2}", time.getHour(), time.getMinute(), time.getSecond());
            //Time time1 = new Time(3, 45, 0);
            //time1.PreviousSecond();
            //time1.Show();
            
            Console.ReadKey();
        }
    }
}

using System;
using static System.Math;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Adult
    {
        private string name;
        private int weight;
        private int height;
        public Adult() { this.name = ""; this.weight = 0; this.height = 0; }
        public Adult(string name, int weight, int height)
        {
            this.name = name;
            this.weight = weight;
            this.height = height;
        }
        public Adult(Adult adult) { this.name = adult.name; this.weight = adult.weight; this.height = adult.height; }
        public float BMI()
        {
            return (float)this.weight / ((float)this.height/100 * (float)this.height/100);
        }
        public void Read()
        {
            Console.WriteLine("Nhập họ và tên:");
            this.name = Console.ReadLine();
            Console.WriteLine("Nhập cân nặng (kg):");
            this.weight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập chiều cao (cm):");
            this.height = Convert.ToInt32(Console.ReadLine());
        }
        public void Print()
        {
            Console.WriteLine("Họ và tên: " + this.name);
            Console.WriteLine("Cân nặng (kg): " + this.weight);
            Console.WriteLine("Chiều cao (cm): " + this.height);
            Console.WriteLine("Chỉ số BMI: " + this.BMI());
        }
        public void HealthAdvice(float BMI)
        {
            float newWeight = this.weight;
            if(BMI < 18.5) newWeight = 18.5f * ((float)this.height/100 * (float)this.height/100);
            else newWeight = 25f * ((float)this.height / 100 * (float)this.height / 100);
            Console.WriteLine("Bạn cần {0} thêm {1} kg để có sức khỏe tốt!", (newWeight>this.weight?"tăng":"giảm"),(Abs(newWeight-(float)this.weight)));
        }
        public void HealthStatus()
        {
            float BMI = this.BMI();
            Console.Write("Tình trạng sức khỏe: ");
            if (BMI < 18.5f) Console.WriteLine("Thiếu cân");
            else if (18.5f <= BMI && BMI <= 25) Console.WriteLine("Bình thường (sức khỏe tốt)");
            else if (25 < BMI && BMI < 30) Console.WriteLine("Thừa cân");
            else Console.WriteLine("Béo phì");
            if (BMI < 18.5f || BMI > 25) this.HealthAdvice(BMI);
        }
    }
}

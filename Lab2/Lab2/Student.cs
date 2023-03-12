using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        public string id;
        public string name;
        public string birthday;
        public string gender;
        public Student() { this.id = ""; this.name = ""; this.birthday = ""; this.gender = ""; }
        public Student(string id, string name, string birthday, string gender) 
        {
            this.id = id;
            this.name = name;
            this.birthday = birthday;   
            this.gender = gender;
        }
        public Student(Student student)
        {
            this.id = student.id;
            this.name = student.name;
            this.birthday = student.birthday;
            this.gender = student.gender;  
        }
        public void Read()
        {
            Console.WriteLine("Nhập vào ID, Họ và tên, ngày sinh, giới tính của sinh viên: ");
            this.id = Console.ReadLine();
            this.name = Console.ReadLine();
            this.birthday= Console.ReadLine();
            this.gender = Console.ReadLine();
        }
        public void Write()
        {
            Console.WriteLine(this.id + '\n' + this.name + '\n' + this.birthday + '\n' + this.gender);
        }
    }
}

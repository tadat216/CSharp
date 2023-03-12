using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Chuoi
    {
        string s;
        int x, y;
        public Chuoi() { this.s = "a"; this.x = 0; this.y = 0; }
        public Chuoi(string s, int x, int y, int backgroundColor, int foreColor)
        {
            this.s = s;
            this.x = x;
            this.y = y;
            Console.BackgroundColor = (ConsoleColor)backgroundColor;
            Console.Clear();
            Console.ForegroundColor = (ConsoleColor)foreColor;
        }
        public void MoveUp() { this.y--; }
        public void MoveDown() { this.y++; }
        public void MoveLeft() { this.x--; }
        public void MoveRight() { this.x++; }
        public void MoveString()
        { 
            Console.CursorVisible = false;
            this.Show();
            ConsoleKey key;
            do
            {
                key = Console.ReadKey().Key;
                if (key == ConsoleKey.UpArrow && this.y > 0) this.MoveUp();
                else if(key == ConsoleKey.DownArrow && this.y <= Console.WindowHeight) this.MoveDown();
                else if (key == ConsoleKey.LeftArrow && this.x > 0) this.MoveLeft();
                else if (key == ConsoleKey.RightArrow && this.x < Console.WindowWidth-1) this.MoveRight();
                
                this.Show();
            }while(key != ConsoleKey.Escape);
        }
        public void Show()
            {
                Console.Clear();
                Console.SetCursorPosition(this.x, this.y);
                Console.WriteLine(this.s);
            }
        }
}

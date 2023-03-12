using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Time
    {
        private int hour, minute, second;
        public Time() { this.hour = 0; this.minute = 0; this.second = 0; }
        public Time(int hour, int minute, int second)
        {
            this.hour = hour;
            this.minute = minute;
            this.second = second;
        }
        public int getHour() { return this.hour; }   
        public int getMinute() { return this.minute; }   
        public int getSecond() { return this.second; }
        public void NextSecond() 
        {
            if (this.second < 59) this.second++;
            else if(this.second == 59 && this.minute < 59) { this.minute++; this.second = 0; }
            else if(this.second == 59 && this.minute == 59) { this.hour++; this.minute = 0; this.second = 0; }
            if (this.hour == 24) this.hour = 0;
        }
        public void PreviousSecond()
        {
            if(this.second > 0) this.second--;
            else if(this.second == 0 && this.minute > 0) { this.minute--; this.second = 59; }
            else if(this.second == 0 && this.minute == 0) { this.hour--; this.minute = this.second = 59; }
            if(this.hour == -1) this.hour = 23;
        }
        public void Show()
        {
            Console.WriteLine("{0}:{1}:{2}", this.hour, this.minute, this.second);
        }
    }
}

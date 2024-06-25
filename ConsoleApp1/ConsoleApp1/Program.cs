using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static  void Main()
        {
            Student x = new Student("Ziad");
            x.PrintInfo();
            x.Name = "Malik";

        }
    }
    class Student
    {
        public string Name { get;  set; }
        public float Score { get; private set; }
        public Student(string name) : this(name, 0) { Console.Write(1); }
        public Student(string name, float score)
        {
            Name = name;
            Score = score;
            Console.Write(2);
        }
        public void PrintInfo()
        {
            Console.WriteLine("{0}:\t{1}", Name, Score);
        }

        
    }
}

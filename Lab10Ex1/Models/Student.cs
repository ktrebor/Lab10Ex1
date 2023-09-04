using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab10Ex1.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }

        public Major major { get; set; }

        public override string ToString() => $"{Id} | {firstName} {lastName} | {age} | {major}";
    }
}

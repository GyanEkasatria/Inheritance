using System;
using System.Collections.Generic;
using System.Text;

namespace Tugas4
{
    public class Student : Person
    {
        public Student(string person, int age, string studentId, string email) :
        base (person, age)
        {
            StudentId = studentId;
            Email = email;
        }
        public string StudentId { get; set; }
        public string Email { get; set; }
    }
}

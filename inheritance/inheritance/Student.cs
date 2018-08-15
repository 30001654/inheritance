using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance
{
    class Student : Person
    {
        public int StudentId { get; set; }

        public Student(string _fname, string _lname, int _stdid)
        {
            Fname = _fname;
            Lname = _lname;
            StudentId = _stdid;
        }

        public string GetStudentDeets()
        {
            return $"First Name: {Fname}\n Last Name: {Lname}\n Student ID: {StudentId}\n";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enrolment4
{
    class Institute
    {
        private static List<Student> _studentList = new List<Student>();
        public static List<Student> StudentList { get => _studentList; private set => _studentList = value; }
        public static decimal TotalBalance()
        {
            decimal total = 0;
            foreach (Student student in _studentList)
            {
                total += student.Balance;
            }
            return total;
        }
    }
}

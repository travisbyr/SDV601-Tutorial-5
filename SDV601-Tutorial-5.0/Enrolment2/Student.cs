using System;

namespace Enrolment2
{
    public class Student
    {
        private string _id;
        private string _name;
        private DateTime _dateOfBirth = DateTime.Today;
        private decimal _balance;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public decimal Balance { get => _balance; set => _balance = value; }

        public override string ToString()
        {
            return _id + "\n" + _name;
        }
    }
}
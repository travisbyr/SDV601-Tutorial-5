using System;

namespace Enrolment4
{
    public abstract class Student
    {
        private static String[] studentType = { "Domestic", "International" };
        private string _id;
        private string _name;
        private DateTime _dateOfBirth = DateTime.Today;
        private decimal _balance;

        public string ID { get => _id; set => _id = value; }
        public string Name { get => _name; set => _name = value; }
        public DateTime DateOfBirth { get => _dateOfBirth; set => _dateOfBirth = value; }
        public decimal Balance { get => _balance; set => _balance = value; }
        public static string[] StudentType { get => studentType; set => studentType = value; }

        public override string ToString()
        {
            return _id + "\n" + _name;
        }

        public static Student NewStudent(int choice)
        {
            if (choice == 0)
            {
                return new DomesticStudent();
            }
            else
            {
                return new InternationalStudent();
            }
        }

        public abstract bool ViewEdit();

        public abstract string TypeOfStudent();
    }
}
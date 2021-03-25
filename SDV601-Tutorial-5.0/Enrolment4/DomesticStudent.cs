namespace Enrolment4
{
    class DomesticStudent : Student
    {
        private static DomesticStudentForm _form = new DomesticStudentForm();
        private decimal _loanAmount;
        private bool _fullTime;

        public override bool ViewEdit()
        {
            return _form.ShowDialog(this);
        }

        public decimal LoanAmount { get => _loanAmount; set => _loanAmount = value; }
        public bool FullTime { get => _fullTime; set => _fullTime = value; }

        public override string ToString()
        {
            return ID + "\t" + Name + "\t" + TypeOfStudent();
            //return base.ToString() +"\nLoan: " + LoanAmount.ToString() + "\nFull Time: "+ FullTime.ToString();
        }

        public override string TypeOfStudent()
        {
            return "Domestic";
        }
    }
}

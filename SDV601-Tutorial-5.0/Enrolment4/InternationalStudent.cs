namespace Enrolment4
{
    class InternationalStudent : Student
    {
        private string _country;
        private float _itelsScore;
        private static InternationalStudentForm _form = new InternationalStudentForm();
        public override bool ViewEdit()
        {
            return _form.ShowDialog(this);
        }
        public float ItelsScore { get => _itelsScore; set => _itelsScore = value; }
        public string Country { get => _country; set => _country = value; }

        public override string ToString()
        {
            //return base.ToString() + "\nCountry: " + Country + "\nIELTS Score: " + ItelsScore.ToString();
            return ID + "\t" + Name + "\t" + TypeOfStudent();
        }

        public override string TypeOfStudent()
        {
            return "International";
        }

    }
}

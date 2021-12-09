namespace DEMOADAPTER
{
    public class TopupStudent : Student
    {
        public int Score { get; set; }

        public TopupStudent()
        {
            
        }

        public TopupStudent(string first, string last) : base(first, last)
        {
           
        }
        public override string GetGrade()
        {
            if (Score < 40) return "Fail";
            else if (Score < 60) return "Pass";
            else if (Score < 80) return " Merit";
            else return "Distinction";
        }
}
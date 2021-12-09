namespace DEMOADAPTER
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            // add some students of different type
            TopupStudent s1 = new TopupStudent("John", "Lenon", 80);
            TopupStudent s2 = new TopupStudent("Paul", "Newman", 60);

            BTECStudent s3 = new BTECStudent("Mike", "Tyson", "Districntion");

            StudentAdapter s4 = new StudentAdapter("Le Hoang", 8.5, 7.0);

            students.Add(s1);
            students.Add(s2);  
            students.Add(s3);
            students.Add(s4);

            foreach(Student s in students)
            {
                System.Console.WriteLine(s);
            }

        }
    }
}
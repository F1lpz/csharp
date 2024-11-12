namespace cvicenie_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<student> students = new List<student>();
            {
                new student() { name = "anna", age = 20 };
                new student() { name = "jacob", age = 22 };
                new student() { name = "paul", age = 18 };
            }
            List<student> tinedzeriStudenti = students.Where(student => student.name.Contains("anna")).ToList();

            foreach (student student in tinedzeriStudenti)
            {
                Console.WriteLine($"LINQ:Student,{student.name} ma {student.age} a je tineger.");



            }
        }
    }
}
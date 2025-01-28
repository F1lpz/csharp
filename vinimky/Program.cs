using System.Data;

namespace vinimky
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var data = File.ReadAllLines("studenti.csv");
            var students = new List<student>();
            foreach ( var row in data.Skip(1))
            {
                var splits = row.Split(',');
                var newstudent = new student(splits[1], splits[2], int.Parse(splits[3]), "I.AI");
                students.Add(newstudent);
            }
            var aaa = 5;

        }
    }
}

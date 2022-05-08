namespace CSharpPractice;

class ForAndForEachLoop
{
    static void Main(string[] args)
    {
        int tableOf = 5;
        for(int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{tableOf} * {i} = {tableOf * i}");
        }

        Console.WriteLine();
        Console.WriteLine();

        List<Student> students = new List<Student>();
        students.Add(new Student() { Id = 101, Name = "John"});
        students.Add(new Student() { Id = 102, Name = "Paul"});
        students.Add(new Student() { Id = 103, Name = "Ben"});

        Console.WriteLine("USING FOR LOOP");
        for(int i = 0; i < students.Count; i++)
        {
            Console.WriteLine($"Student Roll No. {students[i].Id}, Name: {students[i].Name}");
        }

        Console.WriteLine();
        Console.WriteLine("USING FOREACH LOOP"); // Best practice to use when using list
        foreach (Student student in students)
        {
            Console.WriteLine($"Student Roll No. {student.Id}, Name: {student.Name}");
        }
    }
}

class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}


Console.WriteLine("hello world");

var student = new StudentStorageService();

var result1 = student.FilterStudent();

var result2 = student.LINQFilterStudent();

var result3 = student.PLINQFilterStudent();

foreach (var item in result1)
{
    Console.WriteLine(item.Name);
}


foreach (var item in result2)
{
    Console.WriteLine(item.Name);
}



foreach (var item in result3)
{
    Console.WriteLine(item);
}

public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Course { get; set; }

    public DateTime DateOfBirth { get; set; }

    public static List<Student> GetStudentList()
    {
        return new List<Student>()
            {
                new Student()
                {
                    Name = "Минаков К.Р.",
                    Course = 2,
                    DateOfBirth = DateTime.Now.AddYears(-18),
                    Id = 1,
                },
                new Student()
                {
                    Name = "Чурбаков Н.А.",
                    Course = 3,
                    DateOfBirth = DateTime.Now.AddYears(-18).AddMonths(-6),
                    Id = 2
                }
                ,
                new Student()
                {
                    Name = "Потехина О.А",
                    Course = 5,
                    DateOfBirth = DateTime.Now.AddYears(-18).AddDays(-25),
                    Id = 3,
                },
                new Student()
                {
                    Name = "Иванов И.И.",
                    Course = 4,
                    DateOfBirth = DateTime.Now.AddYears(-18).AddMonths(-3).AddDays(-6),
                    Id = 4
                },
                new Student()
                {
                    Name = "Сидоров С.С.",
                    Course = 3,
                    DateOfBirth = new DateTime(2004,6,8),
                    Id = 5
                },
                new Student()
                {
                    Name = "Зюганов В.С.",
                    Course = 4,
                    DateOfBirth = DateTime.Now.AddYears(-16).AddMonths(-3).AddDays(-6),
                    Id = 6
                },
                new Student()
                {
                    Name = "Даванков Г.Л",
                    Course = 5,
                    DateOfBirth = DateTime.Now.AddYears(-16).AddMonths(-3).AddDays(-6),
                    Id = 7
                },
                 new Student()
                {
                    Name = "Харитонов О.Г",
                    Course = 2,
                    DateOfBirth = DateTime.Now.AddYears(-16).AddMonths(-3).AddDays(-6),
                    Id = 8
                },
                  new Student()
                {
                    Name = "Аргел Тал",
                    Course = 1,
                    DateOfBirth = DateTime.Now.AddYears(-20).AddMonths(-3).AddDays(-6),
                    Id = 9
                },
                   new Student()
                {
                    Name = "Лоргар Аврелиан",
                    Course = 4,
                    DateOfBirth = DateTime.Now.AddYears(-17).AddMonths(-3).AddDays(-6),
                    Id = 10
                },
                    new Student()
                {
                    Name = "Константин Вальдор",
                    Course = 6 ,
                    DateOfBirth = DateTime.Now.AddYears(-21).AddMonths(-3).AddDays(-6),
                    Id = 11
                },
            };
    }

}

public class StudentStorageService
{
    private List<Student> _students;

    public StudentStorageService()
    {
        _students = Student.GetStudentList();
    }

    public List<Student> GetStudentList()
    {
        return _students;
    }

    public void AddStudent(Student student)
    {
        _students.Add(student);
    }

    public void DeleteStudent(int studentId)
    {
        _students.RemoveAll(a => a.Id == studentId);
    }

    public List<Student> FilterStudent()
    {
        var result = new List<Student>();

        foreach (var student in _students)
        {
            if (student.Name.ToUpper().StartsWith("А"))
            {
                result.Add(student);
            }
        }
        return result;
    }

    public List<Student> LINQFilterStudent()
    {
        return _students.Where(student => student.Name.ToUpper().StartsWith("Л") && student.DateOfBirth > new DateTime(2004, 6, 8)).ToList();
    }
    public List<string> PLINQFilterStudent()
    {
        return _students
            .Where(student => student.Course > 3)
            .OrderBy(s => s.Name)
            .Skip(2)
            .Select(s => s.Name)
            .Union(new List<string> { "12", "13" })
            .ToList();
    }
}

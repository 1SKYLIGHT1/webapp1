namespace WebApplication1.Models
{
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
                }
            };
        }
    }

    public class StudentStorageService
    {
        private  List<Student> _students;

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
    }
}

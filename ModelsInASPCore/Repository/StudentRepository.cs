using ModelsInASPCore.Models;

namespace ModelsInASPCore.Repository
{
    public class StudentRepository : IStudent
    {
        public List<StudentModel> getAllStudents()
        {
            return DataSource();
        }

        public StudentModel getStudentByName(string name)
        {
            return DataSource().Where(x => x.Name == name).FirstOrDefault();
        }

        private List<StudentModel> DataSource()
        {
            return new List<StudentModel>
            {
                new StudentModel { Rollno = 1, Name = "Divya", Gender = "Female", Age = 24 },
                new StudentModel { Rollno = 2, Name = "Jyoti", Gender = "Female", Age = 25 },
                new StudentModel { Rollno = 3, Name = "Punam", Gender = "Female", Age = 27 },
                new StudentModel { Rollno = 4, Name = "Sonaa", Gender = "Female", Age = 26 },
                new StudentModel { Rollno = 5, Name = "Mandal", Gender = "Female", Age = 23 }

            };

        }
    }
}

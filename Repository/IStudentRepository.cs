using WebAPIBOOK.Model;

namespace WebAPIBOOK.Repository
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>>GetStudents();
        Task<Student>GetStudentbyId(int id);
        Task<int> AddStudent(Student student);
        Task<int>UpdateStudent(Student student);
        Task<int>DeleteStudent(int id);
    }
}

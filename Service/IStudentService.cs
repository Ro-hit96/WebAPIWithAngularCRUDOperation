using WebAPIBOOK.Model;

namespace WebAPIBOOK.Service
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetStudents();
        Task<Student> GetStudentbyId(int id);
        Task<int> AddStudent(Student student);
        Task<int> UpdateStudent(Student student);
        Task<int> DeleteStudent(int id);
    }
}

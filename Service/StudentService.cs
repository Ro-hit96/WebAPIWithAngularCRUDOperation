using WebAPIBOOK.Model;
using WebAPIBOOK.Repository;

namespace WebAPIBOOK.Service
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository repo;
        
        public StudentService(IStudentRepository repo)
        {
            this.repo = repo;  
        }
        public async Task<int> AddStudent(Student student)
        {
            return await repo.AddStudent(student);
        }

        public async Task<int> DeleteStudent(int id)
        {
            return await repo.DeleteStudent(id);
        }

        public async Task<Student> GetStudentbyId(int id)
        {
            return await repo.GetStudentbyId(id);
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await repo.GetStudents();
        }

        public async Task<int> UpdateStudent(Student student)
        {
            return await repo.UpdateStudent(student);
        }
    }
}

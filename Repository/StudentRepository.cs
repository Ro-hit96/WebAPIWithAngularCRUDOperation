using Microsoft.EntityFrameworkCore;
using WebAPIBOOK.Data;
using WebAPIBOOK.Model;

namespace WebAPIBOOK.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext db;
        public StudentRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<int> AddStudent(Student student)
        {
            int result = 0;
            await db.Students.AddAsync(student);
            result=await db.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteStudent(int id)
        {
            int result = 0;
            var student=await db.Students.Where(x =>x.id==id).FirstOrDefaultAsync();
            if (student != null)
            {
                db.Students.Remove(student);
                result = await db.SaveChangesAsync();
            }
            return result;
        }

        public async Task<Student> GetStudentbyId(int id)
        {
            var student=await db.Students.Where(x =>x.id==id).FirstOrDefaultAsync();
            return student;
        }

        public async Task<IEnumerable<Student>> GetStudents()
        {
            return await db.Students.ToListAsync();
        }

        public async Task<int> UpdateStudent(Student student)
        {
            int result = 0;
            var s = await db.Students.Where(x => x.id == student.id).FirstOrDefaultAsync();
            if (s != null)
            {
                s.name = student.name;
                s.City = student.City;
                s.Percentage= student.Percentage;
                result= await db.SaveChangesAsync();
            }
            return result;
        }
    }
}

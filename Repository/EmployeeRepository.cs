using Microsoft.EntityFrameworkCore;
using WebAPIBOOK.Data;
using WebAPIBOOK.Model;

namespace WebAPIBOOK.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly ApplicationDbContext db;
        public EmployeeRepository(ApplicationDbContext db)
        {
            this.db = db;
        }
        public async Task<int> AddEmployee(Employee employee)
        {
            int result = 0;
            await db.Employees.AddAsync(employee);
            result = await db.SaveChangesAsync();
            return result;
        }

        public async Task<int> DeleteEmployeeById(int id)
        {
            int result = 0;
            var employee=await db.Employees.Where(x=>x.Id==id).FirstOrDefaultAsync();
            if (employee != null)
            {
                db.Employees.Remove(employee);
                result=await db.SaveChangesAsync();
            }
            return result;
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await db.Employees.ToListAsync();
        }

        public async Task<Employee> GetEmployeeById(int id)
        {
            var employee=await db.Employees.Where(x=>x.Id == id).FirstOrDefaultAsync();
            return employee;
        }

        public async Task<int> UpdateEmployee(Employee employee)
        {
            int result = 0;
            var emp=await db.Employees.Where(x=>x.Id==employee.Id).FirstOrDefaultAsync();
            if (emp != null)
            {
                emp.name = employee.name;
                emp.email = employee.email;
                emp.age = employee.age;
                emp.salary = employee.salary;
                result=await db.SaveChangesAsync();
            }
            return result;
        }
    }
}

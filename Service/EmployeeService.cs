using WebAPIBOOK.Model;
using WebAPIBOOK.Repository;

namespace WebAPIBOOK.Service
{
    public class EmployeeService : IEmployeeServices
    {
        private readonly IEmployeeRepository repo;
        
        public EmployeeService(IEmployeeRepository repo)
        {
            this.repo = repo;   
        }
        public async Task<int> AddEmployee(Employee employee)
        {
            return await repo.AddEmployee(employee);
        }

        public async Task<int> DeleteEmployeeById(int id)
        {
            return await repo.DeleteEmployeeById(id);
        }

        public async Task<IEnumerable<Employee>> GetEmployee()
        {
            return await repo.GetEmployee();
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            return repo.GetEmployeeById(id);
        }

        public Task<int> UpdateEmployee(Employee employee)
        {
            return repo.UpdateEmployee(employee);
        }
    }
}

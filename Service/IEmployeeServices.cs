using WebAPIBOOK.Model;

namespace WebAPIBOOK.Service
{
    public interface IEmployeeServices
    {
        Task<IEnumerable<Employee>> GetEmployee();
        Task<Employee> GetEmployeeById(int id);
        Task<int> AddEmployee(Employee employee);
        Task<int> UpdateEmployee(Employee employee);
        Task<int> DeleteEmployeeById(int id);
    }
}

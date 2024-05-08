using Transflower.ECommerce.Employees.Entities;
using Transflower.ECommerce.HR.Employees.Interfaces;

namespace Transflower.ECommerce.Employee.Controllers;
public class EmployeePerformanceController{

    private IEmployeePerformanceService  _employeePerformanceService;

    public EmployeePerformanceController(IEmployeePerformanceService employeePerformanceService)
    {
        _employeePerformanceService = employeePerformanceService;
    }

    public async Task<List<Member>> GetAll(){
        return  await  _employeePerformanceService.GetAll();
    }

    // public async Task<Member> GetDetails(int id){
        
    //     return await _membershipService.GetDetails(id);
    // }
}
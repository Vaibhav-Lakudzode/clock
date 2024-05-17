namespace Transflower.ECommerce.Employees.Entities;

public class employeeperformance{
    public int Id { get; set;}
    public string EmployeeId {get;set;}
    public string Test{get;set;}
    public string Communication{get;set;}
 
    public string Congition{get;set;}
     public string Interview{get;set;}
   


override public string ToString(){
    return (""+Id+" "+EmployeeId + " "+ Test + " "+ Communication + " "+ Congition+" "+ Interview);
}

}
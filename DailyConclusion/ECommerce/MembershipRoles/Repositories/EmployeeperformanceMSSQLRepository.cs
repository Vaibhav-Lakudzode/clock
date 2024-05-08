

using System.Data;
using System.Data.SqlClient;

using  Transflower.ECommerce.Employees.Entities;
using Transflower.ECommerce.Employees.Repositories.Interfaces;
namespace Transflower.ECommerce.Employees.Repositories;
public class EmployeeperformanceMSSQLRepository : IEmployeeperformanceRepository
{
    private string connectionString = @"Data Source=DESKTOP-H1K53PL\SQLEXPRESS;Initial Catalog=AssessmentDB;Integrated Security=True;Connect Timeout=30;Encrypt=False";

    public EmployeeperformanceMSSQLRepository(){

    }
    public async Task<List<Member>> GetAll()
    {
        await Task.Delay(100);
        List<Member> members = new List<Member>();  

        IDbConnection connection = new SqlConnection(connectionString);
        IDbCommand command = new SqlCommand("SELECT * FROM employeeperformance",connection as SqlConnection);
        
        try{
            connection.Open();

            IDataReader reader=command.ExecuteReader();
            while(reader.Read()){

                int id=int.Parse(reader["id"].ToString());
                string employeeId=reader["employeeid"].ToString();
                string test=reader["test"].ToString();
                string communication=reader["communication"].ToString();
                string congition=reader["congition"].ToString();
                string interview=reader["interview"].ToString();
                Member theMember=new Member();
                theMember.Id=id;
                theMember.EmployeeId=employeeid;    
                theMember.Test=test;
                theMember.Communication=communication;
                theMember.Congition=congition;
                theMember.Interview=interview;

                members.Add(theMember);
            }
            reader.Close();
        }
        catch(Exception ex){
                    Console.WriteLine(ex.Message);
        }

        finally{
                connection.Close();
        }

        return members;      
    }
    // public async Task<Member> GetDetails(int membershipId)
    //     {
    //         await Task.Delay(100);
    //         Member  member = null;
    //         IDbConnection connection = new SqlConnection(connectionString);
    //         string query ="SELECT * FROM Employees WHERE id="+ membershipId;

    //         IDbCommand command = new SqlCommand(query,connection as SqlConnection);
            
    //         try{
    //             connection.Open();
    //             IDataReader reader=command.ExecuteReader();
    //             if(reader.Read()){

    //                 int id=int.Parse(reader["id"].ToString());
    //                 string firstName=reader["firstname"].ToString();
    //                 string lastName=reader["lastname"].ToString();
    //                 string email=reader["email"].ToString();
    //                 string contact=reader["contact"].ToString();

    //                 member =new Member();
    //                 member.Id = id;
    //                 member.FirstName=firstName;    
    //                 member.LastName=lastName;
    //                 member.Email=email;
    //                 member.Contact=contact;
                
    //             }
    //             reader.Close();
    //         }
    //         catch(Exception ex){
    //                     Console.WriteLine(ex.Message);
    //         }

    //         finally{
    //                 connection.Close();
    //         }

    //         return member;   

    //     }

    // public async Task<bool> Insert (Member member)
    // {
    //     await Task.Delay(100);
    //     return true;
    // }

    // public async Task<bool> Delete(int membershipId)
    // {
    //     await Task.Delay(100);
    //     return true;
    // }

    // public async Task<bool> Update (Member member)
    // {
    //     await Task.Delay(100);
    //     return true;
    // }

    
}
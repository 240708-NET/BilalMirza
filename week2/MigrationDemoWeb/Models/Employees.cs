using System.ComponentModel.DataAnnotations;
namespace MigrationDemoWeb.Models;

public class Employees
{
    [Key] // indicates that EmployeeId is a primary key
    public int EmployeeID{get;set;}

    [Required(ErrorMessage = "First name is required")]
    public string FirstName{get;set;}
    public string LastName{get;set;}
    public string Email{get;set;}
}
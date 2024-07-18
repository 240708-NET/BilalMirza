using System.ComponentModel.DataAnnotations;
namespace MigrationDemoWeb.Models;

public class Departments
{
    [Key] // indicates that DepartmentID is a primary key
    public int DepartmentID {get;set;}
    public string DepartmentName {get;set;}
}
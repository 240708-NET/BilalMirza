using System.ComponentModel.DataAnnotations;

namespace Models;

public class Cipher{

    [Key] // it indicates that EmployeeID is a primary key
    public int CipherID { get; set; }

    [Required(ErrorMessage = "Message is required")]
    public string Message { get; set; }
    
    [Required(ErrorMessage = "Shift is required")]
    public int Shift { get; set; }

    [Required(ErrorMessage = "Direction is required")]
    [RegularExpression("^(encode|decode)$", ErrorMessage = "Direction must be either 'encode' or 'decode'")]
    public string Direction { get; set; }
}
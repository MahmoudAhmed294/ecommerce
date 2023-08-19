namespace BackEnd.Models;

public class Permission
{
    [Key]
    public Guid Id { get; set; }

    public bool AddCategory { get; set; }

    public bool UpdateCategory { get; set; }

    public bool DeleteCategory { get; set; }

    public bool AddProduct { get; set; }

    public bool UpdateProduct { get; set; }

    public bool DeleteProduct { get; set; }

    public string User_Id { get; set; }
}
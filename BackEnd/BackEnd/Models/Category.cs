namespace BackEnd.Models;

public class Category
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(50)]
    public string Name { get; set; }

    [Required]
    public string Image_Url { get; set; }

    public Guid? Parent_Id { get; set; }

    [InverseProperty("Parent")]
    public virtual ICollection<Category>? InverseParent { get; set; } = new List<Category>();

    [ForeignKey("Parent_Id")]
    [InverseProperty("InverseParent")]
    public virtual Category? Parent { get; set; }

    [InverseProperty("Category")]
    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
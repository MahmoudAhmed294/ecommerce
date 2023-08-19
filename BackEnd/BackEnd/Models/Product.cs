namespace BackEnd.Models;

public class Product
{
    [Key]
    public Guid Id { get; set; }

    public Guid Category_Id { get; set; }

    [StringLength(50)]
    public string Name { get; set; }

    [StringLength(200)]
    public string Description { get; set; }

    [Column(TypeName = "money")]
    public decimal? Price { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Cart> Carts { get; set; } = new List<Cart>();

    [ForeignKey("Category_Id")]
    [InverseProperty("Products")]
    public virtual Category Category { get; set; }

    [InverseProperty("Product")]
    public virtual ICollection<Image> Images { get; set; } = new List<Image>();
}
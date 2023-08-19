namespace BackEnd.Models;

public class Cart
{
    [Key]
    public Guid Id { get; set; }

    public Guid Product_Id { get; set; }

    [Required]
    [StringLength(450)]
    public string User_Id { get; set; }

    [ForeignKey("Product_Id")]
    [InverseProperty("Carts")]
    public virtual Product Product { get; set; }
}
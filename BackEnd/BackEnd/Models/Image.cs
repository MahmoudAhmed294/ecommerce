namespace BackEnd.Models;

public class Image
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    [StringLength(500)]
    public string URL { get; set; }

    public Guid Product_Id { get; set; }

    [ForeignKey("Product_Id")]
    [InverseProperty("Images")]
    public virtual Product Product { get; set; }
}
namespace BackEnd.Models;

[PrimaryKey("User_ID", "Connection_ID")]
public class User_Connection
{
    [Key]
    public Guid User_ID { get; set; }

    [Key]
    [StringLength(50)]
    public string Connection_ID { get; set; }
}
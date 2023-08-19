namespace BackEnd.Models;

[Table("Chat_Message")]
public class Chat_Message
{
    [Key]
    public Guid Id { get; set; }

    [Required]
    public string Message { get; set; }

    [Column(TypeName = "date")]
    public DateTime Date { get; set; }

    public TimeSpan Time { get; set; }

    [Required]
    [StringLength(450)]
    public string Sender_ID { get; set; }

    [Required]
    [StringLength(450)]
    public string Receiver_ID { get; set; }
}
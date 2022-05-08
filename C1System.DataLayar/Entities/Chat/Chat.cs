using System.ComponentModel.DataAnnotations;

namespace C1System.DataLayar.Entities.Chat;

public class Chat
{
    [Key]
    public Guid ChatId { get; set; }
}
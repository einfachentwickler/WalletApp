using DataAccess.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

[Table("ct_transactions")]
public class TransactionEntity
{
    [Key]
    public int Id { get; set; }

    public TransactionType Type { get; set; }

    public double Amount { get; set; }

    [Required(AllowEmptyStrings = false), MaxLength(300)]
    public string? Name { get; set; }

    [Required(AllowEmptyStrings = false), MaxLength(65000)]
    public string? Description { get; set; }

    public DateTime Date { get; set; }

    public bool IsPending { get; set; }

    public bool IsAutorizedUser { get; set; }

    [ForeignKey("UserId")]
    public int UserId { get; set; }

    [Required]
    public UserEntity? User { get; set; }
}
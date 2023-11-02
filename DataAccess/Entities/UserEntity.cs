using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Entities;

[Table("ct_users")]
public class UserEntity
{
    [Key]
    public int Id { get; set; }

    [Required(AllowEmptyStrings = false)]
    public string? Name { get; set; }

    [Required]
    public List<TransactionEntity>? Entities { get; set; }
}
using DataAccess.Enums;

namespace BusinessLogic.DTO;

public class TransactionModel
{
    public int Id { get; set; }

    public TransactionType Type { get; set; }

    public string? Amount { get; set; }

    public string? Name { get; set; }

    public string? Description { get; set; }

    public string? Date { get; set; }

    public string? UserName { get; set; }

    public string? Image { get; set; }
}
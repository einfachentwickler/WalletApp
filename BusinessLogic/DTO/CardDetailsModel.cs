namespace BusinessLogic.DTO;

public class CardDetailsModel
{
    public double Balance { get; set; }

    public double Available { get; set; }

    public string? NoPaymentDue { get; set; }

    public string? DailyPoints { get; set; }
}
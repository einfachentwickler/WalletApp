using BusinessLogic.DTO;

namespace BusinessLogic.Handlers.CardDetails;

public interface ICardDetailsHandler
{
    public CardDetailsModel GetAsync();
}
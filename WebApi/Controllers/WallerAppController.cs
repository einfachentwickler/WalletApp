using BusinessLogic.DTO;
using BusinessLogic.Handlers.CardDetails;
using BusinessLogic.Handlers.Transactions;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers;

[Route("api/")]
[Consumes("application/json")]
[Produces("application/json")]
[ApiController]
public class WallerAppController : ControllerBase
{
    private readonly ITransactionsHandler _transactionsHandler;
    private readonly ICardDetailsHandler _cardDetailsHandler;

    public WallerAppController(ITransactionsHandler handler, ICardDetailsHandler cardDetailsHandler)
    {
        _transactionsHandler = handler;
        _cardDetailsHandler = cardDetailsHandler;
    }

    [HttpGet("transactions")]
    public async Task<IActionResult> GetTransactions([FromQuery][Required] int userId)
    {
        IEnumerable<TransactionModel> transactions = await _transactionsHandler.GetAsync(userId);

        return Ok(transactions);
    }

    [HttpGet("cardDetails")]
    public IActionResult GetCardDetails()
    {
        CardDetailsModel result = _cardDetailsHandler.GetAsync();

        return Ok(result);
    }
}
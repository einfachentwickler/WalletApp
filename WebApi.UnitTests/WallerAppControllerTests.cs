using BusinessLogic.DTO;
using BusinessLogic.Handlers.CardDetails;
using BusinessLogic.Handlers.Transactions;
using Microsoft.AspNetCore.Mvc;
using NSubstitute;
using NUnit.Framework;
using WebApi.Controllers;

namespace WebApi.UnitTests;

public class WallerAppControllerTests
{
    private WallerAppController _instance;

    private ITransactionsHandler _transactionsHandler;

    private ICardDetailsHandler _cardHandler;

    [SetUp]
    public void Setup()
    {
        _transactionsHandler = Substitute.For<ITransactionsHandler>();
        _cardHandler = Substitute.For<ICardDetailsHandler>();

        _instance = new WallerAppController(_transactionsHandler, _cardHandler);
    }

    [Test]
    public async Task GetTransactions_ValidUserId_Returns200()
    {
        //Arrange
        _transactionsHandler.GetAsync(1).Returns(new List<TransactionModel>());

        //Act
        IActionResult actionResult = await _instance.GetTransactions(1);

        //Assert
        Assert.IsInstanceOf<OkObjectResult>(actionResult);
    }

    [Test]
    public void GetCardDetails_Success_Returns200()
    {
        //Arrange
        _cardHandler.GetAsync().Returns(new CardDetailsModel());

        //Act
        IActionResult actionResult = _instance.GetCardDetails();

        //Assert
        Assert.IsInstanceOf<OkObjectResult>(actionResult);
    }
}

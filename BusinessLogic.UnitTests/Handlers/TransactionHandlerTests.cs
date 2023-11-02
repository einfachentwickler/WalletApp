using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.Handlers.Transactions;
using BusinessLogic.ImageProcessing;
using DataAccess.Entities;
using DataAccess.Enums;
using DataAccess.Repositories;
using NSubstitute;
using NUnit.Framework;

namespace BusinessLogic.UnitTests.Handlers;

[TestFixture]
public class TransactionHandlerTests
{
    private ITransactionsHandler _instance;

    private IMapper _mapper;

    private ITransactionRepository _repo;

    private IDateFormatter _formatter;

    private IImageProcessor _imageProcessor;

    [SetUp]
    public void Setup()
    {
        _mapper = Substitute.For<IMapper>();

        _repo = Substitute.For<ITransactionRepository>();

        _formatter = Substitute.For<IDateFormatter>();

        _imageProcessor = Substitute.For<IImageProcessor>();

        _instance = new TransactionsHandler(_repo, _mapper, _formatter, _imageProcessor);
    }

    [TestCase(true)]
    [TestCase(false)]
    public async Task Handle_Success_ReturnsModels(bool flag)
    {
        //Arrange
        const int userId = 1;
        const string image = "some base64 string";

        List<TransactionEntity> transactions = new() {
            new TransactionEntity
            {
                Amount = 12,
                IsAutorizedUser = flag,
                Date = DateTime.UtcNow,
                Description = "Test",
                Id = 1,
                IsPending = flag,
                Name = "Test",
                Type = TransactionType.Payment,
                User = new UserEntity
                {
                    Name = "User"
                }
            }
        };

        List<TransactionModel> models = new() {
            new TransactionModel
            {
                Description = "Test desc",
                Id = 1,
                Name = "Test",
                Type = TransactionType.Payment,
                Amount = "123",
                UserName = "User"
            }
        };

        _repo.GetAsync(Arg.Is<int>(x => x == userId)).Returns(transactions);

        _mapper.Map<IEnumerable<TransactionModel>>(Arg.Is<List<TransactionEntity>>(x => x.Count == 1)).Returns(models);

        _imageProcessor.GetImageAsBase64StringAsync().Returns(image);

        //Act
        TransactionModel[] actualResult = (await _instance.GetAsync(userId)).ToArray();

        //Assert
        await _repo.Received().GetAsync(Arg.Is<int>(x => x == userId));

        Assert.That(actualResult[0].Image, Is.EqualTo($"data:image/png;base64,{image}"));
        Assert.That(actualResult[0].Description, Is.EqualTo(flag ? "Pending - Test desc" : "Test desc"));
        Assert.That(actualResult[0].Amount, Is.EqualTo("+123"));
        Assert.That(actualResult[0].UserName, Is.EqualTo(flag ? "User" : null));
    }
}
using AutoMapper;
using BusinessLogic.DTO;
using BusinessLogic.Formatters.Interfaces;
using BusinessLogic.ImageProcessing;
using DataAccess.Entities;
using DataAccess.Enums;
using DataAccess.Repositories;

namespace BusinessLogic.Handlers.Transactions;

public class TransactionsHandler : ITransactionsHandler
{
    private readonly ITransactionRepository _transactionRepository;

    private readonly IDateFormatter _formatter;

    private readonly IMapper _mapper;

    private readonly IImageProcessor _imageProcessor;

    public TransactionsHandler(ITransactionRepository transactionRepository, IMapper mapper, IDateFormatter formatter, IImageProcessor imageProcessor)
    {
        _transactionRepository = transactionRepository;
        _mapper = mapper;
        _formatter = formatter;
        _imageProcessor = imageProcessor;
    }

    public async Task<IEnumerable<TransactionModel>> GetAsync(int userId)
    {
        IEnumerable<TransactionEntity> entities = await _transactionRepository.GetAsync(userId);

        IEnumerable<TransactionModel> models = _mapper.Map<IEnumerable<TransactionModel>>(entities);

        string? icon = await _imageProcessor.GetImageAsBase64StringAsync();

        return models.Select(model =>
        {
            TransactionEntity entity = entities.Single(entity => entity.Id == model.Id);

            if (model.Type is TransactionType.Payment)
            {
                model.Amount = $"+{model.Amount}";
            }

            if (entity.IsPending)
            {
                model.Description = $"Pending - {model.Description}";
            }

            model.Date = _formatter.Format(entity.Date);

            model.UserName = entity.IsAutorizedUser ? model.UserName : null;

            model.Image = "data:image/png;base64," + icon;

            return model;
        });
    }
}
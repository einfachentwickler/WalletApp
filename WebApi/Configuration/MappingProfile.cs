using AutoMapper;
using BusinessLogic.DTO;
using DataAccess.Entities;

namespace WebApi.Configuration;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<TransactionEntity, TransactionModel>().ForMember(model => model.Date, opt => opt.Ignore());
    }
}
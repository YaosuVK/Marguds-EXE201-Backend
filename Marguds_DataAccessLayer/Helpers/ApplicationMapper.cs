using AutoMapper;
using Marguds_BussinessObject.Model;
using Marguds_BussinessObject.ViewModels;

namespace Marguds_DataAccessLayer.Helpers
{
    public class ApplicationMapper : Profile
    {

        public ApplicationMapper()
        {
            // CRUD MAPPING
            // ACCESS MAPPING
            CreateMap<Account, UserInfo>()
                .ReverseMap();

            CreateMap<SignupModel, Account>()
                .ForMember(dest => dest.AccountID, opt => opt.MapFrom(_ => Guid.NewGuid()));

        }
    }
}

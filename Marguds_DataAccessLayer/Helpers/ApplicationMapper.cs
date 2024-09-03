using AutoMapper;
using Marguds_BussinessObject.Model;
using Marguds_BussinessObject.ViewModels;
using BC = global::BCrypt.Net.BCrypt;

namespace Marguds_DataAccessLayer.Helpers
{
    public class ApplicationMapper : Profile
    {

        public ApplicationMapper()
        {
            // CRUD MAPPING
            // ACCESS MAPPING
            CreateMap<Account, UserInfo>()
    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));

            CreateMap<UserInfo, Account> ()
    .ForMember(dest => dest.Status, opt => opt.MapFrom(src => Enum.Parse<Status>(src.Status!)));

            CreateMap<SignupModel, Account>()
                .ForMember(dest => dest.AccountID, opt => opt.MapFrom(_ => Guid.NewGuid()))
                .ForMember(dest => dest.Password, opt => opt.MapFrom(src => BC.EnhancedHashPassword(src.Password, 13)))
                .ForMember(dest => dest.Role, opt => opt.MapFrom(_ => "Customer"))
                .ForMember(dest => dest.Status, opt => opt.MapFrom(_ => 0));


        }
    }
}

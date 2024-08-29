using Marguds_BussinessObject.ViewModels;
using Marguds_DataAccessLayer.Repositories;
using Marguds_DataAccessLayer.Services.IServices;

namespace Marguds_DataAccessLayer.Services
{
    public class AccessService : IAccessService
    {
        private readonly IAccessRepository _accessRepository;

        public AccessService(IAccessRepository accessRepository)
        {
            _accessRepository = accessRepository;
        }

        public async Task<UserInfo?> Login(LoginModel model)
        {
            return await _accessRepository.Login(model);
        }

        public async Task<bool> Signup(SignupModel model)
        {
            return await _accessRepository.Signup(model);
        }
    }
}

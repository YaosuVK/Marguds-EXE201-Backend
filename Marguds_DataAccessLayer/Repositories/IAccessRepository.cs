using Marguds_BussinessObject.ViewModels;

namespace Marguds_DataAccessLayer.Repositories
{
    public interface IAccessRepository
    {
        public Task<UserInfo?> Login(LoginModel model);

        public Task<Boolean> Signup(SignupModel model);
    }
}

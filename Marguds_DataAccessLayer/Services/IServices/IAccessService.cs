using Marguds_BussinessObject.ViewModels;
namespace Marguds_DataAccessLayer.Services.IServices
{
    public interface IAccessService
    {
        public Task<UserInfo?> Login(LoginModel model);

        public Task<bool> Signup(SignupModel model);
    }
}

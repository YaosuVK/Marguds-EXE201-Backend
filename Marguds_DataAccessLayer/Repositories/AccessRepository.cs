using AutoMapper;
using Marguds_BussinessObject.Model;
using Marguds_BussinessObject.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace Marguds_DataAccessLayer.Repositories
{
    public class AccessRepository : IAccessRepository
    {
        private readonly MargudsContext _dbContext;
        private readonly IMapper _mapper;

        public AccessRepository(MargudsContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<UserInfo?> Login(LoginModel model)
        {
            var user = await _dbContext.Accounts.FirstOrDefaultAsync(user =>
                user.Email == model.Email);

            if (user != null)
            {
                //if (!BC.EnhancedVerify(model.Password, user.Password)) { return null; }
                if(user.Password != model.Password) { return null; }
                return _mapper.Map<UserInfo>(user);
            }

            return null;
        }

        public async Task<Boolean> Signup(SignupModel model)
        {
            try
            {
                var newUser = _mapper.Map<Account>(model);

                await _dbContext.Accounts.AddAsync(newUser);
                await _dbContext.SaveChangesAsync();

                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}

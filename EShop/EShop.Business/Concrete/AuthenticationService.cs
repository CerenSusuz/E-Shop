using System.Threading.Tasks;
using EShop.Business.Abstract;
using EShop.Core.Exceptions;
using EShop.Core.Helpers;
using EShop.Core.Plugins.Authentication.Jwt;
using EShop.Core.Plugins.Authentication.Models;
using EShop.DataAccess.Entities;
using EShop.DataAccess.Repositories;

namespace EShop.Business.Concrete
{
    public class AuthenticationService : IAuthenticationService
    {
        private readonly IRepository<Account> _accountRepository;
        private readonly IJwtService _jwtService;

        public AuthenticationService(IRepository<Account> accountRepository, IJwtService jwtService)
        {
            _accountRepository = accountRepository;
            _jwtService = jwtService;
        }
        
        public async Task<TokenInfo> LoginAsync(LoginRequestModel loginModel, string ipAddress)
        {
            var account = await _accountRepository.GetAsync(x => x.Email == loginModel.Email);
            if (account == null) throw new NotFoundException(loginModel.Email+" Account is not found");

            if (account.IsBlocked)
                throw new AuthenticationException("Account is blocked");
            
            var verify =
                HashingHelper.VerifyPasswordHash(loginModel.Password, account.PasswordHash, account.PasswordSalt);
            if (!verify)
                throw new AuthenticationException("Password Wrong");

            var accessToken = _jwtService.CreateToken(new JwtCreateModel(account.Id,
                account.FirstName + " " + account.LastName, account.IsSuperVisor));

            return accessToken;

        }

        public async Task LogoutAsync(int accountId)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TokenInfo> RefreshAsync(string refreshToken, string ipAddress)
        {
            throw new System.NotImplementedException();
        }

        public async Task<TokenInfo> RegisterAsync(RegisterRequestModel registerModel, string ipAddress)
        {
            throw new System.NotImplementedException();
        }

        public async Task<UserInfo> UserInfo(int accountId)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Threading.Tasks;
using EShop.Business.Models;
using EShop.Business.Repositories;
using EShop.Core.Models;

namespace EShop.Business.Abstract
{
    public interface IAccountService : IServiceRepository<AccountDto>
    {
        Task<PagedList<AccountsDto>> GetAllAsync(Filter filter);

    }
}
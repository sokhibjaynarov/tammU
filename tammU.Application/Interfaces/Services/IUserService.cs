using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using tammU.Application.ViewModels;
using tammU.Domain.Commons;
using tammU.Domain.Models;

namespace tammU.Application.Interfaces.Services
{
    public interface IUserService
    {
        Task<BaseResponse<User>> CreateAsync(UserViewModel userDto);
        Task<BaseResponse<User>> GetAsync(Expression<Func<User, bool>> expression);
        Task<BaseResponse<IEnumerable<User>>> GetAllAsync(Expression<Func<User, bool>> expression = null);
        Task<BaseResponse<bool>> DeleteAsync(Expression<Func<User, bool>> expression);
        Task<BaseResponse<User>> UpdateAsync(Guid id, UserViewModel userDto);
    }
}

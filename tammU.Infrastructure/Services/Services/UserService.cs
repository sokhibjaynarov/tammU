using AutoMapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using tammU.Application.Interfaces.Services;
using tammU.Application.Interfaces.UnitOfWork;
using tammU.Application.ViewModels;
using tammU.Domain.Commons;
using tammU.Domain.Enums;
using tammU.Domain.Models;

namespace tammU.Infrastructure.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWork unitOfWork;
        private readonly IMapper mapper;
        private readonly IConfiguration config;

        public UserService(IUnitOfWork unitOfWork, IMapper mapper, IConfiguration config)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
            this.config = config;
        }

        public async Task<BaseResponse<User>> CreateAsync(UserViewModel userDto)
        {
            var response = new BaseResponse<User>();

            // check for email
            var existUserEmail = await unitOfWork.Users.GetAsync(p => p.Email == userDto.Email);
            if (existUserEmail is not null)
            {
                response.ErrorMessage = "Email already exist!";
                return response;
            }

            var existUserUsername = await unitOfWork.Users.GetAsync(p => p.Username == userDto.Username);
            if (existUserUsername is not null)
            {
                response.ErrorMessage = "Username already exist!";
                return response;
            }

            var mappedUser = mapper.Map<User>(userDto);

            var result = await unitOfWork.Users.CreateAsync(mappedUser);

            await unitOfWork.SaveChangesAsync();

            response.Data = result;

            return response;
        }

        public async Task<BaseResponse<bool>> DeleteAsync(Expression<Func<User, bool>> expression)
        {
            var response = new BaseResponse<bool>();

            // check for exist user
            var existUser = await unitOfWork.Users.GetAsync(expression);
            if (existUser is null)
            {
                response.ErrorMessage = "User not found!";
                return response;
            }
            existUser.Delete();

            var result = await unitOfWork.Users.UpdateAsync(existUser);

            await unitOfWork.SaveChangesAsync();

            response.Data = true;

            return response;
        }

        public async Task<BaseResponse<IEnumerable<User>>> GetAllAsync(Expression<Func<User, bool>> expression = null)
        {
            var response = new BaseResponse<IEnumerable<User>>();

            var courses = await unitOfWork.Users.GetAllAsync(expression);

            response.Data = courses;

            return response;
        }

        public async Task<BaseResponse<User>> GetAsync(Expression<Func<User, bool>> expression)
        {
            var response = new BaseResponse<User>();

            var course = await unitOfWork.Users.GetAsync(expression);
            if (course is null)
            {
                response.ErrorMessage = "Course not found";
                return response;
            }

            response.Data = course;

            return response;
        }

        public async Task<BaseResponse<User>> UpdateAsync(Guid id, UserViewModel userDto)
        {
            var response = new BaseResponse<User>();

            // check for exist user
            var course = await unitOfWork.Users.GetAsync(p => p.Id == id && p.State != ItemState.Deleted);
            if (course is null)
            {
                response.ErrorMessage = "Course not found";
                return response;
            }

            return null;
        }
    }
}

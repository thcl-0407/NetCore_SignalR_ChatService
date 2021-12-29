using System;
using Application.Abstractions;
using Application.Models.Response;
using Application.Constant;

namespace Application.Services
{
    public class HomeService : IHomeService
    {
        public BaseResponse<object> StartSuccess()
        {
            return new BaseResponse<object>
            {
                IsSuccess = true,
                Message = StatusConstant.Success
            };
        }
    }
}

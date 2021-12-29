using System;
using Application.Models.Response;

namespace Application.Abstractions
{
    public interface IHomeService
    {
        BaseResponse<object> StartSuccess();
    }
}

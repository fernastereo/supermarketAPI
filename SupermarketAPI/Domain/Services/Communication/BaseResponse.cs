using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SupermarketAPI.Domain.Services.Communication
{
    public abstract class BaseResponse
    {
        public bool Success { get; protected set; }
        public string Messsage { get; protected set; }

        public BaseResponse(bool success, string message)
        {
            Success = success;
            Messsage = message;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Raindrop.Common.OpenApi
{
    public enum ApiResultCode
    {
        Success = 0,
        Fail,
        Null,
        NotExisted,
        ParamsError,
        PasswordError,
    }
}

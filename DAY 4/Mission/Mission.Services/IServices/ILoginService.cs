﻿using Mission.Entities.Entities;
using Mission.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission.Services.IServices
{
    public interface ILoginService
    {
        ResponseResult login(LoginUserRequestModel model);
    }
}

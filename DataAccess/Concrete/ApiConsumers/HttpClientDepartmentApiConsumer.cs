﻿using Core.DataAccess.ApiConsumers;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.ApiConsumers
{
    public class HttpClientDepartmentApiConsumer : HttpClientApiConsumer<Department>, IDepartmentApiConsumer
    {

    }
}

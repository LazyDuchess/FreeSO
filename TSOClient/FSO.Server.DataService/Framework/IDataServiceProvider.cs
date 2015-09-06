﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FSO.Common.DataService.Framework
{
    public interface IDataServiceProvider
    {
        Task<object> Get(object key);

        Type GetKeyType();
        Type GetValueType();
    }
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Vouchers
{
    public class VouchersConfig
    {
        //Easy to create online based on your settings file @ http://json2csharp.com/

        public ConnectionStrings ConnectionStrings { get; set; }
        public string ApplicationName { get; set; }
    }

    public class ConnectionStrings
    {
        public string LocalDBConnection { get; set; }
        public string SQLServerDBConnection { get; set; }
    }    
}

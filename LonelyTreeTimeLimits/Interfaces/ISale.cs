﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISale
    {
        int SaleId { get; set; }
        SaleStatus SaleStatus { get; set; }
        DateTime CreatedDate { get; set; }
        string SpecialRequests { get; set; }
        ICustomer Customer { get; set; }
        bool Deleted { get; set; }
    }
}

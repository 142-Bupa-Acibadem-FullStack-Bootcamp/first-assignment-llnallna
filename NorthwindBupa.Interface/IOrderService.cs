﻿using NorthwindBupa.Entity.Dto;
using NorthwindBupa.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthwindBupa.Interface
{
    public interface IOrderService : IGenericService<Order, DtoOrder>
    {
        IQueryable OrderReport(int orderId);
    }
}

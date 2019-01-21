﻿using DbPoc.Application.Infrastructure;
using DbPoc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;

namespace DbPoc.Application.Queries.Products
{
    public class GetAllProductByTimeQuery : IRequest<IEnumerable<Product>>, ICacheable
    {
        public DateTime StateTime { get; set; }
    }
}

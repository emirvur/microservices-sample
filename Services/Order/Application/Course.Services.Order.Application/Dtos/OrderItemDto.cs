﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Services.Order.Application.Dtos
{
    public class OrderItemDto
    {
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
        public Decimal Price { get; set; }
    }
}

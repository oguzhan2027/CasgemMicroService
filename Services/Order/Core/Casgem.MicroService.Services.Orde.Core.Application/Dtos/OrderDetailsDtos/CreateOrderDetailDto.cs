﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Dtos.OrderDetailsDtos
{
    public class CreateOrderDetailDto
    {
       
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductAmount { get; set; }
        public int OrderingID { get; set; }
        
    }
}

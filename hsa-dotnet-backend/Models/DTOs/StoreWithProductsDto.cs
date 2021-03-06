﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HsaDotnetBackend.Models.DTOs
{
    public sealed class StoreWithProductsDto
    {
        public StoreWithProductsDto()
        {
            this.Products = new List<ProductDto>();
        }
        public string Name { get; set; }
        public int Id { get; set; }
        public System.Data.Entity.Spatial.DbGeography Location { get; set; }
        public IEnumerable<ProductDto> Products { get; set; }
    }
}
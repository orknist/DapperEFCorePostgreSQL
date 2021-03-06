﻿using System.Collections.Generic;

namespace DapperEFCorePostgreSQL.Dtos
{
    public class CategoryDto
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public IEnumerable<ProductDto> Products { get; set; }
    }
}

using System;

namespace DapperEFCorePostgreSQL.Dtos
{
    public class ProductWithCategoryDto
    {
        public int? ProductId { get; set; }

        public int? CategoryId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Content { get; set; }

        public DateTime CreateDate { get; set; }

        public string CategoryName { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductBranch { get; set; }
        public string ProductCategory { get; set; }
        public int ProductStock { get; set; }
        public Category Category { get; set; }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Musician.Models.ViewModels
{
    public class ProductUserVM
    {
        public ProductUserVM()
        {
            ProductList = new List<Product>();
        }

        public IdentityUser AppIden { get; set; }


        //public AppUser ApplicationUser { get; set; }
        public IList<Product> ProductList { get; set; }
    }
}

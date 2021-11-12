using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Musician.Models.ViewModels
{
    public class DetailsVM
    {
        public DetailsVM()
        {
            product = new Product();
        }

        public Product product { get; set; }
        public bool ExistsInCart { get; set; }
    }
}

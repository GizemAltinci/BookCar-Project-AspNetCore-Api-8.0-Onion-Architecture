using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class Car
    {
        public int CarId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public List<CarFeature> CarFeatures { get; set; }
        public List<CarDescription> CarDescriptions { get; set; }
        public Lİst<CarPricing> CarPricings { get; set; }
    }
}

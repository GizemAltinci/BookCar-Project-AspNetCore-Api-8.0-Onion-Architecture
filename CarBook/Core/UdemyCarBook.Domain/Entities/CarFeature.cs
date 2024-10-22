using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Domain.Entities
{
    public class CarFeature
    {
        public int CarFeatureId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int FeatureId { get; set; }
        public Feature Feature { get; set; }
        public bool Availabe { get; set; } //Bu özellik var mı yok mu?
    }
}

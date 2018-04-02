using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboWaffle.Model
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public CategoryModel(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}

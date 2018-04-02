using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboWaffle.Model
{
    public class InputModel
    {
        public int Id { get; set; }
        public int FkCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public InputModel(int id, int fkCategory, string description, decimal amount)
        {
            Id = id;
            FkCategory = fkCategory;
            Description = description;
            Amount = amount;
        }
    }
}

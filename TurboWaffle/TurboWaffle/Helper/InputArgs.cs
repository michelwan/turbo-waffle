using System;

namespace TurboWaffle.Helper
{
    public class InputArgs : EventArgs
    {
        public int Id { get; set; }
        public int FkCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public InputArgs(int id, int fkCategory, string description, decimal amount)
        {
            Id = id;
            FkCategory = fkCategory;
            Description = description;
            Amount = amount;
        }

        public string[] Get()
        {
            return new[] { Id.ToString(), FkCategory.ToString(), Description, Amount.ToString() };
        }
    }
}

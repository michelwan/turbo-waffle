using System;

namespace TurboWaffle.Model
{
    public class InputModel
    {
        #region Properties
        public int Id { get; set; }
        public int FkFlowType { get; set; }
        public int FkCategory { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        #endregion Properties

        public InputModel(int id, int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            Id = id;
            FkFlowType = fkFlowType;
            FkCategory = fkCategory;
            Date = date;
            Description = description;
            Amount = amount;
        }
    }
}

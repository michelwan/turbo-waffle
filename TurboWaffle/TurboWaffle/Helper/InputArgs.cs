using System;

namespace TurboWaffle.Helper
{
    public class InputArgs : EventArgs
    {
        #region Properties
        public int Id { get; set; }
        public int FkFlowType { get; set; }
        public int FkCategory { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        #endregion Properties

        public InputArgs(int id, int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            Id = id;
            FkFlowType = fkFlowType;
            FkCategory = fkCategory;
            Date = date;
            Description = description;
            Amount = amount;
        }

        public string[] Get()
        {
            return new[] { FkFlowType.ToString(), FkCategory.ToString(), Date.ToString(Constants.DateTimeShortFormat), Description, Amount.ToString() };
        }
    }
}

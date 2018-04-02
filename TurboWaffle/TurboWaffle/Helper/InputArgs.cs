using System;

namespace TurboWaffle.Helper
{
    public class InputArgs : EventArgs
    {
        #region Properties
        public int Id { get; set; }
        public int FkFlowType { get; set; }
        public int FkCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        #endregion Properties

        public InputArgs(int id, int fkFlowType, int fkCategory, string description, decimal amount)
        {
            Id = id;
            FkFlowType = fkFlowType;
            FkCategory = fkCategory;
            Description = description;
            Amount = amount;
        }

        public string[] Get()
        {
            return new[] { Id.ToString(), FkFlowType.ToString(), FkCategory.ToString(), Description, Amount.ToString() };
        }
    }
}

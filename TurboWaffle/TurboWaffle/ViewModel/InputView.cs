namespace TurboWaffle.ViewModel
{
    public class InputView
    {
        #region Properties
        public int Id { get; set; }
        public int FkFlowType { get; set; }
        public int FkCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        #endregion Properties

        public InputView(int id, int fkFlowType, int fkCategory, string description, decimal amount)
        {
            Id = id;
            FkFlowType = fkFlowType;
            FkCategory = fkCategory;
            Description = description;
            Amount = amount;
        }
    }
}

namespace TurboWaffle.ViewModel
{
    public class InputView
    {
        public int Id { get; set; }
        public int FkCategory { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public InputView(int id, int fkCategory, string description, decimal amount)
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

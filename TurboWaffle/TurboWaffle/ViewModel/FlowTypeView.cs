namespace TurboWaffle.ViewModel
{
    public class FlowTypeView
    {
        #region Properties
        public int Id { get; set; }
        public string Description { get; set; }
        #endregion Properties

        public FlowTypeView(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}

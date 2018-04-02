namespace TurboWaffle.Model
{
    public class FlowTypeModel
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public FlowTypeModel(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}

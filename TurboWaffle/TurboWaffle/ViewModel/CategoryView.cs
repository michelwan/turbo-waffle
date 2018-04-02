namespace TurboWaffle.ViewModel
{
    public class CategoryView
    {
        public int Id { get; set; }
        public string Description { get; set; }

        public CategoryView(int id, string description)
        {
            Id = id;
            Description = description;
        }
    }
}

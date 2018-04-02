namespace TurboWaffle.Helper
{
    public class Constants
    {
        public static readonly string DateTimeShortFormat = "yyyy-MM-dd";

        public static class XmlElement
        {
            public static readonly string Category = "Category";
            public static readonly string FlowType = "FlowType";
        }

        public static class XmlAttribute
        {
            public static readonly string Amount = "Amount";
            public static readonly string Id = "Id";
            public static readonly string Date = "Date";
            public static readonly string Description = "Description";
            public static readonly string FkCategory = "FkCategory";
            public static readonly string FkFlowType = "FkFlowType";
        }

        public static class Path
        {
            public static readonly string FlowType = "./Data/Data.xml";
        }
    }
}

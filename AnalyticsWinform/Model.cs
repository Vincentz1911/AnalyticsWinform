namespace AnalyticsWinform
{
    class Model
    {
    }

    public class Account_cls
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Property_cls
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public int AccountID { get; set; }
    }

    public class View_cls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string PropertyId { get; set; }
    }
}

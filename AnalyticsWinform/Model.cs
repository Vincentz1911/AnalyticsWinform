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
        public string UA { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string AccountID { get; set; }
        public string IDint { get; set; }
    }

    public class View_cls
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string PropertyId { get; set; }
    }

    public class Oath2Files_cls
    {
        public int ID { get; set; }
        public string File { get; set; }
        public string Account { get; set; }
        public string AppName { get; set; }
    }
}

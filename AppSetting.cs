namespace ConsoleApp1
{
    public class AppSettings
    {
        public string appname { get; set; }
        public string version { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string BaseUrl { get; set; }
    }
}




namespace ConsoleApp1
{
    public class AppSettings
    {
        public string AppName { get; set; }
        public string Version { get; set; }
        public ConnectionStrings ConnectionStrings { get; set; }
    }

    public class ConnectionStrings
    {
        public string DatabaseConnection { get; set; }
    }
}
namespace TaskManager.API.Data.Configurations
{
    public interface IDatabaseConfig
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
    }
}

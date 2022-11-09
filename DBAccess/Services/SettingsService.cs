using namespc = System.Configuration;

namespace DBAccess.Services
{
    public interface ISettingsService
    {
        string DBConnectionString { get; }
    }

    public class SettingsService : ISettingsService
    {
        public string DBConnectionString 
        {
            get
            {
                return namespc.ConfigurationManager.AppSettings["DBConnectionDebug"]!;
            }
        }
       

    }
}

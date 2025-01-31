namespace IT_Help.Models
{
    public class AppConfig
    {
        public string ImageLogo { get; set; }
        public string CompanyName { get; set; }


        public static AppConfig CreateExample()
        {
            AppConfig config = new AppConfig();
            config.CompanyName = "Company";
            return config;
        }

    }
}

namespace EbayClient
{
    public class EbayCredentials
    {
        public enum Environment
        {
            Production,
            Sandbox
        }

        private Environment _EnvironmentType;
        public Environment EnvironmentType
        {
            get
            {
                return _EnvironmentType;
            }

            set
            {
                _EnvironmentType = value;

                switch (value)
                {
                    case Environment.Production:
                        _ApiUrl = "https://api.ebay.com/ws/api.dll";
                        break;

                    case Environment.Sandbox:
                        _ApiUrl = "https://api.sandbox.ebay.com/ws/api.dll";
                        break;
                }
            }
        }

        private string _ApiUrl { get; set; }
        public string ApiUrl
        {
            get
            {
                return _ApiUrl;
            }
        }

        public string AuthToken { get; set; }

        public int SiteId { get; set; }
    }
}

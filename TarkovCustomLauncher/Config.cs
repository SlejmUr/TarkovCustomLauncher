using Newtonsoft.Json;

namespace TarkovCustomLauncher
{
    public class Config
    {
        public class FromNet
        {
            [JsonProperty("ip")]
            public string Ip { get; set; }

            [JsonProperty("port")]
            public int Port { get; set; }

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("discord")]
            public string Discord { get; set; }

            [JsonProperty("website")]
            public string Website { get; set; }

            [JsonProperty("version")]
            public string Version { get; set; }
        }

        public class User
        {

            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("password")]
            public string Password { get; set; }

            [JsonProperty("edition")]
            public string Edition { get; set; }

            [JsonProperty("type")]
            public string GameType { get; set; }

            [JsonProperty("aid")]
            public string? AID { get; set; }

            [JsonProperty("server_ip")]
            public string ServerIP { get; set; }
        }
    }
}

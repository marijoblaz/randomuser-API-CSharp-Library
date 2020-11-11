using Newtonsoft.Json.Linq;

namespace randomuser
{
    public class Login
    {

        public string Uuid { get;  }
        public string Username { get;  }
        public string Password { get;  }
        public string Salt { get;  }
        public string Md5 { get;  }
        public string Sha1 { get;  }
        public string Sha256 { get;  }


        public Login(JToken loginData)
        {
            if (loginData is null)
                throw new System.ArgumentNullException(nameof(loginData));

            Uuid = loginData.SelectToken("uuid").ToString();
            Username = loginData.SelectToken("username").ToString();
            Password = loginData.SelectToken("password").ToString();
            Salt = loginData.SelectToken("salt").ToString();
            Md5 = loginData.SelectToken("md5").ToString();
            Sha1 = loginData.SelectToken("sha1").ToString();
            Sha256 = loginData.SelectToken("sha256").ToString();
        }
        public override string ToString()
        {
            return $"\n\tUuid: {Uuid}\n\tUsername: {Username}\n\tPassword: {Password}\n\tSalt: {Salt}\n\tMd5: " +
                   $"{Md5}\n\tSha1: {Sha1}\n\tSha256: {Sha256}";
        }
    }
}

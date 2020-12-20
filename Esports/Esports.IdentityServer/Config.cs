using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Esports.IdentityServer
{
     public class Config
    {
        public static IEnumerable<ApiResource> Apis
        {
            get
            {
                return new List<ApiResource>
                {
                new ApiResource("es-api", "es-api")
                };
            }
        }

        public static IEnumerable<Client> Clients
        {
            get {
                return new List<Client>
                {
                    new Client
                    {
                        ClientId = "client",
                        AllowedScopes = { "es-api" },

                        AllowedGrantTypes = GrantTypes.ClientCredentials,
                        ClientSecrets =
                        {
                            new Secret("ESport".Sha256())
                        }
                    }
                };
            }
        }
    }

}

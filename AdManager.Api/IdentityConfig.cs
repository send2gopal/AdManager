using System;
using System.Collections.Generic;
using IdentityModel;
using IdentityServer4;
using IdentityServer4.Models;
using IdentityServer4.Test;

namespace AdManager.Api
{
public class IdentityConfig
{
    public static IEnumerable<ApiResource> GetApiResources()
    {
        return new List<ApiResource>
        {
            new ApiResource()
                    {
                        Name = "api",
                        DisplayName = "Cherry API",
                        Scopes =
                        {
                            new Scope("api", "Cherry API"),
                            new Scope(IdentityServerConstants.StandardScopes.OpenId),
                            new Scope(IdentityServerConstants.StandardScopes.Email),
                            new Scope(IdentityServerConstants.StandardScopes.Profile),
                            new Scope(IdentityServerConstants.StandardScopes.OfflineAccess)
                        },
                        UserClaims =
                        {
                            "cherry_sample",
                            JwtClaimTypes.GivenName,
                            JwtClaimTypes.FamilyName,
                            JwtClaimTypes.Name,
                            JwtClaimTypes.Email,
                        }
                    }

        };
    }

    public static IEnumerable<Client> GetClients()
    {
        return new List<Client>
        {
            new Client
            {
                ClientId = "client",

                // no interactive user, use the clientid/secret for authentication
                AllowedGrantTypes = GrantTypes.ResourceOwnerPassword,
                AllowOfflineAccess = true,
            
            
                // secret for authentication
                ClientSecrets =
                {
                    new Secret("secret".Sha256())
                },

                // scopes that client has access to
                AllowedScopes = {  IdentityServerConstants.StandardScopes.OpenId,
                                    IdentityServerConstants.StandardScopes.Email,
                                    IdentityServerConstants.StandardScopes.Profile,
                                    IdentityServerConstants.StandardScopes.OfflineAccess,
                                    "api" }
            }
        };
    }

    public static List<TestUser> GetUsers()
    {
        return new List<TestUser>
        {
            new TestUser
            {
                SubjectId = "1",
                Username = "alice",
                Password = "password"
            },
            new TestUser
            {
                SubjectId = "2",
                Username = "bob",
                Password = "password"
            }
        };
    }
}
}
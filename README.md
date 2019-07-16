# Solution For BearerTokenGenerator

This project is a generate Bearer token for OAuth2.0 by passing the value like below

```C#
      new ClaimsIdentity(new Claim[]
      {
        new Claim("User", "e8b3d754-786e-4269-a668-7ed7ae580630"),

        new Claim("Details", "Valuable"),                            
      });         
```

# What is Bearer Token?
 Bearer Tokens are the predominant type of access token used with OAuth 2.0.
 A Bearer Token is an opaque string, not intended to have any meaning to clients using it. Some servers will issue tokens that are a short string of hexadecimal characters, while others may use structured tokens such as [JSON Web Tokens](https://oauth.net/2/jwt/).



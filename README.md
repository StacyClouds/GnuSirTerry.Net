# GnuSirTerry.Net

ASP.NET Core middleware that adds the `X-Clacks-Overhead: GNU Terry Pratchett` header to every HTTP response.

## What is GNU Sir Terry?

The Clacks is a telegraph-like communications network in Terry Pratchett's Discworld series. When a clacks operator died, their name was sent through the towers encoded in the overhead — keeping their name alive as long as the towers stood.

After Terry Pratchett's death in 2015, the internet adopted this tradition. Adding `X-Clacks-Overhead: GNU Terry Pratchett` to HTTP responses keeps his name travelling through the internet forever. GNU stands for "pass the message on, don't log it, and the message doesn't end at the final node."

Learn more at [gnuterrypratchett.com](http://www.gnuterrypratchett.com/).

## Usage

```csharp
app.UseGnuSirTerryMiddleware();
```

namespace Cardboard.HTTP;

/*
 * This is going to be the start of our pain I feel. What we are looking to
 * accomplish is a lightweight alternative to RestSharp. I want to have some
 * of the convenience features. Interceptors would be nice along with having
 * support for json "streams".
 *
 * https://github.com/restsharp/RestSharp/blob/bf4008f972257908d666b2884ec7fe330b759424/src/RestSharp/RestClient.Extensions.cs#L170
 *
 * Streams allow for some flexibility when it comes to things like the drive stream
 * https://transfem.social/api-doc#tag/drive/POST/drive/stream endpoint. I also
 * want to make a bucket system (with support for rate limit headers) so that
 * when we hit a rate limit our requests don't just disappear they're retried.
 * Discord.NET has their own HTTP client like this which we can also use as a
 * reference in combination with restsharp's code. I'll link that here as well.
 * 
 * https://github.com/discord-net/Discord.Net/blob/dev/src/Discord.Net.Core/Net/Rest/IRestClient.cs
 *
 * We should implement RestClient as IDisposable.
 */
public class RestClient
{
    internal HttpClient HttpClient { get; }
}
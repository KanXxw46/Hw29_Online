using HtmlAgilityPack;
using System;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

namespace _291020
{
    class Program
    {
        static void Main(string[] args)
        {
            public async Task<HtmlDocument> LoadPage(Uri address)
            {
                using (var httpResponse = await new HttpClient().GetAsync(address)
                    .ConfigureAwait(continueOnCapturedContext: false))
                using (var responseContent = httpResponse.Content)
                using (var contentStream = await responseContent.ReadAsStreamAsync()
                    .ConfigureAwait(continueOnCapturedContext: false)) 
                    return LoadHtmlDocument(contentStream); 
            }
        }

        private static Task<HtmlDocument> LoadHtmlDocument(Stream contentStream)
        {
            throw new NotImplementedException();
        }
    }
}

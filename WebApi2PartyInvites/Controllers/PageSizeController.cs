using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using WebApi2PartyInvites.Infrastructure;

namespace WebApi2PartyInvites.Controllers
{
    public class PageSizeController : ApiController, ICustomerController
    {
        private static string TargetUrl = "http://apress.com";
        public async Task<long> GetPaseSize(CancellationToken cToken)
        {    
            WebClient wc = new WebClient();
            Stopwatch sw = Stopwatch.StartNew();
            //byte[] apressData = await wc.DownloadDataTaskAsync(TargetUrl);
            //Debug.WriteLine("Elapsed ms: {0}", sw.ElapsedMilliseconds);
            //return apressData.LongLength;

            List<long> results = new List<long>();

            for (int i = 0; i < 10; i++)
            {
                if (!cToken.IsCancellationRequested)
                {
                    Debug.WriteLine("Making Request: {0}", i);
                    byte[] apressData = await wc.DownloadDataTaskAsync(TargetUrl);
                    results.Add(apressData.LongLength);
                }
                else
                {
                    Debug.WriteLine("Cancelled");
                    return 0;
                }
            }
            Debug.WriteLine("Elapsed ms: {0}", sw.ElapsedMilliseconds);
            return (long)results.Average();
        }

        public Task PostUrl(string newUrl, CancellationToken cToken)
        {
            TargetUrl = newUrl;
            return Task.FromResult<object>(null);
        }
    }
}
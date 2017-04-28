using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace WebApi2PartyInvites.Infrastructure
{
    public interface ICustomerController
    {
        Task<long> GetPaseSize(CancellationToken cToken);
        Task PostUrl(string newUrl, CancellationToken cToken);
    }
}
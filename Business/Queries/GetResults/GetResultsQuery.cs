using System.Collections.Generic;
using Contracts.Responses;
using Infrastructure.MediatR.Interfaces;

namespace Business.Queries.GetResults
{
    public class GetResultsQuery : IQuery<IReadOnlyCollection<BmiResultResource>>
    {
        public GetResultsQuery()
        {
        }
    }
}
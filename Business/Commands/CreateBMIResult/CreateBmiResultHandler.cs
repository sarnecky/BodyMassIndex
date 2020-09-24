using System;
using System.Threading;
using System.Threading.Tasks;
using Contracts.Responses;
using Database.SQL.Entities;
using Database.SQL.Repository;
using Infrastructure.Result;
using Infrastructure.Result.Results;
using MediatR;
using Unit = Infrastructure.Result.Unit;

namespace Business.Commands.CreateBMIResult
{
    public class CreateBmiResultHandler : IRequestHandler<CreateBmiResultCommand, IResult<Unit>>
    {
        private readonly IRepository<BmiResult> _repository;
        
        public CreateBmiResultHandler(IRepository<BmiResult> repository)
        {
            _repository = repository;
        }

        public async Task<IResult<Unit>> Handle(
            CreateBmiResultCommand request, 
            CancellationToken cancellationToken)
        {
            var bmi = Math.Round(
                (float)request.Weight / (request.Height * request.Height),
                MidpointRounding.ToEven);

            await _repository.AddAsync(new BmiResult(){ Bmi = 2, FirstName = "2", Height = 2, Weight = 2, LastName = "df"});
            await _repository.SaveAsync();
            return await new Unit().ToSuccessAsync();
        }
    }
}
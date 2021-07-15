using Example.Commands;
using Example.DartaAccess;
using Example.Models;
using Example.Queries;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Example.Handlers
{
    public class GetPersonByIdHandler : IRequestHandler<GetPersonByIdQuery, PersonModel>
    {
        private readonly IMediator _mediator;
        public GetPersonByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<PersonModel> Handle(GetPersonByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetPersonListQuery());
            var output = results.FirstOrDefault(x => x.Id == request.id);
            return output;
        }
    }

    public class InsertPersonHandler : IRequestHandler<InsertPersonCommamd, PersonModel>
    {
        private readonly IDemoDataAccess _dataAccess;
        public InsertPersonHandler(IDemoDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }
        public Task<PersonModel> Handle(InsertPersonCommamd request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataAccess.InsertPerson(request.FirstName, request.LastName));
        }
    }
}
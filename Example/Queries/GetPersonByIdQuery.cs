using Example.Models;
using MediatR;
using System;
using System.Linq;

namespace Example.Queries
{
    public record GetPersonByIdQuery(int id) : IRequest<PersonModel>;
}

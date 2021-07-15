using Example.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Queries
{
    public record GetPersonListQuery() : IRequest<List<PersonModel>>;
}

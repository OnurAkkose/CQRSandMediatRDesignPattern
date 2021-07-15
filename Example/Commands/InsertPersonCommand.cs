using Example.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example.Commands
{
    public record InsertPersonCommamd(string FirstName, string LastName) : IRequest<PersonModel>;
}

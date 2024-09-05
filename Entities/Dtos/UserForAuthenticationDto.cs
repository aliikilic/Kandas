using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public record UserForAuthenticationDto
    {
        public string? Email { get; init; }
        public string? Password { get; init; }
    }
}

using Petfolio.Communication.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Communication.Request
{
    public class RequestPetJson
    {

        public string Name { get; set; } = string.Empty;
        public DateTime Birthday { get; set; }

        public PetType type { get; set; }
    }
}

using Petfolio.Communication.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.GetAll
{

    public class GetAllPetUseCase
    {
        public ResponseAllPetJson Execute()
        {
            var response = new ResponseAllPetJson()
            {
                Pets = new List<ResponseShortPetJson>
                {
                    new ResponseShortPetJson()
                    {

                        Id = 1,
                        Name = "Belize",
                        Type = Communication.Enums.PetType.Dog


                    },
                    new ResponseShortPetJson()
                    {
                        Id = 2,
                        Name = "Austria",
                        Type = Communication.Enums.PetType.Cat,

                    }
                },
               
                

            };
            return response;
        }
    }
}


  

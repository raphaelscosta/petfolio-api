using Petfolio.Communication.Response;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Petfolio.Application.UseCases.Pet.GetById
{
    public class GetByIdUseCase
    {

        public ResponsePetJson? Execute(int id)
        {
            var pets = new List<ResponsePetJson>()
            {
                new ResponsePetJson
                {
                    Id = 1,
                    Name = "Doce"
                },
                new ResponsePetJson
                {

                    Id = 2,
                    Name = "Nikita"
                }
            };

            var result = pets.Find(p => p.Id == id);

            return result;


        }
    }
}

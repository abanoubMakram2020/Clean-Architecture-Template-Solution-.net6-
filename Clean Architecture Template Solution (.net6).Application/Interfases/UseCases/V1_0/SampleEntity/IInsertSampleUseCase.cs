using Clean_Architecture_Template_Solution__.net6_.Application.DTOs.OutputDTOs;
using SharedKernal.Middlewares.Basees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture_Template_Solution__.net6_.Application.Interfases.UseCases.V1_0
{
    public interface IInsertSampleUseCase : IBaseUseCase<IEnumerable<IdNameOutputDTO<string, string>>>
    {
    }
}

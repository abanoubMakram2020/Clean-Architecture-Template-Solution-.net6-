using Clean_Architecture_Template_Solution__.net6_.Presentation.API.Controllers;
using Microsoft.AspNetCore.Mvc;
using SharedKernal.Common;
using _UseCases = Clean_Architecture_Template_Solution__.net6_.Application.Interfases.UseCases;

namespace Clean_Architecture_Template_Solution__.net6_.Presentation.API.Areas.V1_0.Controllers
{
    [ApiVersion(version: APIVersion.Version1)]
    public class SampleController : BaseController
    {


        [HttpGet]
        [MapToApiVersion(APIVersion.Version1)]
        public async Task<IActionResult> Get([FromServices] _UseCases.V1_0.IInsertSampleUseCase insertCandidateCourseUseCase, int id) =>
            await Presenter.Handle(insertCandidateCourseUseCase.Handle);


    }

}

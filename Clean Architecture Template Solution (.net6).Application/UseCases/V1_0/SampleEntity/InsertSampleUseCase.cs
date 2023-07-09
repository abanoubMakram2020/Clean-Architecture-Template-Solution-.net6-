using Clean_Architecture_Template_Solution__.net6_.Application.DTOs.OutputDTOs;
using Clean_Architecture_Template_Solution__.net6_.Application.Interfases.UseCases.V1_0;
using Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities;
using Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Entity;
using SharedKernal.Middlewares.Basees;

/// <summary>
/// 
/// </summary>
namespace Clean_Architecture_Template_Solution__.net6_.Application.UseCases.V1_0
{
    /// <summary>
    /// 
    /// </summary>
    public class InsertSampleUseCase : BaseUseCase, IInsertSampleUseCase
    {

        public ISampleRepository SampleRepository { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseResultDto<IEnumerable<IdNameOutputDTO<string, string>>>> Handle()
        {
            return ResponseResultDto<IEnumerable<IdNameOutputDTO<string, string>>>.Success(result: null, message: "Version 1");
        }
    }
}

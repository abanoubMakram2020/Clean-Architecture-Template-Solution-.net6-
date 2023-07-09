using Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities;
using Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture_Template_Solution__.net6_.Domain.Repositories.Dapper
{
    public class DapperSampleRepository : DapperBaseRepository<SampleEntity, Guid>, IDapperSampleRepository
    {
        public DapperSampleRepository()
        {
        }
    }
}

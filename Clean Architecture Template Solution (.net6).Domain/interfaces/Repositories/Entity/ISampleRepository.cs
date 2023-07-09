using Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities;
using SharedKernal.DataRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Entity
{
    public interface ISampleRepository : IBaseRepository<SampleEntity, Guid>
    {
    }
}

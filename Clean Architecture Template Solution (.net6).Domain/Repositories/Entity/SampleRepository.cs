using Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities;
using Clean_Architecture_Template_Solution__.net6_.Domain.Interfases.Repositories.Entity;
using Microsoft.EntityFrameworkCore;
using System;


namespace Clean_Architecture_Template_Solution__.net6_.Domain.Repositories.Entity
{
    public class SampleRepository : EntityBaseRepository<SampleEntity, Guid>, ISampleRepository
    {
        public SampleRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
    }
}

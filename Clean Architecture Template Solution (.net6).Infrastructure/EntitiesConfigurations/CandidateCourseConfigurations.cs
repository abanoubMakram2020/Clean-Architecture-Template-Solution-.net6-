using Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities;
using Clean_Architecture_Template_Solution__.net6_.Infrastructure.DatabaseConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean_Architecture_Template_Solution__.net6_.Infrastructure.EntitiesConfigurations
{
    internal class CandidateCourseConfigurations : IEntityTypeConfiguration<SampleEntity>
    {
        public void Configure(EntityTypeBuilder<SampleEntity> builder)
        {
            builder.ToTable(name: TableName.CandidateCourses, schema: Schema.OutSourcing);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedNever().HasColumnType(ColumnType.Uniqueidentifier).IsRequired();
            builder.Property(p => p.DeptHeadApprovalId).HasColumnType(ColumnType.Uniqueidentifier).IsRequired();
            builder.Property(p => p.CourseName).HasColumnType(ColumnType.Nvarchar256).IsRequired();
            builder.Property(p => p.CourseCode).HasColumnType(ColumnType.Nvarchar256).IsRequired();

        }
    }
}

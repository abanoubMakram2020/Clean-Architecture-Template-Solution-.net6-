using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clean_Architecture_Template_Solution__.net6_.Domain.Data.Entities
{
    public class SampleEntity : BaseEntity<Guid>
    {

        public SampleEntity()
        {
            //DeptHeadApproval = new HashSet<DeptHeadApproval>();
        }


        public Guid DeptHeadApprovalId { get; set; }
        public string CourseName { get; set; }
        public string CourseCode { get; set; }
        //public ICollection<DeptHeadApproval> DeptHeadApproval { get; set; }



        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return Id;
            yield return DeptHeadApprovalId;
            yield return CourseName;
            yield return CourseCode;
        }
    }
}

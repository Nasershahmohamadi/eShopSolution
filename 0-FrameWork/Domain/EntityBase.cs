using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_FrameWork.Domain
{
    public class EntityBase
    {
        public long Id { get; private set; }
        public bool IsDeleted { get; private set; }
        public DateTime CreationDate { get;private set; }

        public EntityBase()
        {
            IsDeleted = false;
            CreationDate = DateTime.Now;
        }
    }
}

using NFine.Domain.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.SalverManager
{
    public class Warehouse : Entity<Warehouse>
    {
        public int F_Id { get; set; }

        public decimal F_Longitude { get; set; }

        public decimal F_Latitude { get; set; }

        /// <summary>
        /// 承租人Id
        /// </summary>
        public string F_UserId { get; set; }

        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }

        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }

        public bool? F_DeleteMark { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

        public virtual UserEntity User { get; set; }

    }
}

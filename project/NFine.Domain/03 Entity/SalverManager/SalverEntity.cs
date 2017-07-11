using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.SalverManager
{
    public class SalverEntity : Entity<SalverEntity>
    {
        public int F_Id { get; set; }
        /// <summary>
        /// 托盘名称
        /// </summary>
        public string F_SalverName { get; set; }
        /// <summary>
        /// 托盘标示
        /// </summary>
        public string F_SalverMark { get; set; }
        /// <summary>
        /// 托盘状态（待租，租赁中）
        /// </summary>
        public string F_Status { get; set; }

        public DateTime? F_CreatorTime { get; set; }
        public string F_CreatorUserId { get; set; }

        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }

        public bool? F_DeleteMark { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

        public virtual ICollection<SalverPosition> SalverPositions { get; set; }


    }
}

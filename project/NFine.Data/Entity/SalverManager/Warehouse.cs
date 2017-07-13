using NFine.Data.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.Entity.SalverManager
{
    public class Warehouse : Entity<Warehouse>
    {
        public int F_Id { get; set; }

        /// <summary>
        /// 仓库名称
        /// </summary>
        public string F_WarehouseName { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        public decimal F_Longitude { get; set; }
        /// <summary>
        /// 纬度
        /// </summary>
        public decimal F_Latitude { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string F_Remark { get; set; }

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

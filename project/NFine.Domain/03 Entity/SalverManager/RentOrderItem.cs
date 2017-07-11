using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.SalverManager
{
    public class RentOrderItem : Entity<RentOrderItem>
    {
        public int F_Id { get; set; }

        /// <summary>
        ///托盘Id
        /// </summary>
        public int F_SalverId { get; set; }


        public int F_OrderId { get; set; }

        public decimal Price { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }

        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }


        public bool? F_DeleteMark { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

        public virtual SalverEntity Salver { get; set; }
        public virtual RentOrder RentOrder { get; set; }

    }
}

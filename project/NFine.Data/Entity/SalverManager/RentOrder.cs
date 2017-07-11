using NFine.Data.Entity.SystemManage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.Entity.SalverManager
{
    public class RentOrder : Entity<RentOrder>
    {
        public int F_Id { get; set; }

        /// <summary>
        /// 承租人Id
        /// </summary>
        public string F_UserId { get; set; }
        /// <summary>
        /// 承租人名称
        /// </summary>
        public string F_Tenant { get; set; }

        /// <summary>
        /// 租赁开始日期
        /// </summary>
        public DateTime? F_RentalStartDate { get; set; }

        /// <summary>
        /// 租赁结束日期
        /// </summary>
        public DateTime? F_RentalEndDate { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        public decimal Amount { get; set; }
        /// <summary>
        /// 订单创建时间
        /// </summary>
        public DateTime? F_CreatorTime { get; set; }

        /// <summary>
        /// 订单结算日期
        /// </summary>
        public DateTime? F_CheckoutTime { get; set; }


        public string F_CreatorUserId { get; set; }
        public DateTime? F_LastModifyTime { get; set; }
        public string F_LastModifyUserId { get; set; }


        public bool? F_DeleteMark { get; set; }
        public DateTime? F_DeleteTime { get; set; }
        public string F_DeleteUserId { get; set; }

        public virtual ICollection<RentOrderNote> OrderNotes { get; set; }

        public virtual ICollection<RentOrderItem> OrderItems { get; set; }

        public virtual UserEntity User { get; set; }


    }
}

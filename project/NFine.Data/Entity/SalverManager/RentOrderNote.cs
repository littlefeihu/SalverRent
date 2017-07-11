using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.Entity.SalverManager
{
    public class RentOrderNote
    {
        public int F_Id { get; set; }

        /// <summary>
        ///订单Id
        /// </summary>
        public int F_OrderId { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string F_Note { get; set; }
        /// <summary>
        /// 显示给承租人
        /// </summary>
        public bool DisplayToTenant { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime F_CreatorTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string F_CreatorUserId { get; set; }



        public virtual RentOrder RentOrder { get; set; }
    }
}

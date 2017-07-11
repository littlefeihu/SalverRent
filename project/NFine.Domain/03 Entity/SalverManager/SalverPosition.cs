using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Domain.Entity.SalverManager
{
    public class SalverPosition : Entity<SalverPosition>
    {
        public int F_Id { get; set; }

        public int SalverId { get; set; }

        public decimal F_Longitude { get; set; }

        public decimal F_Latitude { get; set; }

        /// <summary>
        /// 托盘状态（待租，租赁中）
        /// </summary>
        public string F_Status { get; set; }

        public DateTime? F_CreatorTime
        {
            get;
            set;
        }

        public virtual SalverEntity Salver { get; set; }

    }
}

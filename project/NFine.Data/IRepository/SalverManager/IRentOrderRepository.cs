using NFine.Data.Entity.SalverManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFine.Data.IRepository.SalverManager
{
    public interface IRentOrderRepository : IRepositoryBase<RentOrder>
    {
        void DeleteForm(int keyValue);
        void SubmitForm(RentOrder userEntity, int? keyValue);
    }
}

/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using NFine.Code;
using NFine.Data;
using NFine.Data.Entity.SalverManager;
using NFine.Data.Entity.SystemManage;
using NFine.Data.IRepository.SalverManager;
using NFine.Data.IRepository.SystemManage;
using NFine.Repository.SystemManage;

namespace NFine.Repository.SalverManager
{
    public class RentOrderRepository : RepositoryBase<RentOrder>, IRentOrderRepository
    {

        public void DeleteForm(int keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<RentOrder>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(RentOrder salverEntity, int? keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (keyValue.HasValue)
                {
                    var salver = db.FindEntity<RentOrder>(o => o.F_Id == keyValue);
                    salver.F_Remark = salver.F_Remark;
                    salver.F_LastModifyTime = salver.F_LastModifyTime;
                    salver.F_LastModifyUserId = salver.F_LastModifyUserId;
                    db.Update(salver);
                }
                else
                {
                    db.Insert(salverEntity);
                }
                db.Commit();
            }
        }


    }
}

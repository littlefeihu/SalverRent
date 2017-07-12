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
    public class SalverRepository : RepositoryBase<SalverEntity>, ISalverRepository
    {

        public void DeleteForm(int keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<SalverEntity>(t => t.F_Id == keyValue);
                db.Commit();
            }
        }

        public void SubmitForm(SalverEntity userEntity, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(userEntity);
                }
                else
                {
                    db.Insert(userEntity);
                }
                db.Commit();
            }
        }


    }
}

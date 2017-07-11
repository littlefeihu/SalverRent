/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using NFine.Data;
using NFine.Data.Entity.SystemManage;
using NFine.Data.IRepository.SystemManage;
using NFine.Repository.SystemManage;
using System.Collections.Generic;

namespace NFine.Repository.SystemManage
{
    public class RoleRepository : RepositoryBase<RoleEntity>, IRoleRepository
    {
        public void DeleteForm(string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                db.Delete<RoleEntity>(t => t.F_Id == keyValue);
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == keyValue);
                db.Commit();
            }
        }
        public void SubmitForm(RoleEntity roleEntity, List<RoleAuthorizeEntity> roleAuthorizeEntitys, string keyValue)
        {
            using (var db = new RepositoryBase().BeginTrans())
            {
                if (!string.IsNullOrEmpty(keyValue))
                {
                    db.Update(roleEntity);
                }
                else
                {
                    roleEntity.F_Category = 1;
                    db.Insert(roleEntity);
                }
                db.Delete<RoleAuthorizeEntity>(t => t.F_ObjectId == roleEntity.F_Id);
                db.Insert(roleAuthorizeEntitys);
                db.Commit();
            }
        }
    }
}

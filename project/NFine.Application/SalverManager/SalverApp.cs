/*******************************************************************************
 * Copyright © 2016 东青信息版权所有
 * Author: Allen
 * 安徽东青信息软件开发组
 * 
*********************************************************************************/
using NFine.Code;
using NFine.Data.Entity.SalverManager;
using NFine.Data.Entity.SystemManage;
using NFine.Data.IRepository.SalverManager;
using NFine.Data.IRepository.SystemManage;
using NFine.Repository.SalverManager;
using NFine.Repository.SystemManage;
using System;
using System.Collections.Generic;

namespace NFine.Application.SystemManage
{
    public class SalverApp
    {
        private ISalverRepository service = new SalverRepository();

        public List<SalverEntity> GetList(Pagination pagination, string keyword)
        {
            var expression = ExtLinq.True<SalverEntity>();
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_SalverName.Contains(keyword));
                expression = expression.Or(t => t.F_Remark.Contains(keyword));
                expression = expression.Or(t => t.F_SalverMark.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public SalverEntity GetForm(int keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(SalverEntity salverEntity, string keyValue)
        {
            service.SubmitForm(salverEntity, keyValue);
        }
        public void UpdateForm(SalverEntity userEntity)
        {
            service.Update(userEntity);
        }


    }
}

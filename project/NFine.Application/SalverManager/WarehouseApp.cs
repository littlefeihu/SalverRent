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
    public class WarehouseApp
    {
        private IWarehouseRepository service = new WarehouseRepository();

        public List<Warehouse> GetList(Pagination pagination, string keyword, string userid)
        {
            var expression = ExtLinq.True<Warehouse>();
            expression = expression.And(t => t.F_UserId == userid);
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.And(t => t.F_WarehouseName.Contains(keyword));
                expression = expression.Or(t => t.F_Remark.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public Warehouse GetForm(int keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(Warehouse warehouseEntity, int? keyValue)
        {
            service.SubmitForm(warehouseEntity, keyValue);
        }
        public void UpdateForm(Warehouse warehouseEntity)
        {
            service.Update(warehouseEntity);
        }


    }
}

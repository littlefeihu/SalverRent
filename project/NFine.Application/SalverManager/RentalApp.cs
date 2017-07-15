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
    public class RentalApp
    {
        private IRentOrderRepository service = new RentOrderRepository();
        private IRentOrderItemRepository orderitemService = new RentalOrderItemRepository();

        public List<RentOrder> GetList(Pagination pagination, string keyword, string userid)
        {
            var expression = ExtLinq.True<RentOrder>();
            expression = expression.And(t => t.F_UserId.Equals(userid));
            if (!string.IsNullOrEmpty(keyword))
            {
                expression = expression.Or(t => t.F_Remark.Contains(keyword));
                expression = expression.Or(t => t.F_OrderID.Contains(keyword));
                expression = expression.Or(t => t.F_Tenant.Contains(keyword));
            }
            return service.FindList(expression, pagination);
        }
        public List<RentOrderItem> GetOrderItemListByOrderId(Pagination pagination, int orderId)
        {
            var expression = ExtLinq.True<RentOrderItem>();
            expression = expression.And(t => t.F_OrderId.Equals(orderId));

            return orderitemService.FindList(expression, pagination);
        }

        public RentOrder GetForm(int keyValue)
        {
            return service.FindEntity(keyValue);
        }
        public void DeleteForm(int keyValue)
        {
            service.DeleteForm(keyValue);
        }
        public void SubmitForm(RentOrder salverEntity, int? keyValue)
        {
            service.SubmitForm(salverEntity, keyValue);
        }
        public void UpdateForm(RentOrder userEntity)
        {
            service.Update(userEntity);
        }


    }
}

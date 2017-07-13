using NFine.Application.SystemManage;
using NFine.Code;
using NFine.Data.Entity.SalverManager;
using NFine.Data.Entity.SystemManage;
using NFine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;


namespace NFine.Web.Areas.SalverManager.Controllers
{
    public class WarehouseController : ControllerBase
    {
        private WarehouseApp warehouseApp = new WarehouseApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = warehouseApp.GetList(pagination, keyword, CurrentUser.UserId),
                total = pagination.total,
                page = pagination.page,
                records = pagination.records
            };
            return Content(data.ToJson());
        }
        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetFormJson(int keyValue)
        {
            var data = warehouseApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(Warehouse warehouseEntity, int? keyValue)
        {
            if (!keyValue.HasValue)
            {
                warehouseEntity.F_CreatorTime = DateTime.Now;
                warehouseEntity.F_CreatorUserId = CurrentUser.UserId;
                warehouseEntity.F_LastModifyTime = DateTime.Now;
                warehouseEntity.F_LastModifyUserId = CurrentUser.UserId;
                warehouseEntity.F_UserId = CurrentUser.UserId;
            }
            else
            {
                warehouseEntity.F_LastModifyTime = DateTime.Now;
                warehouseEntity.F_LastModifyUserId = CurrentUser.UserId;
            }

            warehouseApp.SubmitForm(warehouseEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(int keyValue)
        {
            warehouseApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
    }
}

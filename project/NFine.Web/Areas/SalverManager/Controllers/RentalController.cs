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
    public class RentalController : ControllerBase
    {
        private RentalApp rentalApp = new RentalApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = rentalApp.GetList(pagination, keyword, CurrentUser.UserId),
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
            var data = rentalApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(RentOrder rentalOrderEntity, int? keyValue)
        {
            if (!keyValue.HasValue)
            {
                rentalOrderEntity.F_Tenant = CurrentUser.UserName;
                rentalOrderEntity.F_UserId = CurrentUser.UserId;
                rentalOrderEntity.F_CreatorTime = DateTime.Now;
                rentalOrderEntity.F_CreatorUserId = CurrentUser.UserId;
                rentalOrderEntity.F_LastModifyTime = DateTime.Now;
                rentalOrderEntity.F_LastModifyUserId = CurrentUser.UserId;
                rentalOrderEntity.F_OrderID = string.Format("{0:yyyyMMddHHmmssffff}", DateTime.Now);
            }
            else
            {
                rentalOrderEntity.F_LastModifyTime = DateTime.Now;
                rentalOrderEntity.F_LastModifyUserId = CurrentUser.UserId;
            }

            rentalApp.SubmitForm(rentalOrderEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult PlaceOrderForm(RentOrder rentOrderEntity, int? keyValue)
        {

            return Success("操作成功。");
        }


        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(int keyValue)
        {
            rentalApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
        [HttpGet]
        public ActionResult CreateRental()
        {
            return View();
        }
        [HttpGet]
        public ActionResult MyRental()
        {
            return View();
        }
        [HttpGet]
        public ActionResult PlaceOrderForm()
        {
            return View();
        }

    }
}

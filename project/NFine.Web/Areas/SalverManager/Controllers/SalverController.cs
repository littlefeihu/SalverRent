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
    public class SalverController : ControllerBase
    {
        private SalverApp salverApp = new SalverApp();

        [HttpGet]
        [HandlerAjaxOnly]
        public ActionResult GetGridJson(Pagination pagination, string keyword)
        {
            var data = new
            {
                rows = salverApp.GetList(pagination, keyword),
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
            var data = salverApp.GetForm(keyValue);
            return Content(data.ToJson());
        }
        [HttpPost]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult SubmitForm(SalverEntity userEntity, int? keyValue)
        {
            if (!keyValue.HasValue)
            {
                userEntity.F_Status = SalverStatus.待租赁.ToString();
                userEntity.F_CreatorTime = DateTime.Now;
                userEntity.F_CreatorUserId = CurrentUser.UserId;
                userEntity.F_LastModifyTime = DateTime.Now;
                userEntity.F_LastModifyUserId = CurrentUser.UserId;
            }
            else
            {
                userEntity.F_LastModifyTime = DateTime.Now;
                userEntity.F_LastModifyUserId = CurrentUser.UserId;
            }

            salverApp.SubmitForm(userEntity, keyValue);
            return Success("操作成功。");
        }
        [HttpPost]
        [HandlerAuthorize]
        [HandlerAjaxOnly]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteForm(int keyValue)
        {
            salverApp.DeleteForm(keyValue);
            return Success("删除成功。");
        }

        [HttpGet]
        public ActionResult Info()
        {
            return View();
        }
    }
}

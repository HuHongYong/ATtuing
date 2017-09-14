using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ATtuing.Service;

namespace ATtuing.UnitTest
{
    [TestClass]
    public class EQEventUnitTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Mapper映射
            MapperConfiguration.Configure();
            EQEventService service = new EQEventService();
           var eqevent= service.GetById();
            Assert.AreEqual(eqevent.EQId, "20150109121037");
            //            public ActionResult Index()
            //{
            //    var xx = EQEventService.GetById();
            //    return Json(xx);
            //}
            //public ActionResult IndexSql()
            //{
            //    var xx = EQEventService.GetByIdSql();
            //    return Json(xx);
            //}
            //public ActionResult IndexInclude()
            //{
            //    var xx = EQEventService.IncludeEQEvent();
            //    return Json(xx);
            //}
            ////一对多最佳测试
            //public ActionResult Index1()
            //{
            //    var xx = EQEventService.GetEQEventTask();
            //    return View();
            //}
        }
    }
}

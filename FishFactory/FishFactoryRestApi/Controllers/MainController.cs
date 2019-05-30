using FishFactoryServiceDAL.BindingM;
using FishFactoryServiceDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FishFactoryRestApi.Controllers
{
    public class MainController : ApiController
    {
        private readonly IMainService _service;
        public MainController(IMainService service)
        {
            _service = service;
        }
        [HttpGet]
        public IHttpActionResult GetList()
        {
            var list = _service.GetList();
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }
        [HttpPost]
        public void CreateRequest(RequestBindingM model)
        {
            _service.CreateRequest(model);
        }
        [HttpPost]
        public void TakeRequestInWork(RequestBindingM model)
        {
            _service.TakeRequestInWork(model);
        }
        [HttpPost]
        public void FinishRequest(RequestBindingM model)
        {
            _service.FinishRequest(model);
        }
        [HttpPost]
        public void PayRequest(RequestBindingM model)
        {
            _service.PayRequest(model);
        }
        [HttpPost]
        public void PutTypeOfFishOnStorage(StorageFishBindingM model)
        {
            _service.PutTypeOfFishOnStorage(model);
        }
    }
}

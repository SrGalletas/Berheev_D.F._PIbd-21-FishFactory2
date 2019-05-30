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
    public class ReptController : ApiController
    {
        private readonly IReptService _service;
        public ReptController(IReptService service)
        {
            _service = service;
        }
        [HttpGet]
        public IHttpActionResult GetStoragesLoad()
        {
            var list = _service.GetStoragesLoad();
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }
        [HttpPost]
        public IHttpActionResult GetCustomerRequests(ReptBindingM model)
        {
            var list = _service.GetCustomerRequests(model);
            if (list == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(list);
        }
        [HttpPost]
        public void SaveCannedFoodCost(ReptBindingM model)
        {
            _service.SaveCannedFoodCost(model);
        }
        [HttpPost]
        public void SaveStoragesLoad(ReptBindingM model)
        {
            _service.SaveStoragesLoad(model);
        }
        [HttpPost]
        public void SaveCustomerRequests(ReptBindingM model)
        {
            _service.SaveCustomerRequests(model);
        }
    }
}

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
    public class StorageController : ApiController
    {
        private readonly IStorageService _service;
        public StorageController(IStorageService service)
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
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var element = _service.GetElement(id);
            if (element == null)
            {
                InternalServerError(new Exception("Нет данных"));
            }
            return Ok(element);
        }
        [HttpPost]
        public void AddElement(StorageBindingM model)
        {
            _service.AddElement(model);
        }
        [HttpPost]
        public void UpdElement(StorageBindingM model)
        {
            _service.UpdElement(model);
        }
        [HttpPost]
        public void DelElement(StorageBindingM model)
        {
            _service.DelElement(model.Id);
        }
    }
}

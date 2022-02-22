using MyNewAspWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyNewAspWebAPI.Controllers
{
    public class NewApiController : ApiController
    {
    
        PRATICEEntities db = new PRATICEEntities();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index()
        {
            List<student> obj = db.students.ToList();
            return Ok(obj);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = db.students.Where(model => model.std_id == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}

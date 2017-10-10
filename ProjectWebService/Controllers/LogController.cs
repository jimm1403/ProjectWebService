using ProjectWebService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProjectWebService.Controllers
{
    public class LogController : ApiController
    {
        // GET: api/Log/ulla
        public Notification GetByName(string name)
        {
            Log logReader = new Log();
            logReader.ReadLog();
            return logReader.Search(name);
        }

        // GET: api/Log/
        public List<Notification> GetAll()
        {
            Log logReader = new Log();
            logReader.ReadLog();
            return logReader.GetList();
        }

        // POST: api/Log
        public void Post()
        {

        }
    }
}

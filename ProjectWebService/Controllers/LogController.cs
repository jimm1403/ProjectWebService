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
        public Notification Get(string name)
        {
            Log logReader = new Log();
            logReader.ReadLog();
            return logReader.Search(name);
        }
    }
}

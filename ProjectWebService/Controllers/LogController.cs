﻿using ProjectWebService.Models;
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

        // GET: api/Log/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Log
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Log/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Log/5
        public void Delete(int id)
        {
        }
    }
}

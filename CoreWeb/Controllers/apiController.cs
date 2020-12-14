using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWeb.Controllers
{
    public class apiController : Controller
    {
        public string test1() {
            return "I'm test api.";
        }
    }
}

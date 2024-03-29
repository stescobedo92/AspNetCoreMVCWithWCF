﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoServiceReference;
using ProductServiceReference;

namespace ClientWCF.Controllers
{
    [Route("demo")]
    public class DemoController : Controller
    {
        private DemoServiceClient _demoServiceClient = new DemoServiceClient();
        private ProductServiceClient _productServiceClient = new ProductServiceClient();

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {
            ViewBag.result1 = _demoServiceClient.HelloAsync().Result;
            ViewBag.result2 = _demoServiceClient.HiAsync("ABC").Result;
            ViewBag.result3 = _demoServiceClient.SumAsync(12,23).Result;

            //Get data of product service
            ViewBag.product = _productServiceClient.findAsync().Result;
            ViewBag.products = _productServiceClient.findAllAsync().Result;
            return View();
        }
    }
}
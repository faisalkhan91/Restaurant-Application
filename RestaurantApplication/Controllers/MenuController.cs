﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestaurantApplication.Helper;
using RestaurantApplication.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RestaurantApplication.Controllers
{
    public class MenuController : Controller
    {
        // GET: /<controller>/

        DataHelper _helper = new DataHelper();

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public async Task<IActionResult> Add(Menu men)
        {
            if (ModelState.IsValid)
            {
                List<Menu> item = new List<Menu>();
                HttpClient client = _helper.InitializeBase();
                string postString = JsonConvert.SerializeObject(item);
                HttpContent _content = new StringContent(postString, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync("api/Orders", _content);
                ViewBag.ValidationMessage = null;
                if (res.IsSuccessStatusCode == true)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    item = JsonConvert.DeserializeObject<List<Menu>>(result);
                }
                return View(item);
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Add");
        }

        [HttpGet]
        public async Task<IActionResult> List()
        {
            List<Menu> item = new List<Menu>();
            HttpClient client = _helper.InitializeBase();
            HttpResponseMessage res = await client.GetAsync("api/Menus");
            if (res.IsSuccessStatusCode == true)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<List<Menu>>(result);
            }
            return View(item);
        }
    }
}

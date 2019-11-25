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
    public class OrderController : Controller
    {
        // GET: /<controller>/

        DataHelper _helper = new DataHelper();
        
        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public async Task<IActionResult> Create(Order ord)
        {
            if (ModelState.IsValid)
            {
                Order item = new Order();
                item = ord;
                HttpClient client = _helper.InitializeBase();
                string postString = JsonConvert.SerializeObject(item);
                HttpContent _content = new StringContent(postString, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync("api/Orders", _content);
                ViewBag.ValidationMessage = null;
                if (res.IsSuccessStatusCode == true)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    item = JsonConvert.DeserializeObject<Order>(result);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["Status"] = "500";
                }
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Create");
        }

        [HttpGet]
        public async Task<IActionResult> Display()
        {
            List<Order> item = new List<Order>();
            HttpClient client = _helper.InitializeBase();
            HttpResponseMessage res = await client.GetAsync("api/Orders");
            if (res.IsSuccessStatusCode == true)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<List<Order>>(result);
            }
            return View(item);
        }

        [HttpGet]
        public async Task<IActionResult> Change(int id)
        {
            Order item = new Order();
            HttpClient client = _helper.InitializeBase();
            item.OrderId = id;
            string url = "api/Orders/" + item.OrderId;
            HttpResponseMessage res = await client.GetAsync(url);
            if (res.IsSuccessStatusCode == true)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                item = JsonConvert.DeserializeObject<Order>(result);
            }
            return View(item);
        }

        [HttpPost]
        public async Task<IActionResult> Change(Order ord)
        {
            if (ModelState.IsValid)
            {
                Order item = new Order();
                item = ord;

                HttpClient client = _helper.InitializeBase();
                string postString = JsonConvert.SerializeObject(item);
                HttpContent _content = new StringContent(postString, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PutAsync("api/Orders", _content);
                ViewBag.ValidationMessage = null;
                if (res.IsSuccessStatusCode == true)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    item = JsonConvert.DeserializeObject<Order>(result);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewData["Status"] = "500";
                }
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Change");
        }
    }
}

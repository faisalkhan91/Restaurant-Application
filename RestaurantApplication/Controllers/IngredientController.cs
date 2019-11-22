using System;
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
    public class IngredientController : Controller
    {
        // GET: /<controller>/
        DataHelper _helper = new DataHelper();

        [HttpGet]
        public IActionResult Insert()
        {
            return View("Insert");
        }

        [HttpPost]
        public async Task<IActionResult> Insert(Ingredient ing)
        {
            if (ModelState.IsValid)
            {
                List<Ingredient> item = new List<Ingredient>();
                HttpClient client = _helper.InitializeBase();
                string postString = JsonConvert.SerializeObject(item);
                HttpContent _content = new StringContent(postString, System.Text.Encoding.UTF8, "application/json");
                HttpResponseMessage res = await client.PostAsync("api/Ingredients", _content);
                ViewBag.ValidationMessage = null;
                if (res.IsSuccessStatusCode == true)
                {
                    var result = res.Content.ReadAsStringAsync().Result;
                    //item = JsonConvert.DeserializeObject<List<Menu>>(result);
                }
                return View(item);
            }
            else
            {
                ViewBag.ValidationMessage = "Validation not Passed.";
            }
            return View("Insert");
        }

        [HttpGet]
        public async Task<IActionResult> View()
        {
            List<Ingredient> item = new List<Ingredient>();
            HttpClient client = _helper.InitializeBase();
            HttpResponseMessage res = await client.GetAsync("api/Ingredients");
            if (res.IsSuccessStatusCode == true)
            {
                var result = res.Content.ReadAsStringAsync().Result;
                //item = JsonConvert.DeserializeObject<List<Menu>>(result);
            }
            return View(item);
        }
    }
}

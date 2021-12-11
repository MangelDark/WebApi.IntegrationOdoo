using Client.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Client.Controllers
{
    public class ResPartnerController : Controller
    {
        // GET: ResPartnerController
        public async Task<ActionResult> Index()
        {
            List<ResPartnerViewModel> data = null;
            using (var client = new HttpClient())
            {
                try
                {
                    client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //HTTP GET
                    var responseTask = client.GetAsync("ResPartnerOdoo");
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        //JavaScriptSerializer ser = new JavaScriptSerializer();
                        //var records =  ser.Deserialize<List<ProductModel>>(jsonData);
                        data = JsonConvert.DeserializeObject<List<ResPartnerViewModel>>(await result.Content.ReadAsStringAsync());
                    }
                }
                catch (Exception)
                {

                    throw;
                }
               
                return View(data);
            }
        }

        // GET: ResPartnerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ResPartnerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ResPartnerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(ResPartnerViewModel collection)
        {

            try
            {
                using (var client = new HttpClient())
                {
                 
                        client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //The data that needs to be sent. Any object works.
             
                    //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
                    string json = JsonConvert.SerializeObject(collection);

                    //Needed to setup the body of the request
                    StringContent data = new StringContent(json, Encoding.UTF8, "application/json");
                    //HTTP GET
                    var responseTask = client.PostAsync("ResPartnerOdoo", data);
                        responseTask.Wait();
                        var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        //JavaScriptSerializer ser = new JavaScriptSerializer();
                        //var records =  ser.Deserialize<List<ProductModel>>(jsonData);
                      var  resp = JsonConvert.DeserializeObject<List<ResPartnerViewModel>>(await result.Content.ReadAsStringAsync());
                    }

                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ResPartnerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ResPartnerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Edit(int id, ResPartnerViewModel collection)
        {
            try
            {
                using (var client = new HttpClient())
                {


                    collection.Id = id;
                    client.BaseAddress = new Uri("https://localhost:5001/api/");
                    //The data that needs to be sent. Any object works.

                    //Converting the object to a json string. NOTE: Make sure the object doesn't contain circular references.
                    string json = JsonConvert.SerializeObject(collection);

                    //Needed to setup the body of the request
                    StringContent data = new StringContent(json,Encoding.UTF8, "application/json");
                    //HTTP GET
                    var responseTask = client.PutAsync("ResPartnerOdoo", data);
                    responseTask.Wait();
                    var result = responseTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        //JavaScriptSerializer ser = new JavaScriptSerializer();
                        //var records =  ser.Deserialize<List<ProductModel>>(jsonData);
                        var resp = JsonConvert.DeserializeObject<List<ResPartnerViewModel>>(await result.Content.ReadAsStringAsync());
                    }

                }
                return View();

            }
            catch
            {
                return View();
            }
        }

        // GET: ResPartnerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ResPartnerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}

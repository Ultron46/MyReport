using DevOps.UI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DevOps.UI.Controllers
{
    public class UserController : Controller
    {
        string baseUrl = "http://localhost:60969/";
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Registration(User user)
        {
            List<User> users = new List<User>();
            var client = new HttpClient();
            
                client.BaseAddress = new Uri(baseUrl);

                client.DefaultRequestHeaders.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage Res = await client.GetAsync("api/Users/GetAllUsers");

                if (Res.IsSuccessStatusCode)
                {
                    var MainMEnuResponse = Res.Content.ReadAsStringAsync().Result;

                    users = JsonConvert.DeserializeObject<List<User>>(MainMEnuResponse);
                }
            bool check = true;
            if(users.Any(x => x.Email == user.Email))
            {
                ViewBag.EmailError = "email id already exists";
                check = false;
            }
            if (users.Any(x => x.Phone == user.Phone))
            {
                ViewBag.PhoneError = "Mobile Number is already exists";
                check = false;
            }
            if(check)
            {
                client.DefaultRequestHeaders.Clear();
                //Res = await client.PostAsync("api/Users/InsertUser");

                var stringContent = new StringContent(JsonConvert.SerializeObject(user), Encoding.UTF8, "application/json");

                var addressUri = new Uri("api/Users/InsertUser", UriKind.Relative);
                Res = client.PostAsync(addressUri, stringContent).Result;

                if (Res.IsSuccessStatusCode)
                {
                    //var MainMEnuResponse = Res.Content.ReadAsStringAsync().Result;

                    //users = JsonConvert.DeserializeObject<List<User>>(MainMEnuResponse);
                    return View("Login");
                }
            }

            return View("Registration", user);
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Login(User user)
        {
            List<User> users = new List<User>();
            var client = new HttpClient();

            client.BaseAddress = new Uri(baseUrl);

            client.DefaultRequestHeaders.Clear();

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage Res = await client.GetAsync("api/Users/GetAllUsers");

            if (Res.IsSuccessStatusCode)
            {
                var MainMEnuResponse = Res.Content.ReadAsStringAsync().Result;

                users = JsonConvert.DeserializeObject<List<User>>(MainMEnuResponse);
            }
            //bool check = true;
            if ((users.Any(x => x.Email == user.Email)) && (users.Any(x => x.Password == user.Password)))
            {

                return View("Registration", user);
                //ViewBag.EmailError = "Email id is Not Valid";
                //check = false;
            }
            else
            {
                ViewBag.LoginError = "Not valid";
                return View("Login", user);
            }
           

        }


        
    }
}
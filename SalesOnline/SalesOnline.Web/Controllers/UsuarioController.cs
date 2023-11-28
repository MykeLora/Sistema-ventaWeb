using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SalesOnline.Application.Contract;
using SalesOnline.Application.Dtos.Usuario;
using SalesOnline.Web.Models.Responses;

namespace SalesOnline.Web.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService usuarioService;

        HttpClientHandler clientHandler = new HttpClientHandler();

        public UsuarioController(IUsuarioService usuarioService)
        {
            this.usuarioService = usuarioService;
        }

        // GET: UsuarioController
        public ActionResult Index()
        {
            UsuarioListResponse usuarioList = new UsuarioListResponse();            

            using (var client = new HttpClient(this.clientHandler))
            {
                using (var response = client.GetAsync("http://localhost:5145/api/Usuario/GetUsuarios").Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;

                        usuarioList = JsonConvert.DeserializeObject<UsuarioListResponse>(apiResponse);
                        

                        if (!usuarioList.success)
                        {
                            ViewBag.Message = usuarioList.message;
                            return View();
                        }

                    }
                    else
                    {
                        usuarioList.message = "Error conectandose al api.";
                        usuarioList.success = false;
                        ViewBag.Message = usuarioList.message;
                        return View();
                    }
                }
            }

            return View(usuarioList.data);
        }

        // GET: UsuarioController/Details/5
        public ActionResult Details(int id)
        {

            UsuarioDetailResponse usuarioDetailResponse = new UsuarioDetailResponse();


            using (var client = new HttpClient(this.clientHandler))
            {

                var url = $"http://localhost:5145/api/Usuario/GetUsuario?id={id}";

                using (var response = client.GetAsync(url).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;

                        usuarioDetailResponse = JsonConvert.DeserializeObject<UsuarioDetailResponse>(apiResponse);

                        if (!usuarioDetailResponse.success)
                            ViewBag.Message = usuarioDetailResponse.message;
                    }
                }
            }


            return View(usuarioDetailResponse.data);
        }

        // GET: UsuarioController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuarioController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UsuarioDtoAdd usuarioDtoAdd)
        {
            BaseResponse baseResponse = new BaseResponse();

            try
            {

                using (var client = new HttpClient(this.clientHandler))
                {

                    var url = $"http://localhost:5145/api/Usuario/SaveUsuario";

                    usuarioDtoAdd.FechaMod = DateTime.Now;
                    usuarioDtoAdd.IdUsuarioMod = 1;

                    StringContent content = new StringContent(JsonConvert.SerializeObject(usuarioDtoAdd), System.Text.Encoding.UTF8, "application/json");

                    using (var response = client.PostAsync(url, content).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = response.Content.ReadAsStringAsync().Result;

                            baseResponse = JsonConvert.DeserializeObject<BaseResponse>(apiResponse);

                            if (!baseResponse.success)
                            {
                                ViewBag.Message = baseResponse.message;
                                return View();
                            }

                        }
                        else
                        {
                            baseResponse.message = "Error conectandose al api.";
                            baseResponse.success = false;
                            ViewBag.Message = baseResponse.message;
                            return View();
                        }
                    }
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Message = baseResponse.message;
                return View();
            }
        }

        // GET: UsuarioController/Edit/5
        public ActionResult Edit(int id)
        {
            UsuarioDetailResponse usuarioDetailResponse = new UsuarioDetailResponse();


            using (var client = new HttpClient(this.clientHandler))
            {

                var url = $"http://localhost:5145/api/Usuario/GetUsuario?id={id}";

                using (var response = client.GetAsync(url).Result)
                {
                    if (response.IsSuccessStatusCode)
                    {
                        string apiResponse = response.Content.ReadAsStringAsync().Result;

                        usuarioDetailResponse = JsonConvert.DeserializeObject<UsuarioDetailResponse>(apiResponse);

                    }
                }
            }


            return View(usuarioDetailResponse.data);
        }


        // POST: UsuarioController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UsuarioDtoUpdate usuarioDtoUpdate)
        {
            BaseResponse baseResponse = new BaseResponse();

            try
            {

                using (var client = new HttpClient(this.clientHandler))
                {

                    var url = $"http://localhost:5145/api/Usuario/UpdateUsuario";

                    usuarioDtoUpdate.FechaMod = DateTime.Now;
                    usuarioDtoUpdate.IdUsuarioMod = 1;

                    StringContent content = new StringContent(JsonConvert.SerializeObject(usuarioDtoUpdate), System.Text.Encoding.UTF8, "application/json");

                    using (var response = client.PostAsync(url, content).Result)
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string apiResponse = response.Content.ReadAsStringAsync().Result;

                            baseResponse = JsonConvert.DeserializeObject<BaseResponse>(apiResponse);

                            if (!baseResponse.success)
                            {
                                ViewBag.Message = baseResponse.message;
                                return View();
                            }

                        }
                        else
                        {
                            ViewBag.Message = baseResponse.message;
                            return View();
                        }
                    }
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ViewBag.Message = baseResponse.message;
                return View();
            }
        }
    }
}


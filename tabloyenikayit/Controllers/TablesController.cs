using BusinessLayer.Tables;
using DataAcsess;
using DataAcsess.Model;
using Microsoft.AspNetCore.Mvc;

namespace tabloyenikayit.Controllers
{
    public class TablesController : Controller
    {

        public IActionResult Index()
        {
            // var tempdataDelete = TempData["Message"];
            return View(TablesManager.TablesGetAll());
        }

        [HttpGet]                             //KAYIT ETME GET
        [Route("/Tables/Insert")]
        public IActionResult Insert()
        {
            return View();
        }

        [HttpPost]                            //KAYIT ETME POST
        [Route("/Tables/Insert")]
        public IActionResult Insert(Personel personel)
        {
            string message = TablesManager.InsertTables(personel);
            if (message.Contains("Error"))
            {
                var aa = message.Split(':');
                ViewBag.ErrorMessage = aa[1];

            }
            else
            {
                var ss= message.Split(':');
                ViewBag.Message = ss[1];

            }
            return View();
        }

        [HttpGet]
        [Route("/Tables/Update/{id}")]           //GÜNCELLEME GET
        public IActionResult Update(int id)
        {
            return View(TablesManager.TablesGetById(id));
        }


        [HttpPost]
        [Route("/Tables/Update/{id}")]        //GÜNCELLEME POST
        public IActionResult Update(int id, Personel personel)
        {
            ViewBag.Message = TablesManager.UpdateTables(id, personel);
            return View(TablesManager.TablesGetById(id));

        }

        [HttpGet]                            //SİLME
        [Route("/Tables/Delete/{id}")]
        public IActionResult Delete(int id)
        {

            TempData["Message"] = TablesManager.DeleteTables(id);

            return Redirect("/Tables/Index");
        }
    }
}

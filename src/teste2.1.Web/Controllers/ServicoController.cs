using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using teste2._1.Web.Models;
using teste2._1.Web.Service;

namespace teste2._1.Web.Controllers
{
    public class ServicoController : Controller
    {
        private ServicoService service;

        public ServicoController()
        {
            service = new Service.ServicoService();
        }
        #region Get
        [HttpGet]
        // GET: Servico
        public ActionResult Index()
        {
            ViewBag.Title = "Listar Serviço";
            var model = service.GetAll();
            return View(model);
        }

        [HttpGet]
        // GET: Servico
        public ActionResult Create()
        {
            ViewBag.Title = "Criar Serviço";
            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.Title = "Editar Serviço";
            var model = service.Get(id);
            return View(model);
        }
        [HttpGet]
        public ActionResult Details(int id)
        {
            ViewBag.Title = "Detalhar Serviço";
            var model = service.Get(id);
            return View(model);
        }
      [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.Title = "Detalhar Serviço";
            var model = service.Get(id);
            return View(model);
        }
        #endregion

        #region Post

        [HttpPost]

        public ActionResult Create(ServicosViewModel model)
        {
            ViewBag.Title = "Criar serviço";
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            service.Add(model);
            return RedirectToAction("Index");
        }
        [HttpPost]

        public ActionResult Delete (ServicosViewModel model)
        {
            ViewBag.Title = "Excluir serviço";
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            service.Remove(model);
            return RedirectToAction("Index");
        }
        [HttpPost]

        public ActionResult Edit(ServicosViewModel model)
        {
            ViewBag.Title = "Criar serviço";
            if (ModelState.IsValid == false)
            {
                return View(model);
            }
            service.Update(model);
            return RedirectToAction("Index");
        }
        #endregion
    }







}

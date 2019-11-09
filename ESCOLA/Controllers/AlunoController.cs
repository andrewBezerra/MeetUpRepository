using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ESCOLA.DAO;
using ESCOLA.Models;
using ESCOLA.REPOSITORIO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ESCOLA.Controllers
{
    public class AlunoController : Controller
    {
        //ALUNODAO ALUDAO = new ALUNODAO();
        IAlunoRepositorio _rep;

        public AlunoController(IAlunoRepositorio rep)
        {
            _rep = rep;
        }


        // GET: Aluno
        public ActionResult Index()
        {
            return View(_rep.Listar());
        }

        // GET: Aluno/Details/5
        public ActionResult Details(int id)
        {
            return View(_rep.BuscarporID(id));
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Aluno item)
        {
            try
            {
                // TODO: Add insert logic here
                _rep.Adicionar(item);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception err)
            {
                return View();
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Aluno/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
using AradFinal.Core.Interfaces;
using AradFinal.Core.ViewModels.Dashboard;
using AradFinal.DAL.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AradFinal.Controllers
{
    public class SocialController : Controller
    {
        private IDashboard _dashboard;
        public SocialController(IDashboard dashboard)
        {
            _dashboard = dashboard;
        }
        public async Task<IActionResult> Index()
        {
            List<Social> socials = await _dashboard.GetSocials();
            return View(socials);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SocialViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                _dashboard.AddSocial(viewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(viewModel);
           
        }

        public async Task<IActionResult> Edit(Guid id)
        {
            Social social = await _dashboard.GetSocial(id);
            SocialViewModel viewModel = new SocialViewModel()
            {
                Address = social.Address,
                Color = social.Color,
                Icon = social.Icon,
                Name = social.Name,
                OrderShow = social.OrderShow
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(SocialViewModel viewModel , Guid id)
        {
            if (ModelState.IsValid)
            {
                _dashboard.UpdateSocial(viewModel, id);
                return RedirectToAction(nameof(Index));
            }

            return View(viewModel);
          
        }

        public IActionResult Trash(Guid id)
        {
            _dashboard.GoTrashSocial(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(Guid id)
        {
            _dashboard.DeleteSocial(id);
            return RedirectToAction(nameof(Index));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LeilaoVirtual.Domain.Base;
using LeilaoVirtual.Domain.Features.Products;
using LeilaoVirtual.Domain.Features.Products.Interfaces;
using LeilaoVirtual.Presentation.Models.Features.Products;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LeilaoVirtual.Presentation.Controllers
{
    
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        private readonly IMapper _mapper;

        public ProductController(IProductService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }
        // GET: ProductController
        public ActionResult Index()
        {
            var products =_service.GetAll();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var product = _mapper.Map<IEnumerable<ProductViewModel>>(_service.GetById(id));
            return View();
        }


        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductViewModel productViewModel)
        {
            if (!ModelState.IsValid) return BadRequest();

            try
            {
                _service.Add(_mapper.Map<Product>(productViewModel));
                return RedirectToAction("Index");
            }
            catch (BusinessException e)
            {

                BadRequest(e.Message);
            }

            return View(productViewModel);
        }


        public ActionResult Edit(int id)
        {
            return View();
        }

 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ProductViewModel productViewModel)
        {
            if (id != productViewModel.Id)
            {

                return BadRequest("O id não é o mesmo informado na query");
            }

            if (!ModelState.IsValid) return BadRequest();

            try
            {
                _service.Update(_mapper.Map<Product>(productViewModel));
                return RedirectToAction("Index");
            }
            catch (BusinessException e)
            {

                BadRequest(e.Message);
            }

            return View(productViewModel);
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

  
        [HttpDelete]
        public ActionResult Delete(long id)
        {

            if (!ModelState.IsValid) return BadRequest();

            try
            {
                var product = _service.GetById(id);

                _service.Delete(product);
                return RedirectToAction("Index");
            }
            catch (BusinessException e)
            {

                BadRequest(e.Message);
            }

            return Ok();
        }
    }
}

using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("admin")]
    public class ResearchImageController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ResearchImageController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.ResearchImages.Include(ri => ri.Research).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Research = _context.Researches.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(ResearchImage model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName2;

                            _context.ResearchImages.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ResearchImageError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchImageError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["ResearchImageError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }

            }

            ViewBag.Research = _context.Researches.ToList();
            return View(model);
        }


        public IActionResult Update(int? id)
        {
            ResearchImage model = _context.ResearchImages.Include(ri=>ri.Research).FirstOrDefault(r => r.Id == id);
            ViewBag.Research = _context.Researches.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(ResearchImage model)
        {
            if (ModelState.IsValid)
            {

                if (ModelState.IsValid)
                {
                    if (model.ImageFile != null)
                    {
                        if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                        {
                            if (model.ImageFile.Length < 3000000)
                            {
                                string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                                string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName2);

                                using (var Stream = new FileStream(FilePath2, FileMode.Create))
                                {
                                    model.ImageFile.CopyTo(Stream);
                                }

                                model.Image = ImageName2;

                                _context.ResearchImages.Add(model);
                                _context.SaveChanges();
                                return RedirectToAction("Index");

                            }
                            else
                            {
                                TempData["ResearchImageError"] = "The size of the Image file must be less than 3 MB";
                                return View(model);
                            }
                        }
                        else
                        {
                            TempData["ResearchImageError"] = "The type of Image file can only be jpeg/jpg or png";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchImageError"] = "Image field must not be empty. Please choose a image";
                        return View(model);
                    }

                }


                _context.ResearchImages.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Category = _context.Categories.ToList();

            return View(model);
        }

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                ///
            }

            ResearchImage image = _context.ResearchImages.Find(id);


            if (image == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(image.Image))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", image.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            


            _context.ResearchImages.Remove(image);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        

    }
}

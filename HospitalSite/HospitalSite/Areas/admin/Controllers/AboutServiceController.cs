using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Areas.admin.Controllers
{
    [Area("Admin")]
    public class AboutServiceController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public AboutServiceController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.ServiceAbouts.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ServiceAbout model)
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
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads",  ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName2;

                            _context.ServiceAbouts.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ServiceAboutError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ServiceAboutError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["ServiceTexnoLabError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.ServiceAbouts.Find(Id) != null)
                {
                    return View(_context.ServiceAbouts.Find(Id));
                }
                else
                {
                    TempData["ServiceAboutError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ServiceAboutError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(ServiceAbout model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpeg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath,  "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;

                        }
                        else
                        {
                            TempData["ServiceAboutError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ServiceAboutError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.ServiceAbouts.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }


        }

        public IActionResult Delete(int? Id)
        {
            if (Id != null)
            {
                ServiceAbout service = _context.ServiceAbouts.Find(Id);
                if (service != null)
                {
                    if (!string.IsNullOrEmpty(service.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads",  service.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.ServiceAbouts.Remove(service);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ServiceAboutError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["ServiceAboutError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}

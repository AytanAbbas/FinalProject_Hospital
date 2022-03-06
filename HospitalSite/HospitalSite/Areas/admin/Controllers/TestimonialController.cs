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
    public class TestimonialController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public TestimonialController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Testimonials.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "img", "image", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName2;

                            _context.Testimonials.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["TestimonialError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["TestimonialError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["BannerError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Testimonials.Find(Id) != null)
                {
                    return View(_context.Testimonials.Find(Id));
                }
                else
                {
                    TempData["TestimonialError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["TestimonialError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(Testimonial model)
        {
            if (ModelState.IsValid)
            {
                if (model.ImageFile != null)
                {
                    if (model.ImageFile.ContentType == "image/jpg" || model.ImageFile.ContentType == "image/png")
                    {
                        if (model.ImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Image))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", model.Image);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "image", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ImageFile.CopyTo(Stream);
                            }

                            model.Image = ImageName;

                        }
                        else
                        {
                            TempData["TestimonialError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["TestimonialError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.Testimonials.Update(model);
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
                Testimonial testimonial = _context.Testimonials.Find(Id);
                if (testimonial != null)
                {
                    if (!string.IsNullOrEmpty(testimonial.Image))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "image", testimonial.Image);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.Testimonials.Remove(testimonial);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["TestimonialError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["TestimonialError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}

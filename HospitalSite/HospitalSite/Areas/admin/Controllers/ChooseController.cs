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
    public class ChooseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public ChooseController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.Chooses.FirstOrDefault());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(Choose model)
        {
            if (ModelState.IsValid)
            {
                if (model.BgImageFile != null)
                {
                    if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                    {
                        if (model.BgImageFile.Length < 3000000)
                        {
                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath,  "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                            _context.Chooses.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ChooseError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ChooseError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["ChooseError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.Chooses.Find(Id) != null)
                {
                    return View(_context.Chooses.Find(Id));
                }
                else
                {
                    TempData["ChooseError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ChooseError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(Choose model)
        {
            if (ModelState.IsValid)
            {
                if (model.BgImageFile != null)
                {
                    if (model.BgImageFile.ContentType == "image/jpeg" || model.BgImageFile.ContentType == "image/png")
                    {
                        if (model.BgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.BgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath,  "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                        }
                        else
                        {
                            TempData["ChooseError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ChooseError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.Chooses.Update(model);
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
                Choose choose = _context.Chooses.Find(Id);
                if (choose != null)
                {
                    if (!string.IsNullOrEmpty(choose.BgImage))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", choose.BgImage);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.Chooses.Remove(choose);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["chooseError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["chooseError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}

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
    public class ProcessPlanController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public ProcessPlanController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.ProcessPlans.ToList());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProcessPlan model)
        {
            if (ModelState.IsValid)
            {
                if (model.ArrowImageFile != null)
                {
                    if (model.ArrowImageFile.ContentType == "image/jpeg" || model.ArrowImageFile.ContentType == "image/png")
                    {
                        if (model.ArrowImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ArrowImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "img", "image", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.ArrowImageFile.CopyTo(Stream);
                            }

                            model.ArrowImage = ImageName2;

                            _context.ProcessPlans.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ProcessPlanError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ProcessPlanError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["ProcessPlanError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.ProcessPlans.Find(Id) != null)
                {
                    return View(_context.ProcessPlans.Find(Id));
                }
                else
                {
                    TempData["ProcessPlanError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["ProcessPlanError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(ProcessPlan model)
        {
            if (ModelState.IsValid)
            {
                if (model.ArrowImageFile != null)
                {
                    if (model.ArrowImageFile.ContentType == "image/jpeg" || model.ArrowImageFile.ContentType == "image/png")
                    {
                        if (model.ArrowImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.ArrowImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", model.ArrowImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.ArrowImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.ArrowImageFile.CopyTo(Stream);
                            }

                            model.ArrowImage = ImageName;

                        }
                        else
                        {
                            TempData["ProcessPlanError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ProcessPlanError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.ProcessPlans.Update(model);
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
                ProcessPlan process = _context.ProcessPlans.Find(Id);
                if (process != null)
                {
                    if (!string.IsNullOrEmpty(process.ArrowImage))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "image", process.ArrowImage);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.ProcessPlans.Remove(process);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["ProcessPlanError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["ProcessPlanError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}

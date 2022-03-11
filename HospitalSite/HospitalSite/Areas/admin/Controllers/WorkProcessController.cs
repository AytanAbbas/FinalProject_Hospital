using HospitalSite.Data;
using HospitalSite.Models;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "SuperAdmin,Moderator")]

    public class WorkProcessController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public WorkProcessController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {
            return View(_context.WorkProcesses.FirstOrDefault());
        }

        public IActionResult Create()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Create(WorkProcess model)
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
                            string FilePath2 = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads",ImageName);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                            _context.WorkProcesses.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["WorkProcessError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["WorkProcessError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                else
                {
                    TempData["WorkProcessError"] = "Image field must not be empty. Please choose a image";
                    return View(model);
                }
            }

            return View(model);
        }

        public IActionResult Update(int? Id)
        {
            if (Id != null)
            {
                if (_context.WorkProcesses.Find(Id) != null)
                {
                    return View(_context.WorkProcesses.Find(Id));
                }
                else
                {
                    TempData["WorkProcessError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }
            }
            else
            {
                TempData["WorkProcessError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }


        }

        [HttpPost]
        public IActionResult Update(WorkProcess model)
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
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads",  model.BgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.BgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.BgImageFile.CopyTo(Stream);
                            }

                            model.BgImage = ImageName;

                        }
                        else
                        {
                            TempData["WorkProcessError3"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["WorkProcessError3"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }

                }

                _context.WorkProcesses.Update(model);
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
                WorkProcess work = _context.WorkProcesses.Find(Id);
                if (work != null)
                {
                    if (!string.IsNullOrEmpty(work.BgImage))
                    {
                        string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "img", "bg-image", work.BgImage);
                        if (System.IO.File.Exists(oldImagePath))
                        {
                            System.IO.File.Delete(oldImagePath);
                        }
                    }
                    _context.WorkProcesses.Remove(work);
                    _context.SaveChanges();
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["WorkProcessError2"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["WorkProcessError2"] = "Id must not be null";
                return RedirectToAction("Index");
            }



        }
    }
}

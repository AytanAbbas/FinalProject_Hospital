using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "SuperAdmin,Moderator")]
    public class ResearchController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public ResearchController(AppDbContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Researches.Include(c => c.Category).ToList());
        }

        public IActionResult Create()
        {
            ViewBag.Category = _context.Categories.ToList();
         
            return View();
        }

        [HttpPost]
        public IActionResult Create(Research model)
        {
            if (ModelState.IsValid)
            {
                if (model.MainImageFile != null)
                {
                    if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                    {
                        if (model.MainImageFile.Length < 3000000)
                        {
                            string ImageName2 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.MainImageFile.FileName;
                            string FilePath2 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName2);

                            using (var Stream = new FileStream(FilePath2, FileMode.Create))
                            {
                                model.MainImageFile.CopyTo(Stream);
                            }

                            model.MainImage = ImageName2;

                            _context.Researches.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ResearchError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }

                if (model.DetailImageFile != null)
                {
                    if (model.DetailImageFile.ContentType == "image/jpeg" || model.DetailImageFile.ContentType == "image/png")
                    {
                        if (model.DetailImageFile.Length < 3000000)
                        {
                            string ImageName3 = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.DetailImageFile.FileName;
                            string FilePath3 = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName3);

                            using (var Stream = new FileStream(FilePath3, FileMode.Create))
                            {
                                model.DetailImageFile.CopyTo(Stream);
                            }

                            model.MainImage = ImageName3;

                            _context.Researches.Add(model);
                            _context.SaveChanges();
                            return RedirectToAction("Index");

                        }
                        else
                        {
                            TempData["ResearchError"] = "The size of the Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchError"] = "The type of Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }



            }

            ViewBag.Category = _context.Categories.ToList();
            return View(model);
        }


        public IActionResult Update(int? id)
        {
            Research model = _context.Researches.Include(c=>c.Category).FirstOrDefault(r => r.Id == id);
            ViewBag.Category = _context.Categories.ToList();
            return View(model);
        }

        [HttpPost]
        public IActionResult Update(Research model)
        {
            if (ModelState.IsValid)
            {

                if (model.MainImageFile != null)
                {
                    if (model.MainImageFile.ContentType == "image/jpeg" || model.MainImageFile.ContentType == "image/png")
                    {
                        if (model.MainImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.MainImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.MainImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.MainImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.MainImageFile.CopyTo(Stream);
                            }

                            model.MainImage = ImageName;
                        }
                        else
                        {
                            TempData["ResearchError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.DetailImageFile != null)
                {
                    if (model.DetailImageFile.ContentType == "image/jpeg" || model.DetailImageFile.ContentType == "image/png")
                    {
                        if (model.DetailImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.DetailImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", model.DetailImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.DetailImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.DetailImageFile.CopyTo(Stream);
                            }

                            model.DetailImage = ImageName;
                        }
                        else
                        {
                            TempData["ResearchError"] = "The size of the Home Page Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["ResearchError"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }


                _context.Researches.Update(model);
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

            Research research = _context.Researches.Find(id);


            if (research == null)
            {
                ///
            }

            //Delete old image
            if (!string.IsNullOrEmpty(research.MainImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", research.MainImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }
            if (!string.IsNullOrEmpty(research.DetailImage))
            {
                string oldImagePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", research.DetailImage);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }



            _context.Researches.Remove(research);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult ResearchDetail(int? Id)
        {
            if (Id != null)
            {
                VmResearch model2 = new();
                if (_context.Researches.Find(Id) != null)
                {
                    model2.ResearchDetail = _context.Researches.Include(c => c.Category).FirstOrDefault(t => t.Id == Id);

                    model2.Category = _context.Categories.FirstOrDefault();
                  
                    return View(model2);
                }
                else
                {
                    TempData["Researchrror"] = "Such an id does not exist";
                    return RedirectToAction("Index");
                }

            }
            else
            {
                TempData["Researchrror"] = "Id must not be null";
                return RedirectToAction("Index");
            }

        }


    }
}

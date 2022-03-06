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
    [Area("admin")]
    public class SiteSettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnviroment;

        public SiteSettingController(AppDbContext context, IWebHostEnvironment webHostEnviroment)
        {
            _context = context;
            _webHostEnviroment = webHostEnviroment;
        }
        public IActionResult Index()
        {

            return View(_context.Settings.FirstOrDefault());
        }

        public IActionResult Update()
        {


            return View(_context.Settings.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Update(Setting model)
        {
            if (ModelState.IsValid)
            {

                if (model.LogoFile != null)
                {
                    if (model.LogoFile.ContentType == "image/jpeg" || model.LogoFile.ContentType == "image/png")
                    {
                        if (model.LogoFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.Logo);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.LogoFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.LogoFile.CopyTo(Stream);
                            }

                            model.Logo = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.FooterBgImageFile != null)
                {
                    if (model.FooterBgImageFile.ContentType == "image/jpeg" || model.FooterBgImageFile.ContentType == "image/png")
                    {
                        if (model.FooterBgImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.FooterBgImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.FooterBgImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.FooterBgImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.FooterBgImageFile.CopyTo(Stream);
                            }

                            model.FooterBgImage = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Home Page Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Home Page Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.SignatureFile != null)
                {
                    if (model.SignatureFile.ContentType == "image/jpeg" || model.SignatureFile.ContentType == "image/png")
                    {
                        if (model.SignatureFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.Logo))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.Signature);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.SignatureFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.SignatureFile.CopyTo(Stream);
                            }

                            model.Signature = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }
                if (model.AboutImageFile != null)
                {
                    if (model.AboutImageFile.ContentType == "image/jpeg" || model.AboutImageFile.ContentType == "image/png")
                    {
                        if (model.AboutImageFile.Length < 3000000)
                        {


                            if (!string.IsNullOrEmpty(model.AboutImage))
                            {
                                string oldImagePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", model.AboutImage);
                                if (System.IO.File.Exists(oldImagePath))
                                {
                                    System.IO.File.Delete(oldImagePath);
                                }
                            }


                            string ImageName = Guid.NewGuid() + "-" + DateTime.Now.ToString("ddMMMMyyyy") + "-" + model.AboutImageFile.FileName;
                            string FilePath = Path.Combine(_webHostEnviroment.WebRootPath, "Uploads", ImageName);

                            using (var Stream = new FileStream(FilePath, FileMode.Create))
                            {
                                model.AboutImageFile.CopyTo(Stream);
                            }

                            model.AboutImage = ImageName;
                        }
                        else
                        {
                            TempData["SettingError"] = "The size of the Logo Image file must be less than 3 MB";
                            return View(model);
                        }
                    }
                    else
                    {
                        TempData["SettingError"] = "The type of Logo Image file can only be jpeg/jpg or png";
                        return View(model);
                    }
                }

                _context.Settings.Update(model);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(model);
        }
    }
}

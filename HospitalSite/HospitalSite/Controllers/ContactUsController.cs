using HospitalSite.Data;
using HospitalSite.Models;
using HospitalSite.ViewModel;
using ICSharpCode.SharpZipLib.Zip;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalSite.Controllers
{
    public class ContactUsController : Controller
    {
        private readonly AppDbContext _context;
        private IHostingEnvironment _oIHostingEnvironment;

        public ContactUsController(AppDbContext context,IHostingEnvironment oIHostingEnvironment)
        {
            _context = context;
            _oIHostingEnvironment= oIHostingEnvironment;
        }
        public IActionResult Index()
        {
            VmContact model = new VmContact
            {
                SiteSocials = _context.SiteSocials.ToList(),
                Setting = _context.Settings.FirstOrDefault(),
               Banner=_context.Banners.FirstOrDefault(b=>b.Page== "ContactUs")

            };
              
            return View(model);
        }
        [HttpPost]
        public IActionResult Message( string name, string email, string phone, string subject, string text)
        {
            VmMessage message1 = new VmMessage();

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(email) && string.IsNullOrEmpty(phone) && string.IsNullOrEmpty(text))
            {
                message1.Status = false;
                message1.Message = "Please enter the information correctly!";
                return Json(message1);
            }

            ContactUs contactUs = new ContactUs();
            contactUs.CreatedDate = DateTime.Now;
            contactUs.Name = name;
            contactUs.Email = email;
            contactUs.Phone = phone;
            contactUs.Subject = subject;
            contactUs.Message = text;

            _context.ContactUs.Add(contactUs);
            _context.SaveChanges();

            message1.Status = true;
            message1.Message = "Thank you for your message!";
            return Json(message1);
        }

        public FileResult GenerateAndDownloadZip() 
        {
            var webRoot = _oIHostingEnvironment.WebRootPath;
            var fileName = "MyZip.zip";
            var tempOutput = webRoot + "/Brouchers/" + fileName;
            using (ZipOutputStream oZipOutputStream = new ZipOutputStream(System.IO.File.Create(tempOutput)))
            {
                oZipOutputStream.SetLevel(9);

                byte[] buffer = new byte[4096];
                var ImageList = new List<string>();

                ImageList.Add(webRoot + "/Brouchers/broucher1.jpg");
                ImageList.Add(webRoot + "/Brouchers/broucher2.jpg");
  


                for (int i = 0; i < ImageList.Count; i++)
                {
                    ZipEntry entry = new ZipEntry(Path.GetFileName(ImageList[i]));
                    entry.DateTime = DateTime.Now;
                    entry.IsUnicodeText = true;
                    oZipOutputStream.PutNextEntry(entry);


                    using (FileStream oFileStream=System.IO.File.OpenRead(ImageList[i])) 
                    {
                        int sourceBytes;
                        do
                        {
                            sourceBytes = oFileStream.Read(buffer, 0, buffer.Length);
                            oZipOutputStream.Write(buffer, 0, sourceBytes);
                        } while (sourceBytes>0);
                    
                    }


                }
                oZipOutputStream.Finish();
                oZipOutputStream.Flush();
                oZipOutputStream.Close();


            }
            byte[] finalResult = System.IO.File.ReadAllBytes(tempOutput);
            if (System.IO.File.Exists(tempOutput)) {

                System.IO.File.Delete(tempOutput);
            }

            if (finalResult==null || !finalResult.Any()) {
                throw new Exception(String.Format("Nothing Found"));
            }
            return File(finalResult,"application/zip" , fileName);
        }


        public FileResult LabDetailAndDownloadZip()
        {
            var webRoot = _oIHostingEnvironment.WebRootPath;
            var fileName = "MyZip.zip";
            var tempOutput = webRoot + "/LabDetails/" + fileName;
            using (ZipOutputStream oZipOutputStream = new ZipOutputStream(System.IO.File.Create(tempOutput)))
            {
                oZipOutputStream.SetLevel(9);

                byte[] buffer = new byte[4096];
                var ImageList = new List<string>();

                ImageList.Add(webRoot + "/LabDetails/Labdetail.png");
                ImageList.Add(webRoot + "/LabDetails/Labdetail2.jpg");





                for (int i = 0; i < ImageList.Count; i++)
                {
                    ZipEntry entry = new ZipEntry(Path.GetFileName(ImageList[i]));
                    entry.DateTime = DateTime.Now;
                    entry.IsUnicodeText = true;
                    oZipOutputStream.PutNextEntry(entry);


                    using (FileStream oFileStream = System.IO.File.OpenRead(ImageList[i]))
                    {
                        int sourceBytes;
                        do
                        {
                            sourceBytes = oFileStream.Read(buffer, 0, buffer.Length);
                            oZipOutputStream.Write(buffer, 0, sourceBytes);
                        } while (sourceBytes > 0);

                    }


                }
                oZipOutputStream.Finish();
                oZipOutputStream.Flush();
                oZipOutputStream.Close();


            }
            byte[] finalResult = System.IO.File.ReadAllBytes(tempOutput);
            if (System.IO.File.Exists(tempOutput))
            {

                System.IO.File.Delete(tempOutput);
            }

            if (finalResult == null || !finalResult.Any())
            {
                throw new Exception(String.Format("Nothing Found"));
            }
            return File(finalResult, "application/zip", fileName);
        }
    }
}

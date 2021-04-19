using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using SymphonyWebApp.Data;
using SymphonyWebApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Controllers
{
    [Authorize]
    public class GmailController : Controller
    {
        private readonly ApplicationDbContext _context;

        private IConfiguration configuration;
        private IWebHostEnvironment webHostEnvironment;
        private IHostingEnvironment _env;

        public GmailController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment, ApplicationDbContext context, IHostingEnvironment env)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
            _context = context;
            _env = env;
        }

        private int IdCustomer;

        public IActionResult Index(int id)
        {
            IdCustomer = id;
            var customer = _context.Customers.FirstOrDefault(x => x.Id == IdCustomer);
            ViewData["CName"] = customer.Name;
            ViewData["CGmail"] = customer.Gmail;
            ViewData["CPhoneNumber"] = customer.PhoneNumber;
            ViewData["CContent"] = "We have received your application form! ";
            return View();
        }

        [HttpPost]
        [Route("send")]
        public IActionResult Send(Gmail gmail, IFormFile[] attachments)
        {
            var customer = _context.Customers.FirstOrDefault(x => x.Id == IdCustomer);
            var body = string.Empty;
            var webRoot = _env.WebRootPath; //get wwwroot Folder

            var pathToFile = _env.WebRootPath
                            + Path.DirectorySeparatorChar.ToString()
                            + "Templates"
                            + Path.DirectorySeparatorChar.ToString()
                            + "EmailTemplate"
                            + Path.DirectorySeparatorChar.ToString()
                            + "EmailTemplate.html";

            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            {
                body = SourceReader.ReadToEnd();
            }
            body = body.Replace("{name}", gmail.Name);
            body = body.Replace("{content}", gmail.Content);

            var mailHelper = new MailHelper(configuration);

            List<string> fileNames = null;
            if (attachments != null && attachments.Length > 0)
            {
                fileNames = new List<string>();
                foreach (IFormFile attachment in attachments)
                {
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", attachment.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        attachment.CopyToAsync(stream);
                    }
                    fileNames.Add(path);
                }
            }
            if (mailHelper.Send(configuration["Gmail:Username"], gmail.Email, gmail.Subject, body, fileNames))
            {
                ViewBag.msg = "Sent Mail Successfully!";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("Index", new Gmail());
        }

        public IActionResult SendDefault(Gmail gmail, IFormFile[] attachments, int id)
        {
            IdCustomer = id;
            var customers = _context.Customers.FirstOrDefault(x => x.Id == IdCustomer);
            gmail.Email = customers.Gmail;
            gmail.Subject = "Announcements from Symphony";
            gmail.Content = "We have received your application and we'll contact you as soon as possible. Remember to pay attention to phone and mail.";

            var body = string.Empty;
            //
            var webRoot = _env.WebRootPath; //get wwwroot Folder

            var pathToFile = _env.WebRootPath
                            + Path.DirectorySeparatorChar.ToString()
                            + "Templates"
                            + Path.DirectorySeparatorChar.ToString()
                            + "EmailTemplate"
                            + Path.DirectorySeparatorChar.ToString()
                            + "EmailTemplate.html";

            using (StreamReader SourceReader = System.IO.File.OpenText(pathToFile))
            {
                body = SourceReader.ReadToEnd();
            }
            body = body.Replace("{name}", customers.Name);
            body = body.Replace("{content}", gmail.Content);
            var mailHelper = new MailHelper(configuration);

            List<string> fileNames = null;
            if (attachments != null && attachments.Length > 0)
            {
                fileNames = new List<string>();
                foreach (IFormFile attachment in attachments)
                {
                    var path = Path.Combine(webHostEnvironment.WebRootPath, "uploads", attachment.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        attachment.CopyToAsync(stream);
                    }
                    fileNames.Add(path);
                }
            }
            if (mailHelper.Send(configuration["Gmail:Username"], gmail.Email, gmail.Subject, body, fileNames))
            {
                ViewBag.msg = "Sent Mail Successfully!";
            }
            else
            {
                ViewBag.msg = "Failed";
            }

            return RedirectToAction("Index", "Customers");
        }
    }
}
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

        public GmailController(IConfiguration _configuration, IWebHostEnvironment _webHostEnvironment, ApplicationDbContext context)
        {
            configuration = _configuration;
            webHostEnvironment = _webHostEnvironment;
            _context = context;
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
            var body = "Hello: " + gmail.Name + "," + "<br>Content: " + gmail.Content;
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
            if (mailHelper.Send(gmail.Email, configuration["Gmail:Username"], gmail.Subject, body, fileNames))
            {
                ViewBag.msg = "Sent Mail Successfully!";
            }
            else
            {
                ViewBag.msg = "Failed";
            }
            return View("Index", new Gmail());
        }
    }
}
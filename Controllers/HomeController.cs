using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;

namespace MyWebSite.Controllers
{
    public class HomeController : Controller
    {
            public IActionResult Index()
            {
                return View();
            }

            public IActionResult Hakkimizda()
            {
                return View();
            }

            public IActionResult Servis()
            {
                return View();
            }

            public IActionResult Proje()
            {
                return View();
            }

            public IActionResult Iletisim()
            {
                return View();
            }
        [HttpPost]
        public IActionResult Iletisim(Mail m)
        {
            try
            {
                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("infoyaprakyildirim@gmail.com", "infoyaprak1");
                client.EnableSsl = true;

                MailMessage msj = new MailMessage();
                msj.From = new MailAddress(m.Email, m.Adi + " " + m.Soyadi);
                msj.To.Add("infoyaprakyildirim@gmail.com");
                msj.Subject = m.Konu + " " + m.Email + " -" + m.Telefon;
                msj.Body = m.Mesaj;

                client.Send(msj);

                MailMessage msj1 = new MailMessage();
                msj1.From = new MailAddress("infoyaprakyildirim@gmail.com", "Yaprak Yıldırım");
                msj1.To.Add(m.Email);
                msj1.Subject = "Mail'inize Cevap";
                msj1.Body = "Teşekkürler mail'iniz bize ulaştı size en kısa sürede dönüş yapıcağız";

                client.Send(msj1);

                ViewBag.Succes = "Teşekkürler Mail Başarılı Bir Şekilde Gönderildi";
                return View();
            }
            catch (Exception)
            {
                ViewBag.Error = "Mail Gönderilirken Bir Hata Oluştu!";
                return View();
            }
        }
    }
}
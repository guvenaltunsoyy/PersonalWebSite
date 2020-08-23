using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebSite.Models;
using Npgsql;

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
        public async Task<IActionResult> Iletisim(Mail m)
        {
            try
            {
                Console.WriteLine(" POSTGRESQL TEST 1 2 3");

                string connString = "Host=ec2-54-247-118-139.eu-west-1.compute.amazonaws.com;Username=bxdchfsgsxrsds;" +
                                "Password=44a3d92cd28bd7ca81e320271be62264697c4e980fcab3149824cdf30f0f9efa;Database=d7fhnt9djkdbps;trustServerCertificate=false;Integrated Security=true;Pooling=true;";

                await using var conn = new NpgsqlConnection(connString);
                await conn.OpenAsync();

          

                // Retrieve all rows
                await using (var cmd = new NpgsqlCommand("SELECT * FROM Test", conn))
                await using (var reader = await cmd.ExecuteReaderAsync())
                    while (await reader.ReadAsync())
                        Console.WriteLine(reader.GetString(0));



                SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
                client.Credentials = new NetworkCredential("infoyaprakyildirim@gmail.com", "infoyaprak1");
                client.EnableSsl = true;

                MailMessage msj = new MailMessage();
                msj.From = new MailAddress(m.Email, m.Adi + " " + m.Soyadi);
                msj.To.Add("infoyaprakyildirim@gmail.com");
                msj.Subject = m.Konu + " " + m.Email ;
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
            catch (Exception e)
            {
                ViewBag.Error = "Mail Gönderilirken Bir Hata Oluştu!";
                return View();
            }
        }
    }
}
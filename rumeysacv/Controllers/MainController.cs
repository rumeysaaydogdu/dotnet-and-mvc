using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;
using rumeysacv.Models;

namespace rumeysacv.Controllers
{
    public class MainController : Controller
    {
        // GET: Main
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Mail mail)
        {
            MailMessage myMail = new MailMessage();
            myMail.To.Add("aydogdurumeysa99@gmail.com");  //liste türünde oludğu için To.Add()  kullanıyoruz
            myMail.From = new MailAddress("rumeysaworks@gmail.com");  //mailimiz string ifade olduğu için, new MailAddress() kullanarak mail türünde bir değişken oluşturuyoruz
            myMail.Subject = mail.GonderenMail + " 'den mail";
            myMail.Body = mail.Icerik + "<br/> <br/>" + mail.AdSoyad;
            myMail.IsBodyHtml = true;  //başlığa yazdığımız html etiketinin yorumlanabilmesi için

            //aşağısı google gmail ayarları

            SmtpClient smtp = new SmtpClient
            {
                Credentials = new NetworkCredential("rumeysaworks@gmail.com", "mvcmail2"),  //bu mesajı kimden gönderiyorsak onun mail ve şifresi
                Port = 587,  //gmail ve hotmail 'in portu
                Host = "smtp.gmail.com",   //hotmail için:  smtp.live.com
                EnableSsl = true   // https deki "S" için izin sanırım
            };

            smtp.Send(myMail);
           
            return View();
        }
    }
}
using SendMail.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net;
using System.Net.Mail;

namespace SendMail.Controllers
{
    public class MailController : Controller
    {
        // GET: Mail
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Mail mail)
        {
            MailMessage myMail = new MailMessage();
            myMail.To.Add("rumcanva@gmail.com");  //liste türünde oludğu için To.Add()  kullanıyoruz
            myMail.From = new MailAddress("rumeysaworks@gmail.com");  //mailimiz string ifade olduğu için, new MailAddress() kullanarak mail türünde bir değişken oluşturuyoruz
            myMail.Subject = "MVC Mail'den: " + mail.Baslik;
            myMail.Body = mail.Icerik + "<br/> <br/>" +  mail.Ad + " " + mail.Soyad;
            myMail.IsBodyHtml = true;  //başlığa yazdığımız html etiketinin yorumlanabilmesi için

            //aşağısı google gmail ayarları

            SmtpClient smtp = new SmtpClient();
            smtp.Credentials = new NetworkCredential("rumeysaworks@gmail.com", "****rumeysaworks@gmail.com'un şifresi buraya gelecek.tırnak kalsın.****");  //bu mesajı kimden gönderiyorsak onun mail ve şifresi
            smtp.Port = 587;  //gmail ve hotmail 'in portu
            smtp.Host = "smtp.gmail.com";   //hotmail için:  smtp.live.com
            smtp.EnableSsl = true;   // https deki "S" için izin sanırım


            try
            {
                smtp.Send(myMail);
                TempData["Message"] = "Mesajınız başarılı bir şekilde gönderildi!";
            }
            catch(Exception ex)
            {
                TempData["Message"] = "Mesajınız gönderilemedi. Hata nedeni:" + ex.Message;
            }

            return View();
        }
    }
}

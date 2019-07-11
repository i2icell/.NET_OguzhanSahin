using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
       
        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }

        

        [HttpPost]

        
        public async Task<IActionResult> Index(Index giris)
        {

           
            WebService.ServicesPortTypeClient client = new WebService.ServicesPortTypeClient(WebService.ServicesPortTypeClient.EndpointConfiguration.ServicesHttpSoap11Endpoint);

            WebService.loginResponse login = await client.loginAsync(giris.Phone_number,giris.Password);

            if (login.@return==1)
            {

                return RedirectToAction("GetBalanced", "Home");

            }
            else
            {
                return View("FailLogin");
            }

            
        }
     

        public IActionResult NewPassword()
        {

            return View();
        }



        [HttpPost]

        public async Task<IActionResult> NewPassword(NewPassword password)
        {
            WebService.ServicesPortTypeClient client = new WebService.ServicesPortTypeClient(WebService.ServicesPortTypeClient.EndpointConfiguration.ServicesHttpSoap11Endpoint);

            WebService.changePasswordResponse changePassword = await client.changePasswordAsync(password.Phonenum,password.Tckimlik_no,password.New_Password);
            
            return View();

        }

        [HttpGet]

        public IActionResult SignUp()
        {
            return View();

        }


        
        [HttpPost]

        public async Task<IActionResult> SignUp(SignUp signn)
        {

            String dogum_tarihi = signn.Dogumtarihi;           
            String year = signn.Dogumtarihi.Substring(0, 4);      
            String month = signn.Dogumtarihi.Substring(5, 2);
            String day = signn.Dogumtarihi.Substring(8, 2);     
            String dogum_tarihi2 = day + "/" + month + "/" + year;


            WebService.ServicesPortTypeClient client = new WebService.ServicesPortTypeClient(WebService.ServicesPortTypeClient.EndpointConfiguration.ServicesHttpSoap11Endpoint);
            // WebService.createAccountResponse createAccResp = await client.createAccountAsync("Oguzhan","Sahin","5317710032","oguuzhansahiin@gmail.com","154326Fbb","05-09-1998", 84277176866);
            WebService.createAccountResponse createAccResp = await client.createAccountAsync(signn.Firstname,signn.Lastname,signn.Phonenum,signn.Email,signn.Password, dogum_tarihi2,signn.Tckimlik_no);

            

            if (createAccResp.@return == 1)
            {
                return RedirectToAction("Home", "Index");

            }

            else
            {
                return View("FailSignUp");
                
            }
    
            }
        
        public async Task<IActionResult> GetBalanced(GetBalanced balanced )
        {
            WebService.ServicesPortTypeClient client = new WebService.ServicesPortTypeClient(WebService.ServicesPortTypeClient.EndpointConfiguration.ServicesHttpSoap11Endpoint);                                                                                                                                                                                                                 string phoneNum = "5355416465";
            
            WebService.getBalancesResponse balance = await client.getBalancesAsync(phoneNum);
            balanced.Internet = balance.@return[0];
            balanced.Dakika = balance.@return[1];
            balanced.Sms = balance.@return[2];

            return View(balanced);

        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class SignUp
    {

        public String Firstname { get; set; }

        public String Lastname  { get; set; }

        public String Email { get; set; }

        public String Password  { get; set; }

        public  String Dogumtarihi { get; set; }

        public String Phonenum { get; set; }

        public String  Tckimlik_no { get; set; }
}
}

/*burada yapman gerekenleri yazayım
1-) HttpPost Signup action'ında olan parametreler ile bir sınıf oluştur
2-) Bu sınıfı yine aynı action ın tek parametresi yap.
3-) view da en üste bu sınıfı model olarak tanımla ->
@model SinifAdi

4-) inputların hepsini<form asp-action="SignUp"></form>
tagı içerisine al
5-) inputlarin icerisindeki name="..." olan yeri asp-for="ModeldenGelenPropisiniyaz" ile degistir name kalmasin
6-)<button asp-controller....olan yeri komple sil yerine bunu ekle ->
<input type = "submit" value="Kaydet" /> */
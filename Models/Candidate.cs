using System.ComponentModel.DataAnnotations;

namespace ControlCenterX.Models
{
    public class Candidate   //Model ile ilgili tanımlamalar yapıldı.
    {
        [Required(ErrorMessage ="E-mail is required.")]  //Zorunlu alan
        public String? Email { get; set; } = String.Empty;  //Email alanı tanımlandığı anda = "" bu şekilde olacak
        [Required(ErrorMessage = "FirstName is required.")]  //Zorunlu alan
        public String? FirstName { get; set; } = String.Empty;
        [Required(ErrorMessage = "LastName is required.")]  //Zorunlu alan
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName} {LastName?.ToUpper()}"; //? var ise o işlemi yap.
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()  //Default olarak o an ki tarih eklendi. 
        {
            ApplyAt=DateTime.Now;  //ApplyAt nesnesi üretildiği anda default güncel tarih gelecek.
            /*Eğer constructor tanımlamadan atama yapılsaydı üretildiği anda atanmazdı değer.*/
        }
    }
}

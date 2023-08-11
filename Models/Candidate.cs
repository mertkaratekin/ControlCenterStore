namespace ControlCenterX.Models
{
    public class Candidate   //Model ile ilgili tanımlamalar yapıldı.
    {
        public String? Email { get; set; } = String.Empty;  //Email alanı tanımlandığı anda = "" bu şekilde olacak
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public String? FullName => $"{FirstName}{LastName?.ToUpper()}"; //? var ise o işlemi yap.
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

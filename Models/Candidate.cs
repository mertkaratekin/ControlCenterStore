namespace ControlCenterX.Models
{
    public class Candidate   //Model ile ilgili tanımlamalar yapıldı.
    {
        public String? Email { get; set; } = String.Empty;
        public String? FirstName { get; set; } = String.Empty;
        public String? LastName { get; set; } = String.Empty;
        public int? Age { get; set; }
        public String? SelectedCourse { get; set; } = String.Empty;
        public DateTime ApplyAt { get; set; }
        public Candidate()  //Default olarak o an ki tarih eklendi. 
        {
            ApplyAt=DateTime.Now;
        }

    }
}

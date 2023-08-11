namespace ControlCenterX.Models
{
    public static class Repository
    {
        private static List<Candidate> applicaitons = new(); //Erişime kaptmak için private yapıldı.
        public static IEnumerable<Candidate> Applications => applicaitons;
        /*Sınıf içerisindeki listeye bakarak yanıt verecek.*/
        /*Listeye sınıf dışarısından erişmek isteyenlere interface desteğiyle dönüş yapılıyor. */
        
        public static void Add(Candidate candidate) /*Formdan gelen elemanlar eklenecek*/
        {
            applicaitons.Add(candidate);/*private olarak tanımlanan listeye ekleme işlemi yapacak*/
        }
    }
}

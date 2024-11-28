namespace BookAPI.ViewModel
{
    public class BookVM
    {
        public string Title { get; set; }
        public string Description { get; set; }
        // Da li smo pročitali knjigu
        public bool IsRead { get; set; }
        // Datum kada smo ju pročitali (nullable Datetime - ako ju nismo
        // pročitali, datum će imati vrijednost null)
        public DateTime? DateRead { get; set; }
        // Ocjena (nullable int - ako ju nismo pročitali, ne možemo ju ocijeniti pa će vrijednost biti null)
        public int? Rate { get; set; } // OVDJE JE BIO PROBLEM - SINTAKSA!
        public string Genre { get; set; }
        public string Author { get; set; }
        public string CoverPictureURL { get; set; }
    }
}



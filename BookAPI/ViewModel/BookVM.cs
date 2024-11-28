using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookAPI.ViewModel
{
    [Route("api/[controller]")]
    [ApiController]

    
        public class BookVM
        {
            public string Title { get; set; }
            public string Description { get; set; }
            //Da li smo pročitali knjigu
            public bool IsRead { get; set; }
            //datum kada smo ju pročitali (nullable Datetime - ako ju nismo 
            //pročitala datum će imati vrijednost null)
            public DateTime? DateRead { get; set; }
            public int? Rate { get; set; }
            public string Genre { get; set; }
            public string Author { get; set; }
            public string CoverPictureURL { get; set; }
        }
    }


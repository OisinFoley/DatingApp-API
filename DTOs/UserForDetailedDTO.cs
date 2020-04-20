using System.Collections.Generic;

namespace DatingApp.API.DTOs
{
    public class UserForDetailedDTO: UserForListDTO
    {
        public string Introduction { get; set; }
        public string LookingFor { get; set; }
        public string Interests { get; set; }
        public ICollection<PhotosForDetailedDTO> Photos { get; set; }
    }
}
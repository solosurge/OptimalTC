using System;
using System.Collections.Generic;

namespace API.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string UserName { get; set; }

        public string KnownAs { get; set; }

        public string PhotoUrl { get; set; }

        public DateTime Created { get; set; } 

        public DateTime LastActive { get; set; }

        public string Information { get; set; }

        public string City { get; set; }
        
        public ICollection<PhotoDto> Photos { get; set; }
    }
}
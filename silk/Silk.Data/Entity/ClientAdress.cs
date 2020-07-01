using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Silk.Data.Entity
{
    public class ClientAdress
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDefault { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public int ZipCode { get; set; }
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
    }
}

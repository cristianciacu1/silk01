using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Silk.Data.Entity
{
    public class Client
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string PicturePath { get; set; }
        public virtual ICollection<ClientAdress> Adresses { get; set; }
    }
}

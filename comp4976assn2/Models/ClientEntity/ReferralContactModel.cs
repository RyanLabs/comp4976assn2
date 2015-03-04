using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace comp4976assn2.Models.ClientEntity
{
    public class ReferralContactModel
    {
        [Key]
        public String ReferralContact { get; set; }
        public List<ClientModel> Client { get; set; }
    }
}
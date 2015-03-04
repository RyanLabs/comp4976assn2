using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace comp4976assn2.Models
{
    public class ClientModel
    {
        [Key]
        public int ClientReferenceNumber { get; set; }
        
        [Range(1, 12, ErrorMessage = "Month must be between 1 and 12")]
        public int Month { get; set; }

        [Range(1, 31, ErrorMessage = "Day must be between 1 and 31")]
        public int Day { get; set; }

        [RegularExpression("/^[a-zA-Z]+$/", ErrorMessage = "Invalid Surname (Letters only)")]
        public String Surname { get; set; }
        [RegularExpression("/^[a-zA-Z]+$/", ErrorMessage = "Invalid Firstname (Letters only)")]
        public String Firstname { get; set; }

        [RegularExpression("/^([0][1-9]|[1-9][0-9])-([0-9]{4}[1-9]|[0-9]{5})$/")]
        public String PoliceFileNumber { get; set; }
        public int CourtFileNumber { get; set; }
        public int SWCFileNumber { get; set; }
        public String RiskAssessmentAssignedTo { get; set; }
        public String AbuserName { get; set; }
        public char Gender { get; set; }
        public int NumberChildren6 { get; set; }
        public int NumberChildren12 { get; set; }
        public int NumberChildren18 { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateLastTransfered { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateReopened { get; set; }

    }
}
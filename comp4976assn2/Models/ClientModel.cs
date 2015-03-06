using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using comp4976assn2.Models.ClientEntity;

namespace comp4976assn2.Models
{
    public class ClientModel
    {
        [DisplayName("Client Reference Number")]
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientReferenceNumber { get; set; }

        [Required]
        [Range(1, 12, ErrorMessage = "Month must be between 1 and 12")]
        public int Month { get; set; }

        [Required]
        [Range(1, 31, ErrorMessage = "Day must be between 1 and 31")]
        public int Day { get; set; }

        [Required]
        [StringLength(35)]
        [MaxLength(35)]
        [RegularExpression("/^[a-zA-Z]+$/", ErrorMessage = "Invalid Surname (Letters only)")]
        public String Surname { get; set; }

        [Required]
        [DisplayName("First Name")]
        [StringLength(35)]
        [MaxLength(35)]
        [RegularExpression("/^[a-zA-Z]+$/", ErrorMessage = "Invalid Firstname (Letters only)")]
        public String Firstname { get; set; }

        [DisplayName("Police File Number")]
        [StringLength(8)]
        [MaxLength(8)]
        [RegularExpression(@"^\d{2}-\d{5}$", ErrorMessage = "Format: 99-99999 (example: 14-77852).")]
        public String PoliceFileNumber { get; set; } //Nullable

        [DisplayName("Court File Number")]
        public int? CourtFileNumber { get; set; } //Nullable

        [Required]
        [DisplayName("SWC File Number")]
        public int SwcFileNumber { get; set; }

        [Required]
        [DisplayName("Risk Assessment Assigned To")]
        [StringLength(70)]
        [MaxLength(70)]
        public String RiskAssessmentAssignedTo { get; set; }

        [Required]
        [DisplayName("Abuser Surname, First Name")]
        [RegularExpression(@"^([A-Za-z]+),\\s+([A-Za-z]+)$", ErrorMessage = "Format: Surname, First Name")]
        public String AbuserName { get; set; }

        [Required]
        [MaxLength(1)]
        [StringLength(1)]
        [RegularExpression(@"^M|m|F|f|T|t$", ErrorMessage = "M or F or T (Trans)")]
        public char Gender { get; set; }

        [DisplayName("Number of Children (0-6)")]
        public int NumberChildren6 { get; set; }

        [DisplayName("Number of Children (7-12)")]
        public int NumberChildren12 { get; set; }

        [DisplayName("Number of Children (13-18)")]
        public int NumberChildren18 { get; set; }

        [DisplayName("Date Last Transferred")]
        [DataType(DataType.Date)]
        public DateTime DateLastTransfered { get; set; }

        [DisplayName("Date Closed")]
        [DataType(DataType.Date)]
        public DateTime DateClosed { get; set; }

        [DisplayName("Date Re-opened")]
        [DataType(DataType.Date)]
        public DateTime DateReopened { get; set; }

        public FiscalYearModel FiscalYear { get; set; }
        public RiskLevelModel RiskLevel { get; set; }
        public CrisisModel Crisis { get; set; }
        public ServiceModel Service { get; set; }
        public ProgramModel Program { get; set; }
        public RiskStatusModel RiskStatus { get; set; }
        public AssignedWorkerModel AssignedWorker { get; set; }
        public ReferralSourceModel ReferralSource { get; set; }
        public ReferralContactModel ReferralContact { get; set; }
        public IncidentModel Incident { get; set; }
        public AbuserRelationshipModel AbuserRelationship { get; set; }
        public VictimOfIncidentModel VictimOfIncident { get; set; }
        public FamilyViolenceFileModel FamilyViolenceFile { get; set; }
        public EthnicityModel Ethnicity { get; set; }
        public AgeModel Age { get; set; }
        public RepeatClientModel RepeatClient { get; set; }
        public DuplicateFileModel DuplicateFile { get; set; }
        public FileStatusModel FileStatus { get; set; }

    }
}
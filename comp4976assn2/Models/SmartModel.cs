using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using comp4976assn2.Models.SmartEntity;

namespace comp4976assn2.Models
{
    public class SmartModel
    {
        [Key]
        public int SmartId { get; set; }

        public int ClientReferenceNumber { get; set; }

        [ForeignKey("ClientReferenceNumber")]
        public ClientModel Client { get; set; }

        public int AccompanimentMinutes { get; set; }
        public int NumberTransportsProvided { get; set; }
        public bool ReferredToNurse { get; set; }

        public SexWorkExploitationModel SexWorkExploitation { get; set; }
        public MultiplePerpetratorsModel MultiplePerpetrators { get; set; }
        public DrugFacilitatedAssaultModel DrugFacilitatedAssault { get; set; }
        public CityOfAssaultModel CityOfAssault { get; set; }
        public CityOfResidenceModel CityOfResidence { get; set; }
        public ReferringHospitalModel ReferringHospital { get; set; }
        public HospitalAttendedModel HospitalAttended { get; set; }
        public SocialWorkAttendanceModel SocialWorkAttendance { get; set; }
        public PoliceAttendanceModel PoliceAttendance { get; set; }
        public VictimServicesAttendanceModel VictimServicesAttendance { get; set; }
        public MedicalOnlyModel MedicalOnly { get; set; }
        public EvidenceStoredModel EvidenceStored { get; set; }
        public HIVMedsModel HivMeds { get; set; }
        public ReferredToCBVSModel ReferredToCbvs { get; set; }
        public PoliceReportedModel PoliceReported { get; set; }
        public ThirdPartyReportModel ThirdPartyReport { get; set; }
        public BadDateReportModel BadDateReport { get; set; }

    }
}
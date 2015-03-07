namespace comp4976assn2.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationshipModels",
                c => new
                    {
                        AbuserRelationship = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AbuserRelationship);
            
            CreateTable(
                "dbo.ClientModels",
                c => new
                    {
                        ClientReferenceNumber = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(nullable: false, maxLength: 35),
                        Firstname = c.String(nullable: false, maxLength: 35),
                        PoliceFileNumber = c.String(maxLength: 8),
                        CourtFileNumber = c.Int(),
                        SwcFileNumber = c.Int(nullable: false),
                        RiskAssessmentAssignedTo = c.String(nullable: false, maxLength: 70),
                        AbuserName = c.String(nullable: false),
                        NumberChildren6 = c.Int(nullable: false),
                        NumberChildren12 = c.Int(nullable: false),
                        NumberChildren18 = c.Int(nullable: false),
                        DateLastTransfered = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReopened = c.DateTime(nullable: false),
                        AbuserRelationship_AbuserRelationship = c.String(maxLength: 128),
                        Age_Age = c.String(maxLength: 128),
                        AssignedWorker_AssignedWorker = c.String(maxLength: 128),
                        Crisis_Crisis = c.String(maxLength: 128),
                        DuplicateFile_DuplicateFile = c.String(maxLength: 128),
                        Ethnicity_Ethnicity = c.String(maxLength: 128),
                        FamilyViolenceFile_FamilyViolenceFile = c.String(maxLength: 128),
                        FileStatus_FileStatus = c.String(maxLength: 128),
                        FiscalYear_FiscalYear = c.String(maxLength: 128),
                        Incident_Incident = c.String(maxLength: 128),
                        Program_Program = c.String(maxLength: 128),
                        ReferralContact_ReferralContact = c.String(maxLength: 128),
                        ReferralSource_ReferralSource = c.String(maxLength: 128),
                        RepeatClient_RepeatClient = c.String(maxLength: 128),
                        RiskLevel_RiskLevel = c.String(maxLength: 128),
                        RiskStatus_RiskStatus = c.String(maxLength: 128),
                        Service_Service = c.String(maxLength: 128),
                        VictimOfIncident_VictimOfIncident = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.ClientReferenceNumber)
                .ForeignKey("dbo.AbuserRelationshipModels", t => t.AbuserRelationship_AbuserRelationship)
                .ForeignKey("dbo.AgeModels", t => t.Age_Age)
                .ForeignKey("dbo.AssignedWorkerModels", t => t.AssignedWorker_AssignedWorker)
                .ForeignKey("dbo.CrisisModels", t => t.Crisis_Crisis)
                .ForeignKey("dbo.DuplicateFileModels", t => t.DuplicateFile_DuplicateFile)
                .ForeignKey("dbo.EthnicityModels", t => t.Ethnicity_Ethnicity)
                .ForeignKey("dbo.FamilyViolenceFileModels", t => t.FamilyViolenceFile_FamilyViolenceFile)
                .ForeignKey("dbo.FileStatusModels", t => t.FileStatus_FileStatus)
                .ForeignKey("dbo.FiscalYearModels", t => t.FiscalYear_FiscalYear)
                .ForeignKey("dbo.IncidentModels", t => t.Incident_Incident)
                .ForeignKey("dbo.ProgramModels", t => t.Program_Program)
                .ForeignKey("dbo.ReferralContactModels", t => t.ReferralContact_ReferralContact)
                .ForeignKey("dbo.ReferralSourceModels", t => t.ReferralSource_ReferralSource)
                .ForeignKey("dbo.RepeatClientModels", t => t.RepeatClient_RepeatClient)
                .ForeignKey("dbo.RiskLevelModels", t => t.RiskLevel_RiskLevel)
                .ForeignKey("dbo.RiskStatusModels", t => t.RiskStatus_RiskStatus)
                .ForeignKey("dbo.ServiceModels", t => t.Service_Service)
                .ForeignKey("dbo.VictimOfIncidentModels", t => t.VictimOfIncident_VictimOfIncident)
                .Index(t => t.AbuserRelationship_AbuserRelationship)
                .Index(t => t.Age_Age)
                .Index(t => t.AssignedWorker_AssignedWorker)
                .Index(t => t.Crisis_Crisis)
                .Index(t => t.DuplicateFile_DuplicateFile)
                .Index(t => t.Ethnicity_Ethnicity)
                .Index(t => t.FamilyViolenceFile_FamilyViolenceFile)
                .Index(t => t.FileStatus_FileStatus)
                .Index(t => t.FiscalYear_FiscalYear)
                .Index(t => t.Incident_Incident)
                .Index(t => t.Program_Program)
                .Index(t => t.ReferralContact_ReferralContact)
                .Index(t => t.ReferralSource_ReferralSource)
                .Index(t => t.RepeatClient_RepeatClient)
                .Index(t => t.RiskLevel_RiskLevel)
                .Index(t => t.RiskStatus_RiskStatus)
                .Index(t => t.Service_Service)
                .Index(t => t.VictimOfIncident_VictimOfIncident);
            
            CreateTable(
                "dbo.AgeModels",
                c => new
                    {
                        Age = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Age);
            
            CreateTable(
                "dbo.AssignedWorkerModels",
                c => new
                    {
                        AssignedWorker = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.AssignedWorker);
            
            CreateTable(
                "dbo.CrisisModels",
                c => new
                    {
                        Crisis = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Crisis);
            
            CreateTable(
                "dbo.DuplicateFileModels",
                c => new
                    {
                        DuplicateFile = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DuplicateFile);
            
            CreateTable(
                "dbo.EthnicityModels",
                c => new
                    {
                        Ethnicity = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Ethnicity);
            
            CreateTable(
                "dbo.FamilyViolenceFileModels",
                c => new
                    {
                        FamilyViolenceFile = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FamilyViolenceFile);
            
            CreateTable(
                "dbo.FileStatusModels",
                c => new
                    {
                        FileStatus = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FileStatus);
            
            CreateTable(
                "dbo.FiscalYearModels",
                c => new
                    {
                        FiscalYear = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.FiscalYear);
            
            CreateTable(
                "dbo.IncidentModels",
                c => new
                    {
                        Incident = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Incident);
            
            CreateTable(
                "dbo.ProgramModels",
                c => new
                    {
                        Program = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Program);
            
            CreateTable(
                "dbo.ReferralContactModels",
                c => new
                    {
                        ReferralContact = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralContact);
            
            CreateTable(
                "dbo.ReferralSourceModels",
                c => new
                    {
                        ReferralSource = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferralSource);
            
            CreateTable(
                "dbo.RepeatClientModels",
                c => new
                    {
                        RepeatClient = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RepeatClient);
            
            CreateTable(
                "dbo.RiskLevelModels",
                c => new
                    {
                        RiskLevel = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RiskLevel);
            
            CreateTable(
                "dbo.RiskStatusModels",
                c => new
                    {
                        RiskStatus = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.RiskStatus);
            
            CreateTable(
                "dbo.ServiceModels",
                c => new
                    {
                        Service = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Service);
            
            CreateTable(
                "dbo.VictimOfIncidentModels",
                c => new
                    {
                        VictimOfIncident = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VictimOfIncident);
            
            CreateTable(
                "dbo.BadDateReportModels",
                c => new
                    {
                        BadDateReport = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.BadDateReport);
            
            CreateTable(
                "dbo.SmartModels",
                c => new
                    {
                        SmartId = c.Int(nullable: false, identity: true),
                        ClientReferenceNumber = c.Int(nullable: false),
                        AccompanimentMinutes = c.Int(nullable: false),
                        NumberTransportsProvided = c.Int(nullable: false),
                        ReferredToNurse = c.Boolean(nullable: false),
                        BadDateReport_BadDateReport = c.String(maxLength: 128),
                        CityOfAssault_CityOfAssault = c.String(maxLength: 128),
                        CityOfResidence_CityOfResidence = c.String(maxLength: 128),
                        DrugFacilitatedAssault_DrugFacilitatedAssault = c.String(maxLength: 128),
                        EvidenceStored_EvidenceStored = c.String(maxLength: 128),
                        HivMeds_HIVMeds = c.String(maxLength: 128),
                        HospitalAttended_HospitalAttended = c.String(maxLength: 128),
                        MedicalOnly_MedicalOnly = c.String(maxLength: 128),
                        MultiplePerpetrators_MultiplePerpetrators = c.String(maxLength: 128),
                        PoliceAttendance_PoliceAttendance = c.String(maxLength: 128),
                        PoliceReported_PoliceReported = c.String(maxLength: 128),
                        ReferredToCbvs_ReferredToCBVS = c.String(maxLength: 128),
                        ReferringHospital_ReferringHospital = c.String(maxLength: 128),
                        SexWorkExploitation_SexWorkExploitation = c.String(maxLength: 128),
                        SocialWorkAttendance_SocialWorkAttendance = c.String(maxLength: 128),
                        ThirdPartyReport_ThirdPartyReport = c.String(maxLength: 128),
                        VictimServicesAttendance_VictimServicesAttendance = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.SmartId)
                .ForeignKey("dbo.BadDateReportModels", t => t.BadDateReport_BadDateReport)
                .ForeignKey("dbo.CityOfAssaultModels", t => t.CityOfAssault_CityOfAssault)
                .ForeignKey("dbo.CityOfResidenceModels", t => t.CityOfResidence_CityOfResidence)
                .ForeignKey("dbo.ClientModels", t => t.ClientReferenceNumber, cascadeDelete: true)
                .ForeignKey("dbo.DrugFacilitatedAssaultModels", t => t.DrugFacilitatedAssault_DrugFacilitatedAssault)
                .ForeignKey("dbo.EvidenceStoredModels", t => t.EvidenceStored_EvidenceStored)
                .ForeignKey("dbo.HIVMedsModels", t => t.HivMeds_HIVMeds)
                .ForeignKey("dbo.HospitalAttendedModels", t => t.HospitalAttended_HospitalAttended)
                .ForeignKey("dbo.MedicalOnlyModels", t => t.MedicalOnly_MedicalOnly)
                .ForeignKey("dbo.MultiplePerpetratorsModels", t => t.MultiplePerpetrators_MultiplePerpetrators)
                .ForeignKey("dbo.PoliceAttendanceModels", t => t.PoliceAttendance_PoliceAttendance)
                .ForeignKey("dbo.PoliceReportedModels", t => t.PoliceReported_PoliceReported)
                .ForeignKey("dbo.ReferredToCBVSModels", t => t.ReferredToCbvs_ReferredToCBVS)
                .ForeignKey("dbo.ReferringHospitalModels", t => t.ReferringHospital_ReferringHospital)
                .ForeignKey("dbo.SexWorkExploitationModels", t => t.SexWorkExploitation_SexWorkExploitation)
                .ForeignKey("dbo.SocialWorkAttendanceModels", t => t.SocialWorkAttendance_SocialWorkAttendance)
                .ForeignKey("dbo.ThirdPartyReportModels", t => t.ThirdPartyReport_ThirdPartyReport)
                .ForeignKey("dbo.VictimServicesAttendanceModels", t => t.VictimServicesAttendance_VictimServicesAttendance)
                .Index(t => t.BadDateReport_BadDateReport)
                .Index(t => t.CityOfAssault_CityOfAssault)
                .Index(t => t.CityOfResidence_CityOfResidence)
                .Index(t => t.ClientReferenceNumber)
                .Index(t => t.DrugFacilitatedAssault_DrugFacilitatedAssault)
                .Index(t => t.EvidenceStored_EvidenceStored)
                .Index(t => t.HivMeds_HIVMeds)
                .Index(t => t.HospitalAttended_HospitalAttended)
                .Index(t => t.MedicalOnly_MedicalOnly)
                .Index(t => t.MultiplePerpetrators_MultiplePerpetrators)
                .Index(t => t.PoliceAttendance_PoliceAttendance)
                .Index(t => t.PoliceReported_PoliceReported)
                .Index(t => t.ReferredToCbvs_ReferredToCBVS)
                .Index(t => t.ReferringHospital_ReferringHospital)
                .Index(t => t.SexWorkExploitation_SexWorkExploitation)
                .Index(t => t.SocialWorkAttendance_SocialWorkAttendance)
                .Index(t => t.ThirdPartyReport_ThirdPartyReport)
                .Index(t => t.VictimServicesAttendance_VictimServicesAttendance);
            
            CreateTable(
                "dbo.CityOfAssaultModels",
                c => new
                    {
                        CityOfAssault = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CityOfAssault);
            
            CreateTable(
                "dbo.CityOfResidenceModels",
                c => new
                    {
                        CityOfResidence = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CityOfResidence);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaultModels",
                c => new
                    {
                        DrugFacilitatedAssault = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssault);
            
            CreateTable(
                "dbo.EvidenceStoredModels",
                c => new
                    {
                        EvidenceStored = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.EvidenceStored);
            
            CreateTable(
                "dbo.HIVMedsModels",
                c => new
                    {
                        HIVMeds = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.HIVMeds);
            
            CreateTable(
                "dbo.HospitalAttendedModels",
                c => new
                    {
                        HospitalAttended = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.HospitalAttended);
            
            CreateTable(
                "dbo.MedicalOnlyModels",
                c => new
                    {
                        MedicalOnly = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MedicalOnly);
            
            CreateTable(
                "dbo.MultiplePerpetratorsModels",
                c => new
                    {
                        MultiplePerpetrators = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.MultiplePerpetrators);
            
            CreateTable(
                "dbo.PoliceAttendanceModels",
                c => new
                    {
                        PoliceAttendance = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PoliceAttendance);
            
            CreateTable(
                "dbo.PoliceReportedModels",
                c => new
                    {
                        PoliceReported = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.PoliceReported);
            
            CreateTable(
                "dbo.ReferredToCBVSModels",
                c => new
                    {
                        ReferredToCBVS = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferredToCBVS);
            
            CreateTable(
                "dbo.ReferringHospitalModels",
                c => new
                    {
                        ReferringHospital = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ReferringHospital);
            
            CreateTable(
                "dbo.SexWorkExploitationModels",
                c => new
                    {
                        SexWorkExploitation = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SexWorkExploitation);
            
            CreateTable(
                "dbo.SocialWorkAttendanceModels",
                c => new
                    {
                        SocialWorkAttendance = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.SocialWorkAttendance);
            
            CreateTable(
                "dbo.ThirdPartyReportModels",
                c => new
                    {
                        ThirdPartyReport = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.ThirdPartyReport);
            
            CreateTable(
                "dbo.VictimServicesAttendanceModels",
                c => new
                    {
                        VictimServicesAttendance = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.VictimServicesAttendance);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SmartModels", "VictimServicesAttendance_VictimServicesAttendance", "dbo.VictimServicesAttendanceModels");
            DropForeignKey("dbo.SmartModels", "ThirdPartyReport_ThirdPartyReport", "dbo.ThirdPartyReportModels");
            DropForeignKey("dbo.SmartModels", "SocialWorkAttendance_SocialWorkAttendance", "dbo.SocialWorkAttendanceModels");
            DropForeignKey("dbo.SmartModels", "SexWorkExploitation_SexWorkExploitation", "dbo.SexWorkExploitationModels");
            DropForeignKey("dbo.SmartModels", "ReferringHospital_ReferringHospital", "dbo.ReferringHospitalModels");
            DropForeignKey("dbo.SmartModels", "ReferredToCbvs_ReferredToCBVS", "dbo.ReferredToCBVSModels");
            DropForeignKey("dbo.SmartModels", "PoliceReported_PoliceReported", "dbo.PoliceReportedModels");
            DropForeignKey("dbo.SmartModels", "PoliceAttendance_PoliceAttendance", "dbo.PoliceAttendanceModels");
            DropForeignKey("dbo.SmartModels", "MultiplePerpetrators_MultiplePerpetrators", "dbo.MultiplePerpetratorsModels");
            DropForeignKey("dbo.SmartModels", "MedicalOnly_MedicalOnly", "dbo.MedicalOnlyModels");
            DropForeignKey("dbo.SmartModels", "HospitalAttended_HospitalAttended", "dbo.HospitalAttendedModels");
            DropForeignKey("dbo.SmartModels", "HivMeds_HIVMeds", "dbo.HIVMedsModels");
            DropForeignKey("dbo.SmartModels", "EvidenceStored_EvidenceStored", "dbo.EvidenceStoredModels");
            DropForeignKey("dbo.SmartModels", "DrugFacilitatedAssault_DrugFacilitatedAssault", "dbo.DrugFacilitatedAssaultModels");
            DropForeignKey("dbo.SmartModels", "ClientReferenceNumber", "dbo.ClientModels");
            DropForeignKey("dbo.SmartModels", "CityOfResidence_CityOfResidence", "dbo.CityOfResidenceModels");
            DropForeignKey("dbo.SmartModels", "CityOfAssault_CityOfAssault", "dbo.CityOfAssaultModels");
            DropForeignKey("dbo.SmartModels", "BadDateReport_BadDateReport", "dbo.BadDateReportModels");
            DropForeignKey("dbo.ClientModels", "VictimOfIncident_VictimOfIncident", "dbo.VictimOfIncidentModels");
            DropForeignKey("dbo.ClientModels", "Service_Service", "dbo.ServiceModels");
            DropForeignKey("dbo.ClientModels", "RiskStatus_RiskStatus", "dbo.RiskStatusModels");
            DropForeignKey("dbo.ClientModels", "RiskLevel_RiskLevel", "dbo.RiskLevelModels");
            DropForeignKey("dbo.ClientModels", "RepeatClient_RepeatClient", "dbo.RepeatClientModels");
            DropForeignKey("dbo.ClientModels", "ReferralSource_ReferralSource", "dbo.ReferralSourceModels");
            DropForeignKey("dbo.ClientModels", "ReferralContact_ReferralContact", "dbo.ReferralContactModels");
            DropForeignKey("dbo.ClientModels", "Program_Program", "dbo.ProgramModels");
            DropForeignKey("dbo.ClientModels", "Incident_Incident", "dbo.IncidentModels");
            DropForeignKey("dbo.ClientModels", "FiscalYear_FiscalYear", "dbo.FiscalYearModels");
            DropForeignKey("dbo.ClientModels", "FileStatus_FileStatus", "dbo.FileStatusModels");
            DropForeignKey("dbo.ClientModels", "FamilyViolenceFile_FamilyViolenceFile", "dbo.FamilyViolenceFileModels");
            DropForeignKey("dbo.ClientModels", "Ethnicity_Ethnicity", "dbo.EthnicityModels");
            DropForeignKey("dbo.ClientModels", "DuplicateFile_DuplicateFile", "dbo.DuplicateFileModels");
            DropForeignKey("dbo.ClientModels", "Crisis_Crisis", "dbo.CrisisModels");
            DropForeignKey("dbo.ClientModels", "AssignedWorker_AssignedWorker", "dbo.AssignedWorkerModels");
            DropForeignKey("dbo.ClientModels", "Age_Age", "dbo.AgeModels");
            DropForeignKey("dbo.ClientModels", "AbuserRelationship_AbuserRelationship", "dbo.AbuserRelationshipModels");
            DropIndex("dbo.SmartModels", new[] { "VictimServicesAttendance_VictimServicesAttendance" });
            DropIndex("dbo.SmartModels", new[] { "ThirdPartyReport_ThirdPartyReport" });
            DropIndex("dbo.SmartModels", new[] { "SocialWorkAttendance_SocialWorkAttendance" });
            DropIndex("dbo.SmartModels", new[] { "SexWorkExploitation_SexWorkExploitation" });
            DropIndex("dbo.SmartModels", new[] { "ReferringHospital_ReferringHospital" });
            DropIndex("dbo.SmartModels", new[] { "ReferredToCbvs_ReferredToCBVS" });
            DropIndex("dbo.SmartModels", new[] { "PoliceReported_PoliceReported" });
            DropIndex("dbo.SmartModels", new[] { "PoliceAttendance_PoliceAttendance" });
            DropIndex("dbo.SmartModels", new[] { "MultiplePerpetrators_MultiplePerpetrators" });
            DropIndex("dbo.SmartModels", new[] { "MedicalOnly_MedicalOnly" });
            DropIndex("dbo.SmartModels", new[] { "HospitalAttended_HospitalAttended" });
            DropIndex("dbo.SmartModels", new[] { "HivMeds_HIVMeds" });
            DropIndex("dbo.SmartModels", new[] { "EvidenceStored_EvidenceStored" });
            DropIndex("dbo.SmartModels", new[] { "DrugFacilitatedAssault_DrugFacilitatedAssault" });
            DropIndex("dbo.SmartModels", new[] { "ClientReferenceNumber" });
            DropIndex("dbo.SmartModels", new[] { "CityOfResidence_CityOfResidence" });
            DropIndex("dbo.SmartModels", new[] { "CityOfAssault_CityOfAssault" });
            DropIndex("dbo.SmartModels", new[] { "BadDateReport_BadDateReport" });
            DropIndex("dbo.ClientModels", new[] { "VictimOfIncident_VictimOfIncident" });
            DropIndex("dbo.ClientModels", new[] { "Service_Service" });
            DropIndex("dbo.ClientModels", new[] { "RiskStatus_RiskStatus" });
            DropIndex("dbo.ClientModels", new[] { "RiskLevel_RiskLevel" });
            DropIndex("dbo.ClientModels", new[] { "RepeatClient_RepeatClient" });
            DropIndex("dbo.ClientModels", new[] { "ReferralSource_ReferralSource" });
            DropIndex("dbo.ClientModels", new[] { "ReferralContact_ReferralContact" });
            DropIndex("dbo.ClientModels", new[] { "Program_Program" });
            DropIndex("dbo.ClientModels", new[] { "Incident_Incident" });
            DropIndex("dbo.ClientModels", new[] { "FiscalYear_FiscalYear" });
            DropIndex("dbo.ClientModels", new[] { "FileStatus_FileStatus" });
            DropIndex("dbo.ClientModels", new[] { "FamilyViolenceFile_FamilyViolenceFile" });
            DropIndex("dbo.ClientModels", new[] { "Ethnicity_Ethnicity" });
            DropIndex("dbo.ClientModels", new[] { "DuplicateFile_DuplicateFile" });
            DropIndex("dbo.ClientModels", new[] { "Crisis_Crisis" });
            DropIndex("dbo.ClientModels", new[] { "AssignedWorker_AssignedWorker" });
            DropIndex("dbo.ClientModels", new[] { "Age_Age" });
            DropIndex("dbo.ClientModels", new[] { "AbuserRelationship_AbuserRelationship" });
            DropTable("dbo.VictimServicesAttendanceModels");
            DropTable("dbo.ThirdPartyReportModels");
            DropTable("dbo.SocialWorkAttendanceModels");
            DropTable("dbo.SexWorkExploitationModels");
            DropTable("dbo.ReferringHospitalModels");
            DropTable("dbo.ReferredToCBVSModels");
            DropTable("dbo.PoliceReportedModels");
            DropTable("dbo.PoliceAttendanceModels");
            DropTable("dbo.MultiplePerpetratorsModels");
            DropTable("dbo.MedicalOnlyModels");
            DropTable("dbo.HospitalAttendedModels");
            DropTable("dbo.HIVMedsModels");
            DropTable("dbo.EvidenceStoredModels");
            DropTable("dbo.DrugFacilitatedAssaultModels");
            DropTable("dbo.CityOfResidenceModels");
            DropTable("dbo.CityOfAssaultModels");
            DropTable("dbo.SmartModels");
            DropTable("dbo.BadDateReportModels");
            DropTable("dbo.VictimOfIncidentModels");
            DropTable("dbo.ServiceModels");
            DropTable("dbo.RiskStatusModels");
            DropTable("dbo.RiskLevelModels");
            DropTable("dbo.RepeatClientModels");
            DropTable("dbo.ReferralSourceModels");
            DropTable("dbo.ReferralContactModels");
            DropTable("dbo.ProgramModels");
            DropTable("dbo.IncidentModels");
            DropTable("dbo.FiscalYearModels");
            DropTable("dbo.FileStatusModels");
            DropTable("dbo.FamilyViolenceFileModels");
            DropTable("dbo.EthnicityModels");
            DropTable("dbo.DuplicateFileModels");
            DropTable("dbo.CrisisModels");
            DropTable("dbo.AssignedWorkerModels");
            DropTable("dbo.AgeModels");
            DropTable("dbo.ClientModels");
            DropTable("dbo.AbuserRelationshipModels");
        }
    }
}

using System.Collections.Generic;
using comp4976assn2.Models.ClientEntity;

namespace comp4976assn2.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<comp4976assn2.Models.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            MigrationsDirectory = @"Migrations\ClientMigrations";
        }

        protected override void Seed(comp4976assn2.Models.ClientContext context)
        {
            context.FiscalYearModels.AddOrUpdate(
                f => f.FiscalYear,
                new FiscalYearModel {FiscalYear = "10-11"},
                new FiscalYearModel {FiscalYear = "11-12"},
                new FiscalYearModel {FiscalYear = "12-13"},
                new FiscalYearModel {FiscalYear = "13-14"},
                new FiscalYearModel {FiscalYear = "14-15"},
                new FiscalYearModel {FiscalYear = "15-16"},
                new FiscalYearModel {FiscalYear = "16-17"}
            );

            context.RiskLevelModels.AddOrUpdate(
                r => r.RiskLevel,
                new RiskLevelModel {RiskLevel = "High"},
                new RiskLevelModel {RiskLevel = "DVU"}
            );

            context.CrisisModels.AddOrUpdate(
                c => c.Crisis,
                new CrisisModel { Crisis = "Call" },
                new CrisisModel { Crisis = "Accompaniment" },
                new CrisisModel { Crisis = "Drop-in" }
            );

            context.ServiceModels.AddOrUpdate(
                s => s.Service,
                new ServiceModel { Service = "N/A" },
                new ServiceModel { Service = "File"}
            );

            context.ProgramModels.AddOrUpdate(
                p => p.Program,
                new ProgramModel { Program = "Crisis"},
                new ProgramModel { Program = "Court"},
                new ProgramModel { Program = "SMART"},
                new ProgramModel { Program = "DVU"},
                new ProgramModel { Program = "MCFD"}
            );

            context.RiskStatusModels.AddOrUpdate(
                r => r.RiskStatus,
                new RiskStatusModel { RiskStatus = "Pending"},
                new RiskStatusModel { RiskStatus = "Complete"},
                new RiskStatusModel { RiskStatus = "null"}
            );

            context.AssignedWorkerModels.AddOrUpdate(
                a => a.AssignedWorker,
                new AssignedWorkerModel { AssignedWorker = "Michelle"},
                new AssignedWorkerModel { AssignedWorker = "Tyra"},
                new AssignedWorkerModel { AssignedWorker = "Louise"},
                new AssignedWorkerModel { AssignedWorker = "Angela"},
                new AssignedWorkerModel { AssignedWorker = "Dave"},
                new AssignedWorkerModel { AssignedWorker = "Troy"},
                new AssignedWorkerModel { AssignedWorker = "Michael"},
                new AssignedWorkerModel { AssignedWorker = "Manpreet"},
                new AssignedWorkerModel { AssignedWorker = "Patrick"},
                new AssignedWorkerModel { AssignedWorker = "None"}
            );

            context.ReferralSourceModels.AddOrUpdate(
                r => r.ReferralSource,
                new ReferralSourceModel { ReferralSource = "Community Agency"},
                new ReferralSourceModel { ReferralSource = "Family/Friend"},
                new ReferralSourceModel { ReferralSource = "Government"},
                new ReferralSourceModel { ReferralSource = "CVAP"},
                new ReferralSourceModel { ReferralSource = "CBVS"}
            );

            context.ReferralContactModels.AddOrUpdate(
                r => r.ReferralContact,
                new ReferralContactModel { ReferralContact = "PVBS" },
                new ReferralContactModel { ReferralContact = "MCFD" },
                new ReferralContactModel { ReferralContact = "PBVS" },
                new ReferralContactModel { ReferralContact = "VictimLINK" },
                new ReferralContactModel { ReferralContact = "TH" },
                new ReferralContactModel { ReferralContact = "Self" },
                new ReferralContactModel { ReferralContact = "FNS" },
                new ReferralContactModel { ReferralContact = "Other" },
                new ReferralContactModel { ReferralContact = "Medical" }
            );
            
            context.IncidentModels.AddOrUpdate(
                i => i.Incident,
                new IncidentModel { Incident = "Abduction" },
                new IncidentModel { Incident = "Adult Historical Sexual Assault" },
                new IncidentModel { Incident = "Adult Sexual Assault" },
                new IncidentModel { Incident = "Partner Assault" },
                new IncidentModel { Incident = "Attempteed Murder" },
                new IncidentModel { Incident = "Child Physical Assault" },
                new IncidentModel { Incident = "Child Sexual Abuse/Exploitation" },
                new IncidentModel { Incident = "Criminal Harassment/Stalking" },
                new IncidentModel { Incident = "Elder Abuse" },
                new IncidentModel { Incident = "Human Trafficking" },
                new IncidentModel { Incident = "Murder" },
                new IncidentModel { Incident = "N/A" },
                new IncidentModel { Incident = "Other" },
                new IncidentModel { Incident = "Other Assault" },
                new IncidentModel { Incident = "Other Crime - DV" },
                new IncidentModel { Incident = "Other Familial Assault" },
                new IncidentModel { Incident = "Threatening" },
                new IncidentModel { Incident = "Youth Sexual Assault/Exploitation" }
            );

            context.AbuserRelationshipModels.AddOrUpdate(
                a => a.AbuserRelationship,
                new AbuserRelationshipModel { AbuserRelationship = "Acquaintance" },
                new AbuserRelationshipModel { AbuserRelationship = "Bad Date" },
                new AbuserRelationshipModel { AbuserRelationship = "DNA" },
                new AbuserRelationshipModel { AbuserRelationship = "Ex-Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Ex-Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Multiple Perps" },
                new AbuserRelationshipModel { AbuserRelationship = "N/A" },
                new AbuserRelationshipModel { AbuserRelationship = "Other" },
                new AbuserRelationshipModel { AbuserRelationship = "Other Familial" },
                new AbuserRelationshipModel { AbuserRelationship = "Parent" },
                new AbuserRelationshipModel { AbuserRelationship = "Partner" },
                new AbuserRelationshipModel { AbuserRelationship = "Sibling" },
                new AbuserRelationshipModel { AbuserRelationship = "Stranger" }
            );

            context.VictimOfIncidentModels.AddOrUpdate(
                v => v.VictimOfIncident,
                new VictimOfIncidentModel { VictimOfIncident = "Primary" },
                new VictimOfIncidentModel { VictimOfIncident = "Secondary" }
            );

            context.FamilyViolenceFileModels.AddOrUpdate(
                f => f.FamilyViolenceFile,
                new FamilyViolenceFileModel { FamilyViolenceFile = "Yes" },
                new FamilyViolenceFileModel { FamilyViolenceFile = "No" },
                new FamilyViolenceFileModel { FamilyViolenceFile = "N/A" }
            );

            context.EthnicityModels.AddOrUpdate(
                e => e.Ethnicity,
                new EthnicityModel { Ethnicity = "Indigenous" },
                new EthnicityModel { Ethnicity = "Asian" },
                new EthnicityModel { Ethnicity = "Black" },
                new EthnicityModel { Ethnicity = "Caucasian" },
                new EthnicityModel { Ethnicity = "Declined" },
                new EthnicityModel { Ethnicity = "Latin" },
                new EthnicityModel { Ethnicity = "Middle Eastern" },
                new EthnicityModel { Ethnicity = "Other" },
                new EthnicityModel { Ethnicity = "South Asian" },
                new EthnicityModel { Ethnicity = "South East Asian" }
            );

            context.AgeModels.AddOrUpdate(
                a => a.Age,
                new AgeModel { Age = "Adult >24 <65" },
                new AgeModel { Age = "Youth >12 <19" },
                new AgeModel { Age = "Youth >18 <25" },
                new AgeModel { Age = "Child <13" },
                new AgeModel { Age = "Senoir >64" }
            );

            context.RepeatClientModels.AddOrUpdate(
                r => r.RepeatClient,
                new RepeatClientModel { RepeatClient = "Yes" }
            );

            context.DuplicateFileModels.AddOrUpdate(
                d => d.DuplicateFile,
                new DuplicateFileModel { DuplicateFile = "Yes"}
            );

            context.FileStatusModels.AddOrUpdate(
                f => f.FileStatus,
                new FileStatusModel { FileStatus = "Reopened" },
                new FileStatusModel { FileStatus = "Closed" },
                new FileStatusModel { FileStatus = "Open" }
            );
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic.Enums
{
 
    //Personal Details
    enum Gender
    {
        Male = 1,
        Female,
        Transgender
    }
    enum CandidateType
    {
        SingleParent=1,
        WorkingMother,
        ServedInMilitary,
        Retired,
        LGBTQ
    }
    enum MaritalStatus
    {
        Unmarried=1,
        Married,
        Widowed,
        Divorced,
        Separated
    }
    enum Category
    {
        General,
        ScheduledCaste,
        ScheduledTribe,
        OBCCreamy,
        OBCNonCreamy
    }
    enum WorkPermitUSA
    {
        HaveUSH1Visa=1,
        NeedUSH1Visa,
        USTNPermitHolder,
        USGreenCardHolder,
        USCitizen,
        AuthorizedtoworkInUS,
        US
    }
    enum WorkPermitOtherCountry
    {
        India=1,
        Australia,
        NewZealand,
        England,
        Irland,
        USA
    }
    enum WorkStatus
    {
        Fresher=1,
        Experienced
    }
    enum NoticePeriod
    {
        FifteenDaysOrLess=1,
        OneMonth,
        TwoMonths,
        ThreeMonths,
        MoreThanThreeMonths
    }

    //Address Details
    //AddressType
    enum AddressType
    {
        PermanentAddress=1,
        CurrentAddress
    }

    //Project Details
    //TagwithEmployment
    enum TagwithEmployment
    {
        Phd=1,
        Grduation,
        PreviousEmployement
    }
    
    enum ProjectStatus
    {
        InProgress=1,
        Completed
    }
    enum ProjectSite
    {
        offsite=1,
        Onsite
    }
    enum EmploymentNature
    {
        FullTime=1,
        PartTime,
        Contractual
    }
    enum Role
    {
        TestEngineer=1,
        QAArchitect,
        TechLead,
        ProjectManager,
        Developer,
        Support
    }

    //Career Profile Details
    //Current Industry
    enum CurrentIndustry
    {
        HardwareAndNeworking1,
        ECommerce,
        Banking,
        Insurance,
        Agriculture,
        ELearning,
        InformaionTechnology
    }
    enum Department
    {
        DataSceinceAndAnalytics=1,
        ProductManagement,
        ITAndInformationSecurity,
        Consulting,
        TeachingAndTraining
    }
    enum DesiredType
    {
        Permanent=1,
        Contractual
    }
    enum DesiredEmploymentType
    {
        FullTime=1,
        PartTime
    }
    enum PrefferedShift
    {
        Day=1,
        Night,
        Flexible
    }
    enum PrefferedLocation
    {
        Bangalore=1,
        Hyderabad,
        Chennai
    }
    enum JobRole
    {
        Testing=1,
        Development,
        ProjectManagement,
        ProductSupport,
        Depolyment,
        Marketing

    }

}

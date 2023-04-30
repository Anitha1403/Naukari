using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate.BusinessLogic.Constants
{
    public class Constants
    {
        //Constant Vaules for Candidate Personal Details 
        //Gender Values
        public const string MALE = "Male";
        public const string FEMALE = "Female";
        public const string TRANSGENDER = "Transgender";

        //CandidateType Values
        public const string SINGLE_PARENT = "Single Parent";
        public const string WORKING_MOTHER = "Working Mother";
        public const string SERVED_IN_MILITARY = "Served in Military";
        public const string RETIRED = "Retired(60+)";
        public const string LGBTQ = "LGBTQ+";

        //MaritalStatus values
        public const string UN_MARRIED = "Single/unmarried";
        public const string MARRIED = "Married";
        public const string WIDOWED = "Widowed";
        public const string DIVORCED = "Divorced";
        public const string SEPARATED = "Separated";

        //Category Values
        public const string GENERAL = "General";
        public const string SC = "Scheduled caste(SC)";
        public const string ST = "Scheduled Tribe(ST)";
        public const string OBC_CREAMY = "OBC- Creamy";
        public const string OBC_NON_CREAMY = "OBC- Non Creamy";

        //Diferently abled
        public const string DIFFERENTLY_ABLED = "Yes";
        public const string DIFFERENTLY_NOT_ABLED = "No";

        //Career break
        public const string CAREER_BREAK = "Yes";
        public const string NO_CAREER_BREAK = "No";

        //Work Permit USA
        public const string HAVE_US_H1_VISA = "Have US H1 Visa";
        public const string NEED_US_H1_VISA = "Need US H1 Visa";
        public const string US_TN_PERMIT_HOLDER = "US TN Permit Holder";
        public const string US_GREEN_CARD_HOLDER = "US Green Card Holder";
        public const string US_CITIZEN = "US Citizen";
        public const string AUTHORIZED_TO_WORK_IN_US="Authorized to work in US";
        public const string US = "US";

        //Work Permit Other Countries
        public const string INDIA = "India";
        public const string AUSTRALIA = "Australia";
        public const string NEWZEALAND = "New Zealand";
        public const string ENGLAND = "England";
        public const string IRLAND = "Irland";
        public const string USA = "USA";

        //Work Status
        public const string FRESHER = "Fresher";
        public const string EXPERIENCED = "Experienced";

        //Notice Period
        public const string FIFTEEN_DAYSORLESS=" 15 days or less";
        public const string ONE_MONTH = "1 Month";
        public const string TWO_MONHS = "2 Months";
        public const string THREE_MONTHS = "3 Months";
        public const string MORE_THAN_THREE_MONTHS = "More than 3 Months";

        //Address Details
        //Address Type
        public const string PERMANENT_ADDRESS = "Permanent Addreess";
        public const string CURRENT_ADDRESS = "Current Addreess";

        //Project Details
        //TagwithEmployment
        public const string PHD = "Phd";
        public const string GRADUATION = "Grduation";
        public const string PREVIOUS_EMPLOYMENT = "Previous Employement";

        //Project Status
        public const string IN_PROGRESS = "InProgress";
        public const string COMPLETED = "Completed";

        //Project site
        public const string OFFSITE = "offsite";
        public const string ONSITE = "Onsite";

        //Employment Nature
        public const string FULL_TIME = "Full Time";
        public const string PART_TIME = "Part Time";
        public const string CONTRACTUAL = "Contractual";

        //Role Description
        public const string TEST_ENGINEER = "Test Engineer";
        public const string QA_ARCHITECT = "QA Architect";
        public const string TECH_LEAD= "Tech Lead";
        public const string PROJECT_MANAGER="Project Manager";
        public const string DEVELOPER = "Developer";
        public const string SUPPORT = "Support";

        //Career Profile
        //Current Industry
        public const string HARDWARE_NETWORKING = "Hardware & Neworking";
        public const string E_COMMERCE = "E-commerce";
        public const string BANKING = "Banking";
        public const string INSURANCE = "Insurance";
        public const string AGRICULTURE = "Agriculture";
        public const string E_LEARNING = "E-Learning";
        public const string INFORMATION_TECHNOLOGY = "Informaion Technology";

        //Department
        public const string DATA_SCIENCE_AND_ANALYTICS = "Data scince & analytics";
        public const string PRODUCT_MANAGEMENT = "Product Management";
        public const string IT_INFORMATION_SECURITY = "IT & Infor mation security";
        public const string CONSULTING = "Consulting";
        public const string TEACHING_TRAINING = "Teaching & Training";

        //Desired type
        public const string PERMANENT_TYPE = "Permanent";
        public const string CONTRACTUAL_TYPE = "Contractual";

        //Desired employment type 
        public const string FULLTIME = "Full Time";
        public const string PARTTIME = "Part Time";

        //Preffered shift
        public const string DAY = "Day";
        public const string NIGHT = "Night";
        public const string FLEXIBLE ="Flexible";

        //Preffered Location
        public const string BANGALORE= "Bangalore";
        public const string HYDERABAD = "Hyderabad";
        public const string CHENNAI = "Chennai";

        //Job role
        public const string TESTING = "Testing";
        public const string DEVELOPMENT = "Development";
        public const string PROJECT_MANAGEMENT = "Project Management";
        public const string PRODUCT_SUPPORT = "Product Support";
        public const string DEPLOYMENT = "Depolyment";
        public const string MARKETING = "Marketing";

        //Accmplishments
        //Online profiles
        //social profile
        public const string FACEBOOK = "Facebook";
        public const string LINKED_IN = "Linkedin";

        //PatentDetails
        //PatentIssue
        public const string PATENT_ISUUED = "Issued";
        public const string PATENT_PENDING = "Pending";

        //Work sample details
        //Currently working
        public const string CURRENTLY_WORKING = "Yes";
        public const string CURRENTLY_NOT_WORKING = "No";

        //Certification details
        //Certification expires 
        public const string CERTIFICATION_EXPIRES = "Yes";
        public const string CERTIFICATION_NOT_EXPIRES = "No";

        //Languages
        //Proficiency
        public const string BEGINNER = "Beginner";
        public const string PROFICIENT = "Proficient";
        public const string EXPERT = "Expert";

        //Read
        public const string ABLED_READ = "Yes";
        public const string NOT_ABLED_READ = "No";

        // write
        public const string ABLED_WRITE = "Yes";
        public const string NOT_ABLED_WRITE = "No";

        //Speak
        public const string ABLED_SPEAK = "Yes";
        public const string NOT_ABLED_SPEAK = "No";

        //Education details
        //SSC education details
        //SSC type 
        public const string SSC_ANDHRA_PRADESH = "AndhraPradesh";
        public const string SSC_KARNATAKA = "Karnataka";
        public const string SSC_TELENGANA = "Telengana";
        public const string SSC_TAMILANADU = "Tamilanadu";

        //SSC Medium
        public const string SSC_TELUGU = "Telugu";
        public const string SSC_ENGLISH = "English";
        public const string SSC_SANSKRIT = "Sanskrit";
        public const string SSC_TAMIL = "Tamil";

        //Twelfth education details
        //Twelfth type 
        public const string TWELFTH_ANDHRA_PRADESH = "AndhraPradesh";
        public const string TWELFTH_KARNATAKA = "Karnataka";
        public const string TWELFTH_TELENGANA = "Telengana";
        public const string TWELFTH_TAMILANADU = "Tamilanadu";

        //Twelfth Medium
        public const string TWELFTH_TELUGU = "Telugu";
        public const string TWELFTH_ENGLISH = "English";
        public const string TWELFTH_SANSKRIT = "Sanskrit";
        public const string TWELFTH_KANNADA = "Kannada";
        public const string TWELFTH_TAMIL = "Tamil";

        //Graduation details
        //Graduation course
        public const string GRADUATION_BSC = "B.SC";
        public const string GRADUATION_BCOM = "B.COM";
        public const string GRADUATION_BA = "BA";
        public const string GRADUATION_BTECH = "Btech";

        //Graduation stream
        public const string GRADUATION_COMPUTERS = "Computers";
        public const string GRADUATION_CIVIL = "Civil";
        public const string GRADUATION_CHEMICAL = "Chemical";
        public const string GRADUATION_COMMUNICATION = "Communication";

        //Course type
        public const string GRADUATION_FULLTIME = "Full time";
        public const string GRADUATION_PARTTIME = "Part Time";
        public const string GRADUATION_DISTANCE = "Distance";

        //Grading system
        public const string SCALE10_GRADUATION_GRADING_SYSTEM = "Scale 10 Graduation system";
        public const string SCALE4_GRADUATION_GRADING_SYSTEM = "Scale 4 Graduation system";
        public const string PASS_GRADUATION_GRADING_SYSTEM = "Course Requires a Pass";

        //primary education
        public const string PRIMARY_GRADUATION = "Yes";
        public const string NOT_PRIMARY_GRADUATION = "No";

        //Post graduation details
        //Post Graduation (PG) course
        public const string PG_MBA = "MBA";
        public const string PG_MCOM = "M.COM";
        public const string PG_MCA = "MCA";
        public const string PG_MTECH = "M.Tech";

        //PG stream
        public const string PG_COMPUTERS = "Computers";
        public const string PG_FINANCE = "Finance";
        public const string PG_CHEMICAL = "Chemical";
        public const string PG_ELECTRICAL = "Electrical";

        //Course type
        public const string PG_FULLTIME = "Full time";
        public const string PG_PARTTIME = "Part Time";
        public const string PG_DISTANCE = "Distance";

        //Grading system
        public const string SCALE10_PG_GRADING_SYSTEM = "Scale 10 Graduation system";
        public const string SCALE4_PG_GRADING_SYSTEM = "Scale 4 Graduation system";
        public const string PASS_PG_GRADING_SYSTEM = "Course Requires a Pass";

        //doctorate education details
        //Doctorate course
        public const string DOCTORATE_PHD = "Phd";
        public const string DOCTORATE_MPHILL = "Mphill";

        //Doctorate stream
        public const string DOCTORATE_COMPUTERS = "Computers";
        public const string DOCTORATE_FINANCE = "Finance";
        public const string DOCTORATE_CHEMICAL = "Chemical";
        public const string DOCTORATE_ELECTRICAL = "Electrical";
        public const string DOCTORATE_MARKETING = "Marketing";

        //Course type
        public const string DOCTORATE_FULLTIME = "Full time";
        public const string DOCTORATE_PARTTIME = "Part Time";
        public const string DOCTORATE_DISTANCE = "Distance";

        //Grading system
        public const string SCALE10_DOCTORATE_GRADING_SYSTEM = "Scale 10 Graduation system";
        public const string SCALE4_DOCTORATE_GRADING_SYSTEM = "Scale 4 Graduation system";
        public const string PASS_DOCTORATE_GRADING_SYSTEM = "Course Requires a Pass";

    }
}

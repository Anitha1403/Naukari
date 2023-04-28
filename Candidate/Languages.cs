using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candidate
{
    /// <summary>
    /// Class that holds Candidate Languages Details
    /// </summary>
    public class Languages
    {
        public List<Language> LanguageList { get; set; }

    }
    public class Language
    {
        /// <summary>
        /// Class that holds Candidate One Languae Details
        /// </summary>
        public string LanguageName { get; set; }
        public string Proficiency { get; set; }
        public bool Read { get; set; }
        public bool Write { get; set; }
        public bool Speak { get; set; }
    }
}

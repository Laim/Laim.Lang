using System.Reflection;
using System.IO;

namespace Laim.Lang
{
    /// <summary>
    /// Main Language Picker Class
    /// </summary>
    public class LanguagePicker
    {
        /// <summary>
        /// The language the user wants to use, ideally you'd follow the ISO Language Codes
        /// https://www.andiamo.co.uk/resources/iso-language-codes/
        /// </summary>
        public static string Language { get; set; }
        
        /// <summary>
        /// This is the location of your language files, such as C:\AppName\Languages\
        /// </summary>
        public static string LanguageLocation { get; set; }
        
        /// <summary>
        /// The format of your language files, such as .lang, .transl etc.
        /// </summary>
        public static string LanguageFileFormat { get; set; } = ".lang"; // default File Format incase not defined by user
       
        /// <summary>
        /// The standard naming convention for your files, such as LangFile-
        /// </summary>
        public static string LanguageFileName { get; set; } = "Language-"; // default File Name incase not defined by user

        /// <summary>
        /// This is the main 'Node' in the language file, language files follow xml format
        /// </summary>
        public static string LangugeFileNode { get; set; } = "Language"; // Default node incase not defined by user

        /// <summary>
        /// The location of your Translator Log files
        /// </summary>
        public static string LanguageLogLocation { get; set; } = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Logs\\Translator\\";
       
        /// <summary>
        /// The name of the file
        /// </summary>
        public static string LanguageLogName { get; set; } = "LanguageLog";
        
        /// <summary>
        /// The format you want the date to be in the filename
        /// </summary>
        public static string LanguageLogDateFormat { get; set; } = "ddMMyyyy";
    }
}

using System;
using System.Xml;   
namespace Laim.Lang
{

    /// <summary>
    /// Basic Translator Class
    /// </summary>
    public class Translator
    {

        private static readonly string dateTime = DateTime.Now.ToString(LanguagePicker.LanguageLogDateFormat);

        /// <summary>
        /// Translate the specific node to the chosen language
        /// </summary>
        /// <param name="Node">The node you want translated</param>
        /// <param name="Default">The value to return if a translation fails</param>
        /// <returns></returns>
        public static string Translate(string Node, string Default = null)
        {
            try
            {
                string FilePath = LanguagePicker.LanguageLocation + LanguagePicker.LanguageFileName + LanguagePicker.Language + LanguagePicker.LanguageFileFormat;

                XmlDocument xml = new XmlDocument();
                xml.Load(FilePath);
                XmlNodeList nodeList = xml.GetElementsByTagName(LanguagePicker.LangugeFileNode);
                string nodeValue = ""; //mlem disgusting

                foreach (XmlElement el in nodeList)
                {
                    nodeValue = el[Node].InnerText;
                }
                return nodeValue;
            } catch (Exception ex)
            {
                System.IO.File.AppendAllText(
                    LanguagePicker.LanguageLogLocation + LanguagePicker.LanguageLogName + "_" + dateTime + ".log", 
                    dateTime + " : " + ex.Message + Environment.NewLine + ex.StackTrace + Environment.NewLine);
                if (Default == null)
                {
                    return "TranslationError";
                } else
                {
                    return Default;
                }
            }
        }
    }
}

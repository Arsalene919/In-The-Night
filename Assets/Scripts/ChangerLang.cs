using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Xml;
using System.Text;
using UnityEngine;
public class ChangerLang : MonoBehaviour
{
    public TextAsset dictionary;

    public string language;
    public int currentLanguage;

    List<Dictionary<string, string>> languages = new List<Dictionary<string, string>>();
    Dictionary<string, string> obj;

    void Reader()
    {
        XmlDocument xmlDoc = new XmlDocument();
        xmlDoc.LoadXml(dictionary.text);
        XmlNodeList languagesList = xmlDoc.GetElementsByTagName("language");

        foreach(XmlNode languageValue in languagesList)
        {
            XmlNodeList languageContent = languageValue.ChildNodes;
            obj = new Dictionary<string, string>();

            foreach(XmlNode value in languageContent)
            {

            }
        }
    }
}

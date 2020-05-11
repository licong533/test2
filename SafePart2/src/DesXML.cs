using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Xml;

namespace SafePart.src {
  public class DesXML {
    public string MapToXMLStr(IDictionary<string, string> map)
    {
      DirAddIP(map);
      XmlDocument doc = MapToXML(map);
      return doc.InnerXml;
    }

    public XmlDocument MapToXML(IDictionary<string, string> map)
    {
      try
      {
        XmlDocument doc = new XmlDocument();
        XmlDeclaration declaration = doc.CreateXmlDeclaration("1.0", "UTF-8", null);
        XmlElement root = doc.DocumentElement;
        doc.InsertBefore(declaration, root);
        XmlElement google = doc.CreateElement("google");
        doc.AppendChild(google);
        foreach (KeyValuePair<string, string> kvp in map) 
        {
          XmlElement element = doc.CreateElement(kvp.Key);
          element.InnerText = kvp.Value;
          google.AppendChild(element);
        }
        return doc;
      }
      catch (Exception ex)
      {
        throw new Exception("Map to XML error." + ex.Message);
      }
    }

    public XmlDocument StringToXML(string str)
    {
      XmlDocument xml = new XmlDocument();
      try
      {
        xml.LoadXml(str);
      }
      catch (Exception ex)
      {
        throw new Exception("Parse string to XML error." + ex.Message);
      }
      return xml;
    }

   /* 
   *<google>
    <son>
      <id>1</id>
      <name>desmond</name>
    </son>
    </google>
     */

    public Hashtable XmlToHashTable(XmlDocument doc)
    {
      Hashtable table = new Hashtable();
      try
      {
        XmlElement root = doc.DocumentElement;
        XmlNodeList sonlist = root.GetElementsByTagName("son");
        foreach (XmlNode node in sonlist) {
          XmlNode id = node.FirstChild;
          XmlNode name = node.LastChild;
          table.Add(id.InnerText, name.InnerText);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Parse XML error. " + ex.Message);
      }
      return table;
    }

    public string XMLToString(XmlDocument doc)
    {
      return doc.InnerXml;
    }

    public IDictionary<string, string> DirAddIP(IDictionary<string, string> map)
    {
      string localip = Common.GetLocalIP();
      string nextip = ConfigurationSettings.AppSettings["serverip"];
      map.Add("before", "");
      map.Add("local", localip);
      map.Add("next", nextip);
      return map;
    }

    public XmlDocument StringToXml(string xml)
    {
      XmlDocument doc = new XmlDocument();
      try
      {
        doc.LoadXml(xml);
      }
      catch (Exception ex)
      {
        throw new Exception("String to xml error." + ex.Message);
      }
      return doc;
    }

    public String GetValueById(XmlDocument doc, String id)
    {
      XmlNodeList list = doc.GetElementsByTagName(id);
      if(list.Count <= 0)
        throw new Exception("Get local value error.");
      return list.Item(0).InnerText;
    }

    public XmlDocument SetValueById(XmlDocument doc, String id, String value)
    {
      XmlNodeList list = doc.GetElementsByTagName(id);
      if (list.Count <= 0)
        throw new Exception("Get local value error.");
      list.Item(0).InnerText = value;
      return doc;
    }
  }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Xml;

namespace SafePart.src
{
  public static class Data
  {
    private static Queue<XmlDocument> FromServer = new Queue<XmlDocument>();
    private static int num = 0;
    private static Mutex mut = new Mutex();
    private static Queue<XmlDocument> monitor = new Queue<XmlDocument>(); 
    private static Mutex monitorsign = new Mutex();

    public static void EnXml(XmlDocument doc)
    {
      lock (mut)
      {
        FromServer.Enqueue(doc);
        num++;
      }
    }

    public static XmlDocument DeXml()
    {
      XmlDocument doc;
      lock (mut)
      {
        doc = FromServer.Dequeue();
        num--;
      }
      return doc;
    }

    public static int GetNum()
    {
      return num;
    }

    public static void EnMonitor(XmlDocument doc)
    {
      lock (monitorsign)
      {
        monitor.Enqueue(doc);
      }
    }

    public static XmlDocument DeMonitor()
    {
      lock (monitorsign)
      {
        if (monitor.Count <= 0)
          return null;
        else
        {
          XmlDocument doc = monitor.Dequeue();
          return doc;
        }
      }
    }
  }
}

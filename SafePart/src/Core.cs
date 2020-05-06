using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Threading;
using System.Xml;

namespace SafePart.src
{
  public class Core
  {
    public void run()
    {
      Thread thread = new Thread(new ThreadStart(this.start));
      thread.Start();
    }

    public void start()
    {
      XmlDocument doc = Data.DeXml();
      if (doc != null)
      {
        DealXml(doc);
      }
      return;
      //It is for all
      //while (true)
      //{
      //  XmlDocument doc = Data.DeXml();
      //  if (doc != null)
      //  {
      //    DealXml(doc);
      //  }
      //}
    }

    public void DealXml(XmlDocument doc)
    {
      try
      {
        DesXML des = new DesXML();
        String local = des.GetValueById(doc, "local");
        String oldnext = des.GetValueById(doc, "next");
        String next = ConfigurationSettings.AppSettings["serverip"];
        doc = des.SetValueById(doc, "before", local);
        doc = des.SetValueById(doc, "local", oldnext);
        doc = des.SetValueById(doc, "next", next);
        String message = des.XMLToString(doc);
        String port = ConfigurationSettings.AppSettings["fromback"];
        Network net = new Network();
        net.Deal(message, port);
      }
      catch (Exception ex)
      {
        throw new Exception("Deal XML Error." +ex.Message);
      }
    }
  }
}

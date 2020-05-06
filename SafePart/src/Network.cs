using System;       //引入11个命名空间
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace SafePart.src {
  public class Network {
    public Network()
    {
      
    }

    public void listenserver()
    {
      string port = ConfigurationSettings.AppSettings["servernumberport"];
      try
      {
        TcpListener listener = new TcpListener(Convert.ToInt32(port)); 
        listener.Start();
        while (true)
        {
          byte[] result = new byte[2050];
          int lenght = 0;
          TcpClient client = listener.AcceptTcpClient();
          NetworkStream stream = client.GetStream();
          while (stream.DataAvailable)
          {
            int len = stream.Read(result, lenght, result.Length);
            lenght += len;
          }
          client.Close();
          dealmessage(result);
        }
      }catch (Exception ex) 
      {
        throw new Exception("listenserver Error.");
      }
      return;
    }

    public void listenmonitor()
    {
      string port = ConfigurationSettings.AppSettings["tomonitor"];
      try
      {
        TcpListener listener = new TcpListener(Convert.ToInt32(port));
        listener.Start();
        while (true)
        {
          byte[] result = new byte[2050];
          StringBuilder sb = new StringBuilder();
          int lenght = 0;
          TcpClient client = listener.AcceptTcpClient();
          NetworkStream stream = client.GetStream();
          while (true)
          {
            int len = stream.Read(result, 0, 2050);
            if (len <= 0)
              break;
            sb.Append(System.Text.Encoding.UTF8.GetString(result, 0, len));
          }
          client.Close();
          XmlDocument doc = (new DesXML().StringToXML(sb.ToString()));
          Data.EnMonitor(doc);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Listen From Server Error.");
      }
      return;
    }

    private void dealmessage(byte[] data)
    {
      ClientRSA clientrsa = new ClientRSA();
      byte[] result = EnDeRSA.Dewithprivatekey(data, clientrsa.Privatekey);
      string message = System.Text.Encoding.ASCII.GetString(result);
      string[] messages = message.Split('\n');
      switch (messages[0])
      {
        case "1":
          dealtypeone(messages);
          break;
        case "2":
          dealtypetwo(messages);
          break;
        case "3":
          dealtypethree(messages);
          break;
        case "4":
          dealtypefour(messages);
          break;
        default:
          throw new Exception("Get bad message.");
      }
    }

    private void dealtypeone(string[] message)
    {
      if (message.Length < 0)
      {
        throw new Exception("Deal type one message error, the length less than three.");
      }
      Message clientmessage = new Message();
      clientmessage.Number = message[1];
      string publickey = "";
      for (int i = 0; i < message.Length; i++) 
      {
        if (message[i].Equals("-----BEGIN PUBLIC KEY-----"))
        {
          for (int j = i; j < message.Length; j++)
          {
            publickey += message[j];
            publickey += '\n';
            if (message[j].Equals("-----END PUBLIC KEY-----"))
            {
              break;
            }
          }
          break;
        }
      }
      ReadWriteRSA.writerrsa("ServerPublicKey.pem", publickey);
      MessageBox.Show("注册成功");
    }

    private void dealtypetwo(string[] message) 
    {
      if (message.Length < 6)
      {
        throw new Exception("Deal type two message error, the length less than six.");
      }
      Message clientmessage = new Message();
      clientmessage.Messagevalue = message[1];
      clientmessage.Number = message[2];
      clientmessage.Address = message[3];
      clientmessage.Level = message[4];
      clientmessage.Email = message[5];
    }

    private void dealtypethree(string[] message)
    {
      ClientAES clientaes = new ClientAES();
      Message clientmessage = new Message();
      clientmessage.Level = message[1];
      clientaes.Level2 = Encoding.ASCII.GetBytes(message[2]);
    }

    private void dealtypefour(string[] message)
    {
      for (int i = 0; i < message.Length; i++)
      {
        if (message[i].Contains("TRUE"))
        {
          MessageBox.Show("注册成功");
          return;
        }
        else if (message[i].Contains("FALSE"))
        {
          MessageBox.Show("注册失败");
          return;
        }
      }
    }

    public Hashtable GetClientList()
    {
      Hashtable list = new Hashtable();
      string ip = ConfigurationSettings.AppSettings["serverip"];
      string port = ConfigurationSettings.AppSettings["clientport"];
      if (string.IsNullOrEmpty(port) || string.IsNullOrEmpty(ip))
      {
        throw new Exception("服务器地址或端口错误。");
      }
      try
      {
        list = GetHashTableFromServer(ip, Convert.ToInt32(port));
      }
      catch (Exception ex)
      {
        throw ex;
      }
      return list;
    }

    private Hashtable GetHashTableFromServer(string ip, int port)
    {
      TcpClient client = new TcpClient(ip, port);
      NetworkStream stream = client.GetStream();
      return GetXMLFromStream(stream);
    }

    private Hashtable GetXMLFromStream(NetworkStream stream)
    {
      StringBuilder build = new StringBuilder();
      byte[] message = new byte[1024];
      while (true) {
        int x = stream.Read(message, 0, 1024);
        if (x == 0)
          break;
        build.Append(Encoding.UTF8.GetString(message, 0, x));
      }
      DesXML desxml = new DesXML();
      XmlDocument doc = desxml.StringToXML(build.ToString());
      return desxml.XmlToHashTable(doc);
    }

    public void Deal(string xml)
    {
      try
      {
        string ip = ConfigurationSettings.AppSettings["serverip"];
        string port = ConfigurationSettings.AppSettings["dealport"];
        TcpClient client = new TcpClient(ip, Convert.ToInt32(port));
        //TODO: AES encrypt should be added
        NetworkStream stream = client.GetStream();
        stream.Write(System.Text.Encoding.UTF8.GetBytes(xml), 0, xml.Length);
        stream.Flush();
        client.Close();
      }
      catch (Exception ex)
      {
        throw new Exception("Send Deal Error." + ex.Message);
      }
    }
    //TODO: This function i have no test

    public void Deal(string xml, String port)
    {
      try
      {
        string ip = ConfigurationSettings.AppSettings["serverip"];
        TcpClient client = new TcpClient(ip, Convert.ToInt32(port));
        //TODO: AES encrypt should be added
        NetworkStream stream = client.GetStream();
        stream.Write(System.Text.Encoding.UTF8.GetBytes(xml), 0, xml.Length);
        stream.Flush();
        client.Close();
      }
      catch (Exception ex)
      {
        throw new Exception("Send Deal Error." + ex.Message);
      }
    }

    public void ListenDeal()
    {
      string port = ConfigurationSettings.AppSettings["listenclient"];
      try
      {
        TcpListener listener = new TcpListener(Convert.ToInt32(port));
        listener.Start();
        while (true)
        {
          byte[] result = new byte[2050];
          StringBuilder build = new StringBuilder();
          TcpClient client = listener.AcceptTcpClient();
          NetworkStream stream = client.GetStream();
          while (true)
          {
            int x = stream.Read(result, 0, 2050);
            if (x == 0)
              break;
            build.Append(Encoding.UTF8.GetString(result, 0, x));
          }
          client.Close();
          //TODO:First AES decrypt, Then I have no deal the message, but it should be deal
          DesXML desxml = new DesXML();
          XmlDocument doc = desxml.StringToXML(build.ToString());
          MessageBox.Show("处理成功");
        } 
      }
      catch (Exception ex)
      {
        throw new Exception("Deal listen Error.");
      }
      return;
    }

    public void ListenFromServer()//后台处理
    {
      string port = ConfigurationSettings.AppSettings["toback"];
      try
      {
        TcpListener listener = new TcpListener(Convert.ToInt32(port));
        listener.Start();
        while (true)
        {
          byte[] result = new byte[2050];
          StringBuilder sb = new StringBuilder();
          int lenght = 0;
          TcpClient client = listener.AcceptTcpClient();
          NetworkStream stream = client.GetStream();
          while (true)
          {
            int len = stream.Read(result, 0, 2050);
            if (len <= 0)
              break;
            sb.Append(System.Text.Encoding.UTF8.GetString(result, 0, len));
          }
          client.Close();
          XmlDocument doc = (new DesXML().StringToXML(sb.ToString()));
          Data.EnXml(doc);
        }
      }
      catch (Exception ex)
      {
        throw new Exception("Listen From Server Error.");
      }
      return;
    }

  }
}

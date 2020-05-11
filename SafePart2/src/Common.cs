using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SafePart.src {
  public class Common {

    public static bool sendfile(string filename)
    {
      string message = filetostring(filename);
      threadsendmessage(message);
      return true;
    }

    public static bool sendstring(string stringname)
    {
      threadsendmessage(stringname);
      return true;
    }

    public static bool sendfileandstring(string filename, string stringname)
    {
     // stringname += '\n';
      stringname += filetostring(filename);
      if (threadsendmessage(stringname))
        return true;
      return false;
    }

    public static bool threadsendmessage(string message)
    {
      bool sign = false;
      ThreadStart methodstart = delegate { sign = sendmessage(message); };
      Thread thread = new Thread(new ThreadStart(methodstart));
      thread.Start();
      thread.Join();
      if (sign == true)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

    public static bool sendmessage(string message)
    {
      string ip = "";
      string port = "";
      TcpClient tcpclient;
      try
      {
        ip = ConfigurationSettings.AppSettings["serverip"];
        port = ConfigurationSettings.AppSettings["serverport"];
      }
      catch (Exception ex)
      {
        MessageBox.Show("Get ip and port error.");
        return false;
      }
      try
      {
        tcpclient = new TcpClient(ip, Convert.ToInt32(port));
        Byte[] data = System.Text.Encoding.ASCII.GetBytes(message);
        Byte[] get = new byte[20];
        NetworkStream stream = tcpclient.GetStream();
        stream.Write(data, 0, data.Length);
        stream.Flush();
        tcpclient.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Message(string) send error.");
        return false;
      }
      return true;
    }

    public static string filetostring(string filename)
    {
      string text = "";
      try
      {
        text = System.IO.File.ReadAllText(filename);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Read file error.");
      }
      return text;
    }

    public static bool sendbytes(byte[] bytes, string port)
    {
      if (threadsendbytes(bytes, port))
        return true;
      else
        return false;
    }

    public static bool threadsendbytes(byte[] bytes, string port)
    {
      bool sign = false;
      ThreadStart threadstart = delegate {sign = thsendbytes(bytes, port);};
      Thread thread = new Thread(threadstart);
      thread.Start();
      thread.Join(5000);
      if (sign)
        return true;
      else
        return false;
    }

    public static bool thsendbytes(byte[] bytes, string port)
    {
      string ip = ConfigurationSettings.AppSettings["serverip"];
      if (port.Equals("88") || String.IsNullOrEmpty(port))
      {
        port = ConfigurationSettings.AppSettings["serverport"];
      }
      try
      {
        TcpClient tcpclient = new TcpClient(ip, Convert.ToInt32(port));
        NetworkStream stream = tcpclient.GetStream();
        stream.Write(bytes, 0, bytes.Length);
        Byte[] get = new byte[20];
        stream.Flush();
        stream.ReadTimeout = 10000;
        stream.Read(get, 0, 20);
        string str = System.Text.Encoding.ASCII.GetString(get);
        tcpclient.Close();
        if (str.Contains("TRUE")) {
          return true;
        } else {
          return false;
        }
        
      }
      catch (Exception ex)
      {
        MessageBox.Show("Message(bytes) send error.");
        return false;
      }
    }

    public static string GetLocalIP()
    {
      IPHostEntry host;
      string localip = "";
      host = Dns.GetHostEntry(Dns.GetHostName());
      foreach (IPAddress ip in host.AddressList)
      {
        if (ip.AddressFamily == AddressFamily.InterNetwork)
        {
          localip = ip.ToString();
          break;
        }
      }
      return localip;
    }
  }
}

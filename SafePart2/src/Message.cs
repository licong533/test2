using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Mime;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Collections.Specialized;
using System.Diagnostics;

namespace SafePart.src {
  public class Message
  {
    private string message;
    private string number;
    private string address;
    private string level;
    private string email;

    public Message()
    {
      Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
      message = config.AppSettings.Settings["message"].Value;
      number = config.AppSettings.Settings["number"].Value;
      address = config.AppSettings.Settings["address"].Value;
      level = config.AppSettings.Settings["level"].Value;
      email = config.AppSettings.Settings["email"].Value;
    }

    public string Messagevalue
    {
      get { return message; }
      set
      {
        message = value;
        savemessage();
      }
    }

    public string Number
    {
      get { return number; }
      set
      {
        number = value;
        savemessage();
      }
    }

    public string Address
    {
      get { return address; }
      set
      {
        address = value;
        savemessage();
      }
    }

    public string Level
    {
      get { return level; }
      set
      {
        level = value;
        savemessage();
      }
    }

    public string Email
    {
      get { return email; }
      set
      {
        email = value;
        savemessage();
      }
    }

    private void savemessage()
    {
      Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
      config.AppSettings.Settings["message"].Value = message;
      config.AppSettings.Settings["number"].Value = number;
      config.AppSettings.Settings["address"].Value = address;
      config.AppSettings.Settings["level"].Value = level;
      config.AppSettings.Settings["email"].Value = email;
      config.Save(ConfigurationSaveMode.Modified, true);
     
    }

    public string getmessage()
    {
      string str = message + '\n';
      str += number + '\n';
      str += address + '\n';
      str += level + '\n';
      str += email + '\n';
      return str;
    }

    public void setnumber(string num)
    {
      ConfigurationSettings.AppSettings["number"] = num;
    }
  }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SafePart.src {
  //read a rsa file or write into rsa file
  public class ReadWriteRSA {
    public static string readrsa(string filename)
    {
      string str = "";
      try
      {
        str = File.ReadAllText(filename);
      }
      catch (Exception ex)
      {
        return null;
      }
      return str;
    }

    public static bool writerrsa(string filename, string message)
    {
      try
      {
        File.WriteAllText(filename, message);
      }
      catch (Exception ex)
      {
        return false;
      }
      return true;
    }
  }
}

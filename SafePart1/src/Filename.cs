using System;
using System.Collections.Generic;
using System.Text;

namespace SafePart.src {
  public static class Filename
  {
    private static string masterPrivateKey = "MasterPrivateKey.pem";
    private static string masterPublicKey = "MasterPublicKey.pem";
    private static string serverPublicKey = "ServerPublicKey.pem";

    public static string MasterPrivateKey
    {
      get { return masterPrivateKey; }
    }

    public static string MasterPublicKey
    {
      get { return masterPublicKey; }
    }

    public static string ServerPublicKey
    {
      get { return serverPublicKey; }
    }
  }
}

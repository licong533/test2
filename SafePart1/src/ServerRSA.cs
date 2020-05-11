using System;
using System.Collections.Generic;
using System.Text;

namespace SafePart.src {
  public class ServerRSA
  {
    private string publickey;

    public ServerRSA()
    {
      publickey = ReadWriteRSA.readrsa(Filename.ServerPublicKey);
    }

    public string Publickey
    {
      get { return publickey; }
      set { publickey = value; }
    }
  }
}

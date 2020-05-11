using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenSSL.Core;
using OpenSSL.Crypto;
using SafePart.src;

namespace SafePart.src {
  public class ClientRSA
  {
    private string publickey;
    private string privatekey;

    public ClientRSA()
    {
      RSA rsa = new RSA();
      string privarename = "MasterPrivateKey.pem";
      string publicname = "MasterPublicKey.pem";
      if (File.Exists(privarename) && File.Exists(publicname))
      {
        publickey = ReadWriteRSA.readrsa(publicname);
        privatekey = ReadWriteRSA.readrsa(privarename);
      }
      else
      {
        generatekeys(rsa);
        publickey = rsa.PublicKeyAsPEM;
        privatekey = rsa.PrivateKeyAsPEM;
      }
    }

//Get and set keys
    public string Publickey {
      get { return publickey; }
      set { publickey = value; }
    }

    public string Privatekey {
      get { return privatekey; }
      set { privatekey = value; }
    }

    private void generatekeys(RSA rsa)
    {
      rsa.GenerateKeys(1024, 65537, null, null);
      File.WriteAllText("MasterPrivateKey.pem", rsa.PrivateKeyAsPEM);
      File.WriteAllText("MasterPublicKey.pem", rsa.PublicKeyAsPEM);
    }
  }
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters;
using System.Text;
using OpenSSL.Core;
using OpenSSL.Crypto;

namespace SafePart.src {
  public class EnDeRSA {
    public static byte[] Enwithpublickey(byte[] data, string key)
    {
      byte[] result;
      try
      {
        BIO bio = new BIO(key);
        RSA rsa = RSA.FromPublicKey(bio, null, null);
        result = rsa.PublicEncrypt(data, RSA.Padding.None);
     //   rsa.
      }
      catch (Exception ex)
      {
        throw new Exception("Enwithpublickey Error.");
      }
       return result;
    }

    public static byte[] Enwithprivatekey(byte[] data, string key)
    {
      byte[] result;
      try
      {
        BIO bio = new BIO(key);
        RSA rsa = RSA.FromPrivateKey(bio);
        result = rsa.PrivateEncrypt(data, RSA.Padding.None);
      }
      catch (Exception ex)
      {
        throw new Exception("Enwithprivatekey Error.");
      }
      return result;
    }

    public static byte[] Dewithpublickey(byte[] data, string key)
    {
      byte[] result;
      try {
        BIO bio = new BIO(key);
        RSA rsa = RSA.FromPublicKey(bio);
        result = rsa.PublicDecrypt(data, RSA.Padding.None);
      } catch (Exception ex) {
        throw new Exception("Dewithpublickey Error.");
      }
      return result;
    }

    public static byte[] Dewithprivatekey(byte[] data, string key) {
      byte[] result = new byte[2048];
      try {
        BIO bio = new BIO(key);
        RSA rsa = RSA.FromPrivateKey(bio);
        for (int i = 0; i < 2048/128; i++)
        {
          byte[] en = new byte[128];
          byte[] de = new byte[128];
          Array.Copy(data, i * 128, en, 0, 128);
          de = rsa.PrivateDecrypt(en, RSA.Padding.None);
          Array.Copy(de, 0, result, i * 128, 128);
          string mes = System.Text.Encoding.ASCII.GetString(de);
        }
      } catch (Exception ex) {
        throw new Exception("Dewithprivatekey Error.");
      }
      return result;
    }

  }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenSSL.Crypto;
using OpenSSL.Core;

namespace SafePart.src {
  public class ClientAES
  {
    private byte[] level1;
    private byte[] level2;
    private string level1filename = "aeslevel1.aes";
    private string level2filename = "aeslevel2.aes";

    public ClientAES()
    {
      if (File.Exists(level1filename))
      {
        level1 = bytefromfile(level1filename, 128);
      }
      else
      {
        generateaes128();
      }
      if (File.Exists(level2filename))
      {
        level2 = bytefromfile(level2filename, 256);
      }
      else
      {
        generateaes256();
      }
    }

    public byte[] Level1
    {
      get { return level1; }
      set
      {
        level1 = value;
        bytestofile(level1, level1filename);
      }
    }

    public byte[] Level2
    {
      get { return level2; }
      set
      {
        level2 = value;
        bytestofile(level2, level2filename);
      }
    }

    private void generateaes128()
    {
      
     // Cipher cipher = Cipher.AES_128_CBC;
     // CipherContext ciphercontext  = new CipherContext(cipher);
      level1 = new byte[]
      {
        0x65, 0x66, 0x65, 0x66,
        0x65, 0x66, 0x65, 0x66,
        0x69, 0x65, 0x65, 0x66,
        0x66, 0x66, 0x65, 0x67
      };
      string filename = "aeslevel1.aes";
      bytestofile(level1, filename);
    }

    private void generateaes256()
    {
      level2 = new byte[]
      {
        0x65, 0x66, 0x65, 0x66,
        0x65, 0x66, 0x65, 0x66,
        0x69, 0x65, 0x65, 0x66,
        0x66, 0x66, 0x65, 0x66,
        0x65, 0x66, 0x65, 0x66,
        0x65, 0x66, 0x65, 0x66,
        0x69, 0x65, 0x65, 0x66,
        0x66, 0x66, 0x65, 0x67
      };
      string filename = "aeslevel2.aes";
      bytestofile(level2, filename);
    }

    private void bytestofile(byte[] data, string filename)
    {
      Stream stream = new FileStream(filename, FileMode.CreateNew);
      BinaryWriter write = new BinaryWriter(stream);
      write.Write(data);
      write.Flush();
      stream.Close();
    }

    private byte[] bytefromfile(string filename, int size)
    {
      Stream stream = new FileStream(filename, FileMode.Open);
      BinaryReader read = new BinaryReader(stream);
      byte[] buffer = read.ReadBytes(size);
      stream.Close();
      return buffer;
    }
  }
}

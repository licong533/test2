using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using SafePart.src;

namespace SafePart {
  public partial class main : Form {
    private delegate void SetTextCallBack(string txt);
    public main() 
    {
      try
      {
        domonitor();
        dealmonitor();
        dolisten();
        asback();
        getresult();
        InitializeComponent();
        AddThread();
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    ~main()
    {
      this.Dispose();
    }


    private void dealmonitor()
    {
      Network network = new Network();
      ThreadStart threadstart = delegate { monitor(); };
      Thread thread = new Thread(threadstart);
      thread.Start();
    }

    private void domonitor()
    {
      Network network = new Network();
      ThreadStart threadstart = delegate { network.listenmonitor(); };
      Thread thread = new Thread(threadstart);
      thread.Start();
    }

    private void dolisten()
    {
      Network network = new Network();
      ThreadStart threadstart = delegate { network.listenserver(); };
      Thread thread = new Thread(threadstart);
      thread.Start();

    }

    private void asback()
    {
      Network network = new Network();
      ThreadStart threadstart = delegate { network.ListenFromServer(); };
      Thread thread = new Thread(threadstart);
      thread.Start();
    }

    private void getresult()
    {
      Network network = new Network();
      ThreadStart threadstart = delegate { network.ListenDeal(); };
      Thread thread = new Thread(threadstart);
      thread.Start();
    }

    private void AddThread()
    {
      Thread ForNum = new Thread(new ThreadStart(this.wait));
      ForNum.Start();
    }

    private void monitor()
    {
      while (true)
      {
        XmlDocument doc =Data.DeMonitor();
        if (doc == null)
        {
          
        }
        else
        {
          MessageBox.Show("We should deal message here.");
        }
      }
    }

    private void wait()
    {
      while (true)
      {
        String value = Data.GetNum().ToString();
        setrcvback(value);
        Thread.Sleep(1000);
      }
    }

    private void setrcvback(String txt)
    {
      if (this.btn_num.InvokeRequired)
      {
        SetTextCallBack d = new SetTextCallBack(setrcvback);
        this.Invoke(d, new object[] {txt});
      }
      else
      {
        btn_num.Text = txt;
      }
    }

    private void clienttab_Selected(object sender, TabControlEventArgs e) 
    {
      if (this.clienttab.SelectedTab == this.clienttab.TabPages["regtab"])
      {
        initregtab();
      } 
      else if (this.clienttab.SelectedTab == this.clienttab.TabPages["safetab"])
      {
        initsafetab();
      } 
      else if (this.clienttab.SelectedTab == this.clienttab.TabPages["messagetab"])
      {
        initmessagetab();
      } 
      else if (this.clienttab.SelectedTab == this.clienttab.TabPages["dealtab"])
      {
        initdealtab();
      }

    }

    private void regbtgenerrsa_Click(object sender, EventArgs e) 
    {
      ClientRSA clientrsa = new ClientRSA();
      regtbpublic.Text = clientrsa.Publickey;
      regtbprivate.Text = clientrsa.Privatekey;
    }

    private void regbtreg_Click(object sender, EventArgs e) {
      ClientRSA clientrsa = new ClientRSA();
      SafePart.src.Message message = new SafePart.src.Message();
      string filename = Filename.MasterPublicKey;
      string temp = "1";
      temp += '\n';
      temp += message.Messagevalue;
      temp += '\n';
      try
      {
        if (Common.sendfileandstring(filename, temp))
        {
          MessageBox.Show("注册已发送， 等待审核.");
        }
        else
        {
          MessageBox.Show("注册已发送， 等待审核.");
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void initregtab()
    {
      SafePart.src.Message message = new SafePart.src.Message();
      if (string.IsNullOrEmpty(message.Number)) {
        regstatusvalue.Text = "没有注册的";
      } else {
        regstatusvalue.Text = "已注册";
        ClientRSA clientrsa = new ClientRSA();
        regtbpublic.Text = clientrsa.Publickey;
        regtbprivate.Text = clientrsa.Privatekey;
      }
    }

    private void initsafetab()
    {
      SafePart.src.Message message = new SafePart.src.Message();
      string currentlevel = message.Level;
      ClientAES clientaes = new ClientAES();
      byte[] level1 = clientaes.Level1;
      byte[] level2 = clientaes.Level2;
      string strlevel1 = Encoding.ASCII.GetString(level1);
      string strlevel2 = Encoding.ASCII.GetString(level2);
      levelbtcurrent.Text = currentlevel;
      levelcbask.Items.Clear();
      levelcbask.Items.Add("1");
      levelcbask.Items.Add("2");
      leveltbone.Text = strlevel1;
      leveltbtwo.Text = strlevel2;
    }

    private void initmessagetab()
    {
      SafePart.src.Message message = new SafePart.src.Message();
      messagetbcheck.Text = message.Messagevalue;
      messagetbnumber.Text = message.Number;
      messagetblevel.Text = message.Level;
      messagetbemail.Text = message.Email;
      messagetbaddress.Text = message.Address;
    }

    private void initdealtab()
    {
      Network network = new Network();
      Hashtable table = network.GetClientList();
      IDictionaryEnumerator enumerator = table.GetEnumerator();
      DataSet ds = new DataSet();
      DataTable dt = ds.Tables.Add("clients");
      DataRow row = null;
      dt.Columns.Add("Number", typeof(string));
      dt.Columns.Add("name", typeof(string));
      while (enumerator.MoveNext())
      {
        row = dt.NewRow();
        dt.NewRow();
        row["number"] = enumerator.Key;
        row["name"] = enumerator.Value;
        dt.Rows.Add(row);
      }
      clientview.DataSource = ds.Tables[0];
    }

    private void levelbtask_Click(object sender, EventArgs e) {
      SafePart.src.Message message = new SafePart.src.Message();
      string type = "3\n";
      string id = message.Number + '\n';
      type += id;
      ClientAES aes = new ClientAES();
      string level = levelcbask.Text;
      int length = type.Length;
      byte[] buffer = new byte[2048];
      byte[] en = new byte[2048];
      Array.Copy(Encoding.ASCII.GetBytes(type), 0, buffer, 0, length);
      byte[] bufferlevel = Encoding.ASCII.GetBytes(level + '\n');
      byte[] bufferkey;
      if (level.Equals("1"))
      {
        bufferkey = aes.Level1;
      }
      else
      {
        bufferkey = aes.Level2;
      }
      int pos = length;
      Array.Copy(bufferlevel, 0, buffer, pos, bufferlevel.Length);
      pos += bufferlevel.Length;
      Array.Copy(bufferkey, 0, buffer, pos, bufferkey.Length);
      pos += bufferkey.Length;
      buffer[pos] = (byte)'\n';
      for (int i = pos + 1; i < 2048; i++)
      {
        buffer[i] = (byte)'*';
      }
      Array.Copy(buffer, en, 2048);
      ServerRSA rsa = new ServerRSA();
      for (int i = 0; i < 2048/128 - 1; i++)
      {
        byte[] preen = new byte[128];
        byte[] prede = new byte[128];
        Array.Copy(buffer, i * 128 + type.Length, preen, 0, 128);
        prede = EnDeRSA.Enwithpublickey(preen, rsa.Publickey);
        Array.Copy(prede, 0, en, i * 128 + type.Length, 128);
      }
      if (Common.sendbytes(en, ConfigurationSettings.AppSettings["serverport"]))
      {
        MessageBox.Show("修改成功");
      }
      else
      {
        MessageBox.Show("修改失败");
      }
      
    }

    private void messagebtmodify_Click(object sender, EventArgs e)
    {
      SafePart.src.Message mes = new SafePart.src.Message();
      mes.Messagevalue = messagetbcheck.Text;
      mes.Level = messagetblevel.Text;
      mes.Address = messagetbaddress.Text;
      mes.Email = messagetbemail.Text;
      mes.Number = messagetbnumber.Text;
      string title = "2\n";
      string idnum = mes.Number + "\n";
      title += idnum;
      int tiltelen = title.Length;
      string sendto = mes.getmessage();
      byte[] buffer = Encoding.ASCII.GetBytes(sendto);
      ServerRSA rsa = new ServerRSA();
   //   buffer = EnDeRSA.Enwithpublickey(buffer, rsa.Publickey);
      byte[] sign = new byte[2048];
    //  sign = Encoding.ASCII.GetBytes(title);
      Array.Copy(Encoding.ASCII.GetBytes(title), sign, title.Length);
      int i = 0;
      for (i = 0; i < buffer.Length; i++)
      {
        sign[tiltelen + i] = buffer[i];
      }
      i += title.Length;
      for (; i < 2048; i++) 
      {
        sign[i] = (byte)'*';
      }
      byte[] en = new byte[2048];
      en = sign;
      for (i = 0; i < 2048/128 - 1; i++)
      {
        byte [] preen = new byte[128];
        byte [] prede = new byte[128];
        Array.Copy(sign, i * 128 + title.Length, preen, 0, 128);
        prede = EnDeRSA.Enwithpublickey(preen, rsa.Publickey);
        Array.Copy(prede, 0, en, i*128 + title.Length, 128);
      }
      if (Common.sendbytes(en, ConfigurationSettings.AppSettings["serverport"]))
      {
        MessageBox.Show("修改成功");
      }
      else
      {
        MessageBox.Show("修改失败");
      }
    }

    private void btn_list_Click(object sender, EventArgs e) 
    {
      
    }

    private void btn_send_Click(object sender, EventArgs e)
    {
      DesXML desxml = new DesXML();
      string sysid = txt_dealid.Text;
      string number = txt_dealnumber.Text;
      string message = txt_dealmessage.Text;
      string font = txt_dealfont.Text;
      IDictionary<string, string> dir = new Dictionary<string, string>();
      dir.Add("sysid", sysid);
      dir.Add("number", number);
      dir.Add("message", message);
      dir.Add("font", font);
      try
      {
        string xml = desxml.MapToXMLStr(dir);
        Network network = new Network();
        network.Deal(xml);
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }

    private void btn_num_Click(object sender, EventArgs e)
    {
      String num = this.btn_num.Text;
      if (String.IsNullOrEmpty(num) || num == "0")
      {
        MessageBox.Show("There is no message.");
      }
      Core core = new Core();
      core.start();
    }
  }
}

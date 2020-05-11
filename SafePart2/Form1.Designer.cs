using System.Drawing;

namespace SafePart {
  partial class main {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
      this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.clienttab = new System.Windows.Forms.TabControl();
      this.welcometab = new System.Windows.Forms.TabPage();
      this.btn_num = new System.Windows.Forms.Button();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.regtab = new System.Windows.Forms.TabPage();
      this.regtbprivate = new System.Windows.Forms.TextBox();
      this.regtbpublic = new System.Windows.Forms.TextBox();
      this.reglblprivate = new System.Windows.Forms.Label();
      this.reglblpublic = new System.Windows.Forms.Label();
      this.regbtreg = new System.Windows.Forms.Button();
      this.regbtgenerrsa = new System.Windows.Forms.Button();
      this.regstatusvalue = new System.Windows.Forms.Label();
      this.regstatus = new System.Windows.Forms.Label();
      this.safetab = new System.Windows.Forms.TabPage();
      this.levellabelask = new System.Windows.Forms.Label();
      this.levelbtask = new System.Windows.Forms.Button();
      this.levelcbask = new System.Windows.Forms.ComboBox();
      this.leveltbtwo = new System.Windows.Forms.TextBox();
      this.label12 = new System.Windows.Forms.Label();
      this.leveltbone = new System.Windows.Forms.TextBox();
      this.levellabelone = new System.Windows.Forms.Label();
      this.levellabelkey = new System.Windows.Forms.Label();
      this.levellabellevel = new System.Windows.Forms.Label();
      this.levelbtcurrent = new System.Windows.Forms.TextBox();
      this.levelbtlcurrent = new System.Windows.Forms.Label();
      this.messagetab = new System.Windows.Forms.TabPage();
      this.messagebtmodify = new System.Windows.Forms.Button();
      this.messagetbcheck = new System.Windows.Forms.TextBox();
      this.messagelabelcheck = new System.Windows.Forms.Label();
      this.messagetbemail = new System.Windows.Forms.TextBox();
      this.messagetblevel = new System.Windows.Forms.TextBox();
      this.messagetbaddress = new System.Windows.Forms.TextBox();
      this.messagetbnumber = new System.Windows.Forms.TextBox();
      this.messagelabelemail = new System.Windows.Forms.Label();
      this.messagelabellevel = new System.Windows.Forms.Label();
      this.messagelabeladdress = new System.Windows.Forms.Label();
      this.messagelabelnumber = new System.Windows.Forms.Label();
      this.dealtab = new System.Windows.Forms.TabPage();
      this.txt_dealid = new System.Windows.Forms.TextBox();
      this.lbl_dealid = new System.Windows.Forms.Label();
      this.btn_send = new System.Windows.Forms.Button();
      this.txt_dealfont = new System.Windows.Forms.TextBox();
      this.lbl_dealfont = new System.Windows.Forms.Label();
      this.txt_dealmessage = new System.Windows.Forms.TextBox();
      this.lbl_dealmessage = new System.Windows.Forms.Label();
      this.txt_dealnumber = new System.Windows.Forms.TextBox();
      this.lbl_dealnumber = new System.Windows.Forms.Label();
      this.clientview = new System.Windows.Forms.DataGridView();
      this.btn_list = new System.Windows.Forms.Button();
      this.clienttab.SuspendLayout();
      this.welcometab.SuspendLayout();
      this.regtab.SuspendLayout();
      this.safetab.SuspendLayout();
      this.messagetab.SuspendLayout();
      this.dealtab.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.clientview)).BeginInit();
      this.SuspendLayout();
      // 
      // contextMenuStrip1
      // 
      this.contextMenuStrip1.Name = "contextMenuStrip1";
      this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
      // 
      // clienttab
      // 
      this.clienttab.Controls.Add(this.welcometab);
      this.clienttab.Controls.Add(this.regtab);
      this.clienttab.Controls.Add(this.safetab);
      this.clienttab.Controls.Add(this.messagetab);
      this.clienttab.Controls.Add(this.dealtab);
      this.clienttab.Location = new System.Drawing.Point(-4, 0);
      this.clienttab.Name = "clienttab";
      this.clienttab.SelectedIndex = 0;
      this.clienttab.Size = new System.Drawing.Size(537, 301);
      this.clienttab.TabIndex = 2;
      this.clienttab.Selected += new System.Windows.Forms.TabControlEventHandler(this.clienttab_Selected);
      // 
      // welcometab
      // 
      this.welcometab.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.welcometab.Controls.Add(this.btn_num);
      this.welcometab.Controls.Add(this.label2);
      this.welcometab.Controls.Add(this.label1);
      this.welcometab.Location = new System.Drawing.Point(4, 22);
      this.welcometab.Name = "welcometab";
      this.welcometab.Padding = new System.Windows.Forms.Padding(3);
      this.welcometab.Size = new System.Drawing.Size(529, 275);
      this.welcometab.TabIndex = 0;
      this.welcometab.Text = "欢迎";
      this.welcometab.UseVisualStyleBackColor = true;
      // 
      // btn_num
      // 
      this.btn_num.ForeColor = System.Drawing.Color.Red;
      this.btn_num.Location = new System.Drawing.Point(83, 6);
      this.btn_num.Name = "btn_num";
      this.btn_num.Size = new System.Drawing.Size(75, 23);
      this.btn_num.TabIndex = 4;
      this.btn_num.Text = "0";
      this.btn_num.UseVisualStyleBackColor = true;
      this.btn_num.Click += new System.EventHandler(this.btn_num_Click);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(4, 8);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(67, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "当前任务：";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label1.Location = new System.Drawing.Point(101, 92);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(325, 35);
      this.label1.TabIndex = 1;
      this.label1.Text = "欢迎使用联机交易网关";
      // 
      // regtab
      // 
      this.regtab.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.regtab.Controls.Add(this.regtbprivate);
      this.regtab.Controls.Add(this.regtbpublic);
      this.regtab.Controls.Add(this.reglblprivate);
      this.regtab.Controls.Add(this.reglblpublic);
      this.regtab.Controls.Add(this.regbtreg);
      this.regtab.Controls.Add(this.regbtgenerrsa);
      this.regtab.Controls.Add(this.regstatusvalue);
      this.regtab.Controls.Add(this.regstatus);
      this.regtab.Location = new System.Drawing.Point(4, 22);
      this.regtab.Name = "regtab";
      this.regtab.Padding = new System.Windows.Forms.Padding(3);
      this.regtab.Size = new System.Drawing.Size(529, 275);
      this.regtab.TabIndex = 1;
      this.regtab.Text = "注册管理";
      this.regtab.UseVisualStyleBackColor = true;
      // 
      // regtbprivate
      // 
      this.regtbprivate.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.regtbprivate.Location = new System.Drawing.Point(122, 138);
      this.regtbprivate.Multiline = true;
      this.regtbprivate.Name = "regtbprivate";
      this.regtbprivate.Size = new System.Drawing.Size(367, 54);
      this.regtbprivate.TabIndex = 7;
      // 
      // regtbpublic
      // 
      this.regtbpublic.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.regtbpublic.Location = new System.Drawing.Point(122, 65);
      this.regtbpublic.Multiline = true;
      this.regtbpublic.Name = "regtbpublic";
      this.regtbpublic.Size = new System.Drawing.Size(367, 54);
      this.regtbpublic.TabIndex = 6;
      // 
      // reglblprivate
      // 
      this.reglblprivate.AutoSize = true;
      this.reglblprivate.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.reglblprivate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.reglblprivate.Location = new System.Drawing.Point(30, 138);
      this.reglblprivate.Name = "reglblprivate";
      this.reglblprivate.Size = new System.Drawing.Size(58, 21);
      this.reglblprivate.TabIndex = 5;
      this.reglblprivate.Text = "私钥：";
      // 
      // reglblpublic
      // 
      this.reglblpublic.AutoSize = true;
      this.reglblpublic.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.reglblpublic.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.reglblpublic.Location = new System.Drawing.Point(30, 65);
      this.reglblpublic.Name = "reglblpublic";
      this.reglblpublic.Size = new System.Drawing.Size(58, 21);
      this.reglblpublic.TabIndex = 4;
      this.reglblpublic.Text = "公钥：";
      // 
      // regbtreg
      // 
      this.regbtreg.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.regbtreg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.regbtreg.Location = new System.Drawing.Point(330, 224);
      this.regbtreg.Name = "regbtreg";
      this.regbtreg.Size = new System.Drawing.Size(94, 29);
      this.regbtreg.TabIndex = 3;
      this.regbtreg.Text = "注册";
      this.regbtreg.UseVisualStyleBackColor = true;
      this.regbtreg.Click += new System.EventHandler(this.regbtreg_Click);
      // 
      // regbtgenerrsa
      // 
      this.regbtgenerrsa.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.regbtgenerrsa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.regbtgenerrsa.Location = new System.Drawing.Point(188, 224);
      this.regbtgenerrsa.Name = "regbtgenerrsa";
      this.regbtgenerrsa.Size = new System.Drawing.Size(94, 29);
      this.regbtgenerrsa.TabIndex = 2;
      this.regbtgenerrsa.Text = "生成RSA密钥对";
      this.regbtgenerrsa.UseVisualStyleBackColor = true;
      this.regbtgenerrsa.Click += new System.EventHandler(this.regbtgenerrsa_Click);
      // 
      // regstatusvalue
      // 
      this.regstatusvalue.AutoSize = true;
      this.regstatusvalue.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.regstatusvalue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.regstatusvalue.Location = new System.Drawing.Point(119, 27);
      this.regstatusvalue.Name = "regstatusvalue";
      this.regstatusvalue.Size = new System.Drawing.Size(58, 21);
      this.regstatusvalue.TabIndex = 1;
      this.regstatusvalue.Text = "未注册";
      // 
      // regstatus
      // 
      this.regstatus.AutoSize = true;
      this.regstatus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.regstatus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.regstatus.Location = new System.Drawing.Point(30, 27);
      this.regstatus.Name = "regstatus";
      this.regstatus.Size = new System.Drawing.Size(90, 21);
      this.regstatus.TabIndex = 0;
      this.regstatus.Text = "注册状态：";
      // 
      // safetab
      // 
      this.safetab.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.safetab.Controls.Add(this.levellabelask);
      this.safetab.Controls.Add(this.levelbtask);
      this.safetab.Controls.Add(this.levelcbask);
      this.safetab.Controls.Add(this.leveltbtwo);
      this.safetab.Controls.Add(this.label12);
      this.safetab.Controls.Add(this.leveltbone);
      this.safetab.Controls.Add(this.levellabelone);
      this.safetab.Controls.Add(this.levellabelkey);
      this.safetab.Controls.Add(this.levellabellevel);
      this.safetab.Controls.Add(this.levelbtcurrent);
      this.safetab.Controls.Add(this.levelbtlcurrent);
      this.safetab.Location = new System.Drawing.Point(4, 22);
      this.safetab.Name = "safetab";
      this.safetab.Padding = new System.Windows.Forms.Padding(3);
      this.safetab.Size = new System.Drawing.Size(529, 275);
      this.safetab.TabIndex = 2;
      this.safetab.Text = "安全级别";
      this.safetab.UseVisualStyleBackColor = true;
      // 
      // levellabelask
      // 
      this.levellabelask.AutoSize = true;
      this.levellabelask.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levellabelask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levellabelask.Location = new System.Drawing.Point(105, 211);
      this.levellabelask.Name = "levellabelask";
      this.levellabelask.Size = new System.Drawing.Size(90, 21);
      this.levellabelask.TabIndex = 10;
      this.levellabelask.Text = "请求等级：";
      // 
      // levelbtask
      // 
      this.levelbtask.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levelbtask.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levelbtask.Location = new System.Drawing.Point(234, 239);
      this.levelbtask.Name = "levelbtask";
      this.levelbtask.Size = new System.Drawing.Size(86, 30);
      this.levelbtask.TabIndex = 9;
      this.levelbtask.Text = "请求";
      this.levelbtask.UseVisualStyleBackColor = true;
      this.levelbtask.Click += new System.EventHandler(this.levelbtask_Click);
      // 
      // levelcbask
      // 
      this.levelcbask.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levelcbask.FormattingEnabled = true;
      this.levelcbask.Location = new System.Drawing.Point(231, 204);
      this.levelcbask.Name = "levelcbask";
      this.levelcbask.Size = new System.Drawing.Size(140, 29);
      this.levelcbask.TabIndex = 8;
      // 
      // leveltbtwo
      // 
      this.leveltbtwo.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.leveltbtwo.Location = new System.Drawing.Point(231, 153);
      this.leveltbtwo.Name = "leveltbtwo";
      this.leveltbtwo.Size = new System.Drawing.Size(140, 29);
      this.leveltbtwo.TabIndex = 7;
      // 
      // label12
      // 
      this.label12.AutoSize = true;
      this.label12.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.label12.Location = new System.Drawing.Point(102, 144);
      this.label12.Name = "label12";
      this.label12.Size = new System.Drawing.Size(22, 21);
      this.label12.TabIndex = 6;
      this.label12.Text = "2:";
      // 
      // leveltbone
      // 
      this.leveltbone.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.leveltbone.Location = new System.Drawing.Point(231, 110);
      this.leveltbone.Name = "leveltbone";
      this.leveltbone.Size = new System.Drawing.Size(140, 29);
      this.leveltbone.TabIndex = 5;
      // 
      // levellabelone
      // 
      this.levellabelone.AutoSize = true;
      this.levellabelone.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levellabelone.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levellabelone.Location = new System.Drawing.Point(102, 110);
      this.levellabelone.Name = "levellabelone";
      this.levellabelone.Size = new System.Drawing.Size(22, 21);
      this.levellabelone.TabIndex = 4;
      this.levellabelone.Text = "1:";
      // 
      // levellabelkey
      // 
      this.levellabelkey.AutoSize = true;
      this.levellabelkey.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levellabelkey.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levellabelkey.Location = new System.Drawing.Point(231, 75);
      this.levellabelkey.Name = "levellabelkey";
      this.levellabelkey.Size = new System.Drawing.Size(42, 21);
      this.levellabelkey.TabIndex = 3;
      this.levellabelkey.Text = "密钥";
      // 
      // levellabellevel
      // 
      this.levellabellevel.AutoSize = true;
      this.levellabellevel.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levellabellevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levellabellevel.Location = new System.Drawing.Point(99, 75);
      this.levellabellevel.Name = "levellabellevel";
      this.levellabellevel.Size = new System.Drawing.Size(42, 21);
      this.levellabellevel.TabIndex = 2;
      this.levellabellevel.Text = "等级";
      // 
      // levelbtcurrent
      // 
      this.levelbtcurrent.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levelbtcurrent.Location = new System.Drawing.Point(231, 29);
      this.levelbtcurrent.Name = "levelbtcurrent";
      this.levelbtcurrent.Size = new System.Drawing.Size(140, 29);
      this.levelbtcurrent.TabIndex = 1;
      // 
      // levelbtlcurrent
      // 
      this.levelbtlcurrent.AutoSize = true;
      this.levelbtlcurrent.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.levelbtlcurrent.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.levelbtlcurrent.Location = new System.Drawing.Point(99, 29);
      this.levelbtlcurrent.Name = "levelbtlcurrent";
      this.levelbtlcurrent.Size = new System.Drawing.Size(122, 21);
      this.levelbtlcurrent.TabIndex = 0;
      this.levelbtlcurrent.Text = "当前加密等级：";
      // 
      // messagetab
      // 
      this.messagetab.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.messagetab.Controls.Add(this.messagebtmodify);
      this.messagetab.Controls.Add(this.messagetbcheck);
      this.messagetab.Controls.Add(this.messagelabelcheck);
      this.messagetab.Controls.Add(this.messagetbemail);
      this.messagetab.Controls.Add(this.messagetblevel);
      this.messagetab.Controls.Add(this.messagetbaddress);
      this.messagetab.Controls.Add(this.messagetbnumber);
      this.messagetab.Controls.Add(this.messagelabelemail);
      this.messagetab.Controls.Add(this.messagelabellevel);
      this.messagetab.Controls.Add(this.messagelabeladdress);
      this.messagetab.Controls.Add(this.messagelabelnumber);
      this.messagetab.Location = new System.Drawing.Point(4, 22);
      this.messagetab.Name = "messagetab";
      this.messagetab.Padding = new System.Windows.Forms.Padding(3);
      this.messagetab.Size = new System.Drawing.Size(529, 275);
      this.messagetab.TabIndex = 3;
      this.messagetab.Text = "基本信息管理";
      this.messagetab.UseVisualStyleBackColor = true;
      // 
      // messagebtmodify
      // 
      this.messagebtmodify.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagebtmodify.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagebtmodify.Location = new System.Drawing.Point(229, 215);
      this.messagebtmodify.Name = "messagebtmodify";
      this.messagebtmodify.Size = new System.Drawing.Size(75, 33);
      this.messagebtmodify.TabIndex = 10;
      this.messagebtmodify.Text = "修改";
      this.messagebtmodify.UseVisualStyleBackColor = true;
      this.messagebtmodify.Click += new System.EventHandler(this.messagebtmodify_Click);
      // 
      // messagetbcheck
      // 
      this.messagetbcheck.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagetbcheck.Location = new System.Drawing.Point(194, 24);
      this.messagetbcheck.Name = "messagetbcheck";
      this.messagetbcheck.Size = new System.Drawing.Size(158, 29);
      this.messagetbcheck.TabIndex = 9;
      // 
      // messagelabelcheck
      // 
      this.messagelabelcheck.AutoSize = true;
      this.messagelabelcheck.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagelabelcheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagelabelcheck.Location = new System.Drawing.Point(101, 31);
      this.messagelabelcheck.Name = "messagelabelcheck";
      this.messagelabelcheck.Size = new System.Drawing.Size(90, 21);
      this.messagelabelcheck.TabIndex = 8;
      this.messagelabelcheck.Text = "验证信息：";
      // 
      // messagetbemail
      // 
      this.messagetbemail.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagetbemail.Location = new System.Drawing.Point(194, 177);
      this.messagetbemail.Name = "messagetbemail";
      this.messagetbemail.Size = new System.Drawing.Size(158, 29);
      this.messagetbemail.TabIndex = 7;
      // 
      // messagetblevel
      // 
      this.messagetblevel.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagetblevel.Location = new System.Drawing.Point(194, 141);
      this.messagetblevel.Name = "messagetblevel";
      this.messagetblevel.Size = new System.Drawing.Size(158, 29);
      this.messagetblevel.TabIndex = 6;
      // 
      // messagetbaddress
      // 
      this.messagetbaddress.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagetbaddress.Location = new System.Drawing.Point(194, 103);
      this.messagetbaddress.Name = "messagetbaddress";
      this.messagetbaddress.Size = new System.Drawing.Size(158, 29);
      this.messagetbaddress.TabIndex = 5;
      // 
      // messagetbnumber
      // 
      this.messagetbnumber.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagetbnumber.Location = new System.Drawing.Point(194, 65);
      this.messagetbnumber.Name = "messagetbnumber";
      this.messagetbnumber.Size = new System.Drawing.Size(158, 29);
      this.messagetbnumber.TabIndex = 4;
      // 
      // messagelabelemail
      // 
      this.messagelabelemail.AutoSize = true;
      this.messagelabelemail.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagelabelemail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagelabelemail.Location = new System.Drawing.Point(104, 177);
      this.messagelabelemail.Name = "messagelabelemail";
      this.messagelabelemail.Size = new System.Drawing.Size(51, 21);
      this.messagelabelemail.TabIndex = 3;
      this.messagelabelemail.Text = "Email:";
      // 
      // messagelabellevel
      // 
      this.messagelabellevel.AutoSize = true;
      this.messagelabellevel.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagelabellevel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagelabellevel.Location = new System.Drawing.Point(101, 141);
      this.messagelabellevel.Name = "messagelabellevel";
      this.messagelabellevel.Size = new System.Drawing.Size(58, 21);
      this.messagelabellevel.TabIndex = 2;
      this.messagelabellevel.Text = "级别：";
      // 
      // messagelabeladdress
      // 
      this.messagelabeladdress.AutoSize = true;
      this.messagelabeladdress.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagelabeladdress.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagelabeladdress.Location = new System.Drawing.Point(101, 103);
      this.messagelabeladdress.Name = "messagelabeladdress";
      this.messagelabeladdress.Size = new System.Drawing.Size(58, 21);
      this.messagelabeladdress.TabIndex = 1;
      this.messagelabeladdress.Text = "地址：";
      // 
      // messagelabelnumber
      // 
      this.messagelabelnumber.AutoSize = true;
      this.messagelabelnumber.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.messagelabelnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.messagelabelnumber.Location = new System.Drawing.Point(101, 65);
      this.messagelabelnumber.Name = "messagelabelnumber";
      this.messagelabelnumber.Size = new System.Drawing.Size(58, 21);
      this.messagelabelnumber.TabIndex = 0;
      this.messagelabelnumber.Text = "编号：";
      // 
      // dealtab
      // 
      this.dealtab.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.dealtab.Controls.Add(this.txt_dealid);
      this.dealtab.Controls.Add(this.lbl_dealid);
      this.dealtab.Controls.Add(this.btn_send);
      this.dealtab.Controls.Add(this.txt_dealfont);
      this.dealtab.Controls.Add(this.lbl_dealfont);
      this.dealtab.Controls.Add(this.txt_dealmessage);
      this.dealtab.Controls.Add(this.lbl_dealmessage);
      this.dealtab.Controls.Add(this.txt_dealnumber);
      this.dealtab.Controls.Add(this.lbl_dealnumber);
      this.dealtab.Controls.Add(this.clientview);
      this.dealtab.Controls.Add(this.btn_list);
      this.dealtab.Location = new System.Drawing.Point(4, 22);
      this.dealtab.Name = "dealtab";
      this.dealtab.Padding = new System.Windows.Forms.Padding(3);
      this.dealtab.Size = new System.Drawing.Size(529, 275);
      this.dealtab.TabIndex = 4;
      this.dealtab.Text = "交易";
      this.dealtab.UseVisualStyleBackColor = true;
      // 
      // txt_dealid
      // 
      this.txt_dealid.Location = new System.Drawing.Point(334, 45);
      this.txt_dealid.Name = "txt_dealid";
      this.txt_dealid.Size = new System.Drawing.Size(100, 20);
      this.txt_dealid.TabIndex = 21;
      // 
      // lbl_dealid
      // 
      this.lbl_dealid.AutoSize = true;
      this.lbl_dealid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lbl_dealid.Location = new System.Drawing.Point(253, 45);
      this.lbl_dealid.Name = "lbl_dealid";
      this.lbl_dealid.Size = new System.Drawing.Size(54, 13);
      this.lbl_dealid.TabIndex = 20;
      this.lbl_dealid.Text = "交易ID：";
      // 
      // btn_send
      // 
      this.btn_send.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.btn_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btn_send.Location = new System.Drawing.Point(256, 218);
      this.btn_send.Name = "btn_send";
      this.btn_send.Size = new System.Drawing.Size(105, 33);
      this.btn_send.TabIndex = 19;
      this.btn_send.Text = "发送";
      this.btn_send.UseVisualStyleBackColor = true;
      this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
      // 
      // txt_dealfont
      // 
      this.txt_dealfont.Location = new System.Drawing.Point(334, 171);
      this.txt_dealfont.Name = "txt_dealfont";
      this.txt_dealfont.Size = new System.Drawing.Size(100, 20);
      this.txt_dealfont.TabIndex = 18;
      // 
      // lbl_dealfont
      // 
      this.lbl_dealfont.AutoSize = true;
      this.lbl_dealfont.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lbl_dealfont.Location = new System.Drawing.Point(253, 171);
      this.lbl_dealfont.Name = "lbl_dealfont";
      this.lbl_dealfont.Size = new System.Drawing.Size(67, 13);
      this.lbl_dealfont.TabIndex = 17;
      this.lbl_dealfont.Text = "发送信息：";
      // 
      // txt_dealmessage
      // 
      this.txt_dealmessage.Location = new System.Drawing.Point(334, 130);
      this.txt_dealmessage.Name = "txt_dealmessage";
      this.txt_dealmessage.Size = new System.Drawing.Size(100, 20);
      this.txt_dealmessage.TabIndex = 16;
      // 
      // lbl_dealmessage
      // 
      this.lbl_dealmessage.AutoSize = true;
      this.lbl_dealmessage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lbl_dealmessage.Location = new System.Drawing.Point(253, 130);
      this.lbl_dealmessage.Name = "lbl_dealmessage";
      this.lbl_dealmessage.Size = new System.Drawing.Size(67, 13);
      this.lbl_dealmessage.TabIndex = 15;
      this.lbl_dealmessage.Text = "后台名称：";
      // 
      // txt_dealnumber
      // 
      this.txt_dealnumber.Location = new System.Drawing.Point(334, 80);
      this.txt_dealnumber.Name = "txt_dealnumber";
      this.txt_dealnumber.Size = new System.Drawing.Size(100, 20);
      this.txt_dealnumber.TabIndex = 14;
      // 
      // lbl_dealnumber
      // 
      this.lbl_dealnumber.AutoSize = true;
      this.lbl_dealnumber.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.lbl_dealnumber.Location = new System.Drawing.Point(253, 80);
      this.lbl_dealnumber.Name = "lbl_dealnumber";
      this.lbl_dealnumber.Size = new System.Drawing.Size(67, 13);
      this.lbl_dealnumber.TabIndex = 13;
      this.lbl_dealnumber.Text = "后台编号：";
      // 
      // clientview
      // 
      this.clientview.BorderStyle = System.Windows.Forms.BorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.clientview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.clientview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.clientview.GridColor = System.Drawing.SystemColors.ControlDarkDark;
      this.clientview.Location = new System.Drawing.Point(0, 6);
      this.clientview.Name = "clientview";
      this.clientview.Size = new System.Drawing.Size(240, 269);
      this.clientview.TabIndex = 12;
      this.clientview.ForeColor = Color.Black;
      // 
      // btn_list
      // 
      this.btn_list.Font = new System.Drawing.Font("Segoe UI", 12F);
      this.btn_list.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
      this.btn_list.Location = new System.Drawing.Point(256, 6);
      this.btn_list.Name = "btn_list";
      this.btn_list.Size = new System.Drawing.Size(105, 33);
      this.btn_list.TabIndex = 11;
      this.btn_list.Text = "选择后台";
      this.btn_list.UseVisualStyleBackColor = true;
      this.btn_list.Click += new System.EventHandler(this.btn_list_Click);
      // 
      // main
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.LightGray;
      this.BackgroundImage = global::SafePart.Properties.Resources.Capture;
      this.ClientSize = new System.Drawing.Size(529, 296);
      this.Controls.Add(this.clienttab);
      this.ForeColor = System.Drawing.SystemColors.Control;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.ImeMode = System.Windows.Forms.ImeMode.On;
      this.Name = "main";
      this.Text = "SafePart";
      this.clienttab.ResumeLayout(false);
      this.welcometab.ResumeLayout(false);
      this.welcometab.PerformLayout();
      this.regtab.ResumeLayout(false);
      this.regtab.PerformLayout();
      this.safetab.ResumeLayout(false);
      this.safetab.PerformLayout();
      this.messagetab.ResumeLayout(false);
      this.messagetab.PerformLayout();
      this.dealtab.ResumeLayout(false);
      this.dealtab.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.clientview)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    private System.Windows.Forms.TabControl clienttab;
    private System.Windows.Forms.TabPage welcometab;
    private System.Windows.Forms.TabPage regtab;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label regstatusvalue;
    private System.Windows.Forms.Label regstatus;
    private System.Windows.Forms.TabPage safetab;
    private System.Windows.Forms.TabPage messagetab;
    private System.Windows.Forms.Button regbtgenerrsa;
    private System.Windows.Forms.Label levellabelask;
    private System.Windows.Forms.Button levelbtask;
    private System.Windows.Forms.ComboBox levelcbask;
    private System.Windows.Forms.TextBox leveltbtwo;
    private System.Windows.Forms.Label label12;
    private System.Windows.Forms.TextBox leveltbone;
    private System.Windows.Forms.Label levellabelone;
    private System.Windows.Forms.Label levellabelkey;
    private System.Windows.Forms.Label levellabellevel;
    private System.Windows.Forms.TextBox levelbtcurrent;
    private System.Windows.Forms.Label levelbtlcurrent;
    private System.Windows.Forms.TextBox messagetbemail;
    private System.Windows.Forms.TextBox messagetblevel;
    private System.Windows.Forms.TextBox messagetbaddress;
    private System.Windows.Forms.TextBox messagetbnumber;
    private System.Windows.Forms.Label messagelabelemail;
    private System.Windows.Forms.Label messagelabellevel;
    private System.Windows.Forms.Label messagelabeladdress;
    private System.Windows.Forms.Label messagelabelnumber;
    private System.Windows.Forms.TextBox regtbprivate;
    private System.Windows.Forms.TextBox regtbpublic;
    private System.Windows.Forms.Label reglblprivate;
    private System.Windows.Forms.Label reglblpublic;
    private System.Windows.Forms.Button regbtreg;
    private System.Windows.Forms.TextBox messagetbcheck;
    private System.Windows.Forms.Label messagelabelcheck;
    private System.Windows.Forms.Button messagebtmodify;
    private System.Windows.Forms.TabPage dealtab;
    private System.Windows.Forms.Button btn_list;
    private System.Windows.Forms.DataGridView clientview;
    private System.Windows.Forms.TextBox txt_dealmessage;
    private System.Windows.Forms.Label lbl_dealmessage;
    private System.Windows.Forms.TextBox txt_dealnumber;
    private System.Windows.Forms.Label lbl_dealnumber;
    private System.Windows.Forms.TextBox txt_dealid;
    private System.Windows.Forms.Label lbl_dealid;
    private System.Windows.Forms.Button btn_send;
    private System.Windows.Forms.TextBox txt_dealfont;
    private System.Windows.Forms.Label lbl_dealfont;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Button btn_num;
  }
}


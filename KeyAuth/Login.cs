using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;

namespace KeyAuth;

public class Login : Form
{
	public static api KeyAuthApp = new api("Eternal Woofer", "oVgAULGd6v", "620b587d26b87c566fc84ee722c010e7f5d24dc2102aafc838fd90fba1dd6435", "1.0");

	private IContainer components = null;

	private SiticoneControlBox siticoneControlBox1;

	private SiticoneControlBox siticoneControlBox2;

	private Label label1;

	private Label label2;

	private Guna2BorderlessForm guna2BorderlessForm1;

	private TextBox username;

	private TextBox textBox1;

	private Guna2Button guna2Button2;

	private Guna2Button guna2Button1;

	private System.Windows.Forms.Timer timer1;

	private TextBox textBox4;

	public Login()
	{
		InitializeComponent();
	}

	private void siticoneControlBox1_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void timer1_Tick(object sender, EventArgs e)
	{
		Process[] processesByName = Process.GetProcessesByName("ida64");
		Process[] processesByName2 = Process.GetProcessesByName("ida32");
		Process[] processesByName3 = Process.GetProcessesByName("ollydbg");
		Process[] processesByName4 = Process.GetProcessesByName("ollydbg64");
		Process[] processesByName5 = Process.GetProcessesByName("loaddll");
		Process[] processesByName6 = Process.GetProcessesByName("httpdebugger");
		Process[] processesByName7 = Process.GetProcessesByName("windowrenamer");
		Process[] processesByName8 = Process.GetProcessesByName("processhacker");
		Process[] processesByName9 = Process.GetProcessesByName("Process Hacker");
		Process[] processesByName10 = Process.GetProcessesByName("ProcessHacker");
		Process[] processesByName11 = Process.GetProcessesByName("HxD");
		Process[] processesByName12 = Process.GetProcessesByName("parsecd");
		Process[] processesByName13 = Process.GetProcessesByName("ida");
		Process[] processesByName14 = Process.GetProcessesByName("dnSpy");
		Process[] processesByName15 = Process.GetProcessesByName("MegaDumper");
		if (processesByName.Length != 0 || processesByName2.Length != 0 || processesByName3.Length != 0 || processesByName4.Length != 0 || processesByName5.Length != 0 || processesByName6.Length != 0 || processesByName7.Length != 0 || processesByName8.Length != 0 || processesByName9.Length != 0 || processesByName10.Length != 0 || processesByName11.Length != 0 || processesByName13.Length != 0 || processesByName12.Length != 0 || processesByName14.Length != 0 || processesByName15.Length != 0)
		{
			SendKeys.Send("{PRTSC}");
			Image image = Clipboard.GetImage();
		}
	}

	private void Login_Load(object sender, EventArgs e)
	{
		KeyAuthApp.init();
		if (KeyAuthApp.response.message == "invalidver")
		{
			if (!string.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink))
			{
				switch (MessageBox.Show("Yes to open file in browser\nNo to download file automatically", "Auto update", MessageBoxButtons.YesNo))
				{
				case DialogResult.Yes:
					Process.Start(KeyAuthApp.app_data.downloadLink);
					Environment.Exit(0);
					break;
				case DialogResult.No:
				{
					WebClient webClient = new WebClient();
					string executablePath = Application.ExecutablePath;
					string text = random_string();
					executablePath = executablePath.Replace(".exe", "-" + text + ".exe");
					webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, executablePath);
					Process.Start(executablePath);
					Process.Start(new ProcessStartInfo
					{
						Arguments = "/C choice /C Y /N /D Y /T 3 & Del \"" + Application.ExecutablePath + "\"",
						WindowStyle = ProcessWindowStyle.Hidden,
						CreateNoWindow = true,
						FileName = "cmd.exe"
					});
					Environment.Exit(0);
					break;
				}
				default:
					MessageBox.Show("Invalid option");
					Environment.Exit(0);
					break;
				}
			}
			MessageBox.Show("Posiadasz star¹ wersjê programu, pobierz now¹ za pomoc¹ komendy !download z kana³u #cmds na discordzie discord.gg/uran");
			Thread.Sleep(2500);
			Environment.Exit(0);
		}
		if (!KeyAuthApp.response.success)
		{
			MessageBox.Show(KeyAuthApp.response.message);
			Environment.Exit(0);
		}
		KeyAuthApp.check();
	}

	private static string random_string()
	{
		string text = null;
		Random random = new Random();
		for (int i = 0; i < 5; i++)
		{
			text += Convert.ToChar(Convert.ToInt32(Math.Floor(26.0 * random.NextDouble() + 65.0)));
		}
		return text;
	}

	private void UpgradeBtn_Click(object sender, EventArgs e)
	{
	}

	private void LoginBtn_Click(object sender, EventArgs e)
	{
		KeyAuthApp.login(username.Text, textBox1.Text);
		if (KeyAuthApp.response.success)
		{
			Main main = new Main();
			main.Show();
			Hide();
		}
		else
		{
			MessageBox.Show("Username or password is invalid!");
		}
	}

	private void RgstrBtn_Click(object sender, EventArgs e)
	{
	}

	private void LicBtn_Click(object sender, EventArgs e)
	{
	}

	private void username_TextChanged(object sender, EventArgs e)
	{
	}

	private void textBox1_TextChanged(object sender, EventArgs e)
	{
	}

	private void siticoneRoundedButton1_Click(object sender, EventArgs e)
	{
		KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
		if (KeyAuthApp.response.success)
		{
			Main main = new Main();
			main.Show();
			Hide();
		}
		else
		{
			MessageBox.Show("License is invalid!");
		}
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
	}

	private void siticoneRoundedButton2_Click(object sender, EventArgs e)
	{
	}

	private void siticoneRoundedButton3_Click(object sender, EventArgs e)
	{
		KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
		if (KeyAuthApp.response.success)
		{
			Main main = new Main();
			main.Show();
			Hide();
		}
		else
		{
			MessageBox.Show("License is invalid!");
		}
	}

	private void guna2Panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		KeyAuthApp.login(username.Text, textBox1.Text);
		if (KeyAuthApp.response.success)
		{
			Main main = new Main();
			main.Show();
			Hide();
		}
		else
		{
			MessageBox.Show("Username or password is invalid!");
		}
	}

	private void guna2Button1_Click_1(object sender, EventArgs e)
	{
		if (guna2Button1.get_BorderThickness() == 0)
		{
			MessageBox.Show("To register please fill in username, password and license (Click the button again)");
			guna2Button1.set_BorderThickness(1);
			return;
		}
		KeyAuthApp.register(username.Text, textBox1.Text, textBox4.Text);
		if (KeyAuthApp.response.success)
		{
			Main main = new Main();
			main.Show();
			Hide();
		}
		else
		{
			MessageBox.Show("License is invalid!");
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0027: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyAuth.Login));
		this.siticoneControlBox1 = new SiticoneControlBox();
		this.siticoneControlBox2 = new SiticoneControlBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
		this.username = new System.Windows.Forms.TextBox();
		this.textBox1 = new System.Windows.Forms.TextBox();
		this.guna2Button1 = new Guna2Button();
		this.guna2Button2 = new Guna2Button();
		this.timer1 = new System.Windows.Forms.Timer(this.components);
		this.textBox4 = new System.Windows.Forms.TextBox();
		base.SuspendLayout();
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox1.set_BorderRadius(5);
		this.siticoneControlBox1.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox1.get_HoveredState().set_FillColor(System.Drawing.Color.FromArgb(232, 17, 35));
		this.siticoneControlBox1.get_HoveredState().set_IconColor(System.Drawing.Color.White);
		this.siticoneControlBox1.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox1);
		this.siticoneControlBox1.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Location = new System.Drawing.Point(717, 5);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Name = "siticoneControlBox1";
		this.siticoneControlBox1.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox1);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Size = new System.Drawing.Size(45, 29);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).TabIndex = 1;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Click += new System.EventHandler(siticoneControlBox1_Click);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox2.set_BorderColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox2.set_BorderRadius(10);
		this.siticoneControlBox2.set_ControlBoxType((ControlBoxType)0);
		this.siticoneControlBox2.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox2.get_HoveredState().set_FillColor(System.Drawing.Color.FromArgb(255, 255, 255));
		this.siticoneControlBox2.get_HoveredState().set_IconColor(System.Drawing.Color.FromArgb(0, 0, 0));
		this.siticoneControlBox2.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox2);
		this.siticoneControlBox2.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Location = new System.Drawing.Point(666, 5);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Name = "siticoneControlBox2";
		this.siticoneControlBox2.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox2);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Size = new System.Drawing.Size(45, 29);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).TabIndex = 2;
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10f);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(-5, 136);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(0, 19);
		this.label1.TabIndex = 22;
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.Color.FromArgb(9, 9, 9);
		this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
		this.label2.Location = new System.Drawing.Point(8, 11);
		this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(103, 19);
		this.label2.TabIndex = 27;
		this.label2.Text = "Eternal Woofer";
		this.guna2BorderlessForm1.set_BorderRadius(30);
		this.guna2BorderlessForm1.set_ContainerControl((System.Windows.Forms.ContainerControl)this);
		this.guna2BorderlessForm1.set_DockIndicatorTransparencyValue(0.6);
		this.guna2BorderlessForm1.set_DragStartTransparencyValue(0.3);
		this.guna2BorderlessForm1.set_ResizeForm(false);
		this.guna2BorderlessForm1.set_TransparentWhileDrag(true);
		this.username.BackColor = System.Drawing.Color.FromArgb(9, 9, 9);
		this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.username.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.username.ForeColor = System.Drawing.Color.Firebrick;
		this.username.Location = new System.Drawing.Point(312, 193);
		this.username.Multiline = true;
		this.username.Name = "username";
		this.username.Size = new System.Drawing.Size(181, 20);
		this.username.TabIndex = 35;
		this.username.TextChanged += new System.EventHandler(textBox1_TextChanged);
		this.textBox1.BackColor = System.Drawing.Color.FromArgb(9, 9, 9);
		this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox1.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.textBox1.ForeColor = System.Drawing.Color.Firebrick;
		this.textBox1.Location = new System.Drawing.Point(312, 248);
		this.textBox1.Name = "textBox1";
		this.textBox1.PasswordChar = '*';
		this.textBox1.Size = new System.Drawing.Size(181, 18);
		this.textBox1.TabIndex = 36;
		this.textBox1.UseSystemPasswordChar = true;
		this.guna2Button1.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button1).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button1.set_BorderColor(System.Drawing.Color.SandyBrown);
		this.guna2Button1.set_BorderRadius(9);
		this.guna2Button1.get_DisabledState()
                   .set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button1.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button1.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button1.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button1.set_FillColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button1).Font = new System.Drawing.Font("Arial Black", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
		((System.Windows.Forms.Control)(object)this.guna2Button1).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button1).Location = new System.Drawing.Point(270, 417);
		((System.Windows.Forms.Control)(object)this.guna2Button1).Name = "guna2Button1";
		this.guna2Button1.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button1).Size = new System.Drawing.Size(245, 36);
		((System.Windows.Forms.Control)(object)this.guna2Button1).TabIndex = 43;
		((System.Windows.Forms.Control)(object)this.guna2Button1).Text = "Register";
		((System.Windows.Forms.Control)(object)this.guna2Button1).Click += new System.EventHandler(guna2Button1_Click_1);
		this.guna2Button2.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button2).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button2.set_BorderColor(System.Drawing.Color.Transparent);
		this.guna2Button2.set_BorderRadius(9);
		this.guna2Button2.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button2.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button2.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button2.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button2.set_FillColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button2).Font = new System.Drawing.Font("Arial Black", 9.75f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		((System.Windows.Forms.Control)(object)this.guna2Button2).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button2).Location = new System.Drawing.Point(270, 375);
		((System.Windows.Forms.Control)(object)this.guna2Button2).Name = "guna2Button2";
		this.guna2Button2.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button2).Size = new System.Drawing.Size(245, 36);
		((System.Windows.Forms.Control)(object)this.guna2Button2).TabIndex = 44;
		((System.Windows.Forms.Control)(object)this.guna2Button2).Text = "Login";
		((System.Windows.Forms.Control)(object)this.guna2Button2).Click += new System.EventHandler(guna2Button2_Click);
		this.timer1.Enabled = true;
		this.timer1.Interval = 1000;
		this.timer1.Tick += new System.EventHandler(timer1_Tick);
		this.textBox4.BackColor = System.Drawing.Color.FromArgb(9, 9, 9);
		this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
		this.textBox4.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.textBox4.ForeColor = System.Drawing.Color.Firebrick;
		this.textBox4.Location = new System.Drawing.Point(312, 302);
		this.textBox4.Name = "textBox4";
		this.textBox4.PasswordChar = '*';
		this.textBox4.Size = new System.Drawing.Size(181, 18);
		this.textBox4.TabIndex = 42;
		this.textBox4.UseSystemPasswordChar = true;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
		this.BackColor = System.Drawing.Color.FromArgb(35, 39, 42);
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
		base.ClientSize = new System.Drawing.Size(769, 480);
		base.Controls.Add(this.textBox4);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button2);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button1);
		base.Controls.Add(this.textBox1);
		base.Controls.Add(this.username);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox2);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox1);
		this.DoubleBuffered = true;
		this.ForeColor = System.Drawing.Color.Transparent;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Login";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Loader";
		base.TransparencyKey = System.Drawing.Color.Maroon;
		base.Load += new System.EventHandler(Login_Load);
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}

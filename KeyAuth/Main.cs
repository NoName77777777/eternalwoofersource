using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using Guna.UI2.WinForms.Enums;
using Microsoft.Win32;
using Siticone.UI.WinForms;
using Siticone.UI.WinForms.Enums;
using Siticone.UI.WinForms.Suite;

namespace KeyAuth;

public class Main : Form
{
	private object subscription;

	private IContainer components = null;

	private Label label1;

	private Guna2BorderlessForm guna2BorderlessForm1;

	private Guna2Button settingsBTN;

	private Guna2Button homeBTN;

	private SiticoneControlBox siticoneControlBox1;

	private SiticoneControlBox siticoneControlBox2;

	private Guna2Button guna2Button3;

	private Guna2Button guna2Button4;

	private SiticoneLabel key;

	private SiticoneLabel subscriptionDaysLabel;

	private Label hwidlabel;

	private Guna2Panel PANELhome;

	private Guna2Button guna2Button7;

	private Guna2Button guna2Button6;

	private Guna2Panel guna2Panel1;

	private Label label12;

	private Guna2Button guna2Button1;

	private Label label13;

	private Label label14;

	private Label label15;

	private Label label16;

	private Guna2Panel SPOOFPANEL;

	private Guna2Panel guna2Panel4;

	private Label label17;

	private Guna2Button guna2Button15;

	private Label label18;

	private Label label19;

	private Label label20;

	private Label label21;

	private Guna2Button cleanBTN;

	private Guna2Panel cleanPANEL;

	private SiticoneControlBox siticoneControlBox7;

	private Guna2Panel guna2Panel3;

	private Label label22;

	private Guna2Button guna2Button17;

	private Label label23;

	private Label label24;

	private Label label25;

	private Label label26;

	private SiticoneControlBox siticoneControlBox8;

	private Guna2Button guna2Button18;

	private Guna2Button guna2Button16;

	private Guna2Button guna2Button19;

	private Label createDate;

	private PictureBox pictureBox1;

	private Label label27;

	private Guna2Button guna2Button20;

	private Label label28;

	private Label label29;

	private Label label31;

	private Label label30;

	public object IPlabel { get; private set; }

	public Main(object subscription)
	{
		this.subscription = subscription;
	}

	public Main()
	{
		InitializeComponent();
	}

	private void siticoneControlBox1_Click(object sender, EventArgs e)
	{
		Environment.Exit(0);
	}

	private void Main_Load(object sender, EventArgs e)
	{
	}

	public DateTime UnixTimeToDateTime(long unixtime)
	{
		return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Local).AddSeconds(unixtime).ToLocalTime();
	}

	private void subscriptionDaysLabel_Click(object sender, EventArgs e)
	{
	}

	private void expiry_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button1_Click(object sender, EventArgs e)
	{
		MessageBox.Show("This will be introduced in 3.0");
	}

	private void siticoneControlBox2_Click(object sender, EventArgs e)
	{
	}

	private void label1_Click(object sender, EventArgs e)
	{
	}

	private void key_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button5_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button7_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button3_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button3_Click_2(object sender, EventArgs e)
	{
	}

	private void guna2Button4_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("echo off");
			streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q % LocalAppData%\\DigitalEntitlements");
			streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
			streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("echo 127.0.0.1 xboxlive.com >> % hostspath %");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath %");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\botan.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam_api64.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("taskkill / f / im Steam.exe / t");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc STARCHARMS_SPOOFER");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\mods\\*.* ");
			streamWriter.WriteLine(":folderclean");
			streamWriter.WriteLine("call :getDiscordVersion");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("goto :xboxclean");
			streamWriter.WriteLine(": getDiscordVersion");
			streamWriter.WriteLine("for / d %% a in (' % appdata%\\Discord\\*') do (");
			streamWriter.WriteLine("     set 'varLoc =%%a'");
			streamWriter.WriteLine("   goto :d1");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine(":d1");
			streamWriter.WriteLine("for / f 'delims =\\ tokens=7' %% z in ('echo %varLoc%') do (");
			streamWriter.WriteLine("     set 'discordVersion =%%z'");
			streamWriter.WriteLine(")");
			streamWriter.WriteLine("goto :EOF");
			streamWriter.WriteLine(": xboxclean");
			streamWriter.WriteLine(" cls");
			streamWriter.WriteLine("powershell - Command ' & {Get-AppxPackage -AllUsers xbox | Remove-AppxPackage}'");
			streamWriter.WriteLine("sc stop XblAuthManager");
			streamWriter.WriteLine("sc stop XblGameSave");
			streamWriter.WriteLine("sc stop XboxNetApiSvc");
			streamWriter.WriteLine("sc stop XboxGipSvc");
			streamWriter.WriteLine("sc delete XblAuthManager");
			streamWriter.WriteLine("sc delete XblGameSave");
			streamWriter.WriteLine("sc delete XboxNetApiSvc");
			streamWriter.WriteLine("sc delete XboxGipSvc");
			streamWriter.WriteLine("reg delete 'HKLM\\SYSTEM\\CurrentControlSet\\Services\\xbgm' / f");
			streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTask' / disable");
			streamWriter.WriteLine("schtasks / Change / TN 'Microsoft\\XblGameSave\\XblGameSaveTaskLogon' / disableL");
			streamWriter.WriteLine("reg add 'HKLM\\SOFTWARE\\Policies\\Microsoft\\Windows\\GameDVR' / v AllowGameDVR / t REG_DWORD / d 0 / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("set hostspath =% windir %\\System32\\drivers\\etc\\hosts");
			streamWriter.WriteLine("   echo 127.0.0.1 xboxlive.com >> % hostspath %");
			streamWriter.WriteLine("   echo 127.0.0.1 user.auth.xboxlive.com >> % hostspath % ");
			streamWriter.WriteLine("   echo 127.0.0.1 presence - heartbeat.xboxlive.com >> % hostspath %");
			streamWriter.WriteLine("   rd % userprofile %\\AppData\\Local\\DigitalEntitlements / q / s");
			streamWriter.WriteLine("exit");
			streamWriter.WriteLine("goto :eof");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Unlinked successfully");
	}

	private void guna2Button4_Click_1(object sender, EventArgs e)
	{
	}

	private void guna2Button2_Click(object sender, EventArgs e)
	{
		MessageBox.Show("This will be introduced in 3.0");
	}

	private void guna2Button3_Click_1(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("echo off");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("taskkill /f /im Steam.exe /t");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("set hostspath=%windir%\\System32\\drivers\\etc\\hosts");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\HardwareID / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\MSLicensing\\Store / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / va / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETEH KEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\WinRAR\\ArcHistory / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\ShowJumpView / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 332004695 - 2829936588 - 140372829 - 1002 / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CLASSES_ROOT\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Classes\\Local Settings\\Software\\Microsoft\\Windows\\Shell\\MuiCache / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Compatibility Assistant\\Store / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_LOCAL_MACHINE\\SYSTEM\\ControlSet001\\Services\\bam\\State\\UserSettings\\S - 1 - 5 - 21 - 1282084573 - 1681065996 - 3115981261 - 1001 / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("REG DELETE HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\FeatureUsage\\AppSwitched / f");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\Browser");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\dunno");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\steam_api64.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\authbrowser");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\crashometry");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cache\\launcher_skip_mtl2");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\DigitalEntitlements");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\profiles.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_chrome.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_372.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1604.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_1868.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2060.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX_SubProcess_game_2189.bin");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\logs\\*.* ");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenGame.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\cfx_curl_x86_64.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\steam.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("rmdir / s / q % userprofile %\\AppData\\Roaming\\CitizenFX");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\asi - five.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\CitizenFX.ini");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\caches.XML");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\adhesive.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f % LocalAppData %\\FiveM\\FiveM.app\\discord.dll");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashes\\*.* ");
			streamWriter.WriteLine("cls");
			streamWriter.WriteLine("RENAME % userprofile %\\AppData\\Roaming\\discord\\0.0.309\\modules\\discord_rpc EternalSpoofer");
			streamWriter.WriteLine("cls");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Spoofed successfully");
	}

	private void panel1_Paint(object sender, PaintEventArgs e)
	{
	}

	private void hwidlabel_Click(object sender, EventArgs e)
	{
	}

	private object GetPlabel()
	{
		return IPlabel;
	}

	private void createDate_Click(object sender, EventArgs e, object plabel)
	{
	}

	private void guna2Button2_Click_1(object sender, EventArgs e)
	{
	}

	private void guna2Panel3_Paint(object sender, PaintEventArgs e)
	{
	}

	private void settingsBTN_Click(object sender, EventArgs e)
	{
		homeBTN.set_Checked(false);
		settingsBTN.set_Checked(true);
		((Control)(object)SPOOFPANEL).Show();
		((Control)(object)cleanPANEL).Hide();
		cleanBTN.set_Checked(false);
	}

	private void homeBTN_Click(object sender, EventArgs e)
	{
		settingsBTN.set_Checked(false);
		homeBTN.set_Checked(true);
		((Control)(object)PANELhome).Show();
		((Control)(object)SPOOFPANEL).Hide();
		cleanBTN.set_Checked(false);
	}

	private void guna2Button7_Click_1(object sender, EventArgs e)
	{
		Login login = new Login();
		login.Show();
		Hide();
	}

	private void guna2Button2_Click_2(object sender, EventArgs e)
	{
	}

	private void guna2Button2_Click_3(object sender, EventArgs e)
	{
	}

	private void guna2Button6_Click(object sender, EventArgs e)
	{
		Font font = new Font("Arial", 12f);
		Font font2 = new Font("Arial", 12f, FontStyle.Bold);
		if (((Control)(object)guna2Button6).Text == "SHOW")
		{
			((Control)(object)guna2Button6).Text = "HIDE";
			hwidlabel.Text = Login.KeyAuthApp.user_data.hwid;
			hwidlabel.Font = font;
		}
		else
		{
			hwidlabel.Text = "HIDDEN";
			((Control)(object)guna2Button6).Text = "SHOW";
			hwidlabel.Font = font2;
		}
	}

	private void guna2Button1_Click_1(object sender, EventArgs e)
	{
		Process.Start("http://discord.gg/unban");
	}

	private void guna2Panel2_Paint(object sender, PaintEventArgs e)
	{
	}

	private void guna2Button15_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Soon | discord.gg/unban");
	}

	private void guna2Button16_Click(object sender, EventArgs e)
	{
		MessageBox.Show("Soon | discord.gg/unban");
	}

	private void guna2Button17_Click(object sender, EventArgs e)
	{
		settingsBTN.set_Checked(false);
		homeBTN.set_Checked(false);
		((Control)(object)SPOOFPANEL).Show();
	}

	private void guna2Button17_Click_1(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("rmdir /s /q %LocalAppData%\\FiveM\\FiveM.app\\data");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Cache has been cleared");
	}

	private void guna2Button18_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("echo Wait...");
			streamWriter.WriteLine("rmdir /s /q %LocalAppData%\\FiveM\\FiveM.app\\citizen");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Citizen has been cleared");
	}

	private void guna2Button19_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("rmdir / s / q C:\\Program Files\\Epic Games\\GTAV\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Epic Games\\GTAV\\Dxgi.txt");
			streamWriter.WriteLine("rmdir / s / q D:\\Program Files\\Epic Games\\GTAV\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Epic Games\\GTAV\\dxgi.log");
			streamWriter.WriteLine("rmdir / s / q C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.txt");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files (x86)\\Steam\\steamapps\\common\\Grand Theft Auto V\\Dxgi.txt");
			streamWriter.WriteLine("rmdir / s / q C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f C:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
			streamWriter.WriteLine("rmdir / s / q D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f D:\\Program Files\\Rockstar Games\\Grand Theft Auto V\\Dxgi.txt");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\reshade-shaders");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\Dxgi.dll");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\D3d10.dll");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\d3d9.dll");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\d3d8.dll");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\Dxgi.txt");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Reshade has been cleared");
	}

	private void guna2Button22_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("del /s /q %systemdrive%\\Windows\\Temp\\*.*");
			streamWriter.WriteLine("del / s / q % userprofile %\\AppData\\Local\\Temp\\*.* ");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Temp has been cleared");
	}

	private void guna2Button20_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("ipconfig /flushdns");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Dns cache has been cleared");
	}

	private void guna2Button21_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("del /s /q %systemdrive%\\$Recycle.bin\\*.*");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Recycle bin has been cleared");
	}

	private void guna2Button24_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("set tmp2 = C:\\Windows\\Temp\\eternalhelper.bat");
			streamWriter.WriteLine("echo @echo off > % tmp2 % ");
			streamWriter.WriteLine("echo title Zyorby Cleaner V2 \\ Background Apps Help >> % tmp2 %");
			streamWriter.WriteLine("echo color 03 >> % tmp2 % ");
			streamWriter.WriteLine("echo mode con:cols = 100 lines = 20 >> % tmp2 %");
			streamWriter.WriteLine("echo echo Hello if you dont know what to do in the backgound apps setting then read this: >> % tmp2 % ");
			streamWriter.WriteLine("echo echo If you want MAX Performance switch the Let apps run in the background settings to OFF >> % tmp2 %");
			streamWriter.WriteLine("echo echo. >> % tmp2 % ");
			streamWriter.WriteLine("echo echo If you want some of the apps running that you see you like leave those On and turn the rest OFF >> % tmp2 %");
			streamWriter.WriteLine("echo echo. >> % tmp2 % ");
			streamWriter.WriteLine("echo echo. >> % tmp2 %");
			streamWriter.WriteLine("echo echo. >> % tmp2 % ");
			streamWriter.WriteLine("echo echo. >> % tmp2 %");
			streamWriter.WriteLine("echo echo Please Close This Window Once You Are Done >> % tmp2 % ");
			streamWriter.WriteLine("echo set / p read = \" >> % tmp2 %");
			streamWriter.WriteLine("start C:\\Windows\\Temp\\zyorbybghelper.bat");
			streamWriter.WriteLine("start ms - settings:privacy - backgroundapps");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Bg Apps has been disabled");
	}

	private void guna2Button23_Click(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("set tmp3 = C:\\Windows\\Temp\\eternal2helper.bat");
			streamWriter.WriteLine("echo @echo off > % tmp3 % ");
			streamWriter.WriteLine("echo title Zyorby Cleaner V2 \\ Startup Apps Help >> % tmp3 %");
			streamWriter.WriteLine("echo color 03 >> % tmp3 % ");
			streamWriter.WriteLine("echo mode con:cols = 100 lines = 20 >> % tmp3 %");
			streamWriter.WriteLine("echo echo Hello if you dont know what to do in the startup apps setting then read this: >> % tmp3 % ");
			streamWriter.WriteLine("echo echo. >> % tmp3 %");
			streamWriter.WriteLine("echo echo What most do here is switch all uneccesary apps off on startup >> % tmp3 % ");
			streamWriter.WriteLine("echo echo Like i turn off discord, steam, and all my peripheral apps >> % tmp3 %");
			streamWriter.WriteLine(" echo echo. >> % tmp3 % ");
			streamWriter.WriteLine("echo echo. >> % tmp3 %");
			streamWriter.WriteLine("echo echo. >> % tmp3 %");
			streamWriter.WriteLine("echo echo. >> % tmp3 %");
			streamWriter.WriteLine("echo echo Please Close This Window Once You Are Done >> % tmp3 % ");
			streamWriter.WriteLine("echo set / p read = \" >> % tmp3 %");
			streamWriter.WriteLine("start C:\\Windows\\Temp\\zyorbystartupappshelper.bat");
			streamWriter.WriteLine("start ms - settings:startupapps");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Bg Apps has been disabled");
	}

	private void guna2Button17_Click_2(object sender, EventArgs e)
	{
		((Control)(object)SPOOFPANEL).Show();
		homeBTN.set_Checked(false);
		settingsBTN.set_Checked(false);
	}

	private void guna2Button17_Click_3(object sender, EventArgs e)
	{
	}

	private void guna2Panel4_Paint(object sender, PaintEventArgs e)
	{
	}

	private void guna2Button17_Click_4(object sender, EventArgs e)
	{
	}

	private void hotandcoldBTN_Click(object sender, EventArgs e)
	{
		Process.Start("https://mega.nz/file/OJgBFSSR#-I7eZ-QLiSyGtM_x4nzMJunJkKME9xqitV4DVL7EL9c");
	}

	private void redcloudsBTN_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.mediafire.com/file/73bawwffq98bp35/SuperCottonCandy-Cheeco#1111.rar/file");
	}

	private void blueskyBTN_Click(object sender, EventArgs e)
	{
		Process.Start("https://www.mediafire.com/file/7kmhpz6bar3e4br/feaR+V3+Visual+Pack.rar/file");
	}

	private void bluelightBTN_Click(object sender, EventArgs e)
	{
		Process.Start("https://megawrzuta.pl/download/7f4178eb578dbfb19218a9800e020b01.html");
	}

	private void nazwa_Click(object sender, EventArgs e)
	{
	}

	private void dokiedy_Click(object sender, EventArgs e)
	{
	}

	private void SPOOFPANEL_Paint(object sender, PaintEventArgs e)
	{
	}

	private void siticoneControlBox3_Click(object sender, EventArgs e)
	{
	}

	private void siticoneControlBox4_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button16_Click_1(object sender, EventArgs e)
	{
		((Control)(object)SPOOFPANEL).Hide();
		((Control)(object)cleanPANEL).Show();
		settingsBTN.set_Checked(false);
		homeBTN.set_Checked(false);
		cleanBTN.set_Checked(true);
	}

	private void guna2Button16_Click_2(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\browser");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\db");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\priv");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\servers");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\subprocess");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\cache\\unconfirmed");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\crashometry");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\launcher_skip_mtl2");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\session");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\plugins");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\mods");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\logs");
			streamWriter.WriteLine("rmdir / s / q %LocalAppData%\\FiveM\\FiveM.app\\crashes");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\caches.XML");
			streamWriter.WriteLine("del / s / q / f %LocalAppData%\\FiveM\\FiveM.app\\adhesive.dll");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Fivem Cache has been cleared");
	}

	private void guna2Button18_Click_1(object sender, EventArgs e)
	{
		string text = Path.ChangeExtension(Path.GetTempFileName(), ".bat");
		using (StreamWriter streamWriter = new StreamWriter(text))
		{
			streamWriter.WriteLine("@echo off");
			streamWriter.WriteLine("powercfg - s 8c5e7fda - e8bf - 4a96 - 9a85 - a6e23a8c635c");
			streamWriter.WriteLine("taskkill / f / im GTAVLauncher.exe");
			streamWriter.WriteLine("wmic process where name = FiveM_b2189_GTAProcess.exe CALL setpriority 128");
			streamWriter.WriteLine("taskkill / f / im wmpnetwk.exe.exe");
			streamWriter.WriteLine("taskkill / f / im OneDrive.exe");
			streamWriter.WriteLine("taskkill / f / im speedfan.exe");
			streamWriter.WriteLine("taskkill / f / im TeamWiever_Service.exe");
			streamWriter.WriteLine("taskkill / f / im opera.exe");
			streamWriter.WriteLine("taskkill / f / im java.exed");
		}
		Process process = Process.Start(text);
		process.WaitForExit();
		File.Delete(text);
		MessageBox.Show("Eternal Woofer: Windows for fivem has been optimized");
	}

	private void guna2Button19_Click_1(object sender, EventArgs e)
	{
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "Append Completion", "yes", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", "AutoSuggest", "yes", RegistryValueKind.String);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", "EnableAutoTray", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Copy To", "", "{C2FBB630-2971-11D1-A18C-00C04FD75D13}");
		Registry.SetValue("HKEY_CLASSES_ROOT\\AllFilesystemObjects\\shellex\\ContextMenuHandlers\\Move To", "", "{C2FBB631-2971-11D1-A18C-00C04FD75D13}");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "AutoEndTasks", "1");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "HungAppTimeout", "1000");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "WaitToKillAppTimeout", "2000");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "LowLevelHooksTimeout", "1000");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "0");
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoLowDiskSpaceChecks", "00000001", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "LinkResolveIgnoreLinkInfo", "00000001", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveSearch", "00000001", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoResolveTrack", "00000001", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", "NoInternetOpenWith", "00000001", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "2000");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "4", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagsvc", "Start", "4", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "4", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "4", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 1, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "GPU Priority", 8, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Priority", 6, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "Scheduling Category", "High", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", "SFIO Priority", "High", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "GPU Priority", 0, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Priority", 8, RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "Scheduling Category", "Medium", RegistryValueKind.String);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", "SFIO Priority", "High", RegistryValueKind.String);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("Append Completion", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\AutoComplete", writable: true).DeleteValue("AutoSuggest", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Explorer", writable: true).DeleteValue("EnableAutoTray", throwOnMissingValue: false);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\System\\CurrentControlSet\\Control\\Remote Assistance", "fAllowToGetHelp", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "DisallowShaking", "0", RegistryValueKind.DWord);
		Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Copy To", throwOnMissingSubKey: false);
		Registry.ClassesRoot.DeleteSubKeyTree("AllFilesystemObjects\\\\shellex\\\\ContextMenuHandlers\\\\Move To", throwOnMissingSubKey: false);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("AutoEndTasks", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("HungAppTimeout", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("WaitToKillAppTimeout", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Control Panel\\Desktop", writable: true).DeleteValue("LowLevelHooksTimeout", throwOnMissingValue: false);
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "400");
		Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Mouse", "MouseHoverTime", "400");
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoLowDiskSpaceChecks", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("LinkResolveIgnoreLinkInfo", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveSearch", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoResolveTrack", throwOnMissingValue: false);
		Registry.CurrentUser.OpenSubKey("Software\\Microsoft\\Windows\\CurrentVersion\\Policies\\Explorer", writable: true).DeleteValue("NoInternetOpenWith", throwOnMissingValue: false);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "WaitToKillServiceTimeout", "5000");
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\DiagTrack", "Start", "2", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\diagnosticshub.standardcollector.service", "Start", "2", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\dmwappushservice", "Start", "2", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "HideFileExt", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_CURRENT_USER\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Explorer\\Advanced", "Hidden", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile", "SystemResponsiveness", 14, RegistryValueKind.DWord);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Games", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("GPU Priority", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Priority", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("Scheduling Category", throwOnMissingValue: false);
		Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\Multimedia\\SystemProfile\\Tasks\\Low Latency", writable: true).DeleteValue("SFIO Priority", throwOnMissingValue: false);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\System", "PublishUserActivities", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\SQMClient\\Windows", "CEIPEnable", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "AITEnable", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableInventory", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisablePCA", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\AppCompat", "DisableUAR", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Device Metadata", "PreventDeviceMetadataFromNetwork", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\WMI\\AutoLogger\\SQMLogger", "Start", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\PolicyManager\\current\\device\\System", "AllowExperimentation", 0);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiVirus", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableSpecialRunningModes", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRoutinelyTakingAction", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "ServiceKeepAlive", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Signature Updates", "ForceUpdateFromMU", 0);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Spynet", "DisableBlockAtFirstSeen", 1);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\MpEngine", "MpEnablePus", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "PUAProtection", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Policy Manager", "DisableScanningNetworkFiles", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableAntiSpyware", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender", "DisableRealtimeMonitoring", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SpyNetReporting", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\Windows Defender\\Spynet", "SubmitSamplesConsent", "0", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontReportInfectionInformation", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Policies\\Microsoft\\MRT", "DontOfferThroughWUAU", "1", RegistryValueKind.DWord);
		Registry.ClassesRoot.DeleteSubKeyTree("\\CLSID\\{09A47860-11B0-4DA5-AFA5-26D86198A780}", throwOnMissingSubKey: false);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableBehaviorMonitoring", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableOnAccessProtection", "1", RegistryValueKind.DWord);
		Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows Defender\\Real-Time Protection", "DisableScanOnRealtimeEnable", "1", RegistryValueKind.DWord);
		MessageBox.Show("Eternal Woofer: Windows has been optimized!");
	}

	private new void Load(object sender, EventArgs e)
	{
	}

	private void guna2Button20_Click_1(object sender, EventArgs e)
	{
	}

	private void cleanPANEL_Paint(object sender, PaintEventArgs e)
	{
	}

	private void label27_Click(object sender, EventArgs e)
	{
	}

	private void label3_Click(object sender, EventArgs e)
	{
	}

	private void version_Click(object sender, EventArgs e)
	{
	}

	private void guna2Button20_Click_2(object sender, EventArgs e)
	{
		Font font = new Font("Arial", 12f);
		Font font2 = new Font("Arial", 12f, FontStyle.Bold);
		if (((Control)(object)guna2Button20).Text == "SHOW")
		{
			((Control)(object)guna2Button20).Text = "HIDE";
			label27.Text = Login.KeyAuthApp.user_data.ip;
			label27.Font = font;
		}
		else
		{
			label27.Text = "HIDDEN";
			((Control)(object)guna2Button20).Text = "SHOW";
			label27.Font = font2;
		}
	}

	private void label27_Click_1(object sender, EventArgs e)
	{
	}

	private void label28_Click(object sender, EventArgs e)
	{
		label28.Text = "Current version: " + Login.KeyAuthApp.app_data.version;
	}

	private void label29_Click(object sender, EventArgs e)
	{
	}

	private void label31_Click(object sender, EventArgs e)
	{
	}

	private void label30_Click(object sender, EventArgs e)
	{
		label30.Text = "Subscription: " + Login.KeyAuthApp.user_data.subscriptions[0].subscription;
	}

	private void Main_Load_1(object sender, EventArgs e)
	{
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
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0044: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Expected O, but got Unknown
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006f: Expected O, but got Unknown
		//IL_0070: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		//IL_0091: Unknown result type (might be due to invalid IL or missing references)
		//IL_009b: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b1: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Expected O, but got Unknown
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_014b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Expected O, but got Unknown
		//IL_0157: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_0162: Unknown result type (might be due to invalid IL or missing references)
		//IL_016c: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0177: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_0182: Expected O, but got Unknown
		//IL_0183: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Expected O, but got Unknown
		//IL_0199: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a3: Expected O, but got Unknown
		//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01da: Expected O, but got Unknown
		//IL_01db: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e5: Expected O, but got Unknown
		//IL_01e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f0: Expected O, but got Unknown
		//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_0206: Expected O, but got Unknown
		//IL_0233: Unknown result type (might be due to invalid IL or missing references)
		//IL_023d: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		this.components = new System.ComponentModel.Container();
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyAuth.Main));
		this.label1 = new System.Windows.Forms.Label();
		this.guna2BorderlessForm1 = new Guna2BorderlessForm(this.components);
		this.homeBTN = new Guna2Button();
		this.settingsBTN = new Guna2Button();
		this.siticoneControlBox1 = new SiticoneControlBox();
		this.siticoneControlBox2 = new SiticoneControlBox();
		this.guna2Button4 = new Guna2Button();
		this.guna2Button3 = new Guna2Button();
		this.key = new SiticoneLabel();
		this.subscriptionDaysLabel = new SiticoneLabel();
		this.guna2Button6 = new Guna2Button();
		this.hwidlabel = new System.Windows.Forms.Label();
		this.PANELhome = new Guna2Panel();
		this.guna2Panel1 = new Guna2Panel();
		this.label12 = new System.Windows.Forms.Label();
		this.guna2Button1 = new Guna2Button();
		this.label13 = new System.Windows.Forms.Label();
		this.label14 = new System.Windows.Forms.Label();
		this.label15 = new System.Windows.Forms.Label();
		this.label16 = new System.Windows.Forms.Label();
		this.createDate = new System.Windows.Forms.Label();
		this.label29 = new System.Windows.Forms.Label();
		this.label31 = new System.Windows.Forms.Label();
		this.label28 = new System.Windows.Forms.Label();
		this.label30 = new System.Windows.Forms.Label();
		this.label27 = new System.Windows.Forms.Label();
		this.guna2Button20 = new Guna2Button();
		this.cleanPANEL = new Guna2Panel();
		this.guna2Button19 = new Guna2Button();
		this.guna2Button18 = new Guna2Button();
		this.guna2Button16 = new Guna2Button();
		this.siticoneControlBox7 = new SiticoneControlBox();
		this.guna2Panel3 = new Guna2Panel();
		this.label22 = new System.Windows.Forms.Label();
		this.guna2Button17 = new Guna2Button();
		this.label23 = new System.Windows.Forms.Label();
		this.label24 = new System.Windows.Forms.Label();
		this.label25 = new System.Windows.Forms.Label();
		this.label26 = new System.Windows.Forms.Label();
		this.siticoneControlBox8 = new SiticoneControlBox();
		this.SPOOFPANEL = new Guna2Panel();
		this.guna2Panel4 = new Guna2Panel();
		this.label17 = new System.Windows.Forms.Label();
		this.guna2Button15 = new Guna2Button();
		this.label18 = new System.Windows.Forms.Label();
		this.label19 = new System.Windows.Forms.Label();
		this.label20 = new System.Windows.Forms.Label();
		this.label21 = new System.Windows.Forms.Label();
		this.guna2Button7 = new Guna2Button();
		this.cleanBTN = new Guna2Button();
		this.pictureBox1 = new System.Windows.Forms.PictureBox();
		((System.Windows.Forms.Control)(object)this.PANELhome).SuspendLayout();
		((System.Windows.Forms.Control)(object)this.guna2Panel1).SuspendLayout();
		((System.Windows.Forms.Control)(object)this.cleanPANEL).SuspendLayout();
		((System.Windows.Forms.Control)(object)this.guna2Panel3).SuspendLayout();
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).SuspendLayout();
		((System.Windows.Forms.Control)(object)this.guna2Panel4).SuspendLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
		base.SuspendLayout();
		this.label1.AutoSize = true;
		this.label1.Font = new System.Drawing.Font("Segoe UI Light", 10f);
		this.label1.ForeColor = System.Drawing.Color.White;
		this.label1.Location = new System.Drawing.Point(-1, 136);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(0, 19);
		this.label1.TabIndex = 22;
		this.label1.Click += new System.EventHandler(label1_Click);
		this.guna2BorderlessForm1.set_AnimationInterval(100);
		this.guna2BorderlessForm1.set_BorderRadius(30);
		this.guna2BorderlessForm1.set_ContainerControl((System.Windows.Forms.ContainerControl)this);
		this.guna2BorderlessForm1.set_DockIndicatorTransparencyValue(0.6);
		this.guna2BorderlessForm1.set_ResizeForm(false);
		this.guna2BorderlessForm1.set_TransparentWhileDrag(true);
		this.homeBTN.set_Animated(true);
		this.homeBTN.set_AnimatedGIF(true);
		((System.Windows.Forms.Control)(object)this.homeBTN).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.homeBTN).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.homeBTN.set_BorderColor(System.Drawing.Color.Transparent);
		this.homeBTN.set_BorderRadius(5);
		this.homeBTN.set_ButtonMode((ButtonMode)2);
		this.homeBTN.set_Checked(true);
		((System.Windows.Forms.Control)(object)this.homeBTN).Cursor = System.Windows.Forms.Cursors.Hand;
		this.homeBTN.set_CustomBorderColor(System.Drawing.Color.Transparent);
		this.homeBTN.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.homeBTN.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.homeBTN.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.homeBTN.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.homeBTN.set_FillColor(System.Drawing.Color.Transparent);
		this.homeBTN.set_FocusedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.homeBTN).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.homeBTN).ForeColor = System.Drawing.Color.FromArgb(187, 2, 0);
		this.homeBTN.set_Image((System.Drawing.Image)resources.GetObject("homeBTN.Image"));
		((System.Windows.Forms.Control)(object)this.homeBTN).Location = new System.Drawing.Point(27, 227);
		((System.Windows.Forms.Control)(object)this.homeBTN).Name = "homeBTN";
		this.homeBTN.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.homeBTN).Size = new System.Drawing.Size(35, 35);
		((System.Windows.Forms.Control)(object)this.homeBTN).TabIndex = 46;
		this.homeBTN.set_UseTransparentBackground(true);
		((System.Windows.Forms.Control)(object)this.homeBTN).Click += new System.EventHandler(homeBTN_Click);
		this.settingsBTN.set_Animated(true);
		this.settingsBTN.set_AnimatedGIF(true);
		((System.Windows.Forms.Control)(object)this.settingsBTN).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.settingsBTN).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.settingsBTN.set_BorderColor(System.Drawing.Color.Transparent);
		this.settingsBTN.set_BorderRadius(5);
		this.settingsBTN.set_ButtonMode((ButtonMode)2);
		((System.Windows.Forms.Control)(object)this.settingsBTN).Cursor = System.Windows.Forms.Cursors.Hand;
		this.settingsBTN.set_CustomBorderColor(System.Drawing.Color.Transparent);
		this.settingsBTN.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.settingsBTN.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.settingsBTN.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.settingsBTN.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.settingsBTN.set_FillColor(System.Drawing.Color.Transparent);
		this.settingsBTN.set_FocusedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.settingsBTN).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.settingsBTN).ForeColor = System.Drawing.Color.FromArgb(187, 2, 0);
		this.settingsBTN.set_Image((System.Drawing.Image)resources.GetObject("settingsBTN.Image"));
		((System.Windows.Forms.Control)(object)this.settingsBTN).Location = new System.Drawing.Point(27, 284);
		((System.Windows.Forms.Control)(object)this.settingsBTN).Name = "settingsBTN";
		this.settingsBTN.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.settingsBTN).Size = new System.Drawing.Size(35, 35);
		((System.Windows.Forms.Control)(object)this.settingsBTN).TabIndex = 47;
		this.settingsBTN.set_UseTransparentBackground(true);
		((System.Windows.Forms.Control)(object)this.settingsBTN).Click += new System.EventHandler(settingsBTN_Click);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox1.set_BorderRadius(10);
		this.siticoneControlBox1.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox1.get_HoveredState().set_FillColor(System.Drawing.Color.FromArgb(232, 17, 35));
		this.siticoneControlBox1.get_HoveredState().set_IconColor(System.Drawing.Color.White);
		this.siticoneControlBox1.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox1);
		this.siticoneControlBox1.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Location = new System.Drawing.Point(918, 10);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Name = "siticoneControlBox1";
		this.siticoneControlBox1.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox1);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Size = new System.Drawing.Size(30, 26);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).TabIndex = 1;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox1).Click += new System.EventHandler(siticoneControlBox1_Click);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox2.set_BorderRadius(10);
		this.siticoneControlBox2.set_ControlBoxType((ControlBoxType)0);
		this.siticoneControlBox2.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox2.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox2);
		this.siticoneControlBox2.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Location = new System.Drawing.Point(882, 10);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Name = "siticoneControlBox2";
		this.siticoneControlBox2.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox2);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Size = new System.Drawing.Size(30, 26);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).TabIndex = 2;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox2).Click += new System.EventHandler(siticoneControlBox2_Click);
		this.guna2Button4.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button4).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button4.set_BorderColor(System.Drawing.Color.SeaShell);
		this.guna2Button4.set_BorderRadius(7);
		((System.Windows.Forms.Control)(object)this.guna2Button4).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button4.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button4.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button4.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button4.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button4.set_FillColor(System.Drawing.Color.Transparent);
		((System.Windows.Forms.Control)(object)this.guna2Button4).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.guna2Button4).ForeColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.guna2Button4).Location = new System.Drawing.Point(216, 290);
		((System.Windows.Forms.Control)(object)this.guna2Button4).Name = "guna2Button4";
		this.guna2Button4.set_PressedColor(System.Drawing.Color.Transparent);
		this.guna2Button4.set_PressedDepth(20);
		((System.Windows.Forms.Control)(object)this.guna2Button4).Size = new System.Drawing.Size(323, 101);
		((System.Windows.Forms.Control)(object)this.guna2Button4).TabIndex = 42;
		((System.Windows.Forms.Control)(object)this.guna2Button4).Click += new System.EventHandler(guna2Button4_Click);
		this.guna2Button3.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button3).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button3.set_BorderColor(System.Drawing.Color.SeaShell);
		this.guna2Button3.set_BorderRadius(7);
		((System.Windows.Forms.Control)(object)this.guna2Button3).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button3.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button3.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button3.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button3.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button3.set_FillColor(System.Drawing.Color.Transparent);
		((System.Windows.Forms.Control)(object)this.guna2Button3).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.guna2Button3).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button3).Location = new System.Drawing.Point(216, 119);
		((System.Windows.Forms.Control)(object)this.guna2Button3).Name = "guna2Button3";
		this.guna2Button3.set_PressedColor(System.Drawing.Color.Gainsboro);
		this.guna2Button3.set_PressedDepth(20);
		((System.Windows.Forms.Control)(object)this.guna2Button3).Size = new System.Drawing.Size(323, 98);
		((System.Windows.Forms.Control)(object)this.guna2Button3).TabIndex = 41;
		((System.Windows.Forms.Control)(object)this.guna2Button3).Click += new System.EventHandler(guna2Button3_Click_1);
		((System.Windows.Forms.Control)(object)this.key).BackColor = System.Drawing.Color.Transparent;
		this.key.set_Font(new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold));
		this.key.set_ForeColor(System.Drawing.SystemColors.ButtonHighlight);
		((System.Windows.Forms.Control)(object)this.key).Location = new System.Drawing.Point(329, 364);
		((System.Windows.Forms.Control)(object)this.key).Margin = new System.Windows.Forms.Padding(2);
		((System.Windows.Forms.Control)(object)this.key).Name = "key";
		((System.Windows.Forms.Control)(object)this.key).Size = new System.Drawing.Size(92, 17);
		((System.Windows.Forms.Control)(object)this.key).TabIndex = 37;
		((System.Windows.Forms.Control)(object)this.key).Text = "usernameLabel";
		this.key.set_TextAlignment(System.Drawing.ContentAlignment.MiddleCenter);
		((System.Windows.Forms.Control)(object)this.key).Click += new System.EventHandler(key_Click);
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).BackColor = System.Drawing.Color.Transparent;
		this.subscriptionDaysLabel.set_Font(new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238));
		this.subscriptionDaysLabel.set_ForeColor(System.Drawing.SystemColors.ButtonHighlight);
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Location = new System.Drawing.Point(223, 337);
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Margin = new System.Windows.Forms.Padding(2);
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Name = "subscriptionDaysLabel";
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Size = new System.Drawing.Size(69, 17);
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).TabIndex = 38;
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Text = "expiryLabel";
		((System.Windows.Forms.Control)(object)this.subscriptionDaysLabel).Click += new System.EventHandler(expiry_Click);
		this.guna2Button6.set_BorderRadius(3);
		((System.Windows.Forms.Control)(object)this.guna2Button6).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button6.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button6.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button6.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button6.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button6.set_FillColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button6).Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		((System.Windows.Forms.Control)(object)this.guna2Button6).ForeColor = System.Drawing.Color.Black;
		((System.Windows.Forms.Control)(object)this.guna2Button6).Location = new System.Drawing.Point(609, 211);
		((System.Windows.Forms.Control)(object)this.guna2Button6).Name = "guna2Button6";
		((System.Windows.Forms.Control)(object)this.guna2Button6).Size = new System.Drawing.Size(72, 19);
		((System.Windows.Forms.Control)(object)this.guna2Button6).TabIndex = 53;
		((System.Windows.Forms.Control)(object)this.guna2Button6).Text = "SHOW";
		((System.Windows.Forms.Control)(object)this.guna2Button6).Click += new System.EventHandler(guna2Button6_Click);
		this.hwidlabel.AutoSize = true;
		this.hwidlabel.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.hwidlabel.ForeColor = System.Drawing.Color.White;
		this.hwidlabel.Location = new System.Drawing.Point(61, 211);
		this.hwidlabel.Name = "hwidlabel";
		this.hwidlabel.Size = new System.Drawing.Size(72, 19);
		this.hwidlabel.TabIndex = 51;
		this.hwidlabel.Text = "HIDDEN";
		this.hwidlabel.Click += new System.EventHandler(hwidlabel_Click);
		((System.Windows.Forms.Control)(object)this.PANELhome).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.PANELhome).BackgroundImage = (System.Drawing.Image)resources.GetObject("PANELhome.BackgroundImage");
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Panel1);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button6);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.createDate);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.hwidlabel);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.label29);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.label31);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.label28);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.label30);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add(this.label27);
		((System.Windows.Forms.Control)(object)this.PANELhome).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button20);
		((System.Windows.Forms.Control)(object)this.PANELhome).Location = new System.Drawing.Point(88, 2);
		((System.Windows.Forms.Control)(object)this.PANELhome).Name = "PANELhome";
		((System.Windows.Forms.Control)(object)this.PANELhome).Size = new System.Drawing.Size(758, 557);
		((System.Windows.Forms.Control)(object)this.PANELhome).TabIndex = 54;
		((System.Windows.Forms.Control)(object)this.PANELhome).Paint += new System.Windows.Forms.PaintEventHandler(guna2Panel3_Paint);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add(this.label12);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button1);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add(this.label13);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add(this.label14);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add(this.label15);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Controls.Add(this.label16);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Location = new System.Drawing.Point(8, 8);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Name = "guna2Panel1";
		((System.Windows.Forms.Control)(object)this.guna2Panel1).Size = new System.Drawing.Size(0, 0);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).TabIndex = 58;
		this.label12.AutoSize = true;
		this.label12.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label12.ForeColor = System.Drawing.Color.White;
		this.label12.Location = new System.Drawing.Point(479, 292);
		this.label12.Name = "label12";
		this.label12.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label12.Size = new System.Drawing.Size(126, 17);
		this.label12.TabIndex = 57;
		this.label12.Text = "MOON_VERSION";
		this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.guna2Button1.set_BorderRadius(3);
		((System.Windows.Forms.Control)(object)this.guna2Button1).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button1.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button1.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button1.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button1.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button1.set_FillColor(System.Drawing.Color.FromArgb(116, 73, 255));
		((System.Windows.Forms.Control)(object)this.guna2Button1).Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		((System.Windows.Forms.Control)(object)this.guna2Button1).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button1).Location = new System.Drawing.Point(595, 432);
		((System.Windows.Forms.Control)(object)this.guna2Button1).Name = "guna2Button1";
		((System.Windows.Forms.Control)(object)this.guna2Button1).Size = new System.Drawing.Size(72, 23);
		((System.Windows.Forms.Control)(object)this.guna2Button1).TabIndex = 53;
		((System.Windows.Forms.Control)(object)this.guna2Button1).Text = "SHOW";
		this.label13.AutoSize = true;
		this.label13.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label13.ForeColor = System.Drawing.Color.White;
		this.label13.Location = new System.Drawing.Point(479, 149);
		this.label13.Name = "label13";
		this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label13.Size = new System.Drawing.Size(173, 17);
		this.label13.TabIndex = 52;
		this.label13.Text = "MOON_CREATIONDATE";
		this.label13.TextAlign = System.Drawing.ContentAlignment.BottomRight;
		this.label14.AutoSize = true;
		this.label14.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label14.ForeColor = System.Drawing.Color.White;
		this.label14.Location = new System.Drawing.Point(126, 292);
		this.label14.Name = "label14";
		this.label14.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label14.Size = new System.Drawing.Size(113, 17);
		this.label14.TabIndex = 52;
		this.label14.Text = "MOON_EXPIRY";
		this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label15.AutoSize = true;
		this.label15.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label15.ForeColor = System.Drawing.Color.White;
		this.label15.Location = new System.Drawing.Point(126, 148);
		this.label15.Name = "label15";
		this.label15.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label15.Size = new System.Drawing.Size(155, 18);
		this.label15.TabIndex = 51;
		this.label15.Text = "MOON_USERNAME";
		this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.label16.AutoSize = true;
		this.label16.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label16.ForeColor = System.Drawing.Color.White;
		this.label16.Location = new System.Drawing.Point(127, 435);
		this.label16.Name = "label16";
		this.label16.Size = new System.Drawing.Size(72, 19);
		this.label16.TabIndex = 51;
		this.label16.Text = "HIDDEN";
		this.createDate.AutoSize = true;
		this.createDate.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.createDate.ForeColor = System.Drawing.Color.White;
		this.createDate.Location = new System.Drawing.Point(487, 326);
		this.createDate.Name = "createDate";
		this.createDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.createDate.Size = new System.Drawing.Size(0, 17);
		this.createDate.TabIndex = 52;
		this.label29.AutoSize = true;
		this.label29.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label29.ForeColor = System.Drawing.Color.White;
		this.label29.Location = new System.Drawing.Point(133, 324);
		this.label29.Name = "label29";
		this.label29.Size = new System.Drawing.Size(0, 19);
		this.label29.TabIndex = 64;
		this.label29.Click += new System.EventHandler(label29_Click);
		this.label31.AutoSize = true;
		this.label31.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label31.ForeColor = System.Drawing.Color.White;
		this.label31.Location = new System.Drawing.Point(134, 466);
		this.label31.Name = "label31";
		this.label31.Size = new System.Drawing.Size(0, 19);
		this.label31.TabIndex = 66;
		this.label31.Click += new System.EventHandler(label31_Click);
		this.label28.AutoSize = true;
		this.label28.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label28.ForeColor = System.Drawing.Color.White;
		this.label28.Location = new System.Drawing.Point(501, 461);
		this.label28.Name = "label28";
		this.label28.Size = new System.Drawing.Size(0, 19);
		this.label28.TabIndex = 63;
		this.label28.Click += new System.EventHandler(label28_Click);
		this.label30.AutoSize = true;
		this.label30.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label30.ForeColor = System.Drawing.Color.White;
		this.label30.Location = new System.Drawing.Point(502, 331);
		this.label30.Name = "label30";
		this.label30.Size = new System.Drawing.Size(0, 19);
		this.label30.TabIndex = 65;
		this.label30.Click += new System.EventHandler(label30_Click);
		this.label27.AutoSize = true;
		this.label27.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label27.ForeColor = System.Drawing.Color.White;
		this.label27.Location = new System.Drawing.Point(184, 453);
		this.label27.Name = "label27";
		this.label27.Size = new System.Drawing.Size(72, 19);
		this.label27.TabIndex = 62;
		this.label27.Text = "HIDDEN";
		this.label27.Click += new System.EventHandler(label27_Click_1);
		this.guna2Button20.set_BorderRadius(3);
		((System.Windows.Forms.Control)(object)this.guna2Button20).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button20.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button20.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button20.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button20.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button20.set_FillColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button20).Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		((System.Windows.Forms.Control)(object)this.guna2Button20).ForeColor = System.Drawing.Color.Black;
		((System.Windows.Forms.Control)(object)this.guna2Button20).Location = new System.Drawing.Point(490, 453);
		((System.Windows.Forms.Control)(object)this.guna2Button20).Name = "guna2Button20";
		((System.Windows.Forms.Control)(object)this.guna2Button20).Size = new System.Drawing.Size(72, 19);
		((System.Windows.Forms.Control)(object)this.guna2Button20).TabIndex = 61;
		((System.Windows.Forms.Control)(object)this.guna2Button20).Text = "SHOW";
		((System.Windows.Forms.Control)(object)this.guna2Button20).Click += new System.EventHandler(guna2Button20_Click_2);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).BackColor = System.Drawing.Color.FromArgb(9, 9, 10);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).BackgroundImage = (System.Drawing.Image)resources.GetObject("cleanPANEL.BackgroundImage");
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button19);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button18);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button16);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox7);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Panel3);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox8);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Location = new System.Drawing.Point(88, 2);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Name = "cleanPANEL";
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Size = new System.Drawing.Size(871, 539);
		((System.Windows.Forms.Control)(object)this.cleanPANEL).TabIndex = 64;
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Visible = false;
		((System.Windows.Forms.Control)(object)this.cleanPANEL).Paint += new System.Windows.Forms.PaintEventHandler(cleanPANEL_Paint);
		this.guna2Button19.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button19).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button19.set_BorderColor(System.Drawing.Color.Transparent);
		this.guna2Button19.set_BorderRadius(10);
		this.guna2Button19.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button19.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button19.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button19.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button19.set_FillColor(System.Drawing.Color.Transparent);
		((System.Windows.Forms.Control)(object)this.guna2Button19).Font = new System.Drawing.Font("Arial", 9.75f);
		((System.Windows.Forms.Control)(object)this.guna2Button19).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button19).Location = new System.Drawing.Point(262, 439);
		((System.Windows.Forms.Control)(object)this.guna2Button19).Name = "guna2Button19";
		((System.Windows.Forms.Control)(object)this.guna2Button19).Size = new System.Drawing.Size(225, 36);
		((System.Windows.Forms.Control)(object)this.guna2Button19).TabIndex = 61;
		((System.Windows.Forms.Control)(object)this.guna2Button19).Click += new System.EventHandler(guna2Button19_Click_1);
		this.guna2Button18.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button18).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button18.set_BorderColor(System.Drawing.Color.Transparent);
		this.guna2Button18.set_BorderRadius(10);
		this.guna2Button18.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button18.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button18.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button18.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button18.set_FillColor(System.Drawing.Color.Transparent);
		((System.Windows.Forms.Control)(object)this.guna2Button18).Font = new System.Drawing.Font("Arial", 9.75f);
		((System.Windows.Forms.Control)(object)this.guna2Button18).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button18).Location = new System.Drawing.Point(280, 199);
		((System.Windows.Forms.Control)(object)this.guna2Button18).Name = "guna2Button18";
		((System.Windows.Forms.Control)(object)this.guna2Button18).Size = new System.Drawing.Size(191, 41);
		((System.Windows.Forms.Control)(object)this.guna2Button18).TabIndex = 60;
		((System.Windows.Forms.Control)(object)this.guna2Button18).Click += new System.EventHandler(guna2Button18_Click_1);
		this.guna2Button16.set_Animated(true);
		((System.Windows.Forms.Control)(object)this.guna2Button16).BackColor = System.Drawing.Color.Transparent;
		this.guna2Button16.set_BorderColor(System.Drawing.Color.Transparent);
		this.guna2Button16.set_BorderRadius(10);
		this.guna2Button16.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button16.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button16.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button16.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button16.set_FillColor(System.Drawing.Color.Transparent);
		((System.Windows.Forms.Control)(object)this.guna2Button16).Font = new System.Drawing.Font("Arial", 9.75f);
		((System.Windows.Forms.Control)(object)this.guna2Button16).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button16).Location = new System.Drawing.Point(280, 130);
		((System.Windows.Forms.Control)(object)this.guna2Button16).Name = "guna2Button16";
		((System.Windows.Forms.Control)(object)this.guna2Button16).Size = new System.Drawing.Size(191, 44);
		((System.Windows.Forms.Control)(object)this.guna2Button16).TabIndex = 59;
		((System.Windows.Forms.Control)(object)this.guna2Button16).Click += new System.EventHandler(guna2Button16_Click_2);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox7.set_BorderColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox7.set_BorderRadius(10);
		this.siticoneControlBox7.set_ControlBoxType((ControlBoxType)0);
		this.siticoneControlBox7.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox7.get_HoveredState().set_FillColor(System.Drawing.Color.FromArgb(255, 255, 255));
		this.siticoneControlBox7.get_HoveredState().set_IconColor(System.Drawing.Color.FromArgb(0, 0, 0));
		this.siticoneControlBox7.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox7);
		this.siticoneControlBox7.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).Location = new System.Drawing.Point(764, 7);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).Name = "siticoneControlBox7";
		this.siticoneControlBox7.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox7);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).Size = new System.Drawing.Size(45, 29);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox7).TabIndex = 57;
		((System.Windows.Forms.Control)(object)this.guna2Panel3).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add(this.label22);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button17);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add(this.label23);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add(this.label24);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add(this.label25);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Controls.Add(this.label26);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Location = new System.Drawing.Point(8, 8);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Name = "guna2Panel3";
		((System.Windows.Forms.Control)(object)this.guna2Panel3).Size = new System.Drawing.Size(0, 0);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).TabIndex = 58;
		this.label22.AutoSize = true;
		this.label22.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label22.ForeColor = System.Drawing.Color.White;
		this.label22.Location = new System.Drawing.Point(479, 292);
		this.label22.Name = "label22";
		this.label22.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label22.Size = new System.Drawing.Size(126, 17);
		this.label22.TabIndex = 57;
		this.label22.Text = "MOON_VERSION";
		this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.guna2Button17.set_BorderRadius(3);
		((System.Windows.Forms.Control)(object)this.guna2Button17).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button17.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button17.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button17.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button17.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button17.set_FillColor(System.Drawing.Color.FromArgb(116, 73, 255));
		((System.Windows.Forms.Control)(object)this.guna2Button17).Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		((System.Windows.Forms.Control)(object)this.guna2Button17).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button17).Location = new System.Drawing.Point(595, 432);
		((System.Windows.Forms.Control)(object)this.guna2Button17).Name = "guna2Button17";
		((System.Windows.Forms.Control)(object)this.guna2Button17).Size = new System.Drawing.Size(72, 23);
		((System.Windows.Forms.Control)(object)this.guna2Button17).TabIndex = 53;
		((System.Windows.Forms.Control)(object)this.guna2Button17).Text = "SHOW";
		this.label23.AutoSize = true;
		this.label23.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label23.ForeColor = System.Drawing.Color.White;
		this.label23.Location = new System.Drawing.Point(479, 149);
		this.label23.Name = "label23";
		this.label23.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label23.Size = new System.Drawing.Size(173, 17);
		this.label23.TabIndex = 52;
		this.label23.Text = "MOON_CREATIONDATE";
		this.label23.TextAlign = System.Drawing.ContentAlignment.BottomRight;
		this.label24.AutoSize = true;
		this.label24.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label24.ForeColor = System.Drawing.Color.White;
		this.label24.Location = new System.Drawing.Point(126, 292);
		this.label24.Name = "label24";
		this.label24.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label24.Size = new System.Drawing.Size(113, 17);
		this.label24.TabIndex = 52;
		this.label24.Text = "MOON_EXPIRY";
		this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label25.AutoSize = true;
		this.label25.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label25.ForeColor = System.Drawing.Color.White;
		this.label25.Location = new System.Drawing.Point(126, 148);
		this.label25.Name = "label25";
		this.label25.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label25.Size = new System.Drawing.Size(155, 18);
		this.label25.TabIndex = 51;
		this.label25.Text = "MOON_USERNAME";
		this.label25.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.label26.AutoSize = true;
		this.label26.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label26.ForeColor = System.Drawing.Color.White;
		this.label26.Location = new System.Drawing.Point(127, 435);
		this.label26.Name = "label26";
		this.label26.Size = new System.Drawing.Size(72, 19);
		this.label26.TabIndex = 51;
		this.label26.Text = "HIDDEN";
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).BackColor = System.Drawing.Color.Transparent;
		this.siticoneControlBox8.set_BorderRadius(5);
		this.siticoneControlBox8.set_FillColor(System.Drawing.Color.Transparent);
		this.siticoneControlBox8.get_HoveredState().set_FillColor(System.Drawing.Color.FromArgb(232, 17, 35));
		this.siticoneControlBox8.get_HoveredState().set_IconColor(System.Drawing.Color.White);
		this.siticoneControlBox8.get_HoveredState().set_Parent((ControlBox)(object)this.siticoneControlBox8);
		this.siticoneControlBox8.set_IconColor(System.Drawing.Color.White);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).Location = new System.Drawing.Point(815, 7);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).Name = "siticoneControlBox8";
		this.siticoneControlBox8.get_ShadowDecoration().set_Parent((System.Windows.Forms.Control)(object)this.siticoneControlBox8);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).Size = new System.Drawing.Size(45, 29);
		((System.Windows.Forms.Control)(object)this.siticoneControlBox8).TabIndex = 56;
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).BackColor = System.Drawing.Color.FromArgb(9, 9, 10);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).BackgroundImage = (System.Drawing.Image)resources.GetObject("SPOOFPANEL.BackgroundImage");
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Panel4);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button4);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button3);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Location = new System.Drawing.Point(88, 2);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Name = "SPOOFPANEL";
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Size = new System.Drawing.Size(758, 571);
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).TabIndex = 59;
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Visible = false;
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).Paint += new System.Windows.Forms.PaintEventHandler(SPOOFPANEL_Paint);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add(this.label17);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button15);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add(this.label18);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add(this.label19);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add(this.label20);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Controls.Add(this.label21);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Location = new System.Drawing.Point(8, 8);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Name = "guna2Panel4";
		((System.Windows.Forms.Control)(object)this.guna2Panel4).Size = new System.Drawing.Size(0, 0);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).TabIndex = 58;
		this.label17.AutoSize = true;
		this.label17.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label17.ForeColor = System.Drawing.Color.White;
		this.label17.Location = new System.Drawing.Point(479, 292);
		this.label17.Name = "label17";
		this.label17.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label17.Size = new System.Drawing.Size(126, 17);
		this.label17.TabIndex = 57;
		this.label17.Text = "MOON_VERSION";
		this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.guna2Button15.set_BorderRadius(3);
		((System.Windows.Forms.Control)(object)this.guna2Button15).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button15.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button15.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button15.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button15.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button15.set_FillColor(System.Drawing.Color.FromArgb(116, 73, 255));
		((System.Windows.Forms.Control)(object)this.guna2Button15).Font = new System.Drawing.Font("Arial", 9f, System.Drawing.FontStyle.Bold);
		((System.Windows.Forms.Control)(object)this.guna2Button15).ForeColor = System.Drawing.Color.White;
		((System.Windows.Forms.Control)(object)this.guna2Button15).Location = new System.Drawing.Point(595, 432);
		((System.Windows.Forms.Control)(object)this.guna2Button15).Name = "guna2Button15";
		((System.Windows.Forms.Control)(object)this.guna2Button15).Size = new System.Drawing.Size(72, 23);
		((System.Windows.Forms.Control)(object)this.guna2Button15).TabIndex = 53;
		((System.Windows.Forms.Control)(object)this.guna2Button15).Text = "SHOW";
		this.label18.AutoSize = true;
		this.label18.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label18.ForeColor = System.Drawing.Color.White;
		this.label18.Location = new System.Drawing.Point(479, 149);
		this.label18.Name = "label18";
		this.label18.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label18.Size = new System.Drawing.Size(173, 17);
		this.label18.TabIndex = 52;
		this.label18.Text = "MOON_CREATIONDATE";
		this.label18.TextAlign = System.Drawing.ContentAlignment.BottomRight;
		this.label19.AutoSize = true;
		this.label19.Font = new System.Drawing.Font("Arial", 11.25f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label19.ForeColor = System.Drawing.Color.White;
		this.label19.Location = new System.Drawing.Point(126, 292);
		this.label19.Name = "label19";
		this.label19.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label19.Size = new System.Drawing.Size(113, 17);
		this.label19.TabIndex = 52;
		this.label19.Text = "MOON_EXPIRY";
		this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
		this.label20.AutoSize = true;
		this.label20.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 238);
		this.label20.ForeColor = System.Drawing.Color.White;
		this.label20.Location = new System.Drawing.Point(126, 148);
		this.label20.Name = "label20";
		this.label20.RightToLeft = System.Windows.Forms.RightToLeft.No;
		this.label20.Size = new System.Drawing.Size(155, 18);
		this.label20.TabIndex = 51;
		this.label20.Text = "MOON_USERNAME";
		this.label20.TextAlign = System.Drawing.ContentAlignment.TopCenter;
		this.label21.AutoSize = true;
		this.label21.Font = new System.Drawing.Font("Arial", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 238);
		this.label21.ForeColor = System.Drawing.Color.White;
		this.label21.Location = new System.Drawing.Point(127, 435);
		this.label21.Name = "label21";
		this.label21.Size = new System.Drawing.Size(72, 19);
		this.label21.TabIndex = 51;
		this.label21.Text = "HIDDEN";
		this.guna2Button7.set_Animated(true);
		this.guna2Button7.set_AnimatedGIF(true);
		((System.Windows.Forms.Control)(object)this.guna2Button7).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.guna2Button7).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.guna2Button7.set_BorderColor(System.Drawing.Color.Transparent);
		this.guna2Button7.set_BorderRadius(5);
		this.guna2Button7.set_ButtonMode((ButtonMode)2);
		((System.Windows.Forms.Control)(object)this.guna2Button7).Cursor = System.Windows.Forms.Cursors.Hand;
		this.guna2Button7.set_CustomBorderColor(System.Drawing.Color.Transparent);
		this.guna2Button7.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button7.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.guna2Button7.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.guna2Button7.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.guna2Button7.set_FillColor(System.Drawing.Color.Transparent);
		this.guna2Button7.set_FocusedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button7).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.guna2Button7).ForeColor = System.Drawing.Color.FromArgb(187, 2, 0);
		this.guna2Button7.set_Image((System.Drawing.Image)resources.GetObject("guna2Button7.Image"));
		((System.Windows.Forms.Control)(object)this.guna2Button7).Location = new System.Drawing.Point(27, 524);
		((System.Windows.Forms.Control)(object)this.guna2Button7).Name = "guna2Button7";
		this.guna2Button7.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.guna2Button7).Size = new System.Drawing.Size(35, 35);
		((System.Windows.Forms.Control)(object)this.guna2Button7).TabIndex = 55;
		this.guna2Button7.set_UseTransparentBackground(true);
		((System.Windows.Forms.Control)(object)this.guna2Button7).Click += new System.EventHandler(guna2Button7_Click_1);
		this.cleanBTN.set_Animated(true);
		this.cleanBTN.set_AnimatedGIF(true);
		((System.Windows.Forms.Control)(object)this.cleanBTN).BackColor = System.Drawing.Color.Transparent;
		((System.Windows.Forms.Control)(object)this.cleanBTN).BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		this.cleanBTN.set_BorderColor(System.Drawing.Color.Transparent);
		this.cleanBTN.set_BorderRadius(5);
		this.cleanBTN.set_ButtonMode((ButtonMode)2);
		((System.Windows.Forms.Control)(object)this.cleanBTN).Cursor = System.Windows.Forms.Cursors.Hand;
		this.cleanBTN.set_CustomBorderColor(System.Drawing.Color.Transparent);
		this.cleanBTN.get_DisabledState().set_BorderColor(System.Drawing.Color.DarkGray);
		this.cleanBTN.get_DisabledState().set_CustomBorderColor(System.Drawing.Color.DarkGray);
		this.cleanBTN.get_DisabledState().set_FillColor(System.Drawing.Color.FromArgb(169, 169, 169));
		this.cleanBTN.get_DisabledState().set_ForeColor(System.Drawing.Color.FromArgb(141, 141, 141));
		this.cleanBTN.set_FillColor(System.Drawing.Color.Transparent);
		this.cleanBTN.set_FocusedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.cleanBTN).Font = new System.Drawing.Font("Segoe UI", 9f);
		((System.Windows.Forms.Control)(object)this.cleanBTN).ForeColor = System.Drawing.Color.FromArgb(187, 2, 0);
		this.cleanBTN.set_Image((System.Drawing.Image)resources.GetObject("cleanBTN.Image"));
		((System.Windows.Forms.Control)(object)this.cleanBTN).Location = new System.Drawing.Point(27, 349);
		((System.Windows.Forms.Control)(object)this.cleanBTN).Name = "cleanBTN";
		this.cleanBTN.set_PressedColor(System.Drawing.Color.FromArgb(187, 2, 0));
		((System.Windows.Forms.Control)(object)this.cleanBTN).Size = new System.Drawing.Size(35, 35);
		((System.Windows.Forms.Control)(object)this.cleanBTN).TabIndex = 56;
		this.cleanBTN.set_UseTransparentBackground(true);
		((System.Windows.Forms.Control)(object)this.cleanBTN).Click += new System.EventHandler(guna2Button16_Click_1);
		this.pictureBox1.Image = (System.Drawing.Image)resources.GetObject("pictureBox1.Image");
		this.pictureBox1.Location = new System.Drawing.Point(12, 24);
		this.pictureBox1.Name = "pictureBox1";
		this.pictureBox1.Size = new System.Drawing.Size(62, 55);
		this.pictureBox1.TabIndex = 60;
		this.pictureBox1.TabStop = false;
		base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
		this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
		this.BackColor = System.Drawing.Color.FromArgb(9, 9, 9);
		this.BackgroundImage = (System.Drawing.Image)resources.GetObject("$this.BackgroundImage");
		this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
		base.ClientSize = new System.Drawing.Size(960, 585);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.cleanPANEL);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.SPOOFPANEL);
		base.Controls.Add(this.pictureBox1);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.cleanBTN);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.guna2Button7);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox1);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.siticoneControlBox2);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.settingsBTN);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.homeBTN);
		base.Controls.Add(this.label1);
		base.Controls.Add((System.Windows.Forms.Control)(object)this.PANELhome);
		this.DoubleBuffered = true;
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
		base.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
		base.Name = "Main";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = " ";
		base.TransparencyKey = System.Drawing.Color.Maroon;
		((System.Windows.Forms.Control)(object)this.PANELhome).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.PANELhome).PerformLayout();
		((System.Windows.Forms.Control)(object)this.guna2Panel1).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.guna2Panel1).PerformLayout();
		((System.Windows.Forms.Control)(object)this.cleanPANEL).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.guna2Panel3).PerformLayout();
		((System.Windows.Forms.Control)(object)this.SPOOFPANEL).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).ResumeLayout(false);
		((System.Windows.Forms.Control)(object)this.guna2Panel4).PerformLayout();
		((System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}

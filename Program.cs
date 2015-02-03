/*
 * Hello and welcome to the VoliBot AutoQueuer Project!
 * Credits to: shalzuth, Maufeat, imsosharp
 * Find assemblies for this AutoQueuer on LeagueSharp's official forum at:
 * http://www.joduska.me/
 * You are allowed to copy, edit and distribute this project,
 * as long as you don't touch this notice and you release your project with source.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Ini;
using System.Collections;
using System.IO;
using System.Threading;
using System.Net;
using System.Management;
using LoLLauncher;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Management;
using System.Management.Instrumentation;
using System.Text;
using System.Diagnostics;
using System.Drawing;

namespace RitoBot
{
    public class Program
    {
        /*| VoliBot is an open source League of Legends Auto Queue Bot
         *| Thanks to: Maufeat, Fulcrum and shalzuth.
         *| Website: www.volibot.com
         */

        public static string Path2;
        public static string Region;
        public static ArrayList accounts = new ArrayList();
        public static ArrayList accounts2 = new ArrayList();
        public static int maxBots = 1;
        public static bool replaceConfig =  false;
        public static int connectedAccs = 0;
        public static string championId = "";
        public static string championId2 = "";
        public static int maxLevel = 31;
        public static bool buyBoost = false;
        public static bool rndSpell = true;
        public static string spell1 = "flash";
        public static string spell2 = "ignite";
        public static string cversion = "5.1.15_01_09_17_50";
        public static bool AutoUpdate = false;
        public static bool LoadGUI = false;
        public static frm_MainWindow MainWindow = new frm_MainWindow();

        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        const int SW_HIDE = 0;
        const int SW_SHOW = 5;

     


        











        static void Main(string[] args)
        {

           
           

            var handle = GetConsoleWindow();

            // Hide
            ShowWindow(handle, SW_HIDE);

            InitChecks();
            loadVersion();
            Console.Title = "Volibot For Garena";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetWindowSize(Console.WindowWidth + 5, Console.WindowHeight);
            Console.WriteLine("=======================================");
            Console.WriteLine("-------- Do Quang Quan Edit  ----------");
            Console.WriteLine("=======================================");
            Console.WriteLine();
            Console.WriteLine(getTimestamp() + "Loading config\\settings.ini");
            loadConfiguration();
            if (replaceConfig)
            {
                Console.WriteLine(getTimestamp() + "Replacing Config");
                gamecfg();
            }
            Console.WriteLine(getTimestamp() + "Loading config\\accounts.txt");
            ReloadAccounts:
            loadAccounts();
            int curRunning = 0;
            LoadGUI = true;
            if (LoadGUI) MainWindow.ShowDialog();
            if (!LoadGUI)
            {
                foreach (string acc in accounts)
                {
                    try
                    {
                        accounts2.RemoveAt(0);
                        string Accs = acc;
                        string[] stringSeparators = new string[] { "|" };
                        var result = Accs.Split(stringSeparators, StringSplitOptions.None);
                        curRunning += 1;
                        if (result[0].Contains("username"))
                        {
                            Console.WriteLine("Please add your accounts into config\\accounts.txt");
                            goto ReloadAccounts;
                        }
                        if (result[2] != null)
                        {
                            QueueTypes queuetype = (QueueTypes)System.Enum.Parse(typeof(QueueTypes), result[2]);
                            RiotBot ritoBot = new RiotBot(result[0], result[1], Region, Path2, curRunning, queuetype);
                        }
                        else
                        {
                            QueueTypes queuetype = QueueTypes.ARAM;
                            RiotBot ritoBot = new RiotBot(result[0], result[1], Region, Path2, curRunning, queuetype);
                        }
                        Console.Title = "RitoBot Console ";
                        if (curRunning == maxBots)
                            break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("CountAccError: You may have an issue in your accounts.txt");
                        Application.Exit();
                    }
                }
                Console.ReadKey();
            }
        }

       

       
        public static string GetCommandLine_lol(Boolean kill_lol = false)
        {

            string cml = "";
            foreach (var process in Process.GetProcesses())
            {
                try
                {
                    if (process.ProcessName.Equals("lol"))
                    {
                        var commandLine = new StringBuilder();

                        using (var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Process WHERE ProcessId = " + process.Id))
                        {
                            foreach (var @object in searcher.Get())
                            {
                                commandLine.Append(@object["CommandLine"]);
                            }
                        }
                        cml = commandLine.ToString().Remove(0, 1);
                        if (kill_lol)
                        {
                            kill_LolCalient();
                        }
                    }
                    
                }
                catch (Exception ex)
                {

                }
            }
            return cml;
        }
        public static void kill_LolCalient()
        {

            Process[] processes = Process.GetProcessesByName("lol");
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }

            Process[] processes2 = Process.GetProcessesByName("LolClient");
            foreach (Process process in processes2)
            {
                process.Kill();
                process.WaitForExit();
            }
        }
        public static void loadVersion()
        {

            var versiontxt = File.OpenText(AppDomain.CurrentDomain.BaseDirectory + @"config\\version.txt");
            cversion = versiontxt.ReadLine();               
        }
        public static void lognNewAccount()
        {
            accounts2 = accounts;
            accounts.RemoveAt(0);
            int curRunning = 0;
            if (accounts.Count == 0)
            {
                Console.WriteLine(getTimestamp() + "No more accounts to login.");
            }
            foreach (string acc in accounts)
            {
                string Accs = acc;
                string[] stringSeparators = new string[] { "|" };
                var result = Accs.Split(stringSeparators, StringSplitOptions.None);
                curRunning += 1;
                if(result[2] != null)
                {
                    QueueTypes queuetype = (QueueTypes)System.Enum.Parse(typeof(QueueTypes), result[2]);
                    RiotBot ritoBot = new RiotBot(result[0], result[1], Region, Path2, curRunning, queuetype);
                } else {
                    QueueTypes queuetype = QueueTypes.ARAM;
                    RiotBot ritoBot = new RiotBot(result[0], result[1], Region, Path2, curRunning, queuetype);
                }
                Console.Title = "RitoBot Console | Currently connected: " + connectedAccs;
                if (curRunning == maxBots)
                    break;
            }
        }
        public static void loadConfiguration()
        {
            try
            {
                IniFile iniFile = new IniFile(AppDomain.CurrentDomain.BaseDirectory + "config\\settings.ini");
                //General
                Path2 = iniFile.IniReadValue("General", "LauncherPath");
                LoadGUI = Convert.ToBoolean(iniFile.IniReadValue("General", "LoadGUI"));
                maxBots = Convert.ToInt32(iniFile.IniReadValue("General", "MaxBots"));
                maxLevel = Convert.ToInt32(iniFile.IniReadValue("General", "MaxLevel"));
                championId = iniFile.IniReadValue("General", "ChampionPick").ToUpper();
                spell1 = iniFile.IniReadValue("General", "Spell1").ToUpper();
                spell2 = iniFile.IniReadValue("General", "Spell2").ToUpper();
                rndSpell = Convert.ToBoolean(iniFile.IniReadValue("General", "RndSpell"));
                replaceConfig = Convert.ToBoolean(iniFile.IniReadValue("General", "ReplaceConfig"));
                AutoUpdate = Convert.ToBoolean(iniFile.IniReadValue("General", "AutoUpdate"));
                //Account
                Region = iniFile.IniReadValue("Account", "Region").ToUpper();
                buyBoost = Convert.ToBoolean(iniFile.IniReadValue("Account", "BuyBoost"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Thread.Sleep(10000);
                Application.Exit();
            }
        }
        public static void loadAccounts()
        {
            var accountsTxtPath = AppDomain.CurrentDomain.BaseDirectory + "config\\accounts.txt";
            TextReader tr = File.OpenText(accountsTxtPath);
            string line;
            accounts.Clear();
            while ((line = tr.ReadLine()) != null)
            {
                accounts.Add(line);
                accounts2.Add(line);
            }
            tr.Close();
        }
        public static String getTimestamp()
        {
           return "[" + DateTime.Now + "] ";
        }
        public static void getColor(ConsoleColor color)
        {
           Console.ForegroundColor = color;
        }
        public static Boolean khoiphuc_cauhinh()
        {
            string file_cfg = Path2 + @"Game\\Config\\game.cfg";
            string file_me = AppDomain.CurrentDomain.BaseDirectory + @"config\\game.cfg";
            //File.Copy(file_cfg, file_me);
            if (File.Exists(file_me))
            {
                File.Delete(file_cfg);

                string oldPath = AppDomain.CurrentDomain.BaseDirectory + @"config\\game.cfg";
                string newpath = Path2 + @"Game\\Config\\";
                string newFileName = "game";
                FileInfo f1 = new FileInfo(oldPath);
                if (f1.Exists)
                {
                    if (!Directory.Exists(newpath))
                    {
                        Directory.CreateDirectory(newpath);
                    }
                    f1.CopyTo(string.Format("{0}{1}{2}", newpath, newFileName, f1.Extension));
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean check_file_lol()
        {
            string file_lol = Path2 + @"lol.exe";
            if (File.Exists(file_lol))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static Boolean back_kup_cauhinh(){
            string file_cfg = Path2 + @"Game\\Config\\game.cfg";
            string file_me = AppDomain.CurrentDomain.BaseDirectory + @"config\\game.cfg";
            //File.Copy(file_cfg, file_me);
            if (File.Exists(file_me))
            {
                File.Delete(file_me);
            }
            string oldPath = Path2 + @"Game\\Config\\game.cfg";
            string newpath = AppDomain.CurrentDomain.BaseDirectory + @"config\\";
            string newFileName = "game";
            FileInfo f1 = new FileInfo(oldPath);
            if (f1.Exists)
            {
                if (!Directory.Exists(newpath))
                {
                    Directory.CreateDirectory(newpath);
                }
                f1.CopyTo(string.Format("{0}{1}{2}", newpath, newFileName, f1.Extension));
                return true;
            }
            else
            {
                return false;
            }
           
        }
        
        public static void gamecfg(int w=1024 , int h = 768)
        {
            try
            {
                string path = Path2 + @"Game\\Config\\game.cfg";
                FileInfo fileInfo = new FileInfo(path);
                fileInfo.IsReadOnly = false;
                fileInfo.Refresh();
                string str = "[General]\nGameMouseSpeed=9\nEnableAudio=0\nUserSetResolution=1\nBindSysKeys=0\nSnapCameraOnRespawn=1\nOSXMouseAcceleration=1\nAutoAcquireTarget=1\nEnableLightFx=0\nWindowMode=1\nShowTurretRangeIndicators=0\nPredictMovement=0\nWaitForVerticalSync=0\nColors=16\nHeight="+h+"\nWidth="+w+"\nSystemMouseSpeed=0\nCfgVersion=4.13.265\n\n[HUD]\nShowNeutralCamps=0\nDrawHealthBars=0\nAutoDisplayTarget=0\nMinimapMoveSelf=0\nItemShopPrevY=19\nItemShopPrevX=117\nShowAllChannelChat=0\nShowTimestamps=0\nObjectTooltips=0\nFlashScreenWhenDamaged=0\nNameTagDisplay=1\nShowChampionIndicator=0\nShowSummonerNames=0\nScrollSmoothingEnabled=0\nMiddleMouseScrollSpeed=0.5000\nMapScrollSpeed=0.5000\nShowAttackRadius=0\nNumericCooldownFormat=3\nSmartCastOnKeyRelease=0\nEnableLineMissileVis=0\nFlipMiniMap=0\nItemShopResizeHeight=47\nItemShopResizeWidth=455\nItemShopPrevResizeHeight="+h+"\nItemShopPrevResizeWidth="+w+"\nItemShopItemDisplayMode=1\nItemShopStartPane=1\n\n[Performance]\nShadowsEnabled=0\nEnableHUDAnimations=0\nPerPixelPointLighting=0\nEnableParticleOptimizations=0\nBudgetOverdrawAverage=10\nBudgetSkinnedVertexCount=10\nBudgetSkinnedDrawCallCount=10\nBudgetTextureUsage=10\nBudgetVertexCount=10\nBudgetTriangleCount=10\nBudgetDrawCallCount=1000\nEnableGrassSwaying=0\nEnableFXAA=0\nAdvancedShader=0\nFrameCapType=3\nGammaEnabled=1\nFull3DModeEnabled=0\nAutoPerformanceSettings=0\n=0\nEnvironmentQuality=0\nEffectsQuality=0\nShadowQuality=0\nGraphicsSlider=0\n\n[Volume]\nMasterVolume=1\nMusicMute=0\n\n[LossOfControl]\nShowSlows=0\n\n[ColorPalette]\nColorPalette=0\n\n[FloatingText]\nCountdown_Enabled=0\nEnemyTrueDamage_Enabled=0\nEnemyMagicalDamage_Enabled=0\nEnemyPhysicalDamage_Enabled=0\nTrueDamage_Enabled=0\nMagicalDamage_Enabled=0\nPhysicalDamage_Enabled=0\nScore_Enabled=0\nDisable_Enabled=0\nLevel_Enabled=0\nGold_Enabled=0\nDodge_Enabled=0\nHeal_Enabled=0\nSpecial_Enabled=0\nInvulnerable_Enabled=0\nDebug_Enabled=1\nAbsorbed_Enabled=1\nOMW_Enabled=1\nEnemyCritical_Enabled=0\nQuestComplete_Enabled=0\nQuestReceived_Enabled=0\nMagicCritical_Enabled=0\nCritical_Enabled=1\n\n[Replay]\nEnableHelpTip=0";
                StringBuilder builder = new StringBuilder();
                builder.AppendLine(str);
                using (StreamWriter writer = new StreamWriter(Path2 + @"Game\\Config\game.cfg"))
                {
                    writer.Write(builder.ToString());
                }
                fileInfo.Refresh();
            }
            catch (Exception exception2)
            {
                 
                Console.WriteLine("game.cfg Error: If using VMWare Shared Folder, make sure it is not set to Read-Only.\nException:" + exception2.Message);
            }
        }
        private static string RandomString(int size)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }

            return builder.ToString();
        }
        private static void InitChecks()
        {
            var theFolder = AppDomain.CurrentDomain.BaseDirectory + @"config\\";
            var accountsTxtLocation = AppDomain.CurrentDomain.BaseDirectory + @"config\\accounts.txt";
            var configTxtLocation = AppDomain.CurrentDomain.BaseDirectory + @"config\\settings.ini";
            var versionTxtLocation = AppDomain.CurrentDomain.BaseDirectory + @"config\\version.txt";

            if (!Directory.Exists(theFolder))
            {
                Directory.CreateDirectory(theFolder);
            }

            if (!File.Exists(configTxtLocation))
            {
                
                var newfile = File.Create(configTxtLocation);
                newfile.Close();
                var content = "[General]\nLauncherPath=C:\\GarenaLoL\\GameData\\Apps\\LoL\\\nLoadGUI=false\nMaxBots=1\nMaxLevel=31\nChampionPick=Annie\nSpell1=Flash\nSpell2=Exhaust\nRndSpell=false\nReplaceConfig=false\nAutoUpdate=false\n\n[Account]\nRegion=TH\nBuyBoost=false";
                var separator = new string[] { "\n" };
                string[] contentlines = content.Split(separator,StringSplitOptions.None);
                File.WriteAllLines(configTxtLocation, contentlines);
            }
            if (!File.Exists(versionTxtLocation))
            {
                var newfile = File.CreateText(versionTxtLocation);
                newfile.Close();
                string[] content = { cversion };
                File.WriteAllLines(versionTxtLocation, content);
            }
            if (!File.Exists(accountsTxtLocation))
            {
                var newfile = File.CreateText(accountsTxtLocation);
                newfile.Close();
                string[] content = { "username|garenaToken|QueueType" };
                File.WriteAllLines(accountsTxtLocation, content);
            }
        }
   }
}

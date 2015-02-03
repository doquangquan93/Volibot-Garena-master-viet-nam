/*
 * VoliBot GUI a.k.a. RitoBot GUI is part of the opensource VoliBot AutoQueuer project.
 * Credits to: shalzuth, Maufeat, imsosharp
 * Find assemblies for this AutoQueuer on LeagueSharp's official forum at:
 * http://www.joduska.me/
 * You are allowed to copy, edit and distribute this project,
 * as long as you don't touch this notice and you release your project with source.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using LoLLauncher;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace RitoBot
{
    public partial class frm_MainWindow : Form
    {
        public frm_MainWindow()
        {
            InitializeComponent();
            Print("VoliBot GUI RC2 Loaded.");
            Print("Volibot's ready for Version: " + Program.cversion.Substring(0,4));
            Print("brought to you by imsosharp.", 2);
            Print("Edit by Do Quang Quan . V 1.6");
        }

        public void Print(string text)
        {
            console.AppendText("[" + DateTime.Now + "] : " + text + "\n");
        }
        public void Print(string text, int newlines)
        {
            console.AppendText("[" + DateTime.Now + "] : " + text);
            for (int i = 0; i < newlines; i++)
            {
                console.AppendText("\n");
            }
        }
        public void ShowAccount(string account, string password, string queuetype)
        {
            LoadedAccounts.AppendText("Tài Khoản : " + account + " Loại : " + queuetype +" \n");
        }
        public void AddText(string text)
        {
            LoadedAccounts.AppendText(text + " \n");
        }

        private void addAccountsBtn_Click(object sender, EventArgs e)
        {
            if (newUserNameInput.Text.Length == 0 || newPasswordInput.Text.Length == 0)
            {
                MessageBox.Show("Username and Password cannot be empty!!!");
            }
            else
            {
                FileHandlers.AccountsTxt(newUserNameInput.Text, newPasswordInput.Text, QueueTypeInput.SelectedItem.ToString());
                Print("Thay đổi tài khoản thành công !");
                var content = newUserNameInput.Text + "|" + newPasswordInput.Text + "|" + QueueTypeInput.SelectedItem.ToString();
                Print(content);
                Program.loadAccounts();
                update_acc();
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            FileHandlers.SettingsIni(LauncherPathInput.Text, MaxBotsInput.Text, MaxLevelInput.Text, DefaultChampionInput.SelectedItem.ToString(), Spell1Input.SelectedItem.ToString(), Spell2Input.SelectedItem.ToString(), RegionInput.SelectedItem.ToString(), BuyBoostInput.SelectedItem.ToString());
            Print("Thay đổi file configs.ini thành công !");
            Program.loadConfiguration();
          
        }

        public void queueLoop()
        {
            // get token
           // update_token();
            foreach (string acc in Program.accounts)
            {
                int curRunning = 0;
                try
                {
                    string taikhoan = newUserNameInput.Text;
                    string token = newPasswordInput.Text;
                    string type = QueueTypeInput.Text;
                    if (taikhoan != null)
                    {
                        QueueTypes queuetype = (QueueTypes)System.Enum.Parse(typeof(QueueTypes), type);
                        RiotBot ritoBot = new RiotBot(taikhoan, token, Program.Region, Program.Path2, curRunning, queuetype, Convert.ToInt32(input_solanchoi.Text));
                        ShowAccount(taikhoan, token, type);
                    }
                    else
                    {
                        QueueTypes queuetype = QueueTypes.ARAM;
                        RiotBot ritoBot = new RiotBot(taikhoan, token, Program.Region, Program.Path2, curRunning, queuetype, Convert.ToInt32(input_solanchoi.Text));
                        ShowAccount(taikhoan, token, "ARAM");
                    }
                    if (curRunning == Program.maxBots)
                        break;
                }
                catch (Exception)
                {
                    console.ForeColor = Color.Red;
                    Print("You may have an error in accounts.txt.");
                    Print("If you just started Volibot for the first time,");
                    Print("add a new account on the leftside panel.");
                    Print("If you keep getting this error,");
                    Print("Delete accounts.txt and restart voli.", 2);
                    Print("Có lỗi : vui lòng xóa folder config và chạy lại ...............", 2);
                }
            }
        }

        private void frm_MainWindow_Load(object sender, EventArgs e)
        {
            if (!Program.check_file_lol())
            {
                Print("Đường dẫn thư mục LOL sai .... vui lòng kiểm tra lại nhé !");
            }
            update_acc();
            newPasswordInput.Text = "by Đỗ Quang Quân";
        }

        public void update_token(Boolean kill=false)
        {
            string token = Program.GetCommandLine_lol(kill);
            if(!token.Equals("")){
                newPasswordInput.Text = token;
                Print("Lấy thành công lấy mã Token !");
            }
            else
            {
                Print("Không thể lấy mã Token !", 2);
            }
           
        }

        public void update_acc()
        {
            LauncherPathInput.Text = Program.Path2;
            RegionInput.Text = Program.Region;
            Spell1Input.Text = Program.spell1;
            Spell2Input.Text = Program.spell2;
            BuyBoostInput.Text = Program.buyBoost.ToString();
            DefaultChampionInput.Text = Program.championId;
       



            foreach (string acc in Program.accounts)
            {
                int curRunning = 0;
                try
                {
                    Program.accounts2.RemoveAt(0);
                    string Accs = acc;
                    string[] stringSeparators = new string[] { "|" };
                    var result = Accs.Split(stringSeparators, StringSplitOptions.None);
                    console.ForeColor = Color.Lime;
                    curRunning += 1;
                    if (result[2] != null)
                    {
                        newUserNameInput.Text = result[0];
                        newPasswordInput.Text = result[1];
                        ShowAccount(result[0], result[1], result[2]);
                    }
                    else
                    {
                        ShowAccount(result[0], result[1], "ARAM");
                    }
                    Program.MainWindow.Text = " Volibot GUI : Do Quang Quan";
                }
                catch (Exception)
                {

                }
            }
            
        }

        private void LauncherPathInput_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
              Print("Bắt đâu chạy ....", 2);
              Boolean check = false;
              Process[] processRunning = Process.GetProcesses();
              foreach (Process pr in processRunning)
              {
                  if (pr.ProcessName == "lol")
                  {
                      check = true;
                  }

              }
              if (check)
              {
                  Print("function 1");
                  update_token(true);
                  Program.loadAccounts();
                  queueLoop();
              }
              else
              {
                  Print("function 2");
                  function_add.khoidonglai_LOL();
              }
        }

        private void configTabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadedAccounts.Text = "";
            console.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int w = Convert.ToInt32(input_width.Text);
            int h = Convert.ToInt32(input_height.Text);
            Program.gamecfg(w,h);
            Print("Thay đổi cấu hình MOD thành công : " + w + " x " + h); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Process[] processes = Process.GetProcessesByName("RitoBot");
            foreach (Process process in processes)
            {
                process.Kill();
                process.WaitForExit();
            }
            Print("Chờ xíu để kill RitoBot.exe rồi ra liền !");
            Thread.Sleep(1000);
           // Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Program.khoiphuc_cauhinh())
            {
                Print("Cài đặt giao diện mặc định thành công !");
            }
            else
            {
                Print("Lỗi không tìm thấy file backup !");
            }
           
        }

        private void button6_Click(object sender, EventArgs e)
        {
            update_token();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Program.back_kup_cauhinh())
            {
                Print("Backup cấu hình thành công !");
            }else{
                Print("Không thể backup file cấu hình !");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!Program.check_file_lol())
            {
                Print("Đường dẫn thư mục LOL sai .... vui lòng kiểm tra lại nhé !");
            }
            else
            {
                Print("Đường dẫn thư mục LOl đúng rồi nhé ! . Quẩy thôi !");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (function_add.start_lol() == 1)
            {
                Print("Quá trình test xong !");
            }
        }



        private void button10_Click(object sender, EventArgs e)
        {
            Print("Làm gì đã có gì mà test :)");
        }

        private void btn_an_lol_Click(object sender, EventArgs e)
        {
           
            function_add.sys_check_lol_5p(17);
        }


       
    }
}

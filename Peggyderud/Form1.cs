using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Synthesis;
using System.Speech.Recognition;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.IO;
using DotNetOpenAuth.AspNet.Clients;


namespace Peggyderud
{


    public partial class Form1 : Form
    {

        System.Media.SoundPlayer player = new System.Media.SoundPlayer();

        //Form Declaration
        SpeechSynthesizer ss = new SpeechSynthesizer();
        PromptBuilder pb = new PromptBuilder();
        SpeechRecognitionEngine spe = new SpeechRecognitionEngine();
        Choices clist = new Choices();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileStream fs1;
            //FileStream fs2;
            fs1 = new FileStream(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Global Commands.txt", FileMode.Open, FileAccess.Read);

            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = true;

            timer1.Start();
            timer2.Start();
            timer3.Start();
            timer4.Start();

            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Global Commands.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Calculator Commands.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Chatting.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Commands.txt    "));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Google Chrome Commands.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Software Commands.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Song Names.txt"));
            clist.Add(File.ReadAllLines(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Questions.txt"));
            clist.Add("i am");
            clist.Add("hello");


            Grammar gr = new Grammar(new GrammarBuilder(clist));
            try
            {
                spe.RequestRecognizerUpdate();
                spe.LoadGrammar(gr);
                spe.SpeechRecognized += Spe_SpeechRecognized;
                spe.SetInputToDefaultAudioDevice();
                spe.RecognizeAsync(RecognizeMode.Multiple);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!");
            }
        }


        private void Spe_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            /* int counter = 0;
           string read;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Song Names.txt");

            while ((line = file.ReadLine()) != null)
            {
                if (line.Contains(e.Result.Text.ToString()))
                {
                    counter += 1;
                    using (var sr = new StreamReader(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Questions.txt"))
                    {
                        for (int i = 0; i < counter; i++)
                        {
                            read = sr.ReadLine();
                        }
                        ss.SpeakAsync(sr.ReadLine());
                        file.Close();
                        break;
                    }
                }
                counter++;
            }
            */

            string voice = e.Result.Text.ToString();
            string voice2 = voice.Replace("search ", "");
            string ab = "google.com/search?q=" + voice2;


            if (e.Result.Text.ToString() != null)
            {

                if(voice.Contains("listen")==true && voice.Contains("music")==true)
                {

                }

                if (voice.Contains("listen") == true && voice.Contains("music") == true)
                {
                    Process.Start("chrome");
                    ss.SpeakAsync("Please tell me the song name");
                }
                        int counter = 0;
                        string line;

                        // Read the file and display it line by line.  
                        System.IO.StreamReader file = new System.IO.StreamReader(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\Grammers\Song Names.txt");
                        while ((line = file.ReadLine()) != null)
                        {
                        if (e.Result.Text.ToString() == line)
                        {
                            SendKeys.Send("^l");
                            System.Threading.Thread.Sleep(300);
                            SendKeys.Send("https://www.youtube.com/results?search_query=" + voice);
                            System.Threading.Thread.Sleep(300);
                            SendKeys.Send("{Enter}");
                            System.Threading.Thread.Sleep(3000);
                            Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\first video.exe");
                        }
                            counter++;
                        }
                        file.Close();
                }

            switch (e.Result.Text.ToString())
            {
                //Search on Google  
                case "search dependency injection":
                    SendKeys.Send("^t");
                    System.Threading.Thread.Sleep(300);
                    SendKeys.Send("^l");
                    SendKeys.Send(ab);
                    SendKeys.Send("{ENTER}");
                    break;

                case "search clickjacking":
                    SendKeys.Send("^t");
                    System.Threading.Thread.Sleep(300);
                    SendKeys.Send("^l");
                    SendKeys.Send(ab);
                    SendKeys.Send("{ENTER}");
                    break;

                case "search Logic Bomb":
                    SendKeys.Send("^t");
                    System.Threading.Thread.Sleep(300);
                    SendKeys.Send("^l");
                    SendKeys.Send(ab);
                    SendKeys.Send("{ENTER}");
                    break;

                case "search united airlines":
                    SendKeys.Send("^t");
                    System.Threading.Thread.Sleep(300);
                    SendKeys.Send("^l");
                    SendKeys.Send(ab);
                    SendKeys.Send("{ENTER}");
                    break;

                case "find more on this topic":
                    Process.Start(@"C:\Users\mgmor\Desktop\Auto hot key\search highlighted text.exe");
                    break;

                //Chatting 
                case "tell me something that i don't know":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ronaldo is better.wav";
                    player.Play();
                    break;

                case "jokhon prothom dhorese koli amar mollika bone":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\jokhon prothom dhoreche koli.wav";
                    player.Play();
                    break;

                case "wonderfull":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\Thanks.wav";
                    player.Play();
                    break;

                case "how do you know":

                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\cursed with knowledge.wav";
                    player.Play();
                    break;

                case "you are too good peggyderud":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\impressive.wav";
                    player.Play();
                    break;

                case "i know how to hack facebook account":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\look at this dude.wav";
                    player.Play();
                    break;

                case "stop trolling me":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1ImReallysorry.wav";
                    player.Play();
                    break;

                case "my only curse is you":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\i can wipe you out.wav";
                    player.Play();
                    break;
                case "you can't wipe me":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\remember you.wav";
                    player.Play();
                    break;

                case "enough please":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1ImReallysorry.wav";
                    player.Play();
                    break;

                case "enough. you thanos":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\2Imreallysorry.wav";
                    player.Play();
                    break;

                //Chatting in fb
                case "i want to chat with jahidul":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Jahidul.exe");
                    break;
                case "i want to chat with tamhid":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\tamhid.exe");
                    break;

                case "say how are you":
                    SendKeys.Send("How are you?");
                    SendKeys.Send("{ENTER}");
                    break;
                case "send him the screenshot":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\send screenshot.exe");
                    break;

                case "Close chat window":
                    SendKeys.Send("{ESC}");
                    break;

                case "play":
                    SendKeys.Send(" ");
                    break;

                case "stop talking":
                    player.Stop();
                    System.Threading.Thread.Sleep(500);
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    ss.SpeakAsyncCancelAll(); break;

                case "ok stop now":
                    player.Stop();
                    System.Threading.Thread.Sleep(500);
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    ss.SpeakAsyncCancelAll(); break;

                case "take screenshot":
                    SendKeys.Send("{PRTSC}");
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\screenshot.wav";
                    player.Play();
                    break;

                case "Enable working mode":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "Yes. Enable working mode":
                    pictureBox1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox3.Visible = false;
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "disable working mode":
                    pictureBox3.Visible = false;
                    pictureBox1.Visible = false;
                    pictureBox2.Visible = true;
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "hide please":
                    this.TopMost = false;
                    this.WindowState = FormWindowState.Minimized;
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "where are you":
                    this.TopMost = true;
                    this.WindowState = FormWindowState.Normal;
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\here i am.wav";
                    player.Play();
                    break;


                //Hacking Mode
                case "Show all the saved password":
                    Process.Start(@"C:\Program Files (x86)\NirSoft\WebBrowserPassView\WebBrowserPassView.exe");
                    System.Threading.Thread.Sleep(2000);
                    SendKeys.Send("^a");
                    System.Threading.Thread.Sleep(500);
                    SendKeys.Send("^s");
                    System.Threading.Thread.Sleep(1000);
                    SendKeys.Send("savedpass.txt");
                    SendKeys.Send("{ENTER}");
                    System.Threading.Thread.Sleep(500);
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Winclose webbroswer passview.exe");
                    System.Threading.Thread.Sleep(500);
                    Process.Start(@"C:\Users\mgmor\Desktop\savedpass.txt");
                    this.WindowState = FormWindowState.Minimized;
                    break;

                //Calculator.EXE
                case "Open Calculator":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    Process.Start("calc.exe"); break;

                case "one": SendKeys.Send("1"); break;
                case "two": SendKeys.Send("2"); break;
                case "three": SendKeys.Send("3"); break;
                case "for": SendKeys.Send("4"); break;
                case "five": SendKeys.Send("5"); break;
                case "six": SendKeys.Send("6"); break;
                case "seven": SendKeys.Send("7"); break;
                case "eight": SendKeys.Send("8"); break;
                case "nine": SendKeys.Send("9"); break;
                case "zero": SendKeys.Send("0"); break;
                case "dot": SendKeys.Send("."); break;


                case "plus": SendKeys.Send("{ADD}"); break;
                case "minus": SendKeys.Send("{SUBTRACT}"); break;
                case "multiply": SendKeys.Send("{MULTIPLY}"); break;
                case "divide": SendKeys.Send("{DIVIDE}"); break;
                case "equal to": SendKeys.Send("{ENTER}"); break;

                case "Exit Calculator":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1Notaproblem.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("Calculator"))
                    {
                        process.Kill();
                    }
                    break;


                //CMD Codes
                case "open cmd":
                    Process.Start("cmd.exe");
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "exit cmd":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1Notaproblem.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("cmd"))
                    {
                        process.Kill();
                    }
                    break;

                case "clear all": SendKeys.Send("cls"); SendKeys.Send("{ENTER}"); break;
                case "show my local ip": SendKeys.Send("ipconfig"); SendKeys.Send("{ENTER}"); break;
                case "write ping": SendKeys.Send("ping"); break;
                case "space": SendKeys.Send(" "); break;
                case "hyphen": SendKeys.Send("-"); break;
                case "type t": SendKeys.Send("t"); break;
                case "press enter": SendKeys.Send("{ENTER}"); break;

                //Opening softwares
                case "Open gimp":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    Process.Start(@"C:\Program Files\GIMP 2\bin\gimp-2.10.exe"); break;
                case "New image": SendKeys.Send("^o"); break;
                case "open image one":
                    for (int i = 0; i < 7; i++)
                    {
                        SendKeys.Send("{TAB}");
                    }
                    SendKeys.Send("{DOWN}");
                    System.Threading.Thread.Sleep(1000);
                    SendKeys.Send("{ENTER}");
                    break;
                case "make this image black and white":
                    SendKeys.Send("%c");
                    for (int i = 0; i < 15; i++)
                    {
                        SendKeys.Send("{DOWN}");
                    }
                    SendKeys.Send("{RIGHT}");
                    System.Threading.Thread.Sleep(1000);
                    SendKeys.Send("d");
                    for (int j = 0; j < 6; j++)
                    {
                        SendKeys.Send("{TAB}");
                    }
                    SendKeys.Send("{ENTER}");
                    break;
                case "save this image":
                    SendKeys.Send("^+e");
                    System.Threading.Thread.Sleep(1000);
                    SendKeys.Send("{TAB}");
                    System.Threading.Thread.Sleep(500);
                    SendKeys.Send("{TAB}");
                    System.Threading.Thread.Sleep(1000);
                    SendKeys.Send("{ENTER}");
                    System.Threading.Thread.Sleep(2000);
                    SendKeys.Send("{ENTER}");
                    break;

                case "Exit Gimp":
                    SendKeys.Send("^q");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{TAB}");
                    SendKeys.Send("{ENTER}");
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1Notaproblem.wav";
                    player.Play();
                    break;



                case "open microsoft paint":
                    Process.Start("mspaint.exe");
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;

                case "connect VPN":
                    this.WindowState = FormWindowState.Minimized;
                    System.Threading.Thread.Sleep(1000);
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Connect VPN.exe");
                    break;

                case "Disconnect VPN and close":
                    this.WindowState = FormWindowState.Minimized;
                    System.Threading.Thread.Sleep(1000);
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Connect VPN.exe");
                    break;

                case "exit paint":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1Notaproblem.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("mspaint.exe"))
                    {
                        process.Kill();
                    }
                    break;

                //Code For Chrome

                case "open new tab": SendKeys.Send("^t"); break;
                case "Open Google Chrome":
                    Process.Start("chrome");
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    break;


                case "Open Youtube": 
                    Process.Start("chrome", "http://www.Youtube.com"); 
                    break;
                case "Search on youtube":
                    for (int i = 0; i < 4; i++)
                    {
                        SendKeys.Send("{TAB}");
                    }
                    break;


                case "go to face book":
                    Process.Start("chrome", "http://www.Facebook.com"); break;
                case "login to my account":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Login to fb.exe");
                    break;


                case "logout from my account": SendKeys.Send("^+{DELETE}"); SendKeys.Send("{Enter}"); SendKeys.Send("^w"); break;
                case "close current tab": SendKeys.Send("^w"); break;
                case "open incognito": SendKeys.Send("^+n"); break;
                case "go to page one": SendKeys.Send("^1"); break;
                case "go to page two": SendKeys.Send("^2"); break;
                case "go to page three": SendKeys.Send("^3"); break;
                case "go to page four": SendKeys.Send("^4"); break;
                case "go to page five": SendKeys.Send("^5"); break;
                case "next tab": SendKeys.Send("^2"); break;
                case "open the last closed tab": SendKeys.Send("^+t"); break;

                case "open the first video":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\first video.exe");
                    break;
                case "open the second video":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\second video.exe");
                    break;
                case "open the third video":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\third video.exe");
                    break;
                case "open the fourth video":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\fourth video.exe");
                    break;
                case "open the fifth video":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\fifth video.exe");
                    break;

                case "forward": SendKeys.Send("{RIGHT}"); break;
                case "forward more": SendKeys.Send("{RIGHT}"); SendKeys.Send("{RIGHT}"); SendKeys.Send("{RIGHT}"); SendKeys.Send("{RIGHT}"); SendKeys.Send("{RIGHT}"); break;
                case "backward": SendKeys.Send("{LEFT}"); break;
                case "backward more": SendKeys.Send("{LEFT}"); SendKeys.Send("{LEFT}"); SendKeys.Send("{LEFT}"); SendKeys.Send("{LEFT}"); SendKeys.Send("{LEFT}"); SendKeys.Send("{LEFT}"); break;
                case "increase sound": SendKeys.Send("{UP}"); break;
                case "increase sound more": SendKeys.Send("{UP}"); SendKeys.Send("{UP}"); SendKeys.Send("{UP}"); SendKeys.Send("{UP}"); SendKeys.Send("{UP}"); SendKeys.Send("{UP}"); break;
                case "decrease sound": SendKeys.Send("{DOWN}"); break;
                case "decrease sound more": SendKeys.Send("{DOWN}"); SendKeys.Send("{DOWN}"); SendKeys.Send("{DOWN}"); SendKeys.Send("{DOWN}"); SendKeys.Send("{DOWN}"); SendKeys.Send("{DOWN}"); break;

                case "full screen":
                    this.WindowState = FormWindowState.Minimized;
                    SendKeys.Send("f");
                    break;
                case "normal screen":
                    SendKeys.Send("f");
                    break;

                case "Exit Chrome":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("chrome"))
                    {
                        process.Kill();
                    }
                    break;


                //Songs to search in chrome


                case "i want a kiss":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\kiss.wav";
                    player.Play();
                    break;

                case "hug me":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\no.wav";
                    player.Play();
                    break;

                case "can you sing like eminem":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\rap god female.wav";
                    player.Play();
                    break;

                case "i'm so sorry":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\2Notaproblem.wav";
                    player.Play();
                    break;

                case "thank you":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\1Notaproblem.wav";
                    player.Play();
                    break;

                case "How Are You":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\i'm fine.wav";
                    player.Play();
                    break;

                case "Open Notepad":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    Process.Start("notepad");
                    break;

                case "Exit Notepad":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("notepad"))
                    {
                        process.Kill();
                    }
                    break;

                case "exit pot player":
                    player.Stop();
                    player.SoundLocation = @"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\wav files\ok.wav";
                    player.Play();
                    foreach (var process in Process.GetProcessesByName("PotPlayerMini64"))
                    {
                        process.Kill();
                    }
                    break;

                //Search on youtube
                case "Castle of glass":
                    SendKeys.Send("Castle of glass");
                    SendKeys.Send("{ENTER}");
                    break;
                case "A gift of love":
                    SendKeys.Send("A gift of love");
                    SendKeys.Send("{ENTER}");
                    break;
                case "Levinho":
                    SendKeys.Send("Castle of glass");
                    SendKeys.Send("{ENTER}");
                    break;
                case "cry me a river":
                    SendKeys.Send("cry me a river");
                    SendKeys.Send("{ENTER}");
                    break;

                case "on my way":
                    SendKeys.Send("on my way");
                    SendKeys.Send("{ENTER}");
                    break;

                case "mans not hot":
                    SendKeys.Send("mans not hot");
                    SendKeys.Send("{ENTER}");
                    break;

                //Facebook Messages
                case "Say Hi":
                    SendKeys.Send("Hi");
                    break;

                //Speedtest
                case "Check my internet speed":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\fast.com.exe");
                    break;
                case "Download this video as mp3":
                    Process.Start(@"C:\Users\mgmor\OneDrive\My Projects\Peggyderud\auto hot key scripts\Download mp3.exe");
                    break;


                case "you can sleep now peggyderud": Application.Exit(); break;
            }         

        }

        private void Label1_Click(object sender, EventArgs e)
        {   

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

            panel2.Left += 2;
            if (panel2.Left > 450)
            {
                panel2.Left = -50;
            }


        }


        private void Panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            panel4.Left += 2;
            if (panel4.Left > 450)
            {
                panel4.Left = -50;
            }
        }

        private void BunifuFlatButton1_Click(object sender, EventArgs e)
        {
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            panel6.Top += 2;
            if (panel6.Top > 450)
            {
                panel6.Top = -50;
            }
        }

        private void Timer4_Tick(object sender, EventArgs e)
        {

            panel8.Top += 2;
            if (panel8.Top > 450)
            {
                panel8.Top = -50;
            }
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
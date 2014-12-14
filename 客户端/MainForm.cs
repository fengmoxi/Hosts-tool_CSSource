using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 代理服务器配置工具
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private string url;

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog();
            objSave.Filter = "hosts文件|hosts";
            objSave.FileName = "hosts";
            if (objSave.ShowDialog() == DialogResult.OK)
            {
                if (radioButton1.Checked)
                {
                    url = "http://hosts.fengmx.com/";
                }
                if (radioButton2.Checked)
                {
                    url = "http://fengmoxi.0fees.us/hosts-tool/";
                }
                if (radioButton3.Checked)
                {
                    url = "https://raw.githubusercontent.com/fengmoxi/hosts-tool-source/master/";
                }
                if (radioButton4.Checked)
                {
                    url = "https://gitcafe.com/fengmoxi/hosts-tool-source/raw/master/";
                }
                if (radioButton5.Checked)
                {
                    url = "https://coding.net/u/fengmoxi/p/hosts-tool/git/raw/master/";
                }
                MessageBox.Show("根据网络状况，这可能需要2~3分钟等待成功提示框，请不要关闭本程序\r\n若长时间无响应，请选择其他服务器\r\n注意，机械硬盘可能需要更久的时间","温馨提示");
                WebRequest myRequest = WebRequest.Create(url+"Data.xml");
                WebResponse myResponse = myRequest.GetResponse();
                Stream stream = myResponse.GetResponseStream();
                XmlDocument data = new XmlDocument();
                data.Load(stream);
                    using (StreamWriter objWriter = new StreamWriter(objSave.FileName, false, System.Text.Encoding.UTF8))
                    {
                        objWriter.WriteLine("#        __        __");
                        objWriter.WriteLine("#       /  \\      /  \\");
                        objWriter.WriteLine("#       |  |      |  |");
                        objWriter.WriteLine("#       |  |      |  |                              __");
                        objWriter.WriteLine("#       |  |______|  |   ________    ________    __|  |__    ________");
                        objWriter.WriteLine("#       |   ______   |  /   __   \\  /   _____|  |__    __|  /   _____|");
                        objWriter.WriteLine("#       |  |      |  |  |  /  \\  |  |  |_____      |  |     |  |_____");
                        objWriter.WriteLine("#       |  |      |  |  |  |  |  |  \\_____   \\     |  |     \\_____   \\");
                        objWriter.WriteLine("#       |  |      |  |  |  \\__/  |   _____|  |     |  |__    _____|  |");
                        objWriter.WriteLine("#       \\__/      \\__/  \\________/  |________/     \\_____|  |________/");
                        objWriter.WriteLine("#       ");
                        objWriter.WriteLine("#       ");
                        objWriter.WriteLine("# Copyright (c) 2013-2014 fengmx.");
                        objWriter.WriteLine("# Created by fengmx.com");
                        objWriter.WriteLine("# Generated time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                        objWriter.WriteLine("# Thanks for using.");
                        objWriter.WriteLine("# If you hava any problem please contact me by E-mail:admin@fengmx.com");
                        objWriter.WriteLine("# Special thanks to: huhamhire-hosts team.");
                        objWriter.WriteLine("#" + "".PadRight(79, '-'));
                        objWriter.WriteLine("# Since the governments of some countries are using technical methods blocking");
                        objWriter.WriteLine("# internet access to some websites and web service providers which includes");
                        objWriter.WriteLine("# some world famous sites like Google, YouTube, twitter, Facebook, and");
                        objWriter.WriteLine("# Wikipedia etc., we designed this tiny utility in order to help people");
                        objWriter.WriteLine("# getting through the Internet blockade.");
                        objWriter.WriteLine("# This file contains the mappings of IP addresses to host names. Each entry");
                        objWriter.WriteLine("# should be kept on an individual line. The IP address should be placed in");
                        objWriter.WriteLine("# the first column followed by the corresponding host name.");
                        objWriter.WriteLine("# The IP address and the host name should be separated by at least one space.");
                        objWriter.WriteLine("# comments (such as these) may be inserted on individual");
                        objWriter.WriteLine("# lines or following the machine name denoted by a '#' symbol.");
                        objWriter.WriteLine("# For example:");
                        objWriter.WriteLine("#      0.0.0.0     www.xxx.com          # xxx server");
                        objWriter.WriteLine("# localhost name resolution is handled within DNS itself.");
                        //输入localhost
                        objWriter.WriteLine("127.0.0.1     localhost");
                        objWriter.WriteLine("#" + "".PadRight(79, '-'));
                        objWriter.WriteLine("# Section Start:");
                        if (checkBox1.Checked)
                        {
                            WebRequest ActivationmyRequest = WebRequest.Create(url + "Activation.xml");
                            WebResponse ActivationmyResponse = ActivationmyRequest.GetResponse();
                            Stream Activationstream = ActivationmyResponse.GetResponseStream();
                            XmlDocument Activation = new XmlDocument();
                            Activation.Load(Activationstream);
                            for(int i=1;i<int.Parse(data.SelectSingleNode("Data/MAXUID/Activation").InnerXml);i++)
                            {
                                objWriter.WriteLine(Activation.SelectSingleNode("Activation/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Activation.SelectSingleNode("Activation/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox2.Checked)
                        {
                            WebRequest ApplemyRequest = WebRequest.Create(url + "Apple.xml");
                            WebResponse ApplemyResponse = ApplemyRequest.GetResponse();
                            Stream Applestream = ApplemyResponse.GetResponseStream();
                            XmlDocument Apple = new XmlDocument();
                            Apple.Load(Applestream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Apple").InnerXml); i++)
                            {
                                objWriter.WriteLine(Apple.SelectSingleNode("Apple/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Apple.SelectSingleNode("Apple/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox3.Checked)
                        {
                            WebRequest GoogleWebmyRequest = WebRequest.Create(url + "GoogleWeb.xml");
                            WebResponse GoogleWebmyResponse = GoogleWebmyRequest.GetResponse();
                            Stream GoogleWebstream = GoogleWebmyResponse.GetResponseStream();
                            XmlDocument GoogleWeb = new XmlDocument();
                            GoogleWeb.Load(GoogleWebstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml); i++)
                            {
                                objWriter.WriteLine(GoogleWeb.SelectSingleNode("GoogleWeb/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + GoogleWeb.SelectSingleNode("GoogleWeb/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox4.Checked)
                        {
                            WebRequest GoogleApismyRequest = WebRequest.Create(url + "GoogleApis.xml");
                            WebResponse GoogleApismyResponse = GoogleApismyRequest.GetResponse();
                            Stream GoogleApisstream = GoogleApismyResponse.GetResponseStream();
                            XmlDocument GoogleApis = new XmlDocument();
                            GoogleApis.Load(GoogleApisstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml); i++)
                            {
                                objWriter.WriteLine(GoogleApis.SelectSingleNode("GoogleApis/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + GoogleApis.SelectSingleNode("GoogleApis/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox5.Checked)
                        {
                            WebRequest FacebookmyRequest = WebRequest.Create(url + "Facebook.xml");
                            WebResponse FacebookmyResponse = FacebookmyRequest.GetResponse();
                            Stream Facebookstream = FacebookmyResponse.GetResponseStream();
                            XmlDocument Facebook = new XmlDocument();
                            Facebook.Load(Facebookstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Facebook").InnerXml); i++)
                            {
                                objWriter.WriteLine(Facebook.SelectSingleNode("Facebook/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Facebook.SelectSingleNode("Facebook/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox6.Checked)
                        {
                            WebRequest TwittermyRequest = WebRequest.Create(url + "Twitter.xml");
                            WebResponse TwittermyResponse = TwittermyRequest.GetResponse();
                            Stream Twitterstream = TwittermyResponse.GetResponseStream();
                            XmlDocument Twitter = new XmlDocument();
                            Twitter.Load(Twitterstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Twitter").InnerXml); i++)
                            {
                                objWriter.WriteLine(Twitter.SelectSingleNode("Twitter/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Twitter.SelectSingleNode("Twitter/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox7.Checked)
                        {
                            WebRequest YoutubemyRequest = WebRequest.Create(url + "Youtube.xml");
                            WebResponse YoutubemyResponse = YoutubemyRequest.GetResponse();
                            Stream Youtubestream = YoutubemyResponse.GetResponseStream();
                            XmlDocument Youtube = new XmlDocument();
                            Youtube.Load(Youtubestream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Youtube").InnerXml); i++)
                            {
                                objWriter.WriteLine(Youtube.SelectSingleNode("Youtube/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Youtube.SelectSingleNode("Youtube/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox8.Checked)
                        {
                            WebRequest WikimyRequest = WebRequest.Create(url + "Wiki.xml");
                            WebResponse WikimyResponse = WikimyRequest.GetResponse();
                            Stream Wikistream = WikimyResponse.GetResponseStream();
                            XmlDocument Wiki = new XmlDocument();
                            Wiki.Load(Wikistream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Wiki").InnerXml); i++)
                            {
                                objWriter.WriteLine(Wiki.SelectSingleNode("Wiki/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Wiki.SelectSingleNode("Wiki/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox9.Checked)
                        {
                            WebRequest SteammyRequest = WebRequest.Create(url + "Steam.xml");
                            WebResponse SteammyResponse = SteammyRequest.GetResponse();
                            Stream Steamstream = SteammyResponse.GetResponseStream();
                            XmlDocument Steam = new XmlDocument();
                            Steam.Load(Steamstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Steam").InnerXml); i++)
                            {
                                objWriter.WriteLine(Steam.SelectSingleNode("Steam/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Steam.SelectSingleNode("Steam/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox10.Checked)
                        {
                            WebRequest FlickrmyRequest = WebRequest.Create(url + "Flickr.xml");
                            WebResponse FlickrmyResponse = FlickrmyRequest.GetResponse();
                            Stream Flickrstream = FlickrmyResponse.GetResponseStream();
                            XmlDocument Flickr = new XmlDocument();
                            Flickr.Load(Flickrstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Flickr").InnerXml); i++)
                            {
                                objWriter.WriteLine(Flickr.SelectSingleNode("Flickr/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Flickr.SelectSingleNode("Flickr/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox11.Checked)
                        {
                            WebRequest GithubmyRequest = WebRequest.Create(url + "Github.xml");
                            WebResponse GithubmyResponse = GithubmyRequest.GetResponse();
                            Stream Githubstream = GithubmyResponse.GetResponseStream();
                            XmlDocument Github = new XmlDocument();
                            Github.Load(Githubstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Github").InnerXml); i++)
                            {
                                objWriter.WriteLine(Github.SelectSingleNode("Github/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Github.SelectSingleNode("Github/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox12.Checked)
                        {
                            WebRequest DropboxmyRequest = WebRequest.Create(url + "Dropbox.xml");
                            WebResponse DropboxmyResponse = DropboxmyRequest.GetResponse();
                            Stream Dropboxstream = DropboxmyResponse.GetResponseStream();
                            XmlDocument Dropbox = new XmlDocument();
                            Dropbox.Load(Dropboxstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml); i++)
                            {
                                objWriter.WriteLine(Dropbox.SelectSingleNode("Dropbox/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Dropbox.SelectSingleNode("Dropbox/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox13.Checked)
                        {
                            WebRequest OnedrivemyRequest = WebRequest.Create(url + "Onedrive.xml");
                            WebResponse OnedrivemyResponse = OnedrivemyRequest.GetResponse();
                            Stream Onedrivestream = OnedrivemyResponse.GetResponseStream();
                            XmlDocument Onedrive = new XmlDocument();
                            Onedrive.Load(Onedrivestream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml); i++)
                            {
                                objWriter.WriteLine(Onedrive.SelectSingleNode("Onedrive/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Onedrive.SelectSingleNode("Onedrive/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox14.Checked)
                        {
                            WebRequest WordPressmyRequest = WebRequest.Create(url + "WordPress.xml");
                            WebResponse WordPressmyResponse = WordPressmyRequest.GetResponse();
                            Stream WordPressstream = WordPressmyResponse.GetResponseStream();
                            XmlDocument WordPress = new XmlDocument();
                            WordPress.Load(WordPressstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/WordPress").InnerXml); i++)
                            {
                                objWriter.WriteLine(WordPress.SelectSingleNode("WordPress/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + WordPress.SelectSingleNode("WordPress/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox15.Checked)
                        {
                            WebRequest OthermyRequest = WebRequest.Create(url + "Other.xml");
                            WebResponse OthermyResponse = OthermyRequest.GetResponse();
                            Stream Otherstream = OthermyResponse.GetResponseStream();
                            XmlDocument Other = new XmlDocument();
                            Other.Load(Otherstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Other").InnerXml); i++)
                            {
                                objWriter.WriteLine(Other.SelectSingleNode("Other/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Other.SelectSingleNode("Other/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox16.Checked)
                        {
                            WebRequest hostsxmyRequest = WebRequest.Create(url + "hostsx.xml");
                            WebResponse hostsxmyResponse = hostsxmyRequest.GetResponse();
                            Stream hostsxstream = hostsxmyResponse.GetResponseStream();
                            XmlDocument hostsx = new XmlDocument();
                            hostsx.Load(hostsxstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/hostsx").InnerXml); i++)
                            {
                                objWriter.WriteLine(hostsx.SelectSingleNode("hostsx/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + hostsx.SelectSingleNode("hostsx/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        if (checkBox17.Checked)
                        {
                            WebRequest mvpsmyRequest = WebRequest.Create(url + "mvps.xml");
                            WebResponse mvpsmyResponse = mvpsmyRequest.GetResponse();
                            Stream mvpsstream = mvpsmyResponse.GetResponseStream();
                            XmlDocument mvps = new XmlDocument();
                            mvps.Load(mvpsstream);
                            for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/mvps").InnerXml); i++)
                            {
                                objWriter.WriteLine(mvps.SelectSingleNode("mvps/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + mvps.SelectSingleNode("mvps/UID-" + i + "/domain").InnerXml);
                            }
                        }
                        objWriter.WriteLine("# Section End.");
                        MessageBox.Show("文件已输出成功！\r\n文件路径：" + objSave.FileName+"\n\r若杀软提示hosts劫持等，请信任或放行", "温馨提示");
                    }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            checkBox2.Checked = true;
            checkBox3.Checked = true;
            checkBox4.Checked = true;
            checkBox5.Checked = true;
            checkBox6.Checked = true;
            checkBox7.Checked = true;
            checkBox8.Checked = true;
            checkBox9.Checked = true;
            checkBox10.Checked = true;
            checkBox11.Checked = true;
            checkBox12.Checked = true;
            checkBox13.Checked = true;
            checkBox14.Checked = true;
            checkBox15.Checked = true;
            checkBox16.Checked = true;
            checkBox17.Checked = true;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                checkBox1.Checked = false;
            }
            else
            {
                checkBox1.Checked = true;
            }
            if (checkBox2.Checked)
            {
                checkBox2.Checked = false;
            }
            else
            {
                checkBox2.Checked = true;
            }
            if (checkBox3.Checked)
            {
                checkBox3.Checked = false;
            }
            else
            {
                checkBox3.Checked = true;
            }
            if (checkBox4.Checked)
            {
                checkBox4.Checked = false;
            }
            else
            {
                checkBox4.Checked = true;
            }
            if (checkBox5.Checked)
            {
                checkBox5.Checked = false;
            }
            else
            {
                checkBox5.Checked = true;
            }
            if (checkBox6.Checked)
            {
                checkBox6.Checked = false;
            }
            else
            {
                checkBox6.Checked = true;
            }
            if (checkBox7.Checked)
            {
                checkBox7.Checked = false;
            }
            else
            {
                checkBox7.Checked = true;
            }
            if (checkBox8.Checked)
            {
                checkBox8.Checked = false;
            }
            else
            {
                checkBox8.Checked = true;
            }
            if (checkBox9.Checked)
            {
                checkBox9.Checked = false;
            }
            else
            {
                checkBox9.Checked = true;
            }
            if (checkBox10.Checked)
            {
                checkBox10.Checked = false;
            }
            else
            {
                checkBox10.Checked = true;
            }
            if (checkBox11.Checked)
            {
                checkBox11.Checked = false;
            }
            else
            {
                checkBox11.Checked = true;
            }
            if (checkBox12.Checked)
            {
                checkBox12.Checked = false;
            }
            else
            {
                checkBox12.Checked = true;
            }
            if (checkBox13.Checked)
            {
                checkBox13.Checked = false;
            }
            else
            {
                checkBox13.Checked = true;
            }
            if (checkBox14.Checked)
            {
                checkBox14.Checked = false;
            }
            else
            {
                checkBox14.Checked = true;
            }
            if (checkBox15.Checked)
            {
                checkBox15.Checked = false;
            }
            else
            {
                checkBox15.Checked = true;
            }
            if (checkBox16.Checked)
            {
                checkBox16.Checked = false;
            }
            else
            {
                checkBox16.Checked = true;
            }
            if (checkBox17.Checked)
            {
                checkBox17.Checked = false;
            }
            else
            {
                checkBox17.Checked = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
                {
                    url = "http://hosts.fengmx.com/";
                }
                if (radioButton2.Checked)
                {
                    url = "http://fengmoxi.0fees.us/hosts-tool/";
                }
                if (radioButton3.Checked)
                {
                    url = "https://raw.githubusercontent.com/fengmoxi/hosts-tool-source/master/";
                }
                if (radioButton4.Checked)
                {
                    url = "https://gitcafe.com/fengmoxi/hosts-tool-source/raw/master/";
                }
                if (radioButton5.Checked)
                {
                    url = "https://coding.net/u/fengmoxi/p/hosts-tool/git/raw/master/";
                }
                MessageBox.Show("根据网络状况，这可能需要2~3分钟等待成功提示框，请不要关闭本程序\r\n若长时间无响应，请选择其他服务器\r\n注意，机械硬盘可能需要更久的时间","温馨提示");
                WebRequest myRequest = WebRequest.Create(url+"Data.xml");
                WebResponse myResponse = myRequest.GetResponse();
                Stream stream = myResponse.GetResponseStream();
                XmlDocument data = new XmlDocument();
                data.Load(stream);
                using (StreamWriter objWriter = new StreamWriter("C:\\Windows\\System32\\drivers\\etc\\hosts", false, System.Text.Encoding.UTF8))
                {
                    objWriter.WriteLine("#        __        __");
                    objWriter.WriteLine("#       /  \\      /  \\");
                    objWriter.WriteLine("#       |  |      |  |");
                    objWriter.WriteLine("#       |  |      |  |                              __");
                    objWriter.WriteLine("#       |  |______|  |   ________    ________    __|  |__    ________");
                    objWriter.WriteLine("#       |   ______   |  /   __   \\  /   _____|  |__    __|  /   _____|");
                    objWriter.WriteLine("#       |  |      |  |  |  /  \\  |  |  |_____      |  |     |  |_____");
                    objWriter.WriteLine("#       |  |      |  |  |  |  |  |  \\_____   \\     |  |     \\_____   \\");
                    objWriter.WriteLine("#       |  |      |  |  |  \\__/  |   _____|  |     |  |__    _____|  |");
                    objWriter.WriteLine("#       \\__/      \\__/  \\________/  |________/     \\_____|  |________/");
                    objWriter.WriteLine("#       ");
                    objWriter.WriteLine("#       ");
                    objWriter.WriteLine("# Copyright (c) 2013-2014 fengmx.");
                    objWriter.WriteLine("# Created by fengmx.com");
                    objWriter.WriteLine("# Generated time: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                    objWriter.WriteLine("# Thanks for using.");
                    objWriter.WriteLine("# If you hava any problem please contact me by E-mail:admin@fengmx.com");
                    objWriter.WriteLine("# Special thanks to: huhamhire-hosts team.");
                    objWriter.WriteLine("#" + "".PadRight(79, '-'));
                    objWriter.WriteLine("# Since the governments of some countries are using technical methods blocking");
                    objWriter.WriteLine("# internet access to some websites and web service providers which includes");
                    objWriter.WriteLine("# some world famous sites like Google, YouTube, twitter, Facebook, and");
                    objWriter.WriteLine("# Wikipedia etc., we designed this tiny utility in order to help people");
                    objWriter.WriteLine("# getting through the Internet blockade.");
                    objWriter.WriteLine("# This file contains the mappings of IP addresses to host names. Each entry");
                    objWriter.WriteLine("# should be kept on an individual line. The IP address should be placed in");
                    objWriter.WriteLine("# the first column followed by the corresponding host name.");
                    objWriter.WriteLine("# The IP address and the host name should be separated by at least one space.");
                    objWriter.WriteLine("# comments (such as these) may be inserted on individual");
                    objWriter.WriteLine("# lines or following the machine name denoted by a '#' symbol.");
                    objWriter.WriteLine("# For example:");
                    objWriter.WriteLine("#      0.0.0.0     www.xxx.com          # xxx server");
                    objWriter.WriteLine("# localhost name resolution is handled within DNS itself.");
                    //输入localhost
                    objWriter.WriteLine("127.0.0.1     localhost");
                    objWriter.WriteLine("#" + "".PadRight(79, '-'));
                    objWriter.WriteLine("# Section Start:");
                    if (checkBox1.Checked)
                    {
                        WebRequest ActivationmyRequest = WebRequest.Create(url + "Activation.xml");
                        WebResponse ActivationmyResponse = ActivationmyRequest.GetResponse();
                        Stream Activationstream = ActivationmyResponse.GetResponseStream();
                        XmlDocument Activation = new XmlDocument();
                        Activation.Load(Activationstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Activation").InnerXml); i++)
                        {
                            objWriter.WriteLine(Activation.SelectSingleNode("Activation/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Activation.SelectSingleNode("Activation/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox2.Checked)
                    {
                        WebRequest ApplemyRequest = WebRequest.Create(url + "Apple.xml");
                        WebResponse ApplemyResponse = ApplemyRequest.GetResponse();
                        Stream Applestream = ApplemyResponse.GetResponseStream();
                        XmlDocument Apple = new XmlDocument();
                        Apple.Load(Applestream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Apple").InnerXml); i++)
                        {
                            objWriter.WriteLine(Apple.SelectSingleNode("Apple/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Apple.SelectSingleNode("Apple/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox3.Checked)
                    {
                        WebRequest GoogleWebmyRequest = WebRequest.Create(url + "GoogleWeb.xml");
                        WebResponse GoogleWebmyResponse = GoogleWebmyRequest.GetResponse();
                        Stream GoogleWebstream = GoogleWebmyResponse.GetResponseStream();
                        XmlDocument GoogleWeb = new XmlDocument();
                        GoogleWeb.Load(GoogleWebstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml); i++)
                        {
                            objWriter.WriteLine(GoogleWeb.SelectSingleNode("GoogleWeb/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + GoogleWeb.SelectSingleNode("GoogleWeb/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox4.Checked)
                    {
                        WebRequest GoogleApismyRequest = WebRequest.Create(url + "GoogleApis.xml");
                        WebResponse GoogleApismyResponse = GoogleApismyRequest.GetResponse();
                        Stream GoogleApisstream = GoogleApismyResponse.GetResponseStream();
                        XmlDocument GoogleApis = new XmlDocument();
                        GoogleApis.Load(GoogleApisstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml); i++)
                        {
                            objWriter.WriteLine(GoogleApis.SelectSingleNode("GoogleApis/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + GoogleApis.SelectSingleNode("GoogleApis/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox5.Checked)
                    {
                        WebRequest FacebookmyRequest = WebRequest.Create(url + "Facebook.xml");
                        WebResponse FacebookmyResponse = FacebookmyRequest.GetResponse();
                        Stream Facebookstream = FacebookmyResponse.GetResponseStream();
                        XmlDocument Facebook = new XmlDocument();
                        Facebook.Load(Facebookstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Facebook").InnerXml); i++)
                        {
                            objWriter.WriteLine(Facebook.SelectSingleNode("Facebook/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Facebook.SelectSingleNode("Facebook/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox6.Checked)
                    {
                        WebRequest TwittermyRequest = WebRequest.Create(url + "Twitter.xml");
                        WebResponse TwittermyResponse = TwittermyRequest.GetResponse();
                        Stream Twitterstream = TwittermyResponse.GetResponseStream();
                        XmlDocument Twitter = new XmlDocument();
                        Twitter.Load(Twitterstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Twitter").InnerXml); i++)
                        {
                            objWriter.WriteLine(Twitter.SelectSingleNode("Twitter/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Twitter.SelectSingleNode("Twitter/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox7.Checked)
                    {
                        WebRequest YoutubemyRequest = WebRequest.Create(url + "Youtube.xml");
                        WebResponse YoutubemyResponse = YoutubemyRequest.GetResponse();
                        Stream Youtubestream = YoutubemyResponse.GetResponseStream();
                        XmlDocument Youtube = new XmlDocument();
                        Youtube.Load(Youtubestream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Youtube").InnerXml); i++)
                        {
                            objWriter.WriteLine(Youtube.SelectSingleNode("Youtube/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Youtube.SelectSingleNode("Youtube/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox8.Checked)
                    {
                        WebRequest WikimyRequest = WebRequest.Create(url + "Wiki.xml");
                        WebResponse WikimyResponse = WikimyRequest.GetResponse();
                        Stream Wikistream = WikimyResponse.GetResponseStream();
                        XmlDocument Wiki = new XmlDocument();
                        Wiki.Load(Wikistream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Wiki").InnerXml); i++)
                        {
                            objWriter.WriteLine(Wiki.SelectSingleNode("Wiki/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Wiki.SelectSingleNode("Wiki/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox9.Checked)
                    {
                        WebRequest SteammyRequest = WebRequest.Create(url + "Steam.xml");
                        WebResponse SteammyResponse = SteammyRequest.GetResponse();
                        Stream Steamstream = SteammyResponse.GetResponseStream();
                        XmlDocument Steam = new XmlDocument();
                        Steam.Load(Steamstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Steam").InnerXml); i++)
                        {
                            objWriter.WriteLine(Steam.SelectSingleNode("Steam/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Steam.SelectSingleNode("Steam/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox10.Checked)
                    {
                        WebRequest FlickrmyRequest = WebRequest.Create(url + "Flickr.xml");
                        WebResponse FlickrmyResponse = FlickrmyRequest.GetResponse();
                        Stream Flickrstream = FlickrmyResponse.GetResponseStream();
                        XmlDocument Flickr = new XmlDocument();
                        Flickr.Load(Flickrstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Flickr").InnerXml); i++)
                        {
                            objWriter.WriteLine(Flickr.SelectSingleNode("Flickr/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Flickr.SelectSingleNode("Flickr/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox11.Checked)
                    {
                        WebRequest GithubmyRequest = WebRequest.Create(url + "Github.xml");
                        WebResponse GithubmyResponse = GithubmyRequest.GetResponse();
                        Stream Githubstream = GithubmyResponse.GetResponseStream();
                        XmlDocument Github = new XmlDocument();
                        Github.Load(Githubstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Github").InnerXml); i++)
                        {
                            objWriter.WriteLine(Github.SelectSingleNode("Github/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Github.SelectSingleNode("Github/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox12.Checked)
                    {
                        WebRequest DropboxmyRequest = WebRequest.Create(url + "Dropbox.xml");
                        WebResponse DropboxmyResponse = DropboxmyRequest.GetResponse();
                        Stream Dropboxstream = DropboxmyResponse.GetResponseStream();
                        XmlDocument Dropbox = new XmlDocument();
                        Dropbox.Load(Dropboxstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml); i++)
                        {
                            objWriter.WriteLine(Dropbox.SelectSingleNode("Dropbox/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Dropbox.SelectSingleNode("Dropbox/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox13.Checked)
                    {
                        WebRequest OnedrivemyRequest = WebRequest.Create(url + "Onedrive.xml");
                        WebResponse OnedrivemyResponse = OnedrivemyRequest.GetResponse();
                        Stream Onedrivestream = OnedrivemyResponse.GetResponseStream();
                        XmlDocument Onedrive = new XmlDocument();
                        Onedrive.Load(Onedrivestream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml); i++)
                        {
                            objWriter.WriteLine(Onedrive.SelectSingleNode("Onedrive/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Onedrive.SelectSingleNode("Onedrive/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox14.Checked)
                    {
                        WebRequest WordPressmyRequest = WebRequest.Create(url + "WordPress.xml");
                        WebResponse WordPressmyResponse = WordPressmyRequest.GetResponse();
                        Stream WordPressstream = WordPressmyResponse.GetResponseStream();
                        XmlDocument WordPress = new XmlDocument();
                        WordPress.Load(WordPressstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/WordPress").InnerXml); i++)
                        {
                            objWriter.WriteLine(WordPress.SelectSingleNode("WordPress/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + WordPress.SelectSingleNode("WordPress/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox15.Checked)
                    {
                        WebRequest OthermyRequest = WebRequest.Create(url + "Other.xml");
                        WebResponse OthermyResponse = OthermyRequest.GetResponse();
                        Stream Otherstream = OthermyResponse.GetResponseStream();
                        XmlDocument Other = new XmlDocument();
                        Other.Load(Otherstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/Other").InnerXml); i++)
                        {
                            objWriter.WriteLine(Other.SelectSingleNode("Other/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + Other.SelectSingleNode("Other/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox16.Checked)
                    {
                        WebRequest hostsxmyRequest = WebRequest.Create(url + "hostsx.xml");
                        WebResponse hostsxmyResponse = hostsxmyRequest.GetResponse();
                        Stream hostsxstream = hostsxmyResponse.GetResponseStream();
                        XmlDocument hostsx = new XmlDocument();
                        hostsx.Load(hostsxstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/hostsx").InnerXml); i++)
                        {
                            objWriter.WriteLine(hostsx.SelectSingleNode("hostsx/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + hostsx.SelectSingleNode("hostsx/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    if (checkBox17.Checked)
                    {
                        WebRequest mvpsmyRequest = WebRequest.Create(url + "mvps.xml");
                        WebResponse mvpsmyResponse = mvpsmyRequest.GetResponse();
                        Stream mvpsstream = mvpsmyResponse.GetResponseStream();
                        XmlDocument mvps = new XmlDocument();
                        mvps.Load(mvpsstream);
                        for (int i = 1; i < int.Parse(data.SelectSingleNode("Data/MAXUID/mvps").InnerXml); i++)
                        {
                            objWriter.WriteLine(mvps.SelectSingleNode("mvps/UID-" + i + "/ip").InnerXml + "".PadRight(5, ' ') + mvps.SelectSingleNode("mvps/UID-" + i + "/domain").InnerXml);
                        }
                    }
                    objWriter.WriteLine("# Section End.");
                    MessageBox.Show("hosts已成功写入系统！\n\r若杀软提示hosts劫持等，请信任或放行", "温馨提示");
                }
        }
    }
}

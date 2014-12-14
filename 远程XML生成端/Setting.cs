using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace 远程XML生成端
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }
        private void ac_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Activation.xml
            XmlDocument Activationxmldoc = new XmlDocument();
            Activationxmldoc.Load("Activation.xml");
            XmlNode Activationroot = Activationxmldoc.SelectSingleNode("Activation");//查找<Activation> 
            XmlElement Activationxe1 = Activationxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Activation").InnerXml);//创建一个节点 
            XmlElement Activationsub1 = Activationxmldoc.CreateElement("domain");//添加domin
            Activationsub1.InnerText = dac.Text;//设置domain
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Activationxmldoc.CreateElement("ip");//添加ip
            Activationsub1.InnerText = iac.Text;//设置IP
            Activationxe1.AppendChild(Activationsub1);//添加到节点中 
            Activationroot.AppendChild(Activationxe1);//添加到<Activation>节点中 
            //保存创建好的XML文档
            Activationxmldoc.Save("Activation.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Activation").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Activation").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void a_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Apple.xml
            XmlDocument Applexmldoc = new XmlDocument();
            Applexmldoc.Load("Apple.xml");
            XmlNode Appleroot = Applexmldoc.SelectSingleNode("Apple");//查找<Apple> 
            XmlElement Applexe1 = Applexmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Apple").InnerXml);//创建一个节点 
            XmlElement Applesub1 = Applexmldoc.CreateElement("domain");//添加domin
            Applesub1.InnerText = da.Text;//设置domain
            Applexe1.AppendChild(Applesub1);//添加到节点中
            Applesub1 = Applexmldoc.CreateElement("ip");//添加ip
            Applesub1.InnerText = ia.Text;//设置IP
            Applexe1.AppendChild(Applesub1);//添加到节点中 
            Appleroot.AppendChild(Applexe1);//添加到<Apple>节点中 
            //保存创建好的XML文档
            Applexmldoc.Save("Apple.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Apple").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Apple").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void gw_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化GoogleWeb.xml
            XmlDocument GoogleWebxmldoc = new XmlDocument();
            GoogleWebxmldoc.Load("GoogleWeb.xml");
            XmlNode GoogleWebroot = GoogleWebxmldoc.SelectSingleNode("GoogleWeb");//查找<GoogleWeb> 
            XmlElement GoogleWebxe1 = GoogleWebxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml);//创建一个节点 
            XmlElement GoogleWebsub1 = GoogleWebxmldoc.CreateElement("domain");//添加domin
            GoogleWebsub1.InnerText = dgw.Text;//设置domain
            GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中
            GoogleWebsub1 = GoogleWebxmldoc.CreateElement("ip");//添加ip
            GoogleWebsub1.InnerText = igw.Text;//设置IP
            GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中 
            GoogleWebroot.AppendChild(GoogleWebxe1);//添加到<GoogleWeb>节点中 
            //保存创建好的XML文档
            GoogleWebxmldoc.Save("GoogleWeb.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void ga_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化GoogleWeb.xml
            XmlDocument GoogleWebxmldoc = new XmlDocument();
            GoogleWebxmldoc.Load("GoogleApis.xml");
            XmlNode GoogleWebroot = GoogleWebxmldoc.SelectSingleNode("GoogleApis");//查找<GoogleWeb> 
            XmlElement GoogleWebxe1 = GoogleWebxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml);//创建一个节点 
            XmlElement GoogleWebsub1 = GoogleWebxmldoc.CreateElement("domain");//添加domin
            GoogleWebsub1.InnerText = dga.Text;//设置domain
            GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中
            GoogleWebsub1 = GoogleWebxmldoc.CreateElement("ip");//添加ip
            GoogleWebsub1.InnerText = iga.Text;//设置IP
            GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中 
            GoogleWebroot.AppendChild(GoogleWebxe1);//添加到<GoogleWeb>节点中 
            //保存创建好的XML文档
            GoogleWebxmldoc.Save("GoogleApis.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void fb_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Facebook.xml
            XmlDocument Facebookxmldoc = new XmlDocument();
            Facebookxmldoc.Load("Facebook.xml");
            XmlNode Facebookroot = Facebookxmldoc.SelectSingleNode("Facebook");//查找<Facebook> 
            XmlElement Facebookxe1 = Facebookxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Facebook").InnerXml);//创建一个节点 
            XmlElement Facebooksub1 = Facebookxmldoc.CreateElement("domain");//添加domin
            Facebooksub1.InnerText = dfb.Text;//设置domain
            Facebookxe1.AppendChild(Facebooksub1);//添加到节点中
            Facebooksub1 = Facebookxmldoc.CreateElement("ip");//添加ip
            Facebooksub1.InnerText = ifb.Text;//设置IP
            Facebookxe1.AppendChild(Facebooksub1);//添加到节点中 
            Facebookroot.AppendChild(Facebookxe1);//添加到<Facebook>节点中 
            //保存创建好的XML文档
            Facebookxmldoc.Save("Facebook.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Facebook").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Facebook").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void t_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Facebook.xml
            XmlDocument Facebookxmldoc = new XmlDocument();
            Facebookxmldoc.Load("Twitter.xml");
            XmlNode Facebookroot = Facebookxmldoc.SelectSingleNode("Twitter");//查找<Twitter> 
            XmlElement Facebookxe1 = Facebookxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Twitter").InnerXml);//创建一个节点 
            XmlElement Facebooksub1 = Facebookxmldoc.CreateElement("domain");//添加domin
            Facebooksub1.InnerText = dt.Text;//设置domain
            Facebookxe1.AppendChild(Facebooksub1);//添加到节点中
            Facebooksub1 = Facebookxmldoc.CreateElement("ip");//添加ip
            Facebooksub1.InnerText = it.Text;//设置IP
            Facebookxe1.AppendChild(Facebooksub1);//添加到节点中 
            Facebookroot.AppendChild(Facebookxe1);//添加到<Twitter>节点中 
            //保存创建好的XML文档
            Facebookxmldoc.Save("Twitter.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Twitter").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Twitter").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void y_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Youtube.xml
            XmlDocument Youtubexmldoc = new XmlDocument();
            Youtubexmldoc.Load("Youtube.xml");
            XmlNode Youtuberoot = Youtubexmldoc.SelectSingleNode("Youtube");//查找<Youtube> 
            XmlElement Youtubexe1 = Youtubexmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Youtube").InnerXml);//创建一个节点 
            XmlElement Youtubesub1 = Youtubexmldoc.CreateElement("domain");//添加domin
            Youtubesub1.InnerText = dy.Text;//设置domain
            Youtubexe1.AppendChild(Youtubesub1);//添加到节点中
            Youtubesub1 = Youtubexmldoc.CreateElement("ip");//添加ip
            Youtubesub1.InnerText = iy.Text;//设置IP
            Youtubexe1.AppendChild(Youtubesub1);//添加到节点中 
            Youtuberoot.AppendChild(Youtubexe1);//添加到<Youtube>节点中 
            //保存创建好的XML文档
            Youtubexmldoc.Save("Youtube.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Youtube").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Youtube").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void w_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Wiki.xml
            XmlDocument Wikixmldoc = new XmlDocument();
            Wikixmldoc.Load("Wiki.xml");
            XmlNode Wikiroot = Wikixmldoc.SelectSingleNode("Wiki");//查找<Wiki> 
            XmlElement Wikixe1 = Wikixmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Wiki").InnerXml);//创建一个节点 
            XmlElement Wikisub1 = Wikixmldoc.CreateElement("domain");//添加domin
            Wikisub1.InnerText = dw.Text;//设置domain
            Wikixe1.AppendChild(Wikisub1);//添加到节点中
            Wikisub1 = Wikixmldoc.CreateElement("ip");//添加ip
            Wikisub1.InnerText = iw.Text;//设置IP
            Wikixe1.AppendChild(Wikisub1);//添加到节点中 
            Wikiroot.AppendChild(Wikixe1);//添加到<Wiki>节点中 
            //保存创建好的XML文档
            Wikixmldoc.Save("Wiki.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Wiki").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Wiki").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void st_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Wiki.xml
            XmlDocument Wikixmldoc = new XmlDocument();
            Wikixmldoc.Load("Steam.xml");
            XmlNode Wikiroot = Wikixmldoc.SelectSingleNode("Steam");//查找<Wiki> 
            XmlElement Wikixe1 = Wikixmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Steam").InnerXml);//创建一个节点 
            XmlElement Wikisub1 = Wikixmldoc.CreateElement("domain");//添加domin
            Wikisub1.InnerText = dst.Text;//设置domain
            Wikixe1.AppendChild(Wikisub1);//添加到节点中
            Wikisub1 = Wikixmldoc.CreateElement("ip");//添加ip
            Wikisub1.InnerText = ist.Text;//设置IP
            Wikixe1.AppendChild(Wikisub1);//添加到节点中 
            Wikiroot.AppendChild(Wikixe1);//添加到<Wiki>节点中 
            //保存创建好的XML文档
            Wikixmldoc.Save("Steam.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Steam").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Steam").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void fl_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Flickr.xml
            XmlDocument Flickrxmldoc = new XmlDocument();
            Flickrxmldoc.Load("Flickr.xml");
            XmlNode Flickrroot = Flickrxmldoc.SelectSingleNode("Flickr");//查找<Flickr> 
            XmlElement Flickrxe1 = Flickrxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Flickr").InnerXml);//创建一个节点 
            XmlElement Flickrsub1 = Flickrxmldoc.CreateElement("domain");//添加domin
            Flickrsub1.InnerText = dfl.Text;//设置domain
            Flickrxe1.AppendChild(Flickrsub1);//添加到节点中
            Flickrsub1 = Flickrxmldoc.CreateElement("ip");//添加ip
            Flickrsub1.InnerText = ifl.Text;//设置IP
            Flickrxe1.AppendChild(Flickrsub1);//添加到节点中 
            Flickrroot.AppendChild(Flickrxe1);//添加到<Flickr>节点中 
            //保存创建好的XML文档
            Flickrxmldoc.Save("Flickr.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Flickr").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Flickr").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void g_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Github.xml
            XmlDocument Githubxmldoc = new XmlDocument();
            Githubxmldoc.Load("Github.xml");
            XmlNode Githubroot = Githubxmldoc.SelectSingleNode("Github");//查找<Github> 
            XmlElement Githubxe1 = Githubxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Github").InnerXml);//创建一个节点 
            XmlElement Githubsub1 = Githubxmldoc.CreateElement("domain");//添加domin
            Githubsub1.InnerText = dg.Text;//设置domain
            Githubxe1.AppendChild(Githubsub1);//添加到节点中
            Githubsub1 = Githubxmldoc.CreateElement("ip");//添加ip
            Githubsub1.InnerText = ig.Text;//设置IP
            Githubxe1.AppendChild(Githubsub1);//添加到节点中 
            Githubroot.AppendChild(Githubxe1);//添加到<Github>节点中 
            //保存创建好的XML文档
            Githubxmldoc.Save("Github.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Github").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Github").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void d_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Dropbox.xml
            XmlDocument Dropboxxmldoc = new XmlDocument();
            Dropboxxmldoc.Load("Dropbox.xml");
            XmlNode Dropboxroot = Dropboxxmldoc.SelectSingleNode("Dropbox");//查找<Dropbox> 
            XmlElement Dropboxxe1 = Dropboxxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml);//创建一个节点 
            XmlElement Dropboxsub1 = Dropboxxmldoc.CreateElement("domain");//添加domin
            Dropboxsub1.InnerText = dd.Text;//设置domain
            Dropboxxe1.AppendChild(Dropboxsub1);//添加到节点中
            Dropboxsub1 = Dropboxxmldoc.CreateElement("ip");//添加ip
            Dropboxsub1.InnerText = id.Text;//设置IP
            Dropboxxe1.AppendChild(Dropboxsub1);//添加到节点中 
            Dropboxroot.AppendChild(Dropboxxe1);//添加到<Dropbox>节点中 
            //保存创建好的XML文档
            Dropboxxmldoc.Save("Dropbox.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void od_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Onedrive.xml
            XmlDocument Onedrivexmldoc = new XmlDocument();
            Onedrivexmldoc.Load("Onedrive.xml");
            XmlNode Onedriveroot = Onedrivexmldoc.SelectSingleNode("Onedrive");//查找<Onedrive> 
            XmlElement Onedrivexe1 = Onedrivexmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml);//创建一个节点 
            XmlElement Onedrivesub1 = Onedrivexmldoc.CreateElement("domain");//添加domin
            Onedrivesub1.InnerText = dod.Text;//设置domain
            Onedrivexe1.AppendChild(Onedrivesub1);//添加到节点中
            Onedrivesub1 = Onedrivexmldoc.CreateElement("ip");//添加ip
            Onedrivesub1.InnerText = iod.Text;//设置IP
            Onedrivexe1.AppendChild(Onedrivesub1);//添加到节点中 
            Onedriveroot.AppendChild(Onedrivexe1);//添加到<Onedrive>节点中 
            //保存创建好的XML文档
            Onedrivexmldoc.Save("Onedrive.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void wp_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化WordPress.xml
            XmlDocument WordPressxmldoc = new XmlDocument();
            WordPressxmldoc.Load("WordPress.xml");
            XmlNode WordPressroot = WordPressxmldoc.SelectSingleNode("WordPress");//查找<WordPress> 
            XmlElement WordPressxe1 = WordPressxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/WordPress").InnerXml);//创建一个节点 
            XmlElement WordPresssub1 = WordPressxmldoc.CreateElement("domain");//添加domin
            WordPresssub1.InnerText = dwp.Text;//设置domain
            WordPressxe1.AppendChild(WordPresssub1);//添加到节点中
            WordPresssub1 = WordPressxmldoc.CreateElement("ip");//添加ip
            WordPresssub1.InnerText = iwp.Text;//设置IP
            WordPressxe1.AppendChild(WordPresssub1);//添加到节点中 
            WordPressroot.AppendChild(WordPressxe1);//添加到<WordPress>节点中 
            //保存创建好的XML文档
            WordPressxmldoc.Save("WordPress.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/WordPress").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/WordPress").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void ot_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化Other.xml
            XmlDocument Otherxmldoc = new XmlDocument();
            Otherxmldoc.Load("Other.xml");
            XmlNode Otherroot = Otherxmldoc.SelectSingleNode("Other");//查找<Other> 
            XmlElement Otherxe1 = Otherxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/Other").InnerXml);//创建一个节点 
            XmlElement Othersub1 = Otherxmldoc.CreateElement("domain");//添加domin
            Othersub1.InnerText = dot.Text;//设置domain
            Otherxe1.AppendChild(Othersub1);//添加到节点中
            Othersub1 = Otherxmldoc.CreateElement("ip");//添加ip
            Othersub1.InnerText = iot.Text;//设置IP
            Otherxe1.AppendChild(Othersub1);//添加到节点中 
            Otherroot.AppendChild(Otherxe1);//添加到<Other>节点中 
            //保存创建好的XML文档
            Otherxmldoc.Save("Other.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Other").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/Other").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void h_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化hostsx.xml
            XmlDocument hostsxxmldoc = new XmlDocument();
            hostsxxmldoc.Load("hostsx.xml");
            XmlNode hostsxroot = hostsxxmldoc.SelectSingleNode("hostsx");//查找<hostsx> 
            XmlElement hostsxxe1 = hostsxxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/hostsx").InnerXml);//创建一个节点 
            XmlElement hostsxsub1 = hostsxxmldoc.CreateElement("domain");//添加domin
            hostsxsub1.InnerText = dh.Text;//设置domain
            hostsxxe1.AppendChild(hostsxsub1);//添加到节点中
            hostsxsub1 = hostsxxmldoc.CreateElement("ip");//添加ip
            hostsxsub1.InnerText = ih.Text;//设置IP
            hostsxxe1.AppendChild(hostsxsub1);//添加到节点中 
            hostsxroot.AppendChild(hostsxxe1);//添加到<hostsx>节点中 
            //保存创建好的XML文档
            hostsxxmldoc.Save("hostsx.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/hostsx").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/hostsx").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void m_Click(object sender, EventArgs e)
        {
            //初始化Data.xml
            XmlDocument Dataxmldoc = new XmlDocument();
            Dataxmldoc.Load("Data.xml");
            //初始化mvps.xml
            XmlDocument mvpsxmldoc = new XmlDocument();
            mvpsxmldoc.Load("mvps.xml");
            XmlNode mvpsroot = mvpsxmldoc.SelectSingleNode("mvps");//查找<mvps> 
            XmlElement mvpsxe1 = mvpsxmldoc.CreateElement("UID-" + Dataxmldoc.SelectSingleNode("Data/MAXUID/mvps").InnerXml);//创建一个节点 
            XmlElement mvpssub1 = mvpsxmldoc.CreateElement("domain");//添加domin
            mvpssub1.InnerText = dm.Text;//设置domain
            mvpsxe1.AppendChild(mvpssub1);//添加到节点中
            mvpssub1 = mvpsxmldoc.CreateElement("ip");//添加ip
            mvpssub1.InnerText = im.Text;//设置IP
            mvpsxe1.AppendChild(mvpssub1);//添加到节点中 
            mvpsroot.AppendChild(mvpsxe1);//添加到<mvps>节点中 
            //保存创建好的XML文档
            mvpsxmldoc.Save("mvps.xml");
            int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/mvps").InnerXml) + 1;
            Dataxmldoc.SelectSingleNode("Data/MAXUID/mvps").InnerXml = MAXID.ToString();
            Dataxmldoc.Save("Data.xml");
        }

        private void iac_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.ac_Click(sender, e);//触发button事件  
            }
        }

        private void ia_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.a_Click(sender, e);//触发button事件  
            }
        }

        private void igw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.gw_Click(sender, e);//触发button事件  
            }
        }

        private void iga_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.ga_Click(sender, e);//触发button事件  
            }
        }

        private void ifb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.fb_Click(sender, e);//触发button事件  
            }
        }

        private void it_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.t_Click(sender, e);//触发button事件  
            }
        }

        private void iy_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.y_Click(sender, e);//触发button事件  
            }
        }

        private void iw_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.w_Click(sender, e);//触发button事件  
            }
        }

        private void ist_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.st_Click(sender, e);//触发button事件  
            }
        }

        private void ifl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.fl_Click(sender, e);//触发button事件  
            }
        }

        private void ig_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.g_Click(sender, e);//触发button事件  
            }
        }

        private void id_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.d_Click(sender, e);//触发button事件  
            }
        }

        private void iod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.od_Click(sender, e);//触发button事件  
            }
        }

        private void iwp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.wp_Click(sender, e);//触发button事件  
            }
        }

        private void iot_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.ot_Click(sender, e);//触发button事件  
            }
        }

        private void ih_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.h_Click(sender, e);//触发button事件  
            }
        }

        private void im_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//如果输入的是回车键  
            {
                this.m_Click(sender, e);//触发button事件  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Activation.xml
                XmlDocument Activationxmldoc = new XmlDocument();
                Activationxmldoc.Load("Activation.xml");
                XmlNode Activationroot = Activationxmldoc.SelectSingleNode("Activation");//查找<Activation> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Activation").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Activationxe1 = Activationxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                XmlElement Activationsub1 = Activationxmldoc.CreateElement("domain");//添加domin
                Activationsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                Activationxe1.AppendChild(Activationsub1);//添加到节点中
                Activationsub1 = Activationxmldoc.CreateElement("ip");//添加ip
                Activationsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                Activationxe1.AppendChild(Activationsub1);//添加到节点中 
                Activationroot.AppendChild(Activationxe1);//添加到<Activation>节点中 
                MAXID++;
                }
                //保存创建好的XML文档
                Activationxmldoc.Save("Activation.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Activation").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Apple.xml
                XmlDocument Applexmldoc = new XmlDocument();
                Applexmldoc.Load("Apple.xml");
                XmlNode Appleroot = Applexmldoc.SelectSingleNode("Apple");//查找<Apple> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Apple").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Applexe1 = Applexmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Applesub1 = Applexmldoc.CreateElement("domain");//添加domin
                    Applesub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Applexe1.AppendChild(Applesub1);//添加到节点中
                    Applesub1 = Applexmldoc.CreateElement("ip");//添加ip
                    Applesub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Applexe1.AppendChild(Applesub1);//添加到节点中 
                    Appleroot.AppendChild(Applexe1);//添加到<Apple>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Applexmldoc.Save("Apple.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Apple").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化GoogleWeb.xml
                XmlDocument GoogleWebxmldoc = new XmlDocument();
                GoogleWebxmldoc.Load("GoogleWeb.xml");
                XmlNode GoogleWebroot = GoogleWebxmldoc.SelectSingleNode("GoogleWeb");//查找<GoogleWeb> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement GoogleWebxe1 = GoogleWebxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement GoogleWebsub1 = GoogleWebxmldoc.CreateElement("domain");//添加domin
                    GoogleWebsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中
                    GoogleWebsub1 = GoogleWebxmldoc.CreateElement("ip");//添加ip
                    GoogleWebsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    GoogleWebxe1.AppendChild(GoogleWebsub1);//添加到节点中 
                    GoogleWebroot.AppendChild(GoogleWebxe1);//添加到<GoogleWeb>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                GoogleWebxmldoc.Save("GoogleWeb.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleWeb").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化GoogleApis.xml
                XmlDocument GoogleApisxmldoc = new XmlDocument();
                GoogleApisxmldoc.Load("GoogleApis.xml");
                XmlNode GoogleApisroot = GoogleApisxmldoc.SelectSingleNode("GoogleApis");//查找<GoogleApis> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement GoogleApisxe1 = GoogleApisxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement GoogleApissub1 = GoogleApisxmldoc.CreateElement("domain");//添加domin
                    GoogleApissub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    GoogleApisxe1.AppendChild(GoogleApissub1);//添加到节点中
                    GoogleApissub1 = GoogleApisxmldoc.CreateElement("ip");//添加ip
                    GoogleApissub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    GoogleApisxe1.AppendChild(GoogleApissub1);//添加到节点中 
                    GoogleApisroot.AppendChild(GoogleApisxe1);//添加到<GoogleApis>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                GoogleApisxmldoc.Save("GoogleApis.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/GoogleApis").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Facebook.xml
                XmlDocument Facebookxmldoc = new XmlDocument();
                Facebookxmldoc.Load("Facebook.xml");
                XmlNode Facebookroot = Facebookxmldoc.SelectSingleNode("Facebook");//查找<Facebook> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Facebook").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Facebookxe1 = Facebookxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Facebooksub1 = Facebookxmldoc.CreateElement("domain");//添加domin
                    Facebooksub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Facebookxe1.AppendChild(Facebooksub1);//添加到节点中
                    Facebooksub1 = Facebookxmldoc.CreateElement("ip");//添加ip
                    Facebooksub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Facebookxe1.AppendChild(Facebooksub1);//添加到节点中 
                    Facebookroot.AppendChild(Facebookxe1);//添加到<Facebook>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Facebookxmldoc.Save("Facebook.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Facebook").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Twitter.xml
                XmlDocument Twitterxmldoc = new XmlDocument();
                Twitterxmldoc.Load("Twitter.xml");
                XmlNode Twitterroot = Twitterxmldoc.SelectSingleNode("Twitter");//查找<Twitter> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Twitter").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Twitterxe1 = Twitterxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Twittersub1 = Twitterxmldoc.CreateElement("domain");//添加domin
                    Twittersub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Twitterxe1.AppendChild(Twittersub1);//添加到节点中
                    Twittersub1 = Twitterxmldoc.CreateElement("ip");//添加ip
                    Twittersub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Twitterxe1.AppendChild(Twittersub1);//添加到节点中 
                    Twitterroot.AppendChild(Twitterxe1);//添加到<Twitter>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Twitterxmldoc.Save("Twitter.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Twitter").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Youtube.xml
                XmlDocument Youtubexmldoc = new XmlDocument();
                Youtubexmldoc.Load("Youtube.xml");
                XmlNode Youtuberoot = Youtubexmldoc.SelectSingleNode("Youtube");//查找<Youtube> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Youtube").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Youtubexe1 = Youtubexmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Youtubesub1 = Youtubexmldoc.CreateElement("domain");//添加domin
                    Youtubesub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Youtubexe1.AppendChild(Youtubesub1);//添加到节点中
                    Youtubesub1 = Youtubexmldoc.CreateElement("ip");//添加ip
                    Youtubesub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Youtubexe1.AppendChild(Youtubesub1);//添加到节点中 
                    Youtuberoot.AppendChild(Youtubexe1);//添加到<Youtube>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Youtubexmldoc.Save("Youtube.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Youtube").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Wiki.xml
                XmlDocument Wikixmldoc = new XmlDocument();
                Wikixmldoc.Load("Wiki.xml");
                XmlNode Wikiroot = Wikixmldoc.SelectSingleNode("Wiki");//查找<Wiki> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Wiki").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Wikixe1 = Wikixmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Wikisub1 = Wikixmldoc.CreateElement("domain");//添加domin
                    Wikisub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Wikixe1.AppendChild(Wikisub1);//添加到节点中
                    Wikisub1 = Wikixmldoc.CreateElement("ip");//添加ip
                    Wikisub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Wikixe1.AppendChild(Wikisub1);//添加到节点中 
                    Wikiroot.AppendChild(Wikixe1);//添加到<Wiki>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Wikixmldoc.Save("Wiki.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Wiki").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Steam.xml
                XmlDocument Steamxmldoc = new XmlDocument();
                Steamxmldoc.Load("Steam.xml");
                XmlNode Steamroot = Steamxmldoc.SelectSingleNode("Steam");//查找<Steam> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Steam").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Steamxe1 = Steamxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Steamsub1 = Steamxmldoc.CreateElement("domain");//添加domin
                    Steamsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Steamxe1.AppendChild(Steamsub1);//添加到节点中
                    Steamsub1 = Steamxmldoc.CreateElement("ip");//添加ip
                    Steamsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Steamxe1.AppendChild(Steamsub1);//添加到节点中 
                    Steamroot.AppendChild(Steamxe1);//添加到<Steam>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Steamxmldoc.Save("Steam.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Steam").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Flickr.xml
                XmlDocument Flickrxmldoc = new XmlDocument();
                Flickrxmldoc.Load("Flickr.xml");
                XmlNode Flickrroot = Flickrxmldoc.SelectSingleNode("Flickr");//查找<Flickr> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Flickr").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Flickrxe1 = Flickrxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Flickrsub1 = Flickrxmldoc.CreateElement("domain");//添加domin
                    Flickrsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Flickrxe1.AppendChild(Flickrsub1);//添加到节点中
                    Flickrsub1 = Flickrxmldoc.CreateElement("ip");//添加ip
                    Flickrsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Flickrxe1.AppendChild(Flickrsub1);//添加到节点中 
                    Flickrroot.AppendChild(Flickrxe1);//添加到<Flickr>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Flickrxmldoc.Save("Flickr.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Flickr").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Github.xml
                XmlDocument Githubxmldoc = new XmlDocument();
                Githubxmldoc.Load("Github.xml");
                XmlNode Githubroot = Githubxmldoc.SelectSingleNode("Github");//查找<Github> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Github").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Githubxe1 = Githubxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Githubsub1 = Githubxmldoc.CreateElement("domain");//添加domin
                    Githubsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Githubxe1.AppendChild(Githubsub1);//添加到节点中
                    Githubsub1 = Githubxmldoc.CreateElement("ip");//添加ip
                    Githubsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Githubxe1.AppendChild(Githubsub1);//添加到节点中 
                    Githubroot.AppendChild(Githubxe1);//添加到<Github>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Githubxmldoc.Save("Github.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Github").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Dropbox.xml
                XmlDocument Dropboxxmldoc = new XmlDocument();
                Dropboxxmldoc.Load("Dropbox.xml");
                XmlNode Dropboxroot = Dropboxxmldoc.SelectSingleNode("Dropbox");//查找<Dropbox> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Dropboxxe1 = Dropboxxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Dropboxsub1 = Dropboxxmldoc.CreateElement("domain");//添加domin
                    Dropboxsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Dropboxxe1.AppendChild(Dropboxsub1);//添加到节点中
                    Dropboxsub1 = Dropboxxmldoc.CreateElement("ip");//添加ip
                    Dropboxsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Dropboxxe1.AppendChild(Dropboxsub1);//添加到节点中 
                    Dropboxroot.AppendChild(Dropboxxe1);//添加到<Dropbox>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Dropboxxmldoc.Save("Dropbox.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Dropbox").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Onedrive.xml
                XmlDocument Onedrivexmldoc = new XmlDocument();
                Onedrivexmldoc.Load("Onedrive.xml");
                XmlNode Onedriveroot = Onedrivexmldoc.SelectSingleNode("Onedrive");//查找<Onedrive> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Onedrivexe1 = Onedrivexmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Onedrivesub1 = Onedrivexmldoc.CreateElement("domain");//添加domin
                    Onedrivesub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Onedrivexe1.AppendChild(Onedrivesub1);//添加到节点中
                    Onedrivesub1 = Onedrivexmldoc.CreateElement("ip");//添加ip
                    Onedrivesub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Onedrivexe1.AppendChild(Onedrivesub1);//添加到节点中 
                    Onedriveroot.AppendChild(Onedrivexe1);//添加到<Onedrive>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Onedrivexmldoc.Save("Onedrive.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Onedrive").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化WordPress.xml
                XmlDocument WordPressxmldoc = new XmlDocument();
                WordPressxmldoc.Load("WordPress.xml");
                XmlNode WordPressroot = WordPressxmldoc.SelectSingleNode("WordPress");//查找<WordPress> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/WordPress").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement WordPressxe1 = WordPressxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement WordPresssub1 = WordPressxmldoc.CreateElement("domain");//添加domin
                    WordPresssub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    WordPressxe1.AppendChild(WordPresssub1);//添加到节点中
                    WordPresssub1 = WordPressxmldoc.CreateElement("ip");//添加ip
                    WordPresssub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    WordPressxe1.AppendChild(WordPresssub1);//添加到节点中 
                    WordPressroot.AppendChild(WordPressxe1);//添加到<WordPress>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                WordPressxmldoc.Save("WordPress.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/WordPress").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化Other.xml
                XmlDocument Otherxmldoc = new XmlDocument();
                Otherxmldoc.Load("Other.xml");
                XmlNode Otherroot = Otherxmldoc.SelectSingleNode("Other");//查找<Other> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/Other").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement Otherxe1 = Otherxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement Othersub1 = Otherxmldoc.CreateElement("domain");//添加domin
                    Othersub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    Otherxe1.AppendChild(Othersub1);//添加到节点中
                    Othersub1 = Otherxmldoc.CreateElement("ip");//添加ip
                    Othersub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    Otherxe1.AppendChild(Othersub1);//添加到节点中 
                    Otherroot.AppendChild(Otherxe1);//添加到<Other>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                Otherxmldoc.Save("Other.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/Other").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化hostsx.xml
                XmlDocument hostsxxmldoc = new XmlDocument();
                hostsxxmldoc.Load("hostsx.xml");
                XmlNode hostsxroot = hostsxxmldoc.SelectSingleNode("hostsx");//查找<hostsx> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/hostsx").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement hostsxxe1 = hostsxxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement hostsxsub1 = hostsxxmldoc.CreateElement("domain");//添加domin
                    hostsxsub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    hostsxxe1.AppendChild(hostsxsub1);//添加到节点中
                    hostsxsub1 = hostsxxmldoc.CreateElement("ip");//添加ip
                    hostsxsub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    hostsxxe1.AppendChild(hostsxsub1);//添加到节点中 
                    hostsxroot.AppendChild(hostsxxe1);//添加到<hostsx>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                hostsxxmldoc.Save("hostsx.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/hostsx").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.InitialDirectory = "C://";
            fileDialog.Filter = "hosts文件|*.*";
            fileDialog.FilterIndex = 1;
            fileDialog.RestoreDirectory = true;
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(fileDialog.FileName, Encoding.Default);
                String line;
                //初始化mvps.xml
                XmlDocument mvpsxmldoc = new XmlDocument();
                mvpsxmldoc.Load("mvps.xml");
                XmlNode mvpsroot = mvpsxmldoc.SelectSingleNode("mvps");//查找<mvps> 
                //初始化Data.xml
                XmlDocument Dataxmldoc = new XmlDocument();
                Dataxmldoc.Load("Data.xml");
                int MAXID = int.Parse(Dataxmldoc.SelectSingleNode("Data/MAXUID/mvps").InnerXml);
                while ((line = sr.ReadLine()) != null)
                {
                    XmlElement mvpsxe1 = mvpsxmldoc.CreateElement("UID-" + MAXID);//创建一个节点 
                    XmlElement mvpssub1 = mvpsxmldoc.CreateElement("domain");//添加domin
                    mvpssub1.InnerText = line.Substring(line.LastIndexOf("#") + 1, line.LastIndexOf("$") - line.LastIndexOf("#") - 1);//设置domain
                    mvpsxe1.AppendChild(mvpssub1);//添加到节点中
                    mvpssub1 = mvpsxmldoc.CreateElement("ip");//添加ip
                    mvpssub1.InnerText = line.Substring(0, line.LastIndexOf("#"));//设置IP
                    mvpsxe1.AppendChild(mvpssub1);//添加到节点中 
                    mvpsroot.AppendChild(mvpsxe1);//添加到<mvps>节点中 
                    MAXID++;
                }
                //保存创建好的XML文档
                mvpsxmldoc.Save("mvps.xml");
                Dataxmldoc.SelectSingleNode("Data/MAXUID/mvps").InnerXml = MAXID.ToString();
                Dataxmldoc.Save("Data.xml");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            XmlDocument mydoc = new XmlDocument();
            //初始化Data.xml
            XmlDocument Dataxmldoc;
            XmlElement Dataxmlelem;
            Dataxmldoc = new XmlDocument();
            //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
            XmlDeclaration Memberxmldecl;
            Memberxmldecl = Dataxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
            Dataxmldoc.AppendChild(Memberxmldecl);
            //加入一个根元素Member
            Dataxmlelem = Dataxmldoc.CreateElement("", "Data", "");
            Dataxmldoc.AppendChild(Dataxmlelem);
            XmlNode Activationroot = Dataxmldoc.SelectSingleNode("Data");//查找<Data> 
            XmlElement Activationxe1 = Dataxmldoc.CreateElement("MAXUID");//创建一个节点 
            XmlElement Activationsub1;
            Activationsub1 = Dataxmldoc.CreateElement("Activation");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Apple");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Dropbox");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Facebook");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Flickr");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Github");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("GoogleApis");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("GoogleWeb");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("hostsx");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("mvps");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Onedrive");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Other");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Steam");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Twitter");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Wiki");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("WordPress");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中
            Activationsub1 = Dataxmldoc.CreateElement("Youtube");//添加
            Activationsub1.InnerText = "1";//设置
            Activationxe1.AppendChild(Activationsub1);//添加到节点中 
            Activationroot.AppendChild(Activationxe1);//添加到<Data>节点中 
            //保存创建好的XML文档
            Dataxmldoc.Save("Data.xml");

                //初始化Activation.xml
                XmlDocument Activationxmldoc;
                XmlElement Activationxmlelem;
                Activationxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>

                Memberxmldecl = Activationxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Activationxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Activationxmlelem = Activationxmldoc.CreateElement("", "Activation", "");
                Activationxmldoc.AppendChild(Activationxmlelem);
                //保存创建好的XML文档
                Activationxmldoc.Save("Activation.xml");
                //初始化Apple.xml
                XmlDocument Applexmldoc;
                XmlElement Applexmlelem;
                Applexmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Applexmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Applexmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Applexmlelem = Applexmldoc.CreateElement("", "Apple", "");
                Applexmldoc.AppendChild(Applexmlelem);
                //保存创建好的XML文档
                Applexmldoc.Save("Apple.xml");
                //初始化GoogleWeb.xml
                XmlDocument GoogleWebxmldoc;
                XmlElement GoogleWebxmlelem;
                GoogleWebxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = GoogleWebxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                GoogleWebxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                GoogleWebxmlelem = GoogleWebxmldoc.CreateElement("", "GoogleWeb", "");
                GoogleWebxmldoc.AppendChild(GoogleWebxmlelem);
                //保存创建好的XML文档
                GoogleWebxmldoc.Save("GoogleWeb.xml");
                //初始化GoogleApi.xml
                XmlDocument GoogleApixmldoc;
                XmlElement GoogleApixmlelem;
                GoogleApixmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = GoogleApixmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                GoogleApixmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                GoogleApixmlelem = GoogleApixmldoc.CreateElement("", "GoogleApis", "");
                GoogleApixmldoc.AppendChild(GoogleApixmlelem);
                //保存创建好的XML文档
                GoogleApixmldoc.Save("GoogleApis.xml");
                //初始化Facebook.xml
                XmlDocument Facebookxmldoc;
                XmlElement Facebookxmlelem;
                Facebookxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Facebookxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Facebookxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Facebookxmlelem = Facebookxmldoc.CreateElement("", "Facebook", "");
                Facebookxmldoc.AppendChild(Facebookxmlelem);
                //保存创建好的XML文档
                Facebookxmldoc.Save("Facebook.xml");
                //初始化Twitter.xml
                XmlDocument Twitterxmldoc;
                XmlElement Twitterxmlelem;
                Twitterxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Twitterxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Twitterxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Twitterxmlelem = Twitterxmldoc.CreateElement("", "Twitter", "");
                Twitterxmldoc.AppendChild(Twitterxmlelem);
                //保存创建好的XML文档
                Twitterxmldoc.Save("Twitter.xml");
                //初始化Youtube.xml
                XmlDocument Youtubexmldoc;
                XmlElement Youtubexmlelem;
                Youtubexmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Youtubexmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Youtubexmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Youtubexmlelem = Youtubexmldoc.CreateElement("", "Youtube", "");
                Youtubexmldoc.AppendChild(Youtubexmlelem);
                //保存创建好的XML文档
                Youtubexmldoc.Save("Youtube.xml");
                //初始化Wiki.xml
                XmlDocument Wikixmldoc;
                XmlElement Wikixmlelem;
                Wikixmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Wikixmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Wikixmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Wikixmlelem = Wikixmldoc.CreateElement("", "Wiki", "");
                Wikixmldoc.AppendChild(Wikixmlelem);
                //保存创建好的XML文档
                Wikixmldoc.Save("Wiki.xml");
                //初始化Steam.xml
                XmlDocument Steamxmldoc;
                XmlElement Steamxmlelem;
                Steamxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Steamxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Steamxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Steamxmlelem = Steamxmldoc.CreateElement("", "Steam", "");
                Steamxmldoc.AppendChild(Steamxmlelem);
                //保存创建好的XML文档
                Steamxmldoc.Save("Steam.xml");
                //初始化Flickr.xml
                XmlDocument Flickrxmldoc;
                XmlElement Flickrxmlelem;
                Flickrxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Flickrxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Flickrxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Flickrxmlelem = Flickrxmldoc.CreateElement("", "Flickr", "");
                Flickrxmldoc.AppendChild(Flickrxmlelem);
                //保存创建好的XML文档
                Flickrxmldoc.Save("Flickr.xml");
                //初始化Github.xml
                XmlDocument Githubxmldoc;
                XmlElement Githubxmlelem;
                Githubxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Githubxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Githubxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Githubxmlelem = Githubxmldoc.CreateElement("", "Github", "");
                Githubxmldoc.AppendChild(Githubxmlelem);
                //保存创建好的XML文档
                Githubxmldoc.Save("Github.xml");
                //初始化Dropbox.xml
                XmlDocument Dropboxxmldoc;
                XmlElement Dropboxxmlelem;
                Dropboxxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Dropboxxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Dropboxxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Dropboxxmlelem = Dropboxxmldoc.CreateElement("", "Dropbox", "");
                Dropboxxmldoc.AppendChild(Dropboxxmlelem);
                //保存创建好的XML文档
                Dropboxxmldoc.Save("Dropbox.xml");
                //初始化Onedrive.xml
                XmlDocument Onedrivexmldoc;
                XmlElement Onedrivexmlelem;
                Onedrivexmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Onedrivexmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Onedrivexmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Onedrivexmlelem = Onedrivexmldoc.CreateElement("", "Onedrive", "");
                Onedrivexmldoc.AppendChild(Onedrivexmlelem);
                //保存创建好的XML文档
                Onedrivexmldoc.Save("Onedrive.xml");
                //初始化WordPress.xml
                XmlDocument WordPressxmldoc;
                XmlElement WordPressxmlelem;
                WordPressxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = WordPressxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                WordPressxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                WordPressxmlelem = WordPressxmldoc.CreateElement("", "WordPress", "");
                WordPressxmldoc.AppendChild(WordPressxmlelem);
                //保存创建好的XML文档
                WordPressxmldoc.Save("WordPress.xml");
                //初始化Other.xml
                XmlDocument Otherxmldoc;
                XmlElement Otherxmlelem;
                Otherxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = Otherxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                Otherxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                Otherxmlelem = Otherxmldoc.CreateElement("", "Other", "");
                Otherxmldoc.AppendChild(Otherxmlelem);
                //保存创建好的XML文档
                Otherxmldoc.Save("Other.xml");
                //初始化hostsx.xml
                XmlDocument hostsxxmldoc;
                XmlElement hostsxxmlelem;
                hostsxxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = hostsxxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                hostsxxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                hostsxxmlelem = hostsxxmldoc.CreateElement("", "hostsx", "");
                hostsxxmldoc.AppendChild(hostsxxmlelem);
                //保存创建好的XML文档
                hostsxxmldoc.Save("hostsx.xml");
                //初始化mvps.xml
                XmlDocument mvpsxmldoc;
                XmlElement mvpsxmlelem;
                mvpsxmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="gb2312"?>
                
                Memberxmldecl = mvpsxmldoc.CreateXmlDeclaration("1.0", "gb2312", null);
                mvpsxmldoc.AppendChild(Memberxmldecl);
                //加入一个根元素Member
                mvpsxmlelem = mvpsxmldoc.CreateElement("", "mvps", "");
                mvpsxmldoc.AppendChild(mvpsxmlelem);
                //保存创建好的XML文档
                mvpsxmldoc.Save("mvps.xml");
        }
    }
}
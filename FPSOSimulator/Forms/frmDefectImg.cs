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

namespace FPSOSimulator.Forms
{
    public partial class frmDefectImg : Form
    {
        public frmDefectImg()
        {
            InitializeComponent();
        }

        public void SetFormPara(int senderForm, int idx)
        {
            if (senderForm == 1)
            {

                //frmMain.ProDefectImgInfo.
                //for test
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTWIDTH = 600;
                //frmMain.ProDefectImgInfo[frmMain.SelectPicNum].FAULTHEIGHT = 600;

                int mywidth = 600; //frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTWIDTH;
                int myheight = 600; // frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTHEIGHT;
                BackPicBox.Size = new Size(mywidth, myheight);
                string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTFILENAME + ".jpg");
                //string aimpath = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FileAimPath;

                //if (File.Exists(aimpath))
                //{
                //    BackPicBox.Image = Image.FromFile(aimpath);
                //}
                //else
                //{
                //    BackPicBox.Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                //}

                //if (File.Exists(aimpath))
                //{
                //    Stream s = File.Open(aimpath, FileMode.Open);
                //    BackPicBox.Image = Image.FromStream(s);
                //    s.Close();

                //    //pictureBoxes[idx, i].Image = Image.FromFile(aimpath);
                //}
                //else
                //{

                //    Stream s = File.Open(apppath + "\\" + "FaultPic.jpg", FileMode.Open);
                //    BackPicBox.Image = Image.FromStream(s);
                //    s.Close();
                //    //pictureBoxes[idx, i].Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                //}

                //ProductInfo[i].FAULTPOSX[j]

                //ParaLbl1.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].OUT_ID;
                //ParaLbl2.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].LNKNUM);
                //ParaLbl3.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].LNKCOMP);
                //ParaLbl4.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].LNKDATETIME;
                //ParaLbl5.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].LNKOPER;
                //ParaLbl6.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].LNKSHIFT;
                //ParaLbl7.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTTYPE;
                //ParaLbl8.Text = frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTNAME;
                //ParaLbl9.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTPOSX);
                //ParaLbl10.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTPOSY);
                //ParaLbl11.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTWIDTH);
                //ParaLbl12.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTHEIGHT);
                //ParaLbl13.Text = Convert.ToString(frmMain.ProDefectImgInfo[idx, frmMain.SelectPicNum].FAULTFILENAME);
            }
            else
            {


                int mywidth = 600;// NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTWIDTH;
                int myheight = 600;// NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTHEIGHT;
                BackPicBox.Size = new Size(mywidth, myheight);
                string apppath = System.Windows.Forms.Application.StartupPath;
                //BackPicBox.Image = Image.FromFile(apppath + "\\DefectPicturesTest" + "\\" + NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTFILENAME + ".jpg");
                string aimpath = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FileAimPath;

                //if (File.Exists(aimpath))
                //{
                //    BackPicBox.Image = Image.FromFile(aimpath);
                //}
                //else
                //{
                //    BackPicBox.Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                //}

                if (File.Exists(aimpath))
                {
                    Stream s = File.Open(aimpath, FileMode.Open);
                    BackPicBox.Image = Image.FromStream(s);
                    s.Close();

                    //pictureBoxes[idx, i].Image = Image.FromFile(aimpath);
                }
                else
                {

                    Stream s = File.Open(apppath + "\\" + "FaultPic.jpg", FileMode.Open);
                    BackPicBox.Image = Image.FromStream(s);
                    s.Close();
                    //pictureBoxes[idx, i].Image = Image.FromFile(apppath + "\\" + "FaultPic.jpg");
                }

                //ProductInfo[i].FAULTPOSX[j]

                ParaLbl1.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].OUT_ID;
                ParaLbl2.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].LNKNUM);
                ParaLbl3.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].LNKCOMP);
                ParaLbl4.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].LNKDATETIME;
                ParaLbl5.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].LNKOPER;
                ParaLbl6.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].LNKSHIFT;
                ParaLbl7.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTTYPE;
                ParaLbl8.Text = NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTNAME;
                ParaLbl9.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTPOSX);
                ParaLbl10.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTPOSY);
                ParaLbl11.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTWIDTH);
                ParaLbl12.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTHEIGHT);
                ParaLbl13.Text = Convert.ToString(NFRMDefectHistory.ProDefectImgInfo[idx, NFRMDefectHistory.SelectPicNum].FAULTFILENAME);
            }

        }

    }
}

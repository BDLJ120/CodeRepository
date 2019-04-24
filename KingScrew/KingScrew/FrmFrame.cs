using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using CSharp_OPTControllerAPI;

namespace KingScrew
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class FrmFrame : Form
    {
        public FrmFrame()
        {
            InitializeComponent();
        }

        #region 窗口切换

        /// <summary>
        /// 切换窗口, 默认关闭其它窗口。
        /// </summary>
        /// <typeparam name="T">窗口</typeparam>
        /// <param name="btn">按钮</param>
        /// <param name="closeOthers">是否关闭其它窗口</param>
        void ShowForm<T>(Button btn, bool closeOthers = true) where T : Form, new()
        {
            bool exist = false;
            for (int i = 0; i < panelMain.Controls.Count; i++)
            {
                if (panelMain.Controls[i] is T)
                {
                    panelMain.Controls[i].BringToFront();
                    exist = true;
                }
                else
                {
                    if (closeOthers)
                    {
                        (panelMain.Controls[i] as Form).Close();
                        i = -1;
                    }
                }
            }
            if (!exist)
            {
                T f = new T();
                f.MdiParent = this;
                f.Parent = panelMain;
                f.Show();
                f.BringToFront();
            }
            foreach (Button item in panelTitle.Controls)
            {
                item.BackColor = Color.Gainsboro;
            }
            btn.BackColor = Color.DarkSeaGreen;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ShowForm<FrmHome>(sender as Button);
            Globals.runStatus = Globals.RunStatus.Ready;
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            if (Globals.runStatus == Globals.RunStatus.Running)
            {
                MsgBox.Show("程序运行中，不能开启窗口");
                return;
            }
            Globals.runStatus = Globals.RunStatus.Debug;
            ShowForm<FrmSet>(sender as Button, false);
        }

        private void btnChart_Click(object sender, EventArgs e)
        {
            if (Globals.runStatus == Globals.RunStatus.Running)
            {
                MsgBox.Show("程序运行中，不能开启窗口");
                return;
            }
            Globals.runStatus = Globals.RunStatus.Debug;
            ShowForm<FrmSPC>(sender as Button, false);
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            ShowForm<FrmLog>(sender as Button, false);
        }

        private void btnCcd_Click(object sender, EventArgs e)
        {
            if (Globals.runStatus == Globals.RunStatus.Running)
            {
                MsgBox.Show("程序运行中，不能开启窗口");
                return;
            }
            Globals.runStatus = Globals.RunStatus.Debug;
            ShowForm<FrmVision>(sender as Button);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            if (Globals.runStatus == Globals.RunStatus.Running)
            {
                MsgBox.Show("程序运行中，不能开启窗口");
                return;
            }
            Globals.runStatus = Globals.RunStatus.Debug;
            ShowForm<FrmUser>(sender as Button);
        }

        #endregion

        void MainFormLoad(object sender, EventArgs e)
        {
            SplashForm.Display(Application.ProductName);
            this.Text = Application.ProductName;
            tsslMsg.Text = "";
            List<string> errorStrs = new List<string>();

            //初始化日志记录功能
            Globals.MLog = Log4netManager.GetLogger();
            Globals.MLog.Info("========== 程序启动 ==========");

            //初始化用户信息
            Globals.CurrentUser = "工程师";

            //初始化运行模式
            Globals.CurrentRunMode = Globals.RunMode.ProductionMode;

            //TODO: 初始化视觉
            SplashForm.SetTextAndProgress("正在初始化相机和视觉程序...", 10);
            string rsStr = Acqs.Init();
            if (rsStr != "OK")
            {
                string tempStr = "初始化相机错误：" + rsStr;
                errorStrs.Add(tempStr);
                Globals.MLog.Error(tempStr);
            }

            rsStr = ProductManager.SetProduct(0);

            //初始化光源控制器
            SplashForm.SetTextAndProgress("正在初始化光源控制...", 50);
            Globals.OPTController = new OPTControllerAPI();
            int ret = Globals.OPTController.CreateEtheConnectionByIP("");
            if (ret != 0)
            {
                string tempStr = "光源控制器连接失败：" + ret;
                errorStrs.Add(tempStr);
                Globals.MLog.Error(tempStr);
            }

            //初始化PLC连接
            SplashForm.SetTextAndProgress("正在初始化PLC连接...", 80);
            int rsInt = Globals.MXStation1.Open();
            if (rsInt != 0)
            {
                string tempStr = "PLC连接失败：" + rsInt;
                errorStrs.Add(tempStr);
                Globals.MLog.Error(tempStr);
            }

            //初始化异常，禁用窗口
            //if (errorStrs.Count > 0)
            //{
            //    Globals.runStatus = Globals.RunStatus.Alarm;
            //    tsslMsg.Text = errorStrs[0];
            //    tsslMsg.ForeColor = Color.Red;
            //    MsgBox.Show(string.Join("\r\n", errorStrs), ico: MessageBoxIcon.Error);
            //    panelTitle.Enabled = false;
            //    ShowForm<FrmLog>(btnLog);
            //    return;
            //}

            btnHome.PerformClick();

            //启动刷新界面timer
            tUpdateUI.Start();
            SplashForm.CloseDisplay();
        }

        private void FrmFrame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MsgBox.Show("确定退出程序？", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.OK)
            {
                try
                {
                    //TODO: 程序关闭,释放资源
                    Globals.OPTController.DestoryEtheConnect();





                }
                catch { }
                Globals.MLog.Info("程序关闭");
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void tUpdateUI_Tick(object sender, EventArgs e)
        {
            TSSL_DateTime.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
            tsslRunStatus.Text = EnumDescription.GetFieldText(Globals.runStatus);
            tsslRunStatus.ForeColor = Globals.runStatus == Globals.RunStatus.Alarm ? Color.Red : Color.Black;
            if (tsslCurrentUser.Text != Globals.CurrentUser)
            {
                tsslCurrentUser.Text = Globals.CurrentUser;
                tsslCurrentUser.ForeColor = Globals.CurrentUser == "工程师" ? Color.Red : Color.Black;
                Globals.SetControlsEnable(panelTitle);
            }

            tsslMode.Text = EnumDescription.GetFieldText(Globals.CurrentRunMode);
            tsslMode.ForeColor = Globals.CurrentRunMode == Globals.RunMode.ProductionMode ? Color.Black : Color.Red;


        }

        private void panelTitle_DoubleClick(object sender, EventArgs e)
        {
            this.Location = new Point(0, 0);
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            Vision.StartAutoRun();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            Vision.StopAutoRun();
        }

    }
}

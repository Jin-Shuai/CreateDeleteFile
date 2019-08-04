using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using HalconDotNet;

namespace CreateDeleteFile
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
        }
        //实例化视觉类
        HalconVision HalconVision = new HalconVision();

        private void MainFrm_Load(object sender, EventArgs e)
        {
            //读取配置参数
            Read_Parameter();
            //创建结果图像文件夹
            HalconVision.CreationDateFile(HalconVision.SavePath.m_SavePath, (int)nudDayHour.Value, (int)nudNightHour.Value);
            //获取当前时间
            GetCurrentTime();
            //获取磁盘和文件大小
            GetDeleteDiverFileSize();
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnCreatePath_Click(object sender, EventArgs e)
        {
            //创建FolderBrowserDialog对象
            FolderBrowserDialog FBDialog = new FolderBrowserDialog();
            //判断是否选择文件夹
            if (FBDialog.ShowDialog() == DialogResult.OK)
            {
                //记录选择的文件夹
                HalconVision.SavePath.m_SavePath = FBDialog.SelectedPath;
                if (HalconVision.SavePath.m_SavePath.EndsWith("\\"))
                {
                    tbCreatePath.Text = HalconVision.SavePath.m_SavePath;//显示选择的文件夹
                }
                else
                {
                    tbCreatePath.Text = HalconVision.SavePath.m_SavePath + "\\";//显示选择的文件夹
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            //创建FolderBrowserDialog对象
            FolderBrowserDialog FBDialog = new FolderBrowserDialog();
            //判断是否选择文件夹
            if (FBDialog.ShowDialog() == DialogResult.OK)
            {
                //记录选择的文件夹
                HalconVision.SavePath.m_ReadPath = FBDialog.SelectedPath;
                if (HalconVision.SavePath.m_ReadPath.EndsWith("\\"))
                {
                    tbSelectFile.Text = HalconVision.SavePath.m_ReadPath;//显示选择的文件夹
                }
                else
                {
                    tbSelectFile.Text = HalconVision.SavePath.m_ReadPath + "\\";//显示选择的文件夹
                }
            }
        }

        private void tmrPath_Tick(object sender, EventArgs e)
        {//图像保存路径的定时器
            int intHour = DateTime.Now.Hour;
            int intMinute = DateTime.Now.Minute;
            int intSecond = DateTime.Now.Second;

            //白班
            int iWHour = (int)nudDayHour.Value;
            int iWMinute = (int)nudDayMinute.Value;
            int iWSecond = (int)nudDaySecond.Value;
            //夜班
            int iBHour = (int)nudNightHour.Value;
            int iBMinute = (int)nudNightMinute.Value;
            int iBSecond = (int)nudNightSecond.Value;

            // 设置　每天的08:00:00创建一个白班文件夹  
            if (intHour == iWHour && intMinute == iWMinute && intSecond == iWSecond)
            {
                //对当前日期进行格式化
                string strName = DateTime.Now.ToString("yyyy年MM月dd日 白班");
                //创建DirectoryInfo对象
                DirectoryInfo DInfo = new DirectoryInfo(HalconVision.SavePath.m_SavePath + strName);
                //创建文件夹
                DInfo.Create();
            }

            // 设置　每天的20:00:00创建一个夜班文件夹 
            if (intHour == iBHour && intMinute == iBMinute && intSecond == iBSecond)
            {
                //对当前日期进行格式化
                string strName = DateTime.Now.ToString("yyyy年MM月dd日 夜班");
                //创建DirectoryInfo对象
                DirectoryInfo DInfo = new DirectoryInfo(HalconVision.SavePath.m_SavePath + strName);
                //创建文件夹
                DInfo.Create();
            }

        }

        public void Save_Parameter()
        {//保存设置参数
            try
            {
                HalconVision.IniWriteValue("图像路径", "CreatePath", tbCreatePath.Text, HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("图像路径", "SelectFile", tbSelectFile.Text, HalconVision.SavePath.m_IniPath);

                HalconVision.IniWriteValue("班次设定", "nudDayHour", Convert.ToString(nudDayHour.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("班次设定", "nudDayMinute", Convert.ToString(nudDayMinute.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("班次设定", "nudDaySecond", Convert.ToString(nudDaySecond.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("班次设定", "nudNightHour", Convert.ToString(nudNightHour.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("班次设定", "nudNightMinute", Convert.ToString(nudNightMinute.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("班次设定", "nudNightSecond", Convert.ToString(nudNightSecond.Value), HalconVision.SavePath.m_IniPath);

                HalconVision.IniWriteValue("磁盘设定", "nudRAM", Convert.ToString(nudRAM.Value), HalconVision.SavePath.m_IniPath);
                HalconVision.IniWriteValue("磁盘设定", "nudDay", Convert.ToString(nudDay.Value), HalconVision.SavePath.m_IniPath);
            }
            catch (Exception)
            { }
        }

        public void Read_Parameter()
        {//读取设置参数
            tbCreatePath.Text = HalconVision.IniReadValue("图像路径", "CreatePath", HalconVision.SavePath.m_IniPath);
            tbSelectFile.Text = HalconVision.IniReadValue("图像路径", "SelectFile", HalconVision.SavePath.m_IniPath);

            nudDayHour.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudDayHour", HalconVision.SavePath.m_IniPath));
            nudDayMinute.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudDayMinute", HalconVision.SavePath.m_IniPath));
            nudDaySecond.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudDaySecond", HalconVision.SavePath.m_IniPath));
            nudNightHour.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudNightHour", HalconVision.SavePath.m_IniPath));
            nudNightMinute.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudNightMinute", HalconVision.SavePath.m_IniPath));
            nudNightSecond.Value = Convert.ToDecimal(HalconVision.IniReadValue("班次设定", "nudNightSecond", HalconVision.SavePath.m_IniPath));

            nudRAM.Value = Convert.ToDecimal(HalconVision.IniReadValue("磁盘设定", "nudRAM", HalconVision.SavePath.m_IniPath));
            nudDay.Value = Convert.ToDecimal(HalconVision.IniReadValue("磁盘设定", "nudDay", HalconVision.SavePath.m_IniPath));
        }

        private void btnSet_Click(object sender, EventArgs e)
        {//保存设置
            Save_Parameter();
        }

        private void GetCurrentTime()
        {//获取当前年月日
            tbDayYear.Text = tbNightYear.Text = Convert.ToString(DateTime.Now.Year);
            tbDayMonth.Text = tbNightMonth.Text = Convert.ToString(DateTime.Now.Month);
            tbDayDay.Text = tbNightDay.Text = Convert.ToString(DateTime.Now.Day);
        }

        private void btnGetWeight_Click(object sender, EventArgs e)
        {//获取选中文件大小
            GetDeleteDiverFileSize();           
        }

        private void GetDeleteDiverFileSize()
        {//获取磁盘和文件大小
            //获取磁盘大小
            HalconVision.GetHardDiskFreeSpace(tbSelectFile.Text, out HalconVision.FileSize.m_TotalCapacity, out HalconVision.FileSize.m_Capacity, out HalconVision.FileSize.m_FreeSpace);
            tbTotalCapacity.Text = HalconVision.FileSize.m_TotalCapacity;//显示总空间
            tbCapacity.Text = HalconVision.FileSize.m_Capacity;//显示剩余空间

            //获取文件大小
            HalconVision.GetFilesSize(tbSelectFile.Text, out HalconVision.FileSize.m_FileSize);
            tbCapacitySize.Text = HalconVision.FileSize.m_FileSize;//显示文件大小

            //删除文件夹  
            if (HalconVision.FileSize.m_FreeSpace < nudRAM.Value)
            {
                //删除文件夹
                HalconVision.DeleteFile(tbSelectFile.Text, (int)nudDay.Value);
            }         
        }      
    }
}

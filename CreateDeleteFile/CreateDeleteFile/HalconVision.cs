using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HalconDotNet;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;

//实例化视觉类
//HalconVision HalconVision = new HalconVision();

namespace CreateDeleteFile
{
    //异常错误信息
    public struct s_CheckError
    {
        public int iErrorType;					// 错误代码
        public string strErrorInfo;				// 错误描述
    }

    //定义串口变量
    public class ComParam
    {
        //串口参数
        public string m_Com;			        //串口对象
        public int m_iComPort;					//串口号
        public int m_iComBatery;				//波特率
        public int m_iComDDV;					//校验位
        public int m_iComBits;					//数据位
        public int m_iComStopBit;				//停止位

        public ComParam()
        {
            //串口参数
            m_Com = "COM1";			        //串口对象
            m_iComPort = 1;					//串口号
            m_iComBatery = 9600; ;		    //波特率
            m_iComDDV = 0;					//校验位
            m_iComBits = 8;					//数据位
            m_iComStopBit = 1;				//停止位
        }
    }

    //定义相机变量
    public class CamParam
    {
        public HTuple m_AcqHandle;			//相机类的对象指针
        public HTuple m_CamSN;	            //相机SN号，可以根据相机上的SN填写
        public bool m_bExternalTrigger;  	//1为外触发，0为软触发
        public double m_Shutter;		    //相机快门
        public double m_Gain;				//相机增益
        public HTuple m_CamNum;				//相机数量
        public bool m_bCamIsOK;             //相机是否存在

        public CamParam()
        {
            m_AcqHandle = -1;
            m_CamSN = -1;
            m_bExternalTrigger = false;
            m_Shutter = 1000;
            m_Gain = 0;
            m_CamNum = 0;
        }
    }

    //定义模板变量
    public class Model
    {
        //模板参数
        public HTuple m_ModelID;				//定位模板
        public HObject m_ModelRegion;			//模板区域

        public Model()
        {
            m_ModelID = -1;
            HOperatorSet.GenEmptyObj(out m_ModelRegion);
        }

        ~Model()
        {
            ClearShapeModel(ref m_ModelID);
            m_ModelRegion.Dispose();
        }

        public void ClearShapeModel(ref HTuple ModelID)
        {
            if (ModelID > -1)
            {
                HOperatorSet.ClearShapeModel(ModelID);
                ModelID = -1;
            }
        }
    }

    //定义相机标定参数
    public class CamCaliParm
    {
        //定义相机内参
        //定义镜头焦距   远心镜头焦距为0 
        public double m_Focus;
        //定义相机畸变系数
        public double m_Kappa;
        //定义相机相元大小
        public double m_Sx;
        public double m_Sy;
        //定义图像中心中标
        public double m_Cx;
        public double m_Cy;
        //定义图像宽度 高度
        public int m_ImgWidth;
        public int m_ImgHeight;

        //定义相机内参数组
        public HTuple m_CamParIn = null;

        //定义相机句柄
        public HTuple m_AcqHandle;

        //定义标定参数
        //定义标定句柄
        public HTuple m_CalibDataID;
        //定义标定板轮廓
        public HObject m_CalibContours;
        //定义标定板标定点
        public HObject m_CalibCross;

        //定义标定数组参数
        public HTuple m_CamParam = null;

        //定义校正图像
        public HObject m_MapImage;

        //设置相机和标定板参数
        //设置标定板类型
        public HTuple m_CalibSetup;
        //设置相机类型
        public HTuple m_CameraType;
        //设置标定板描述文件
        public HTuple m_CalTabDescrFile;

        public CamCaliParm()
        {
            m_Focus = 0.00219846;
            m_Kappa = -78129.2;

            m_Sx = 5.5e-06;
            m_Sy = 5.5e-06;

            m_Cx = 320;
            m_Cy = 240;

            m_ImgWidth = 640;
            m_ImgHeight = 480;

            m_CamParIn = new HTuple();
            m_CamParIn[0] = m_Focus;
            m_CamParIn[1] = m_Kappa;
            m_CamParIn[2] = m_Sx;
            m_CamParIn[3] = m_Sy;
            m_CamParIn[4] = m_Cx;
            m_CamParIn[5] = m_Cy;
            m_CamParIn[6] = m_ImgWidth;
            m_CamParIn[7] = m_ImgHeight;

            m_AcqHandle = -1;
            m_CalibDataID = -1;
            HOperatorSet.GenEmptyObj(out m_CalibContours);
            HOperatorSet.GenEmptyObj(out m_CalibCross);
            HOperatorSet.GenEmptyObj(out m_MapImage);

            m_CalibSetup = "calibration_object";
            m_CameraType = "area_scan_division";
            m_CalTabDescrFile = "caltab_big.descr";
        }
    }

    //定义公用图像和区域变量
    public class ImageRegion
    {
        //定义图像
        public HObject m_Image1;
        public HObject m_Image2;
        public HObject m_Image3;
        public HObject m_Image4;
        public HObject m_Image5;
        public HObject m_Image6;
        public HObject m_Image7;
        public HObject m_Image8;

        //定义区域
        public HObject m_Region1;
        public HObject m_Region2;
        public HObject m_Region3;
        public HObject m_Region4;
        public HObject m_Region5;
        public HObject m_Region6;
        public HObject m_Region7;
        public HObject m_Region8;

        public ImageRegion()
        {
            HOperatorSet.GenEmptyObj(out m_Image1);
            HOperatorSet.GenEmptyObj(out m_Image2);
            HOperatorSet.GenEmptyObj(out m_Image3);
            HOperatorSet.GenEmptyObj(out m_Image4);
            HOperatorSet.GenEmptyObj(out m_Image5);
            HOperatorSet.GenEmptyObj(out m_Image6);
            HOperatorSet.GenEmptyObj(out m_Image7);
            HOperatorSet.GenEmptyObj(out m_Image8);

            HOperatorSet.GenEmptyObj(out m_Region1);
            HOperatorSet.GenEmptyObj(out m_Region2);
            HOperatorSet.GenEmptyObj(out m_Region3);
            HOperatorSet.GenEmptyObj(out m_Region4);
            HOperatorSet.GenEmptyObj(out m_Region5);
            HOperatorSet.GenEmptyObj(out m_Region6);
            HOperatorSet.GenEmptyObj(out m_Region7);
            HOperatorSet.GenEmptyObj(out m_Region8);
        }
    }

    //定义文件保存路劲
    public class SavePath
    {
        //配置文件路劲
        public string m_IniPath;
        //图像读取路径
        public string m_ReadPath;
        //图像保存路径
        public string m_SavePath;
        //标定图像路径
        public string m_CalibPath;

        //相机内参数组
        public string m_CamParInPath;

        public SavePath()
        {
            m_IniPath = Application.StartupPath + "//SoftwareConfig.ini";
            m_ReadPath = "F:/Image/";
            m_SavePath = "F:/Image/";
            m_CalibPath = "F:/Image/";

            m_CamParInPath = Application.StartupPath + "//CamParIn.ini";
        }



    }

    //定义4个标定线程
    public class ThreadCalibration
    {
        //定义线程启动标志位
        public bool m_bBusy1;
        public bool m_bBusy2;
        public bool m_bBusy3;
        public bool m_bBusy4;
        //定义线程
        public Thread m_GrabThread1;
        public Thread m_GrabThread2;
        public Thread m_GrabThread3;
        public Thread m_GrabThread4;

        public ThreadCalibration()
        {
            m_bBusy1 = false;
            m_bBusy2 = false;
            m_bBusy3 = false;
            m_bBusy4 = false;
        }
    }

    //定义文件大小
    public class FileSize
    {
        //选中磁盘总大小
        public string m_TotalCapacity;
        //选中磁盘剩余大小
        public string m_Capacity;
        public int  m_FreeSpace;

        //单个文件夹大小
        public string m_FileSize;

        public FileSize()
        {
            m_TotalCapacity = "G9";
            m_Capacity = "G9";
            m_FreeSpace = 5;

            m_FileSize = "G9";
        }
    }

    public class HalconVision
    {
        #region //A00 单例模式
        private static HalconVision _instance = null;
        public static HalconVision Instance()
        {
            if (_instance == null)
            {
                _instance = new HalconVision();
            }
            return _instance;
        }
        #endregion

        #region //A01 Ini文件读写
        //声明读写INI文件的API函数  
        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal,
                                    int size, string filePath);
        //复制内存
        [DllImport("Kernel32.dll")]
        private static extern void CopyMemory(int dest, int source, int size);

        //保存参数到ini文件  
        public void IniWriteValue(string Section, string Key, string Value, string Path)
        {
            WritePrivateProfileString(Section, Key, Value, Path);
        }

        //读取ini文件中的参数   
        public string IniReadValue(string Section, string Key, string Path)
        {
            StringBuilder temp = new StringBuilder(255);
            int i = GetPrivateProfileString(Section, Key, "", temp, 255, Path);
            return temp.ToString();
        }
        #endregion

        #region //A02 实例化对象
        public ComParam ComParam = new ComParam();
        public CamParam CamParam = new CamParam();
        public Model Model = new Model();
        public CamCaliParm CamCaliParm = new CamCaliParm();
        public ImageRegion ImageRegion = new ImageRegion();
        public SavePath SavePath = new SavePath();
        public ThreadCalibration ThreadCalibration = new ThreadCalibration();
        public FileSize FileSize = new FileSize();
        #endregion

        #region//A03 自定义函数
        public void ShowImage(HObject Image, HTuple HalconWindowID)
        {
            //记录图片显示的宽度、高度
            HTuple Width, Heigth;
            //清屏
            HOperatorSet.ClearWindow(HalconWindowID);
            //获取图片长度、宽度
            HOperatorSet.GetImageSize(Image, out Width, out Heigth);
            //设置显示区域
            HOperatorSet.SetPart(HalconWindowID, 0, 0, Heigth, Width);
            //显示图片
            HOperatorSet.DispObj(Image, HalconWindowID);
        }

        public void CreationDateFile(string ImgSavePath, int DayHour, int NightHour)
        {//分白夜班按日期创建文件夹
            //int DayHour = 8;
            //int NightHour = 20;

            //获取当前小时
            int JudgHour = DateTime.Now.Hour;
            if (JudgHour >= DayHour && JudgHour <= NightHour)
            {
                //对当前日期进行格式化
                string strName = DateTime.Now.ToString("yyyy年MM月dd日 白班");
                //创建DirectoryInfo对象
                DirectoryInfo DInfo = new DirectoryInfo(ImgSavePath + strName);
                //判断白班文件夹是否存在
                if (Directory.Exists(@"ImgResultPath + strName"))
                {
                    return;
                }
                else
                {
                    //创建文件夹
                    DInfo.Create();
                }
            }
            else if (JudgHour < DayHour)
            {
                //以前一天的日期来命名文件夹
                string strName = DateTime.Now.AddDays(-1).ToString("yyyy年MM月dd日 夜班");
                //创建DirectoryInfo对象
                DirectoryInfo DInfo = new DirectoryInfo(ImgSavePath + strName);
                //判断夜班文件夹是否存在
                if (Directory.Exists(@"ImgResultPath + strName"))
                {
                    return;
                }
                else
                {
                    //创建文件夹
                    DInfo.Create();
                }
            }
            else
            {
                //对当前日期进行格式化
                string strName = DateTime.Now.ToString("yyyy年MM月dd日 夜班");
                //创建DirectoryInfo对象
                DirectoryInfo DInfo = new DirectoryInfo(ImgSavePath + strName);
                //判断夜班文件夹是否存在
                if (Directory.Exists(@"ImgResultPath + strName"))
                {
                    return;
                }
                else
                {
                    //创建文件夹
                    DInfo.Create();
                }
            }
        }

        public double  GetFilesSize(String FilePath ,out string FileSize)
        {//获取单个文件夹的大小 //路劲中不要有中文
            DirectoryInfo directoryInfo = new DirectoryInfo(FilePath);
            double length = 0;
            try
            {               
                foreach (FileSystemInfo fsi in directoryInfo.GetFileSystemInfos())
                {
                    if (fsi is FileInfo)
                    {
                        length += ((FileInfo)fsi).Length;
                    }
                    else
                    {
                        length += GetFilesSize(fsi.FullName, out FileSize);
                    }
                }
            }
            catch(Exception)
            { }


            FileSize = Convert.ToString(double.Parse((length / (1024 * 1024 * 1024)).ToString("0.00"))) + " G"; 
            return 0;
        }

        public void GetHardDiskFreeSpace(string FilePath, out string TotalCapacity, out string Capacity ,out int FreeSpace)
        {//获取磁盘大小 //路劲中不要有中文
            HTuple Substrings = null, Substring = null;
            HOperatorSet.TupleSplit(FilePath, ":", out Substrings);
            Substring = Substrings[0] + ":\\";

            TotalCapacity = "G8";
            Capacity = "G8";
            FreeSpace = 5;
      
            System.IO.DriveInfo[] drives = System.IO.DriveInfo.GetDrives();
            foreach (System.IO.DriveInfo drive in drives)
            {
                if (drive.Name == Substring)
                {
                    TotalCapacity = drive.TotalSize / 1024 / 1024 / 1024 + " G1";//显示总空间
                    Capacity = drive.TotalFreeSpace / 1024 / 1024 / 1024 + " G1";//显示剩余空间
                    FreeSpace = (int)(drive.TotalFreeSpace / 1024 / 1024 / 1024);
                }
            }
        }

        public void DeleteFile(string fileDirect, int saveDay)
        {// 删除文件夹
            DateTime nowTime = DateTime.Now;
            DirectoryInfo root = new DirectoryInfo(fileDirect);
            DirectoryInfo[] dics = root.GetDirectories(); //获取文件夹

            FileAttributes attr = File.GetAttributes(fileDirect);
            if (attr == FileAttributes.Directory) //判断是不是文件夹
            {
                foreach (DirectoryInfo file in dics) //遍历文件夹
                {
                    TimeSpan t = nowTime - file.CreationTime;  //当前时间  减去 文件创建时间
                    int day = t.Days;
                    if (day > saveDay)   //保存的时间 单位：天
                    {
                        Directory.Delete(file.FullName, true);  //删除超过时间的文件夹
                    }
                }
            }
        }
        #endregion

        #region//A04 Halcon自带函数

        #endregion
    }
}


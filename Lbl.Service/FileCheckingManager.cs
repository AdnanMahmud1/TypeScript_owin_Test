using System;

namespace Lbl.Service
{
    public class FileCheckingManager
    {
        public static string TestProjectFileLocation(int type = 1)
        {
            string physicalPath = "";
            physicalPath = type == 1 ? @"E:\ImageTest\Images\" : @"E:\ImageTest\No_image2.jpg";

            return physicalPath;
        }


        public static bool OnlineAdmFileCheck(string fileExt)
        {
            string extension = fileExt.ToLower();
            if (extension == ".jpg" || extension == ".JPG" || extension == ".jpeg")
            {
                return true;
            }
            return false;
        }


        public static string FileUploadLocation()
        {
            string physicalPath = @"E:\ImageTest\Images\";
            return physicalPath;
        }
        public static String BytesToString(long byteCount)
        {
            string[] suf = { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
            if (byteCount == 0)
                return "0" + suf[0];
            long bytes = Math.Abs(byteCount);
            int place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
            double num = Math.Round(bytes / Math.Pow(1024, place), 1);
            return (Math.Sign(byteCount) * num).ToString() + suf[place];
        }
        public static bool CheckUploadedFileType(string fileExt)
        {
            string extension = fileExt.ToLower();
            if (extension == ".jpg" || extension == ".doc" || extension == ".docx" ||
                extension == ".pdf" || extension == ".xls" || extension == ".xlsx" ||
                extension == ".ppt" || extension == ".pptx" || extension == ".txt" || extension == ".png" || extension == ".jpeg")
            {
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DownLoadTool.common
{
   public  class ChangeFileName
    {
        /// <summary>
        /// thay đổi đuôi tên từ mp4 -> mp3(true) hoặc ngược lại false 
        /// </summary>
        /// <param name="fileName">tên file đầy đủ </param>
        /// /// <param name="type">true: mp3, false: mp4</param>
        /// <returns>null</returns>
        public static string ChangeType(string fileName,bool type)
        {
           
            if (type)
            {
                if (fileName.EndsWith(".mp4"))
                {
                    fileName = FourCharacters(fileName);
                    fileName += ".mp3";
                    return fileName;
                }
            }  
            else
            {
                if (fileName.EndsWith(".mp3"))
                {
                    fileName = FourCharacters(fileName);
                    fileName += ".mp4";
                    return fileName;
                }
            }
            return "";
        }
         static string FourCharacters(string str)
        {
            return string.IsNullOrEmpty(str) ? "" : str.Remove(str.Length - 4, 4);
        }
    }
}

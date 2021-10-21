using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using xNet;

namespace DownLoadTool
{
    class FaceBook
    {


        public List<object> GetVideoFaceBook(string link)
        {
            HttpRequest http = new HttpRequest();
            List<object> listUrl = new List<object>();
            http.AddParam("url", link);
            http.Referer = "https://snapsave.app/vn";

            string html = http.Post(@"https://snapsave.app/action.php?lang=vn").ToString();
           
            html = html.Replace("\\", "");
            string regexResolution = "(?<=<td class=\"video-quality\">)(.*?)(?=<\\/td>)";//ok
            string regexUrl = "(?<=a href=\")(https:.*?)(?=\" onclick)";//ok
            var url = Regex.Matches(html, regexUrl, RegexOptions.Singleline);
            var resolution = Regex.Matches(html, regexResolution, RegexOptions.Singleline);
            if (url.Count > 0)
            {
                for (int i = 0; i < url.Count; i++)
                {
                    listUrl.Add(new { Uri = url[i], Resolution = resolution[i] });
                }
            }
            return listUrl;

        }

    }
}

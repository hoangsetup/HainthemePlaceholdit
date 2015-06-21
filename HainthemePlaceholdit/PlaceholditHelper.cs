using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;

namespace HainthemePlaceholdit
{
    internal static class PlaceholditHelper
    {
        //private static string LinkPartent =
        //    "https://placeholdit.imgix.net/~text?txtsize=-txtsize-&bg=-bgcolor-&txtclr=-txtcolor-&txt=-txt-&-size-&fm=-format-";
        private static string LinkPartent = "http://placehold.it/-size-/-bgcolor-/-txtcolor--format--text-";

        public static void DownloadImage(string parentPath, MyImageFile img)
        {
            string bgcolor = "0099ff";
            string txtcolor = "ffffff";
            string txt = img.Text;
            string size = img.Size;
            string format = img.Format;
            string txtsize = img.TextSize + "";
            string text = "?text=";
            if (!string.IsNullOrEmpty(img.BgColor))
            {
                bgcolor = img.BgColor;
            }
            if (!string.IsNullOrEmpty(img.TxtColor))
            {
                txtcolor = img.TxtColor;
            }
            if (!string.IsNullOrEmpty(img.Text))
            {
                text += img.Text;
            }
            else
            {
                text = "";
            }
            string link =
                LinkPartent.Replace("-bgcolor-", bgcolor)
                    .Replace("-txtcolor-", txtcolor)
                    .Replace("-txt-", txt)
                    .Replace("-size-", size)
                    .Replace("-format-", format).Replace("-txtsize-", txtsize).Replace("-text-", text);
            Image image = GetImageFromUrl(link);
            string fileName = Path.Combine(parentPath, img.Name);
            image.Save(fileName);
        }

        private static Image GetImageFromUrl(string url)
        {
            HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);

            using (HttpWebResponse httpWebReponse = (HttpWebResponse)httpWebRequest.GetResponse())
            {
                using (Stream stream = httpWebReponse.GetResponseStream())
                {
                    if (stream != null) return Image.FromStream(stream);
                }
            }
            return null;
        }
    }
}

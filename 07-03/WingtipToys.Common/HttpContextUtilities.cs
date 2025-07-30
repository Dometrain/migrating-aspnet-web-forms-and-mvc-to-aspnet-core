using System.Web;

namespace WingtipToys.Common
{
    public static class HttpContextUtilities
    {
        public static bool IsMobileBrowser()
        {
            var userAgent = HttpContext.Current?.Request?.UserAgent ?? string.Empty;
            return userAgent.ToLower().Contains("mobi");
        }
    }
}
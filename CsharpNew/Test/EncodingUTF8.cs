using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CsharpNew
{
    class EncodingUTF8
    {
        public static string HttpPost(string url, string msg, Encoding encodingIn, Encoding encodingOut, string contentType = "application/xml;charset=utf-8", Dictionary<string, string> dicHeader = null)
        {
            ServicePointManager.DefaultConnectionLimit = 200;

            ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls;

            HttpWebRequest request = null;

            request = WebRequest.Create(url) as HttpWebRequest;
            if (dicHeader != null)
            {
                foreach (var header in dicHeader)
                {
                    request.Headers.Add(header.Key, header.Value);
                }
            }

            //ssl双向认证附加客户端证书
            //if (cert != null)
            //{
            //    var now = DateTime.Now;

            //    var effectiveDateStr = cert.GetEffectiveDateString();

            //    var expirationDateStr = cert.GetExpirationDateString();

            //    var effectiveDate = Convert.ToDateTime(effectiveDateStr);

            //    var expirationDate = Convert.ToDateTime(expirationDateStr);

            //    if (effectiveDate > now)
            //    {
            //        throw new Exception("证书:" + cert.Issuer + " 尚未生效");
            //    }

            //    if (expirationDate < now)
            //    {
            //        throw new Exception("证书:" + cert.Issuer + " 已经过期");
            //    }

            //    request.ClientCertificates.Add(cert);
            //}
            request.ProtocolVersion = HttpVersion.Version11;
            request.Method = "POST";
            request.ContentType = contentType;
            if (msg != null)
            {
                var data = encodingIn.GetBytes(msg);
                request.ContentLength = data.Length;
                using (var stream = request.GetRequestStream())
                {
                    stream.Write(data, 0, data.Length);
                }
            }

            var response = (HttpWebResponse)request.GetResponse();
            var streamResponse = response.GetResponseStream();
            if (streamResponse == null)
                return string.Empty; //GetEncoding("GB2312")
            using (var sr = new StreamReader(streamResponse, encodingOut))
            {
                var result = sr.ReadToEnd();
                response.Close();
                return result;
            }
        }

    }
}

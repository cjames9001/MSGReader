﻿/*
   Copyright 2013-2018 Kees van Spelde

   Licensed under The Code Project Open License (CPOL) 1.02;
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

     http://www.codeproject.com/info/cpol10.aspx

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
   See the License for the specific language governing permissions and
   limitations under the License.
*/
using System.Text;

namespace MsgReader.Outlook
{
    /// <summary>
    /// This class is used to convert RTF to HTML
    /// </summary>
    internal static class RtfToHtmlConverter
    {
        #region ConvertRtfToHtml
        /// <summary>
        /// Convert RTF to HTML
        /// </summary>
        /// <param name="rtf">The rtf string</param>
        /// <returns></returns>
        public static string ConvertRtfToHtml(string rtf)
        {
            if (string.IsNullOrEmpty(rtf))
                return string.Empty;

            Encoding encoding = Encoding.ASCII;
            byte[] bytes = encoding.GetBytes(rtf);
            rtf = encoding.GetString(bytes);

            var html = RtfPipe.Rtf.ToHtml(rtf.Trim('\0'));
            return html;
        }
        #endregion
    }
}

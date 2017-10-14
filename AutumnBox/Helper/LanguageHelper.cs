/* =============================================================================*\
*
* Filename: LanguageHelper.cs
* Description: 
*
* Version: 1.0
* Created: 9/23/2017 21:21:10(UTC+8:00)
* Compiler: Visual Studio 2017
* 
* Author: zsh2401
* Company: I am free man
*
\* =============================================================================*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AutumnBox.Helper
{
    /// <summary>
    /// 待完成
    /// </summary>
    public static class LanguageHelper
    {
        public enum LanguageType
        {
            zh_CN,
            en_US,
        }
        public static LanguageType CurrentLanguage { get; private set; }
        public static void ChangeLanuage(LanguageType lang)
        {
            throw new NotImplementedException();
#pragma warning disable CS0162 // 检测到无法访问的代码
            string _lang = lang.ToString().Replace('_', '-');
#pragma warning restore CS0162 // 检测到无法访问的代码
            if (App.Current.Resources["LanguageName"].ToString() != lang.ToString())
                Application.Current.Resources.Source = new Uri($@"Lang\{_lang}.xaml", UriKind.Relative);
        }
    }
}
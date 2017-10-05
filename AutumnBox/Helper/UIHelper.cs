﻿using AutumnBox.Basic.Devices;
using AutumnBox.Basic.Functions.RunningManager;
using AutumnBox.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;

namespace AutumnBox.Helper
{
    public static class UIHelper
    {
        /// <summary>
        /// 设置一个grid下的所有button的开启与否
        /// </summary>
        /// <param name="grid"></param>
        /// <param name="status"></param>
        public static void SetGridButtonStatus(Grid grid, bool status)
        {
            var o = grid.Children;
            foreach (object a in o)
            {
                Button btn = (a as Button);
                if (btn != null)
                {
                    btn.IsEnabled = status;
                }
            }
        }
        /// <summary>
        /// 将Bitmap转为BitmapImage
        /// </summary>
        /// <param name="bitmap">一个bitmap对象</param>
        /// <returns>一个BitmapImage对象</returns>
        public static BitmapImage BitmapToBitmapImage(System.Drawing.Bitmap bitmap)
        {
            BitmapImage bitmapImage = new BitmapImage();
            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                bitmap.Save(ms, bitmap.RawFormat);
                bitmapImage.BeginInit();
                bitmapImage.StreamSource = ms;
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
            }
            return bitmapImage;
        }
        public static void DragMove(Window m, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                m.DragMove();
            }
        }
        public static void DragMove(Window m, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                m.DragMove();
            }
        }
        private static RateBox rateBox;
        public static void ShowRateBox(Window Owner,RunningManager rm=null) {
            try
            {
                if (rm == null)
                {
                    rateBox = new RateBox(Owner);
                    rateBox.ShowDialog();
                    return;
                }
                if (rateBox.IsActive) rateBox.Close();
                rateBox = new RateBox(Owner, rm);
                rateBox.ShowDialog();
            }
            catch
            {
                rateBox = new RateBox(Owner, rm);
                rateBox.ShowDialog();
            }
        }
        public static void CloseRateBox() {
            try
            {
               rateBox.Close();
            }
            catch { }
        }
    }

}

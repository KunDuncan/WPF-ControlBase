﻿
using System.Windows;

namespace HeBianGu.General.WpfControlLib
{
    /// <summary>
    /// 用于配置窗口关闭和打开时动画效果，需要外部注册
    /// </summary>
    public interface IWindowAnimationService
    {
        void CloseAnimation(Window window);

        void ShowAnimation(Window window);
    }
}
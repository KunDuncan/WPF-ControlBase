﻿using HeBianGu.Base.WpfBase;
using System.Windows;

namespace HeBianGu.Demo.Demo7
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vale = TestSetting.Instance.Value;
            MessageProxy.Windower.ShowSumit("框架自带的窗口对话框");
        }
    }
}

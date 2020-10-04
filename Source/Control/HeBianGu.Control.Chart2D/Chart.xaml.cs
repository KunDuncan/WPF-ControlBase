﻿using HeBianGu.Base.WpfBase;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HeBianGu.Control.Chart2D
{
    public class Chart : ViewLayerGroup
    {
        [TypeConverter(typeof(DisplayTypeConverter))]
        public ObservableCollection<string> Display
        {
            get { return (ObservableCollection<string>)GetValue(DisplayProperty); }
            set { SetValue(DisplayProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DisplayProperty =
            DependencyProperty.Register("Display", typeof(ObservableCollection<string>), typeof(Chart), new PropertyMetadata(new ObservableCollection<string>(), (d, e) =>
            {
                XyLayer control = d as XyLayer;

                if (control == null) return;

                ObservableCollection<string> config = e.NewValue as ObservableCollection<string>;

            }));



        public Style xAxisStyle
        {
            get { return (Style)GetValue(xAxisStyleProperty); }
            set { SetValue(xAxisStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty xAxisStyleProperty =
            DependencyProperty.Register("xAxisStyle", typeof(Style), typeof(Chart), new PropertyMetadata(default(Style), (d, e) =>
             {
                 Chart control = d as Chart;

                 if (control == null) return;

                 Style config = e.NewValue as Style;

             }));


        public Style  yAxisStyle
        {
            get { return (Style )GetValue(yAxisStyleProperty); }
            set { SetValue(yAxisStyleProperty, value); }
        }

        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty yAxisStyleProperty =
            DependencyProperty.Register("yAxisStyle", typeof(Style ), typeof(Chart), new PropertyMetadata(default(Style ), (d, e) =>
             {
                 Chart control = d as Chart;

                 if (control == null) return;

                 Style  config = e.NewValue as Style ;

             }));


    }

    //public class Chart : ChartScene
    //{

    //}

    //public class StaticCurveChartScene : Chart
    //{

    //}

}
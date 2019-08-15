﻿using HeBianGu.Base.WpfBase;
using HeBianGu.Common.PublicTool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace HeBianGu.General.WpfMvc
{
    public class MvcLogViewModelBase : MvcViewModelBase, IMvcLog
    {
        private ObservableCollection<Log> _logs = new ObservableCollection<Log>();
        /// <summary> 说明  </summary>
        public ObservableCollection<Log> Logs
        {
            get { return _logs; }
            set
            {
                _logs = value;
                RaisePropertyChanged("Logs");
            }
        }


        private ObservableCollection<Log> _runlogs = new ObservableCollection<Log>();
        /// <summary> 说明  </summary>
        public ObservableCollection<Log> RunLogs
        {
            get { return _runlogs; }
            set
            {
                _runlogs = value;
                RaisePropertyChanged("RunLogs");
            }
        }

        private ObservableCollection<Log> _errorlogs = new ObservableCollection<Log>();
        /// <summary> 说明  </summary>
        public ObservableCollection<Log> ErrorLogs
        {
            get { return _errorlogs; }
            set
            {
                _errorlogs = value;
                RaisePropertyChanged("ErrorLogs");
            }
        }

        private ObservableCollection<Log> _outputlogs = new ObservableCollection<Log>();
        /// <summary> 说明  </summary>
        public ObservableCollection<Log> OutPutLogs
        {
            get { return _outputlogs; }
            set
            {
                _outputlogs = value;
                RaisePropertyChanged("OutPutLogs");
            }
        }

        

        public void RunLog(string title,string message)
        {
            var log = new Log() { Flag = "\xe76c", Time = DateTime.Now.ToDateTimeString(), Title = title, Message = message };



            Application.Current.Dispatcher.Invoke(() =>
            {
                this.RunLogs.Add(log);
                this.Logs.Add(log);
            });

            
        }

        public void OutPutLog(string title, string message)
        {
            var log = new Log() { Flag = "\xe76c", Time = DateTime.Now.ToDateTimeString(), Title = title, Message = message }; 

            Application.Current.Dispatcher.Invoke(() =>
            {
                this.OutPutLogs.Add(log);
                this.Logs.Add(log);
            });


        }

        public void ErrorLog(string title, string message)
        {
            var log = new Log() { Flag = "\xe701", Time = DateTime.Now.ToDateTimeString(), Title = title, Message = message };

            Application.Current.Dispatcher.Invoke(() =>
            {
                this.ErrorLogs.Add(log);
                this.Logs.Add(log);
            });

        }
    }
}

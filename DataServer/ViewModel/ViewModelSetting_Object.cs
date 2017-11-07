﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;
using CobraDataServer;
using project.Helpers;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Runtime.CompilerServices;

namespace CobraDataServer
{
    partial class ViewModelSetting : ViewModelBase, INotifyPropertyChanged
    {
     
        // private string y = byte.Parse(data.hour_start_pipe.ToString());
        public static object list => data.eliminate;

        public string sizepacket { get => mydb.sizepacket.ToString(); set => mydb.sizepacket = int.Parse(value); }
        public string Prefix1 { get => data.pipe_prefix1; set => data.pipe_prefix1 = value; }
        public string Prefix2 { get => data.pipe_prefix2; set => data.pipe_prefix2 = value; }
        public string Pathtik1 { get => data.pathTIKERS1; set => data.pathTIKERS1 = value; }
        public string Pathtik2 { get => data.pathTIKERS2; set => data.pathTIKERS2 = value; }
        public string HourStartPipe { get => data.hour_start_pipe.ToString();  set => byte.Parse(value); }

        public string bdconn { get => mydb.Connectparam; set => mydb.Connectparam = value; }
        public string bdpath { get => mydb.Path; set => mydb.Path = value; }
        public string bdname { get => mydb.Namebd; set => mydb.Namebd = value; }

        public bool enabledatabase { get => mydb.enable; set => mydb.enable = value; }
        public bool enablepipe { get => data.PIPEENABLE; set => data.PIPEENABLE = value; }




        public List<string> listalltickers
        {
            get
            {
                return (data.ListTickers);
            }
            set {  }
        }

        // Using a DependencyProperty as the backing store for listalltickers.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty listalltickersProperty =
            DependencyProperty.Register("listalltickers", typeof(List<string>), typeof(ListBox), 
                new PropertyMetadata(new List<string>()  ));



        public List<string> listactive
        {
            get { return mydb.listtickers; }
            set { }
        }

        ////Using a DependencyProperty as the backing store for listDB.This enables animation, styling, binding, etc...
        public static readonly DependencyProperty listactveProperty =
            DependencyProperty.Register("listactive", typeof(List<string>), typeof(ListBox),
                new PropertyMetadata(mydb.listtickers
                ));
      

        #region Реализация INotifyPropertyChanged
        /// <summary>Уведомляет подписчика о изменении свойства</summary>
        void NotifyPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged;


        public void NamedPropertyChanged(string PropertyName)
        {
            PropertyChanged?.Invoke(this, new System.ComponentModel.PropertyChangedEventArgs(PropertyName));
        }

        #endregion
    }//class


}//namespace

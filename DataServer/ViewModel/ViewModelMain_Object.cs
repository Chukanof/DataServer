﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Collections;

namespace project.ViewModel
{
    partial class ViewModelMain : ViewModelBase
    {


        public object memory
        {
            get
            {
                return "(C) 2017 Memory Usage: " + string.Format("{0:0.00} MB", GC.GetTotalMemory(true) / 1024.0 / 1024.0);
            }

        }

        public static object list => Model.data.eliminate;

    }//class



    public class Instumensts
    {
        public Instumensts(string s, string cl)
        {
            _name = s;
            _class = cl;
            _bid = 0;
            _ask = 0;
        }
        string _name, _class;
        decimal _bid, _ask;
        int _ct=0;


        public int ct
        {
            get
            {
                return _ct;
            }
            set
            {
                _ct = value;
            }
        }

        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public string Class
        {
            get
            {
                return _class;
            }
            set
            {
                _class = value;
            }
        }

        public decimal ask
        {
            get
            {
                return _ask;
            }
            set
            {
                _ask = value;
            }
        }
        public decimal bid
        {
            get
            {
                return _bid;
            }
            set
            {
                _bid = value;
            }
        }
    }

}//namespace

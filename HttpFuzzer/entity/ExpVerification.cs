﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LoveCoody.entity
{
    public class ExpVerification
    {

        /// <summary>
        /// 0、根据响应码校验
        /// 1、根据返回结果校验
        /// 2、新文件是否存在
        /// </summary>
        private int type;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }

        private String context;

        public String Context
        {
            get { return context; }
            set { context = value; }
        }

        private String calc;

        public String Calc
        {
            get { return calc; }
            set { calc = value; }
        }

    }
}

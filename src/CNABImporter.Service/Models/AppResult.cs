﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CNABImporter.Service.Models
{
    public class AppResult
    {
        public bool Success { get; set; }

        public string Message { get; set; } = "Erro ao realizar operação";

        public object Object { get; set; }

        public AppResult Good(string msg, object obj = null)
        {
            Success = true;
            Message = msg;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }

        public AppResult Bad(string msg, object obj = null)
        {
            Success = false;
            Message = msg;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }

        public AppResult Good(object obj)
        {
            Success = true;
            Message = "Operação realizada com Success";
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }

        public AppResult Bad(object obj)
        {
            Success = false;
            if (obj != null)
            {
                Object = obj;
            }
            return this;
        }
    }
}

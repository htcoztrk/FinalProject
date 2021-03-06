﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
        // getter read only'dir ve sadece constructorda set etmeliyiz.
        //ilk consructor calistiginda successi diger constructor'a  yolla
        public Result(bool success, string message):this(success)
        {
            Message = message;
           
        }
        public Result(bool success)
        {            
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}

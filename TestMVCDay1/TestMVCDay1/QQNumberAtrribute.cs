using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCDay1
{
    public class QQNumberAtrribute :RegularExpressionAttribute
    {
        public QQNumberAtrribute() : base(@"^\d{5,10}$")
        {
            this.ErrorMessage = "字段{0}不是合法的qq号,qq号长度在5-10位";

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TestMVCDay1
{
    public class MVCHelper
    {
       public static string GetValidMsg(ModelStateDictionary modelState)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var propName in modelState.Keys)
            {
                if (modelState[propName].Errors.Count<=0)
                {
                    continue;

                }
                sb.Append("属性错误").Append(propName).Append(":");
                foreach (ModelError modelError in modelState[propName].Errors)
                {
                    sb.Append(modelError.ErrorMessage);

                }
                sb.AppendLine();
            }
            return sb.ToString();
        }
        
    }
}
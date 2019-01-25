using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestMVCDay1
{
    public class CNPhoneNumAttribute :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value is string)
            {
                string s = (string)value;
                if (s.Length==13)
                {
                    if (s.StartsWith("13")||s.StartsWith("15")||s.StartsWith("18"))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else if(s.Contains("-"))
                {
                    //010,021 0755
                    string[] strs = s.Split('-');
                    if (strs[0].Length==3|| strs[0].Length==4)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }

        }
    }
}
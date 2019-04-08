using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 事件入门
{
    public class Person
    {
        private int age;
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
                if (value % 12 == 0)
                {
                    //if (OnBenMingNian != null)
                    //{
                    //    OnBenMingNian();//调用添加的组合方法
                    //}

                    if (this._OnBenMingNian!=null)
                    {
                        this._OnBenMingNian();
                    }
                }
            }
        }
        public  Action _OnBenMingNian;
        //public event Action OnBenmingNian;//event 委托类型 事件的名字简化写法
        //  public  Action OnBenmingNian;//event 委托类型 事件的名字

            //事件是私有的委托和add remove构成的 这是与委托的本质区别
        public event Action OnBenMingNian
        {
            add
            {

                this._OnBenMingNian += value;

            }
            remove
            {
                this._OnBenMingNian -= value;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace SignalRTest1
{
    public class TestHub : Hub
    {
        public void SendMessage(string userName, string msg)
        {
            //不同的浏览器页面connID是不一样的，如果同一个浏览器再打开一个页面connId也认为是另外一个
            //连接
            string connId = this.Context.ConnectionId;
            
          
            Clients.All.onMessage(userName + "和大家说" + msg);
        }

        public void Test()
        {
            //QueryString 在hub.start()前通过connection.hub.qs方式设置，这个设置是全局的,对于当前的
            //连接的所有SignalR请求都会带着这个.注意一定要在hub.start()之前设置.通常用全局验证信息等,
            //普通的数据通过Hub的方法来传递即可.后续不能再修改connection.hub.qs
            string name = Context.QueryString["name"];
            string age = Context.QueryString["age"];
        }
        //可用refresh页面执行下面的task
        public override Task OnConnected()
        {
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            return base.OnDisconnected(stopCalled);
        }
        //网络不好的情况下走下面的方法
        public override Task OnReconnected()
        {
            return base.OnReconnected();
        }
    }
}
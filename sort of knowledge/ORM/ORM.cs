using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ORM
{
    public class ORM
    {
        //约定：1，类名要和表名一样
        //2,字段名和数据库列明一样
        //3主键名字必须叫Id，必须是自动递增,int类型
        public static void  Insert(Object obj)
        {

            Type type = obj.GetType();//typeof(Person)
            string className = type.Name;

            PropertyInfo[] propInfos = type.GetProperties();
            string[] propNames = new string[propInfos.Length - 1];//排除掉Id
            string[] paramNames = new string[propInfos.Length-1];
            SqlParameter[] sqlParameters = new SqlParameter[propInfos.Length-1];
            int count = 0;
            //for (int i = 0; i < propInfos.Length; i++)
            foreach (PropertyInfo propInfo in propInfos)
            {
               // PropertyInfo propInfo = propInfos[i];
                string propName = propInfo.Name;
                if (propName != "Id")//排除Id
                {
                    // propNames[count] = propInfos[i].Name;
                    //  paramNames[count] ="@"+ propInfos[i].Name;
                    //下面的省的取两次了
                    SqlParameter sqlParameter = new SqlParameter();
                    propNames[count] = propName;
                    paramNames[count] = "@" + propName;
                    sqlParameter.Value = propInfo.GetValue(obj);
                    sqlParameters[count] = sqlParameter;
                    count++;
                }
            }
          
            string colnames = string.Join(",", propNames);
            //拼接生成Insert语句
            StringBuilder sbSQL = new StringBuilder();
            sbSQL.Append("Insert into").Append(className).Append("(");
            sbSQL.Append(string.Join(",", propNames)).Append(")");
            sbSQL.Append(" values(").Append(string.Join(",",paramNames)).Append(")");
            //SqlHelper.ExcuteNonQuery(sqlSQL.ToString(),sqlParameters);
        }

        public static T SelectById<T>(int id) where T:new()//泛型约束，约束T必须有个无参的构造函数
        {


            Type type = typeof(T);//typeof(Person)
            string className = type.Name;
            //约定 叫Id
            string sql = "select * from " + className + " where Id=@Id";
            //DataTable dt=SqlHelper.ExecuteQuery(sql,new SqlParameter("@Id",id))
            DataTable dt = null;
            if (dt.Rows.Count <= 0)
            {
                //return null;
                return default(T);//default()运算符用来获得类型的默认值
                //default(int)->0 default(bool)->false default(Person)->null
            }
            else if (dt.Rows.Count > 1)
            {
                throw new Exception(" 粗大事了,查到多条Id=" + id + "数据");
            }
            // Object obj = Activator.CreateInstance(type);
            DataRow row = dt.Rows[0];
            T obj = new T();
            foreach (PropertyInfo propInfo in type.GetProperties())
            {
                string propName = propInfo.Name;//属性名就是列名
                object value = row[propName];//获取数据库中的列的值
                propInfo.SetValue(obj, value);//给obj对象的propInfo属性赋值为value
            }
            return obj;
        }

        public static Object SelectById(Type type, int id)
        {
            string className = type.Name;
            //约定 叫Id
            string sql = "select * from " + className + " where Id=@Id";
            //DataTable dt=SqlHelper.ExecuteQuery(sql,new SqlParameter("@Id",id))
            DataTable dt = null;
            if (dt.Rows.Count<=0)
            {
                return null;
            }
            else if (dt.Rows.Count>1)
            {
                throw new Exception(" 粗大事了,查到多条Id=" + id + "数据");
            }
            DataRow row = dt.Rows[0];
            Object obj = Activator.CreateInstance(type);
            foreach (PropertyInfo propInfo in type.GetProperties())
            {
                string propName = propInfo.Name;//属性名就是列名
                object value = row[propName];//获取数据库中的列的值
                propInfo.SetValue(obj, value);//给obj对象的propInfo属性赋值为value
            }
            return obj;
        }
        public static void DeleteById(Type type, int id)
        {



        }


        public static void Update(Object obj)
        {
            //生成Update语句了
            //怎么知道哪一列被修改了呢
            //就是把所有的列在更新一遍无所谓


        }
    }
}

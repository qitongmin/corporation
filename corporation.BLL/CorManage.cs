using corporation.DAL;
using corporation.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace corporation.BLL
{
    public class CorManage
    {
        //社团信息修改
        public static bool CorModify(Cor c)
        {
            return CorService.CorModify(c);
        }
        //社团成员添加，注意已添加社团成员不可再加入
        public static bool GetCorAdd(string xh)
        {
            if (UserService.GetUserCorId(xh))   //为真存在
            {
                return false;
            }
            return CorService.GetCorAdd(xh);
        }
        //获取社团成员列表
        public static DataTable GetCorUser()
        {
            return CorService.GetCorUser();
        }
        //删除社团中的成员
        public static  bool RemoveUserCor(int id)
        {
            return CorService.RemoveUserCor(id);
        }
        //获取社团类别列表
        public static DataTable GetCorTypeList()
        {
            return CorService.GetCorTypeList();
        }
        //根据社团类别id查询社团名称
        public static string GetCorTypeId(int CorTypeId)
        {
            return CorService.GetCorTypeId(CorTypeId);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CoRSample
{
    /// <summary>
    /// 主任类，充当具体处理者
    /// </summary>
    class Director:Approver
    {
        public Director(string name):base(name)
        {

        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if(request.Amount<50000)
            {
                WriteLine("主任{0}审批采购单：{1}，金额：{2}，采购目的：{3}。", this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                this.successor.ProcessRequest(request);     //转发请求
            }
        }

    }
}

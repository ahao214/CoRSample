using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    /// <summary>
    /// 董事长类，充当具体处理者
    /// </summary>
    class President:Approver
    {
        public President(string name):base(name)
        {

        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            if (request.Amount < 500000)
            {
                Console.WriteLine("董事长{0}审批采购单：{1}，金额：{2}，采购目的：{3}。", this.name, request.Number, request.Amount, request.Purpose);
            }
            else
            {
                this.successor.ProcessRequest(request);     //转发请求
            }
        }
    }
}

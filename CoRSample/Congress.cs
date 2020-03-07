using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    /// <summary>
    /// 董事会类，充当具体处理者
    /// </summary>
    class Congress : Approver
    {
        public Congress(string name) : base(name)
        {

        }

        //具体请求处理方法
        public override void ProcessRequest(PurchaseRequest request)
        {
            Console.WriteLine("董事会{0}审批采购单：{1}，金额：{2}，采购目的：{3}。", this.name, request.Number, request.Amount, request.Purpose);
        }
    }

}

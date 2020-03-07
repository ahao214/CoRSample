using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoRSample
{
    /// <summary>
    /// 职责链模式
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Approver wjzhang, gyang, jguo, meeting;
            wjzhang = new Director("张无忌");
            gyang = new VicePresident("杨过");
            jguo = new President("郭靖");
            meeting = new Congress("董事会");

            //创建职责链
            wjzhang.SetSuccessor(gyang);
            gyang.SetSuccessor(jguo);
            jguo.SetSuccessor(meeting);

            //创建多个采购单对象并递交请求
            PurchaseRequest prOne = new PurchaseRequest(45000, 10001, "购买倚天剑");
            wjzhang.ProcessRequest(prOne);

            PurchaseRequest prTwo = new PurchaseRequest(60000, 10002, "购买屠龙刀");
            wjzhang.ProcessRequest(prTwo);

            PurchaseRequest prThree = new PurchaseRequest(160000, 10003, "购买易筋经");
            wjzhang.ProcessRequest(prThree);

            PurchaseRequest prFour = new PurchaseRequest(800000, 10004, "购买桃花岛");
            wjzhang.ProcessRequest(prFour);


            Console.ReadLine();
        }
    }
}

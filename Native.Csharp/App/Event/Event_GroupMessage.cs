﻿using Native.Csharp.Sdk.Cqp.Enum;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;
using Native.Csharp.Tool.Jx3zs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.App.Event
{
    public class Event_GroupMessage : IReceiveGroupMessage
    {
        public void ReceiveGroupMessage(object sender, CqGroupMessageEventArgs e)
        {
            try
            {
                var message =  e.Message;
                string[] strList = new string[] { };
                if (e.Message?.Length > 2)
                {
                    strList = message.Split(' ');
                    message = e.Message.Substring(0, 3);
                    if (strList.Length == 2 && !string.IsNullOrEmpty(strList[1]))
                    {
                        switch (message)
                        {
                            case "金价 ": Common.CqApi.SendGroupMessage(e.FromGroup, $"服务器:{strList[1]}\r\n金价:{Tools.GetPrice(strList[1]).Item1}"); break;
                            case "物价 ": Common.CqApi.SendGroupMessage(e.FromGroup, Tools.GetAppearance(strList[1])); break;
                            case "开服 ": Common.CqApi.SendGroupMessage(e.FromGroup, $"服务器:{strList[1]}\r\n状态:{Tools.CheckService(strList[1])}"); break;
                            case "绑定 ":
                                var groupMember = Common.CqApi.GetMemberInfo(e.FromGroup, e.FromQQ);
                                if (groupMember.PermitType == PermitType.Manage || groupMember.PermitType == PermitType.Holder)
                                {
                                    Common.CqApi.SendGroupMessage(e.FromGroup, Tools.BindIngGroup(e.FromGroup, strList[1]));
                                }
                                else
                                {
                                    Common.CqApi.SendGroupMessage(e.FromGroup, Tools.BindIngGroup(e.FromGroup,"非群管理员，无权操作"));
                                }
                                break;
                        }
                    }
                }
                else
                {
                    switch (message)
                    {
                        case "周常": Common.CqApi.SendGroupMessage(e.FromGroup, Tools.GetDayOrWeekTask(e.Message)); break;
                        case "日常": Common.CqApi.SendGroupMessage(e.FromGroup, Tools.GetDayOrWeekTask(e.Message)); break;
                        case "剑三": Common.CqApi.SendGroupMessage(e.FromGroup, "剑三助手功能列表\r\n 物价：物价 黑盒子\r\n 金价：金价 梦江南 \r\n 日常：日常\r\n 周常：周常\r\n 开服查询：开服 梦江南\r\n 绑定区服：绑定 梦江南（金价和开服绑定区服后可以直接发送金价/物价进行查询）"); break;
                        case "金价": Common.CqApi.SendGroupMessage(e.FromGroup, Tools.GetPrice(e.FromGroup)); break;
                        case "开服": Common.CqApi.SendGroupMessage(e.FromGroup, Tools.CheckService(e.FromGroup)); break;
                    }
                }
            }
            catch(Exception ex)
            {
                Common.CqApi.AddLoger(LogerLevel.Info,"指令未识别","插件数据处理出错，可能输入未识别区服");
            }
        }
    }
}

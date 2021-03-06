using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Native.Csharp.Model
{
    public class Price
    {
        private static readonly object lockOjeck = new object();
        private static Dictionary<string, string> keyValues;
        private Price() { }
        /// <summary>
        /// dd373
        /// </summary>
        public const string DDUrl = "https://www.dd373.com/s/8v8pc2-{0}-0-0-0-cwmaee-0-0-0-0-su-0-512-0.html";
        /// <summary>
        /// uu898
        /// </summary>
        public const string UUUrl = "http://www.uu898.com/newTrade-150-c-3-{0}/";

        /// <summary>
        /// key -���� value-dd373/uu898
        /// </summary>
        public static Dictionary<string, string> KeyValues
        {
            get
            {
                if (null == keyValues)
                {
                    lock (lockOjeck)
                    {
                        keyValues = new Dictionary<string, string>();
                        keyValues.Add("������", "km917s-m10vqg,1315-s8920");
                        keyValues.Add("��������", "km917s-ch7w22,km917s-ch7w22");
                        keyValues.Add("������", "km917s-52fsse,1315-s30493");
                        keyValues.Add("��������", "hswdmk-7vfvfx,1319-s18064");
                        keyValues.Add("������", "hswdmk-jvtg2x,1319-s9588");
                        keyValues.Add("�������", "hswdmk-hxrhn0,hswdmk-hxrhn0");
                        keyValues.Add("Ǭ��һ��", "hswdmk-jwr9j7,1319-s8964");
                        keyValues.Add("��ת����", "hswdmk-ackn6g,1319-s8966");
                        keyValues.Add("Ψ�Ҷ���", "hswdmk-td3he5,1319-s6897");
                        keyValues.Add("�ν���", "hswdmk-kqkv28,1319-s8963");
                        keyValues.Add("�����콾", "h56n27-36eh2k,1650-s11110");
                        keyValues.Add("���ƺ", "fgd20g-1h23hp,2695-s30199");
                        keyValues.Add("������", "fgd20g-kjkanv,2695-s30198");
                        keyValues.Add("��÷���", "sc86kv-g85njj,3428-s39907");
                        keyValues.Add("��ѩ�ط�", "sc86kv-mb5h4n,3428-s42664");
                        keyValues.Add("���޽���", "p0fq8c-mh8vjt,2820-s30269");
                        keyValues.Add("ֹ��Ϊ��", "7kr689-5njgjc,2821-s30270");
                    }
                }
                return keyValues;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Native.Csharp.Jx3zs;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;

namespace Native.Csharp.App.Event
{
    /// <summary>
	/// Type=1001 ��Q����, �¼�ʵ��
	/// </summary>
    public class Event_CqStartup : ICqStartup
    {
        /// <summary>
		/// ���� ��Q �������¼��ص�
		/// </summary>
		/// <param name="sender">�¼��Ĵ�������</param>
		/// <param name="e">�¼��ĸ��Ӳ���</param>
        public void CqStartup (object sender, CqStartupEventArgs e)
        {
            // ���������ڿ�Q�����̡߳��б����á�
            // ÿ��������Q��Ӧ�����ò�������ʱ���������������ã���������ִ�в����ʼ�����롣
            // ����ؾ������̱�������ִ��ʱ�䣬����Ῠס��������Լ�������ļ��ء�

            Common.AppDirectory = Common.CqApi.GetAppDirectory ();  // ��ȡӦ������Ŀ¼(���财������ʱ���뽫����ע��)
            //TaskHelper.timer.Start();
            // �����磺D:\CoolQ\data\app\com.example.demo\
            // Ӧ�õ��������ݡ����á����롿����ڴ�Ŀ¼��������û��������š�
        }
    }
}

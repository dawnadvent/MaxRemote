/*----------------------------------------------------------------
        // Copyright (C) 2007 L3'Studio
        // ��Ȩ���С� 
        // �����ߣ�L3'Studio�Ŷ�
        // �ļ�����PassWordFile.cs
        // �ļ����������������ļ��ṹ(�����Ѿ��������ܺ������)��
//----------------------------------------------------------------*/

using System;

namespace ICanSeeYou.Configure
{
    /// <summary>
    /// �����ļ��ṹ(�����Ѿ��������ܺ������)
    /// </summary>
    [Serializable]
    public class PassWordFile
    {
        private string passWord;
        /// <summary>
        /// �������ܺ������
        /// </summary>
        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }
    }
}

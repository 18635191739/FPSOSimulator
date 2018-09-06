using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FPSOSimulator
{
    public class MyEncoding
    {
        public enum CodeType
        {
            Default = 1,
            ASCII = 2,
            GB2312 = 3,
            BIG5 = 4,
            Unicode = 5,
            UTF8 = 6　　//成员的值可以设置成一样的，但是成员不行
        }
        public MyEncoding(int ByteNum)
        {
            mEnbytes = new byte[ByteNum];
            mEnsrcbytes = new byte[ByteNum];
            EncodingType = CodeType.Default;
        }

       

        //public CodeType EncodingType;


        private CodeType mEncodingType = CodeType.Default;
        /// <summary>
        /// show flag
        /// </summary>
        public CodeType EncodingType
        {
            get
            {
                return mEncodingType;
            }
            set
            {
                mEncodingType = value;
                //this.Invalidate();
            }
        }

        //Console.WriteLine((int)Week.Monday);　　//获取值
        public string str_cn;
        private byte[] mEnbytes;

        public byte[] enbytes
        {
            get
            {
                return mEnbytes;
            }
            set
            {
                mEnbytes = value;
            }
        }

        private byte[] mEnsrcbytes;

        public byte[] ensrcbytes
        {
            get
            {
                return mEnsrcbytes;
            }
            set
            {
                mEnsrcbytes = value;
            }
        }

        //public byte[] enbytes;
        //public byte[] ensrcBytes;

        public  void EncodingCharacters()
        {
            ////英文字符串
            //string str_en = "Welcome to the Encoding world.";
            ////简体中文
            //string str_cn = "欢迎来到编码世界！";
            ////繁体中文
            //string str_tw = "歡迎來到編碼世界"; 

            Encoding defaultEncoding = Encoding.Default;
            //Console.WriteLine("默认编码：{0}", defaultEncoding.BodyName);
            Encoding dstEncoding = null;


            //Default=input1 * input2


            switch (EncodingType)
            {

                case CodeType.ASCII:
                    //ASCII码
                    //Console.WriteLine("----ASCII编码----");
                    dstEncoding = Encoding.ASCII;
                    OutputByEncoding(defaultEncoding, dstEncoding, str_cn, ensrcbytes, enbytes);

                    break;

                case CodeType.GB2312:

                    //GB2312
                    //Console.WriteLine("----GB2312编码----");
                    dstEncoding = Encoding.GetEncoding("GB2312");
                    OutputByEncoding(defaultEncoding, dstEncoding, str_cn, ensrcbytes, enbytes);

                    break;

                case CodeType.BIG5:

                    //BIG5
                    //Console.WriteLine("----BIG5编码----");
                    dstEncoding = Encoding.GetEncoding("BIG5");
                    OutputByEncoding(defaultEncoding, dstEncoding, str_cn, ensrcbytes, enbytes);

                    break;

                case CodeType.Unicode:
                    //Unicode
                    //Console.WriteLine("----Unicode编码----");
                    dstEncoding = Encoding.Unicode;
                    OutputByEncoding(defaultEncoding, dstEncoding, str_cn, ensrcbytes, enbytes);

                    break;

                case CodeType.UTF8:

                    //UTF8
                    //Console.WriteLine("----UTF8编码----");
                    dstEncoding = Encoding.UTF8;
                    OutputByEncoding(defaultEncoding, dstEncoding, str_cn, ensrcbytes, enbytes);
                    break;
            }


        }

        public  void OutputByEncoding(Encoding srcEncoding, Encoding dstEncoding, string srcStr, byte[] srcBytes, byte[] bytes)
        {
            ensrcbytes = srcEncoding.GetBytes(srcStr);
            //Console.WriteLine("Encoding.GetBytes: {0}", BitConverter.ToString(srcBytes));
            enbytes = Encoding.Convert(srcEncoding, dstEncoding, ensrcbytes);
            //Console.WriteLine("Encoding.GetBytes: {0}", BitConverter.ToString(bytes));
            string result = dstEncoding.GetString(bytes);
            //Console.WriteLine("Encoding.GetString: {0}", result);
        }
    }
}

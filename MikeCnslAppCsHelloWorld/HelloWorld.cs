using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MikeCnslAppCsHelloWorld
{
    class HelloWorld
    {

        static int gLineCnt;

        static void Main(string[] args)
        {

            CTest oTest = new CTest();
            //oTest.run();
            //oTest.run();
            oTest.run();

        }

        static public void M3Log(int id, String sStr1)
        {
            Console.Write(id + "   " + gLineCnt + "   " + System.DateTime.Now + "   ");
            Console.Write(sStr1);
            gLineCnt++;
        }
        static public void M3LogShort(String sStr1)
        {
            Console.Write(sStr1);
        }
    }

    class CTest
    {
        public static int mClsId;
        private int mObjId; //class id

        //property to return/set a value
        public int ObjId
        {
            get
            {
                return (this.mObjId);
            }
            set
            {
                this.mObjId = value;
            }
        }
        public int run()
        {

            MikeCnslAppCsHelloWorld.HelloWorld.M3Log(System.Threading.Thread.CurrentThread.GetHashCode(), "Testing Started\n");

            System.Console.WriteLine("Hello World, Mike");

            MikeCnslAppCsHelloWorld.HelloWorld.M3Log(System.Threading.Thread.CurrentThread.GetHashCode(), "Testing Completed\n\n");

            return (0);
        }
    }
}

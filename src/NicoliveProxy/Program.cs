using System;
using System.Collections.Generic;
using System.Text;
using TrotiNet;

namespace NicoLiveProxy
{
    class NicoLiveProxy
    {

        public class TransparentProxy : ProxyLogic
        {
            public TransparentProxy(HttpSocket clientSocket)
                : base(clientSocket) { }

            static new public TransparentProxy CreateProxy(HttpSocket clientSocket)
            {
                return new TransparentProxy(clientSocket);
            }

            protected override void OnReceiveRequest()
            {

                if (RequestLine.Method == "GET" && RequestLine.URI.Contains("nicovideo.jp/api/getpublishstatus?"))
                {
                    RequestLine.URI = System.Text.RegularExpressions.Regex.Replace(RequestLine.URI, "(v=lv[0-9]+)", "");
                }
                Console.WriteLine("-> " + RequestLine );
            }

            protected override void OnReceiveResponse()
            {

            }
        }

        static void Main(string[] args)
        {

            int port = 8080;
            string[] cmds;
            cmds = System.Environment.GetCommandLineArgs();
            int i;
            if (cmds.Length > 1 && int.TryParse(cmds[1], out i))
            {
                port = int.Parse(cmds[1]);
            }


            Console.WriteLine("listen port: " + port);

            bool bUseIPv6 = false;

            var Server = new TcpServer(port, bUseIPv6);
            Server.Start(TransparentProxy.CreateProxy);


            Server.InitListenFinished.WaitOne();
            if (Server.InitListenException != null)
                throw Server.InitListenException;

            while (true)
                System.Threading.Thread.Sleep(1000);

            //Server.Stop();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CmlLib.Core;
using CmlLib.Core.Auth;

namespace MCLauncher
{
    /// <summary>
    /// Window1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();

            
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            startMinecraftAsync();
        }

        private async Task startMinecraftAsync()
        {
            System.Net.ServicePointManager.DefaultConnectionLimit = 256;

            var path = new MinecraftPath(Environment.GetEnvironmentVariable("appdata") + "\\.launcher"); // 기본 게임 경로 사용

            var launcher = new CMLauncher(path);

            // 콘솔에 실행 진행률 표시
            launcher.FileChanged += (e) =>
            {
                Console.WriteLine("[{0}] {1} - {2}/{3}", e.FileKind.ToString(), e.FileName, e.ProgressedFileCount, e.TotalFileCount);
            };
            launcher.ProgressChanged += (s, e) =>
            {
                Console.WriteLine("{0}%", e.ProgressPercentage);
            };

            var versions = await launcher.GetAllVersionsAsync();
            foreach (var item in versions)
            {
                // 모든 버전 이름 표시
                // 여기서 출력되는 버전 이름을 CreateProcessAsync 메서드를 호출할 때 사용하면 됩니다.
                Console.WriteLine(item.Name);
            }

            var launchOption = new MLaunchOption
            {
                MaximumRamMb = 1024,
                Session = MSession.GetOfflineSession("hello"), // Login Session. ex) Session = MSession.GetOfflineSession("hello")

                //ScreenWidth = 1600,
                //ScreenHeigth = 900,
                //ServerIp = "mc.hypixel.net"
            };

            //var process = await launcher.CreateProcessAsync("실행할 버전 이름을 여기에 입력하세요", launchOption);
            var process = await launcher.CreateProcessAsync("1.18.1", launchOption); // 바닐라
                                                                                     // var process = await launcher.CreateProcessAsync("1.12.2-forge1.12.2-14.23.5.2838", launchOption); // 포지
                                                                                     // var process = await launcher.CreateProcessAsync("1.12.2-LiteLoader1.12.2"); // 라이트로더
                                                                                     // var process = await launcher.CreateProcessAsync("fabric-loader-0.11.3-1.16.5") // fabricMC

            process.Start();
        }
    }
}

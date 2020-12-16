using System;
using System.Drawing;
using System.Windows.Forms;
namespace Windosws
{
    class MessageFilter : IMessageFilter
    {
        public bool PreFilterMessage(ref Message e)
        {
            if (e.Msg == 0x0F || e.Msg == 0xA0 || e.Msg == 0x200 || e.Msg == 0x113)
                return false;
            Console.WriteLine($"{e.ToString()} : {e.Msg}");

            if (e.Msg == 0x201)
                Application.Exit();
            return true;
        }
    }

    class MainApp : Form
    {
        public void MyMouseHandler(object sender, MouseEventArgs e)
        {
            Console.WriteLine($"Sender: {((Form)sender).Text}");
            Console.WriteLine($"X:{e.X} Y:{e.Y}");
            Console.WriteLine($"Button:{e.Button}, Clicks:{e.Clicks}");
            Console.WriteLine();
        }

        public MainApp(String title)
        {
            this.Text = title;
            this.Width = 500;
            this.Height = 500;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.BackColor = Color.Red;
            this.Opacity = 0.8;
            this.MouseDown += new MouseEventHandler(MyMouseHandler);
            this.MouseClick += new MouseEventHandler(MainApp_ClickRight);
        }
        void MainApp_ClickRight(object sender, MouseEventArgs e)
        {
            string file = @"C:\Users\asomu\Pictures\241227_color.jpg";
            if (System.IO.File.Exists(file))
            {
                this.BackgroundImage = Image.FromFile(file);
            }
            else
                MessageBox.Show("이미지가 없습니다!");

        }
        static void Main(string[] args)
        {
           // Application.AddMessageFilter(new MessageFilter());
            Application.Run(new MainApp("Mouse Event Test"));
            Console.WriteLine("Exiting Window Application...");

        }
    }
}

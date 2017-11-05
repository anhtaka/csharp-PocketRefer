using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Chap6
{
    class TaskSchedulerFromCurrentSynchronizationContext
    {
        public static Window win { get; set; }
        public static TextBox TextBox1 { get; set; }

        private static void Button1_Click(object sender, RoutedEventArgs e)
        {
            Task task = new Task(() =>
            {
                //デフォルトではTaskの非同期処理は
                //スレッドプールのスレッドで実行される
                //UIスレッド以外からのUIは更新できないため例外が発生する
                TextBox1.Text = "OK";
            });
            //同期コンテキストから取得したタスクスケジューラーを
            //Startに渡すことで、UIスレッドで実行できるようになる
            TaskScheduler scheduler 
                = TaskScheduler.FromCurrentSynchronizationContext();
            //引数未指定だとTaskScheduler.Defaultになり例外が発生する
            task.Start(scheduler);
        }

        private static void Button2_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Task task = new Task(() =>
                {
                    TextBox1.Text = "OK";
                });
                task.Start();
                task.Wait();
            }
            catch (Exception ex)
            {
                TextBox1.Text += ex.ToString();
            }
        }

        [STAThread]
        static void Main(string[] args)
        {
            InitializeComponent();
        }

        private static void InitializeComponent()
        {
            var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
            var app = new System.Windows.Application();
            win = new Window();
            var grid = new Grid();
            win.Title = "TaskSchedulerFromCurrentSynchronizationContext";
            win.Height = 350;
            win.Width = 525;
            win.Content = grid;
            grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            var Button1 = new Button() { Name = "Button1", Content = "実行(例外発生しない)", Height = 30, Width = 150 };
            grid.Children.Add(Button1);
            var Button2 = new Button() { Name = "Button2", Content = "実行(例外発生)", Height = 30, Width = 150, HorizontalAlignment = HorizontalAlignment.Left };
            grid.Children.Add(Button2);
            Grid.SetColumn(Button2, 1);

            TextBox1 = new TextBox() { Name = "TextBox1", AcceptsReturn = true, HorizontalScrollBarVisibility = ScrollBarVisibility.Auto, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            grid.Children.Add(TextBox1);
            Grid.SetRow(TextBox1, 1);
            Grid.SetColumnSpan(TextBox1, 2);

            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;

            app.Run(win);
        }
        [DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
    }
}

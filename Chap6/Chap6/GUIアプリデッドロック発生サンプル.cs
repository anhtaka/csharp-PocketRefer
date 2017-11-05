using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Chap6
{
    class GUIアプリデッドロック発生サンプル
    {
        public static Window win { get; set; }
        public static TextBox TextBox1 { get; set; }
        //非同期メソッド
        static async Task<string> DoWorkAsync()
        {
            await Task.Delay(1000);
            return "サンプル完了";
        }
        //GUIアプリで同期メソッドから、
        //非同期メソッドの完了を待機しようとすると…
        private static void Button1_Click(
            object sender, RoutedEventArgs e)
        {
            Task<string> task = DoWorkAsync();
            //デッドロック発生、アプリはフリーズ
            TextBox1.Text = task.Result;
        }

        //原則asyncメソッドはawaitで待機
        //（呼び出し側もasyncメソッドにする）
        private static async void Button2_Click(
            object sender, RoutedEventArgs e)
        {
            Task<string> task = DoWorkAsync();
            TextBox1.Text = await task;
        }

        //awaitでの待機後に同じコンテキストに戻らなくてよい指定
        //であるConfigureAwait(continueOnCapturedContext:false)を使用
        static async Task<string> DoWork2Async()
        {
            await Task.Delay(1000).ConfigureAwait(false);
            return "サンプル2完了";
        }
        private static void Button3_Click(
            object sender, RoutedEventArgs e)
        {
            Task<string> task = DoWork2Async();
            //待機中にUIスレッドのブロックは発生するが
            //デッドロックは発生しない
            TextBox1.Text = task.Result;
        }

        [STAThread]
        static void Main(string[] args)
        {
            var task = Task.Run(() =>{
                Console.WriteLine("こちらのウィンドウでキーを押すとアプリケーションを終了します。");
                Console.ReadKey(true);
                Environment.Exit(0);              
            });
            InitializeComponent();

        }

        private static void InitializeComponent()
        {

            var app = new System.Windows.Application();
            win = new Window();
            var grid = new Grid();
            win.Title = "GUIアプリデッドロック発生サンプル";
            win.Height = 350;
            win.Width = 525;
            win.Content = grid;
            grid.RowDefinitions.Add(new RowDefinition() { Height = GridLength.Auto });
            grid.RowDefinitions.Add(new RowDefinition() { Height = new GridLength(1, GridUnitType.Star) });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = GridLength.Auto });
            grid.ColumnDefinitions.Add(new ColumnDefinition() { Width = new GridLength(1, GridUnitType.Star) });

            var Button1 = new Button() { Name = "Button1", Content = "実行(デッドロック発生)", Height = 30, Width = 150 };
            grid.Children.Add(Button1);
            var Button2 = new Button() { Name = "Button2", Content = "実行", Height = 30, Width = 150, HorizontalAlignment = HorizontalAlignment.Left };
            grid.Children.Add(Button2);
            Grid.SetColumn(Button2, 1);
            var Button3 = new Button() { Name = "Button3", Content = "実行(ブロックされるがデッドロック回避)", Height = 30, HorizontalAlignment = HorizontalAlignment.Left };
            grid.Children.Add(Button3);
            Grid.SetColumn(Button3, 2);


            TextBox1 = new TextBox() { Name = "TextBox1", AcceptsReturn = true, HorizontalScrollBarVisibility = ScrollBarVisibility.Auto, VerticalScrollBarVisibility = ScrollBarVisibility.Auto };
            grid.Children.Add(TextBox1);
            Grid.SetRow(TextBox1, 1);
            Grid.SetColumnSpan(TextBox1, 4);

            Button1.Click += Button1_Click;
            Button2.Click += Button2_Click;
            Button3.Click += Button3_Click;
            app.Run(win);
        }

    }
}

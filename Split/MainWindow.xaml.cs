using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;


namespace Split
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
        //TEST
        //TEST2
        //Test3
        //Test4
        //TEST5
            InitializeComponent();
            resumestart();  // Removing Temp
            Trigger();  // Create Buttons
        }
        public void Trigger()
        {
            string[] filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.bat");
            foreach (var item in filePaths)
            {
                var fileName = System.IO.Path.GetFileNameWithoutExtension(item);

                System.Windows.Controls.Button newBtn = new Button();
                Style myStyle = (Style)Resources["btnLightRed"];
                newBtn.Style = myStyle;
                newBtn.Width = 80;
                newBtn.HorizontalAlignment = HorizontalAlignment.Left;
                newBtn.Click += (s, e) => { buttontrigger(fileName); };
                newBtn.Content = fileName;
                newBtn.Name = fileName;
                sp.Children.Add(newBtn);



            }

            if (filePaths.Length > 0)
            {
                System.Windows.Controls.Button newBtn = new Button();
                Style myStyle = (Style)Resources["btnLightRed"];
                newBtn.Style = myStyle;
                newBtn.Width  = 80;
                newBtn.HorizontalAlignment = HorizontalAlignment.Left;
                newBtn.Click += (s, e) => { buttontrigger("All"); };
                newBtn.Content = "All";
                newBtn.Name = "All";
                sp.Children.Add(newBtn);
            }

        }
        public void buttontrigger(string from)
        {
            if (from == "All")
            {
                App.Current.Shutdown();
            }
            else
            {
                
                string[] filePaths = Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory, "*.bat");
                foreach (var item in filePaths)
                {
                    var fileName = System.IO.Path.GetFileNameWithoutExtension(item);
                    if (fileName != from)
                    {
                        File.Move(AppDomain.CurrentDomain.BaseDirectory+"\\"+fileName + ".bat", AppDomain.CurrentDomain.BaseDirectory+"\\"+"Temp" + fileName + ".bat");
                    }
                }

                App.Current.Shutdown();

            }
        }
        public void resumestart()
        {
            DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            FileInfo[] infos = d.GetFiles();
            foreach (FileInfo f in infos)
            {
                if (System.IO.Path.GetFileNameWithoutExtension(f.FullName).Contains("Temp"))
                {
                    File.Move(f.FullName, f.FullName.Replace("Temp", ""));
                }
            }
        }
    }
}


//DirectoryInfo d = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
//FileInfo[] infos = d.GetFiles();
//                foreach (FileInfo f in infos)
//                {
//                if (System.IO.Path.GetFileNameWithoutExtension(f.FullName) == from)
//                {
//                    File.Move(f.FullName, f.FullName.Replace(from, "Temp" + from));
//                }
//                else
//                {

//                }
//                }

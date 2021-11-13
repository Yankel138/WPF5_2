using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Drawing.Imaging;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_Ink(object sender, RoutedEventArgs e)
        {
            canvas.EditingMode = InkCanvasEditingMode.Ink;
        }

        private void Button_Click_Clear(object sender, RoutedEventArgs e)
        {
            canvas.EditingMode = InkCanvasEditingMode.EraseByPoint;
        }

        private void Button_Click_Color(object sender, RoutedEventArgs e)
        {
            string color = (sender as Button).Name as string;

            if (canvas != null)
            {
                switch (color)
                {
                    case "Black":
                        canvas.DefaultDrawingAttributes.Color = Colors.Black;
                        break;
                    case "Gray":
                        canvas.DefaultDrawingAttributes.Color = Colors.Gray;
                        break;
                    case "White":
                        canvas.DefaultDrawingAttributes.Color = Colors.White;
                        break;
                    case "Red":
                        canvas.DefaultDrawingAttributes.Color = Colors.Red;
                        break;
                    case "Orange":
                        canvas.DefaultDrawingAttributes.Color = Colors.Orange;
                        break;
                    case "Yellow":
                        canvas.DefaultDrawingAttributes.Color = Colors.Yellow;
                        break;
                    case "Green":
                        canvas.DefaultDrawingAttributes.Color = Colors.Green;
                        break;
                    case "Blue":
                        canvas.DefaultDrawingAttributes.Color = Colors.Blue;
                        break;
                    case "Purple":
                        canvas.DefaultDrawingAttributes.Color = Colors.Purple;
                        break;
                }
            }
        }


        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            double weight = Convert.ToDouble(((sender as ComboBox).SelectedItem as TextBlock).Text);
            if (canvas != null)
            {
                canvas.DefaultDrawingAttributes.Width = weight;
                canvas.DefaultDrawingAttributes.Height = weight;
            }
        }

        private void MenuItem_Click_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg|PNG (*.png)|*.png|Все файлы изображений(*.*)|(*.*)";
            if (ofd.ShowDialog()==true)
            {
                //ImageEditor.Image 
            }
        }

        private void MenuItem_Click_Save(object sender, RoutedEventArgs e)
        {
            //SaveFileDialog sfd = new SaveFileDialog();
            //sfd.Filter = "Images|*.png;*.bmp;*.jpg";
            //ImageFormat format = ImageFormat.Png;
            //if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    string ext = System.IO.Path.GetExtension(sfd.FileName);
            //    switch (ext)
            //    {
            //        case ".jpg":
            //            format = ImageFormat.Jpeg;
            //            break;
            //        case ".bmp":
            //            format = ImageFormat.Bmp;
            //            break;
            //    }
            //    canvas.Image.Save(sfd.FileName, format);
            //}


            //SaveFileDialog saveFileDialog = new SaveFileDialog();
            //saveFileDialog.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg|PNG (*.png)|*.png|Все файлы изображений(*.*)|(*.*)";
        }

        private void MenuItem_Click_Exit(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}

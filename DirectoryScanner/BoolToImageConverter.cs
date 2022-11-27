using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace DirectoryScannerConverters
{ 
     public class BoolToImageConverter : IValueConverter
     {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                bool val = (bool)value;
                if (!val) //is file
                {
                    // TODO I.V. refactor path.
                    return new BitmapImage(new Uri(@"C:\Users\Lenovo\Documents\бгуир\предметы\3курс\5сем\СПП\лабы\3 лаба\DirectoryScanner\DirectoryScanner\Assets\file.png", UriKind.RelativeOrAbsolute));
                }
                else //is directory
                {
                    return new BitmapImage(new Uri(@"C:\Users\Lenovo\Documents\бгуир\предметы\3курс\5сем\СПП\лабы\3 лаба\DirectoryScanner\DirectoryScanner\Assets\directory.png", UriKind.RelativeOrAbsolute));
                }
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                throw new NotImplementedException();
            }
     }  
}

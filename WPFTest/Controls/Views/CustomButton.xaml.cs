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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPFTest.Controls.ViewModels;

namespace WPFTest.Controls.Views
{
    /// <summary>
    /// Interaction logic for CustomButton.xaml
    /// </summary>
    public enum EnumTest
    {
        First,
        Second,
        Third
    }
    public partial class CustomButton : UserControl
    {
        private static CustomButton dependencyObject;

        #region Properties
        #region CustomTextProperty
        public static readonly DependencyProperty CustomTextProperty =
            DependencyProperty.Register(
                nameof(CustomText),
                typeof(string),
                typeof(CustomButton),
                new FrameworkPropertyMetadata(
                    "", 
                    new PropertyChangedCallback(CustomTextCallback)
                )
            );

        public string CustomText
        {
            get { return (string)GetValue(CustomTextProperty); }
            set { SetValue(CustomTextProperty, value); }
        }

        private static void CustomTextCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomButton;
            dependencyObject.CustomButtonViewModel.CustomButtonText = dependencyObject.CustomText;
        }
        #endregion CustomTextProperty

        #region MyTypeProperty
        public static readonly DependencyProperty MyTypeProperty =
            DependencyProperty.Register(
                nameof(MyType),
                typeof(EnumTest),
                typeof(CustomButton),
                new FrameworkPropertyMetadata(
                    EnumTest.First,
                    new PropertyChangedCallback(MyTypeCallback)
                )
            );

        public EnumTest MyType
        {
            get { return (EnumTest)GetValue(MyTypeProperty); }
            set { SetValue(MyTypeProperty, value); }
        }

        private static void MyTypeCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomButton;
            dependencyObject.CustomButtonViewModel.MyType = dependencyObject.MyType;
        }
        #endregion MyTypeProperty

        private CustomButtonViewModel _customButtonViewModel;
        public CustomButtonViewModel CustomButtonViewModel
        {
            get { return _customButtonViewModel; }
        }
        #endregion Properties

        public CustomButton()
        {
            InitializeComponent();
            _customButtonViewModel = new CustomButtonViewModel();
        }
    }
}

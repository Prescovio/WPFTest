using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for CustomPopup.xaml
    /// </summary>
    public partial class CustomPopup : UserControl
    {
        private static CustomPopup dependencyObject;

        #region Properties
        #region IsOpenProperty
        public static readonly DependencyProperty IsOpenProperty =
            DependencyProperty.Register(
                nameof(IsOpen),
                typeof(bool),
                typeof(CustomPopup),
                new FrameworkPropertyMetadata(
                    false,
                    new PropertyChangedCallback(IsOpenCallback)
                )
            );

        public bool IsOpen
        {
            get { return (bool)GetValue(IsOpenProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        private static void IsOpenCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomPopup;
            dependencyObject.CustomPopupViewModel.IsOpen = dependencyObject.IsOpen;
        }
        #endregion CustomTextProperty

        #region WidthProperty
        public static readonly DependencyProperty WidthProperty =
            DependencyProperty.Register(
                nameof(Width),
                typeof(double),
                typeof(CustomPopup),
                new FrameworkPropertyMetadata(
                    double.NaN,
                    new PropertyChangedCallback(WidthCallback)
                )
            );

        public double Width
        {
            get { return (double)GetValue(WidthProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        private static void WidthCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomPopup;
            dependencyObject.CustomPopupViewModel.Width = dependencyObject.Width;
        }
        #endregion CustomTextProperty

        #region HeightProperty
        public static readonly DependencyProperty HeightProperty =
            DependencyProperty.Register(
                nameof(Height),
                typeof(double),
                typeof(CustomPopup),
                new FrameworkPropertyMetadata(
                    double.NaN,
                    new PropertyChangedCallback(HeightCallback)
                )
            );

        public double Height
        {
            get { return (double)GetValue(HeightProperty); }
            set { SetValue(IsOpenProperty, value); }
        }

        private static void HeightCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomPopup;
            dependencyObject.CustomPopupViewModel.Height = dependencyObject.Height;
        }
        #endregion CustomTextProperty

        #region PlacementProperty
        public static readonly DependencyProperty PlacementProperty =
            DependencyProperty.Register(
                nameof(Placement),
                typeof(PlacementMode),
                typeof(CustomPopup),
                new FrameworkPropertyMetadata(
                    PlacementMode.Center,
                    new PropertyChangedCallback(PlacementCallback)
                )
            );

        public PlacementMode Placement
        {
            get { return (PlacementMode)GetValue(PlacementProperty); }
            set { SetValue(PlacementProperty, value); }
        }

        private static void PlacementCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomPopup;
            dependencyObject.CustomPopupViewModel.Placement = dependencyObject.Placement;
        }
        #endregion CustomTextProperty

        //#region PlacementTargetProperty
        //public static readonly DependencyProperty PlacementTargetProperty =
        //    DependencyProperty.Register(
        //        nameof(PlacementTarget),
        //        typeof(UIElement),
        //        typeof(CustomPopup),
        //        new FrameworkPropertyMetadata(
        //            PlacementMode.Center,
        //            new PropertyChangedCallback(PlacementTargetCallback)
        //        )
        //    );

        //public UIElement PlacementTarget
        //{
        //    get { return (UIElement)GetValue(PlacementTargetProperty); }
        //    set { SetValue(PlacementTargetProperty, value); }
        //}

        //private static void PlacementTargetCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        //{
        //    dependencyObject = d as CustomPopup;
        //    dependencyObject.CustomPopupViewModel.PlacementTarget = dependencyObject.PlacementTarget;
        //}
        //#endregion CustomTextProperty

        #region PopupClosedCommandProperty
        public static readonly DependencyProperty PopupClosedCommandProperty =
            DependencyProperty.Register(
                nameof(PopupClosedCommand),
                typeof(DelegateCommand),
                typeof(CustomPopup),
                new FrameworkPropertyMetadata(
                    new PropertyChangedCallback(PopupClosedCommandCallback)
                )
            );

        public DelegateCommand PopupClosedCommand
        {
            get { return (DelegateCommand)GetValue(PopupClosedCommandProperty); }
            set { SetValue(PopupClosedCommandProperty, value); }
        }

        private static void PopupClosedCommandCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            dependencyObject = d as CustomPopup;
            dependencyObject.CustomPopupViewModel.PopupClosedCommand = dependencyObject.PopupClosedCommand;
        }
        #endregion PopupClosedCommandProperty

        private CustomPopupViewModel _customPopupViewModel;
        public CustomPopupViewModel CustomPopupViewModel
        {
            get { return _customPopupViewModel; }
        }
        #endregion Properties
        public CustomPopup()
        {
            InitializeComponent();
            _customPopupViewModel = new CustomPopupViewModel();
        }
    }
}

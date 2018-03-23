using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls.Primitives;

namespace WPFTest.Controls.ViewModels
{
    public class CustomPopupViewModel : ViewModelBase
    {
        #region Properties
        private bool _isOpen;
        public bool IsOpen
        {
            get { return _isOpen; }
            set { Assign(ref _isOpen, value, () => IsOpen); }
        }

        private double _width;
        public double Width
        {
            get { return _width; }
            set { Assign(ref _width, value, () => Width); }
        }

        private double _height;
        public double Height
        {
            get { return _height; }
            set { Assign(ref _height, value, () => Height); }
        }

        private PlacementMode _placement;
        public PlacementMode Placement
        {
            get { return _placement; }
            set { Assign(ref _placement, value, () => Placement); }
        }

        private UIElement _placementTarget;
        public UIElement PlacementTarget
        {
            get { return _placementTarget; }
            set { Assign(ref _placementTarget, value, () => PlacementTarget); }
        }

        #region CloseButtonCommand
        private DelegateCommand _closeButtonCommand;
        public DelegateCommand CloseButtonCommand
        {
            get { return _closeButtonCommand; }
            set { Assign(ref _closeButtonCommand, value, () => CloseButtonCommand); }
        }

        private void ExecuteCloseButtonCommand(object parameter)
        {
            this.IsOpen = false;
            if (PopupClosedCommand != null)
                PopupClosedCommand.Execute(true);
        }
        private bool CanExecuteCloseButtonCommand(object parameter)
        {
            return true;
        }
        #endregion ButtonCommand

        #region PopupClosedCommand
        private DelegateCommand _popupClosedCommand;
        public DelegateCommand PopupClosedCommand
        {
            get { return _popupClosedCommand; }
            set { Assign(ref _popupClosedCommand, value, () => PopupClosedCommand); }
        }
        #endregion CallbackCommand
        #endregion Properties

        public CustomPopupViewModel()
        {
            _closeButtonCommand = new DelegateCommand(ExecuteCloseButtonCommand, CanExecuteCloseButtonCommand);
        }
    }
}

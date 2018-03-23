using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFTest.Controls.Views;

namespace WPFTest.Controls.ViewModels
{
    public class CustomButtonViewModel : ViewModelBase
    {
        #region Properties
        private string _customButtonText;
        public string CustomButtonText
        {
            get { return _customButtonText; }
            set { Assign(ref _customButtonText, value, () => CustomButtonText); }
        }

        private EnumTest _myType;
        public EnumTest MyType
        {
            get { return _myType; }
            set { Assign(ref _myType, value, () => MyType); }
        }

        #region ButtonCommand
        private DelegateCommand _buttonCommand;
        public DelegateCommand ButtonCommand
        {
            get { return _buttonCommand; }
            set { Assign(ref _buttonCommand, value, () => ButtonCommand); }
        }

        private void ExecuteButtonCommand(object parameter)
        {
            CustomButtonText = "WTF NOW" + MyType;
            OpenPopup = !OpenPopup;
        }
        private bool CanExecuteButtonCommand(object parameter)
        {
            return true;
        }
        #endregion ButtonCommand

        #region CallbackCommand
        private DelegateCommand _callbackCommand;
        public DelegateCommand CallbackCommand
        {
            get { return _callbackCommand; }
            set { Assign(ref _callbackCommand, value, () => CallbackCommand); }
        }

        private void ExecuteCallbackCommand(object parameter)
        {
            this.OpenPopup = false;
        }
        private bool CanExecuteCallbackCommand(object parameter)
        {
            return true;
        }
        #endregion CallbackCommand

        private bool _openPopup;
        public bool OpenPopup
        {
            get { return _openPopup; }
            set { Assign(ref _openPopup, value, () => OpenPopup); }
        }
        #endregion Properties

        public CustomButtonViewModel()
        {
            _buttonCommand = new DelegateCommand(ExecuteButtonCommand, CanExecuteButtonCommand);
            _callbackCommand = new DelegateCommand(ExecuteCallbackCommand, CanExecuteCallbackCommand);
        }
    }
}

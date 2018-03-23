using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTest.Dialogs.ViewModels
{
    public class TestUserControlViewModel : ViewModelBase
    {
        #region Properties
        private string _testProp = "TestPropValue";
        public string TestProp
        {
            get { return _testProp; }
            set { Assign(ref _testProp, value, () => TestProp); }
        }

        private bool _visibilityBool = true;
        public bool VisibilityBool
        {
            get { return _visibilityBool; }
            set { Assign(ref _visibilityBool, value, () => VisibilityBool); }
        }
        #endregion

        #region Constructors
        public TestUserControlViewModel()
        {

        }
        #endregion Constructors
    }
}

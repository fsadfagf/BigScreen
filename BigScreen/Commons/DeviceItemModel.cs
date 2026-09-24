using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Text;

namespace BigScreen.Commons
{
    public class DeviceItemModel : BindableBase
    {
        private int index;
        public int Index
        {
            get { return index; }
            set { SetProperty(ref index, value); }
        }
        private bool _isWarning;
        public bool IsWarning
        {
            get { return _isWarning; }
            set { SetProperty<bool>(ref _isWarning, value); }
        }
        private List<VariableModel> variableList;
        public List<VariableModel> VariableList
        {
            get { return variableList; }
            set { SetProperty(ref variableList, value); }
        }
    }
}

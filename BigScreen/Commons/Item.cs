using Prism.Mvvm;
using System.Collections.Generic;
using System.Windows.Media;

namespace BigScreen.Commons
{
    public class Item : BindableBase
    {
        private int index;
        public int Index
        {
            get { return index; }
            set { SetProperty(ref index, value); }
        }
        private Geometry data;
        public Geometry Data
        {
            get { return data; }
            set { SetProperty(ref data, value); }
        }
        private object content;
        public object Content
        {
            get { return content; }
            set { SetProperty(ref content, value); }
        }
        private bool isChecked;
        public bool IsChecked
        {
            get { return isChecked; }
            set { SetProperty(ref isChecked, value); }
        }
        private string currentImage;
        public string CurrentImage
        {
            get { return currentImage; }
            set { SetProperty(ref currentImage, value); }
        }
        private List<DeviceItemModel> deviceList;
        public List<DeviceItemModel> DeviceList
        {
            get { return deviceList; }
            set { SetProperty(ref deviceList, value); }
        }
    }
}

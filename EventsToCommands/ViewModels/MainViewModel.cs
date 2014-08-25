using EventsToCommands;
using Microsoft.Phone.UserData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ContactData.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private SolidColorBrush rectColor;

        public MainViewModel()
        {
            this.rectColor = new SolidColorBrush(Colors.Blue);
            this.DemoCommand = new DelegateCommand(this.DemoCommandAction);
        }

        public DelegateCommand DemoCommand { get; set; }

        public SolidColorBrush RectColor
        {
            get { return this.rectColor; }
            set { this.SetProperty(ref this.rectColor, value); }
        }

        private void DemoCommandAction(object obj)
        {
            this.RectColor = new SolidColorBrush(Colors.Red);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEatTracker.Models;

namespace WPFEatTracker.ViewModel
{
    public class OtherVM : INotifyPropertyChanged
    {
        private string? _name;

        public string? NameOther
        {
            get => _name;
            set => this.MutateVerbose(ref _name, value, RaisePropertyChanged());
        }

        private int? _kkalor;
        public int? KKal
        {
            get => _kkalor;
            set => this.MutateVerbose(ref _kkalor, value, RaisePropertyChanged());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
            => args => PropertyChanged?.Invoke(this, args);
    }
}

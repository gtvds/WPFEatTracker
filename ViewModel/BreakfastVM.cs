using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEatTracker.Models;

namespace WPFEatTracker.ViewModel
{
    public class BreakfastVM : INotifyPropertyChanged
    {
        private string? _name;

        public string? Name
        {
            get => _name;
            set => this.MutateVerbose(ref _name, value, RaisePropertyChanged());
        }

        private int? _kkal;
        public int? KKal
        {
            get => _kkal;
            set => this.MutateVerbose(ref _kkal, value, RaisePropertyChanged());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
            => args => PropertyChanged?.Invoke(this, args);
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFEatTracker.Models;

namespace WPFEatTracker.ViewModel
{
    public class DinnerVM : INotifyPropertyChanged
    {
        private string? _namedr;

        public string? NameDinner
        {
            get => _namedr;
            set => this.MutateVerbose(ref _namedr, value, RaisePropertyChanged());
        }

        private int? kkalor;
        public int? KKal
        {
            get => kkalor;
            set => this.MutateVerbose(ref kkalor, value, RaisePropertyChanged());
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        private Action<PropertyChangedEventArgs> RaisePropertyChanged()
            => args => PropertyChanged?.Invoke(this, args);
    }
}

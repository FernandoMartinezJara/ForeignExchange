using ForeignExchange.Models;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace ForeignExchange.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        #region Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        #region Attributes

        bool _isRunning;
        string _result;

        #endregion

        #region Properties

        public string Amount { get; set; }
        public ObservableCollection<RateModel> Rates { get; set; }
        public RateModel Rate { get; set; }
        public RateModel SourceRate { get; set; }
        public RateModel TargetRate { get; set; }

        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                if (_isRunning != value)
                {
                    _isRunning = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(IsRunning)));

                }
            }
        }

        public bool IsEnabled { get; set; }

        public string Result
        {
            get
            {
                return _result;
            }
            set
            {
                if (_result != value)
                {
                    _result = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Result)));
                }
            }
        }
        #endregion

        #region Commands

        public ICommand ConvertCommand
        {
            get
            {
                return new RelayCommand(Convert);
            }
        }

        void Convert()
        {

        }

        #endregion

        #region Contructor

        public MainViewModel()
        {
            LoadRates();
        }

        #endregion

        #region Methods
        void LoadRates()
        {
            IsRunning = false;
            Result = "Loading Rates";
        }
        #endregion

    }
}

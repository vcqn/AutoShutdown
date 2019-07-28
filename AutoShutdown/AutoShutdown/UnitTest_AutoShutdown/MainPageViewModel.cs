using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest_AutoShutdown
{
    public class MainPageViewModel : BaseViewModel
    {

        #region Labels
        private string _shutdownButton;
        public string ShutdownButton
        {
            get { return _shutdownButton; }
            set { SetProperty(ref _shutdownButton, value); }
        }

        private string _sleepButton;
        public string SleepButton
        {
            get { return _sleepButton; }
            set { SetProperty(ref _sleepButton, value); }
        }

        private string _restartButton;

        public string RestartButton
        {
            get { return _restartButton; }
            set { SetProperty(ref _restartButton, value); }
        }

        private string _hibernateButton;

        public string HibernateButton
        {
            get { return _hibernateButton; }
            set { SetProperty(ref _hibernateButton, value); }
        }

        private string _start;

        public string StartButton
        {
            get { return _start; }
            set { SetProperty(ref _start, value); }
        }

        #endregion

        public List<OptionModel> OptionList { get; set; }

        public MainPageViewModel()
        {
            GenerateOptions();
        }

        private void GenerateOptions()
        {
            if (OptionList == null)
                OptionList = new List<OptionModel>();

            OptionList.Add(new OptionModel(1, "Shutdown"));
            OptionList.Add(new OptionModel(2, "Restart"));
            OptionList.Add(new OptionModel(3, "Sleep"));
            OptionList.Add(new OptionModel(4, "Hibernate"));
        }
    }
}

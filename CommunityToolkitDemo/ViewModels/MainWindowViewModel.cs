using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace CommunityToolkitDemo.ViewModels
{
    public partial class MainWindowViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _name = "张三";

        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(Avatar))]
        private string _gender = "男";

        [ObservableProperty]
        private bool? _isMale = true;

        [ObservableProperty]
        private bool? _isFemale = false;

        [ObservableProperty]
        private int _age = 18;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(IncreaseAgeCommand))]
        private bool _isChecked = true;

        /// <summary>
        /// 根据性别自动切换头像 emoji。
        /// </summary>
        public string Avatar => Gender == "女" ? "👩" : "👨";

        [RelayCommand]
        void SetGender(string gender)
        {
            if (Gender == gender) return;
            Gender = gender;
            IsMale = gender == "男";
            IsFemale = gender == "女";
        }

        [RelayCommand(CanExecute =nameof(IsChecked))]
        void IncreaseAge()
        {
            Age++;
        }
    }
}
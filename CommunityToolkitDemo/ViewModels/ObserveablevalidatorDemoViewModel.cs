using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;
using CommunityToolkit.Mvvm.Messaging.Messages;
using CommunityToolkitDemo.Properties;
namespace CommunityToolkitDemo.ViewModels
{
    public partial class ObserveablevalidatorDemoViewModel:ObservableValidator
    {
        [ObservableProperty]
        [Required(ErrorMessage = "Age is required")]
        [Range(0, 120, ErrorMessage = "Age must be between 0 and 120")]
        int _age=18;

        partial void OnAgeChanged(int value)
        {
            ValidateProperty(value,nameof(Age));
        }

        [ObservableProperty]
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessageResourceName = "EmailErrorMessage", ErrorMessageResourceType = typeof(Language))]
        string _email;

        [ObservableProperty]
        string _errorMessage;
        [RelayCommand]
        void Submit()
        {
            ValidateAllProperties();
            if (HasErrors)
            {
                // 必须走 ErrorMessage 属性 setter,才能触发 PropertyChanged 通知
                ErrorMessage = string.Join(Environment.NewLine, GetErrors());
                return;
            }
            ErrorMessage = "Form submitted successfully!";
        }
    }
}

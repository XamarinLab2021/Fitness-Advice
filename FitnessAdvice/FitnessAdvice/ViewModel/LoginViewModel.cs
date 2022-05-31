using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FitnessAdvice.View;
using System.ComponentModel;
using System.Windows.Input;

namespace FitnessAdvice.ViewModel
{
    internal class LoginViewModel : INotifyPropertyChanged  
    {  
    public Action DisplayInvalidLoginPrompt;
        public Action DisplaySuccessfulLogin; //dorobiť
    public event PropertyChangedEventHandler PropertyChanged = delegate { };
    private string email;
    public string Email
    {
        get { return email; }
        set
        {
            email = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Email"));
        }
    }
    private string password;
    public string Password
    {
        get { return password; }
        set
        {
            password = value;
            PropertyChanged(this, new PropertyChangedEventArgs("Password"));
        }
    }
    public ICommand SubmitCommand { protected set; get; }
    public LoginViewModel()
    {
        SubmitCommand = new Command(OnSubmit);
    }
    public void OnSubmit()
    {
        if (email != "triggered71@gmail.com" || password != "secret")
        {
            DisplayInvalidLoginPrompt();
        }
            else
            {
                DisplaySuccessfulLogin();
            }
    }
}  
}  
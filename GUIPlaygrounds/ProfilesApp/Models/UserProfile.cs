using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ProfilesApp.Models;


public class UserProfile : INotifyPropertyChanged
{
    private string _userName = string.Empty;

    private string _email = string.Empty;

    private DateTime _dateOfBirth;

    private bool _isActive;


    public string UserName
    {
        get => _userName;
        set
        {
            if (_userName != value)
            {
                _userName = value;
                OnPropertyChanged(nameof(UserName));

            }
        }
    }

    public string Email
    {
        get => _email;
        set
        {
            if (_email != value)
            {
                _email = value;
                OnPropertyChanged(nameof(Email));
            }
        }
    }

    public DateTime DateOfBirth
    {
        get => _dateOfBirth;
        set
        {
            if (_dateOfBirth != value)
            {
                _dateOfBirth = value;
                OnPropertyChanged(nameof(DateOfBirth));
            }
        }
    }

    public bool IsActive
    {
        get => _isActive;
        set
        {
            if (_isActive != value)
            {
                _isActive = value;
                OnPropertyChanged(nameof(IsActive));
            }
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;


    protected void OnPropertyChanged(string propertyName)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }


}
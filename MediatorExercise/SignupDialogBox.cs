using System;

namespace MediatorExercise
{
    public class SignupDialogBox
    {
        private readonly TextBox _userNameTextBox;
        private readonly TextBox _passwordTextBox;
        private readonly CheckBox _agreeToTermsCheckBox;
        private readonly Button _signupButton;

        public SignupDialogBox()
        {
            _userNameTextBox = new TextBox();
            _userNameTextBox.SignupEventHandlers += OnControlChanged;

            _passwordTextBox = new TextBox();
            _passwordTextBox.SignupEventHandlers += OnControlChanged;

            _agreeToTermsCheckBox = new CheckBox();
            _agreeToTermsCheckBox.SignupEventHandlers += OnControlChanged;

            _signupButton = new Button();
        }

        private void OnControlChanged(object source, EventArgs args) {
            _signupButton.IsEnabled = IsFormValid();
        }

        private bool IsFormValid() {
            return !_userNameTextBox.IsEmpty() && !_passwordTextBox.IsEmpty() && _agreeToTermsCheckBox.IsChecked;
        }

        public void SimulateUserInteraction() {
            // Initially the button should be disabled
            Console.WriteLine($"Initially: {_signupButton.IsEnabled}");

            // The user enters their username, the button is still disabled
            _userNameTextBox.Content = "Ivan";
            Console.WriteLine($"After setting the username: {_signupButton.IsEnabled}");

            // The user enters their password, the button is still disabled
            _passwordTextBox.Content = "secret";
            Console.WriteLine($"After setting the password: {_signupButton.IsEnabled}");

            // The agrees to the terms, the button becomes enabled
            _agreeToTermsCheckBox.IsChecked = true;
            Console.WriteLine($"After agreeing to terms: {_signupButton.IsEnabled}");

            // The user removes the password, the button becomes disabled
            _passwordTextBox.Content = "";
            Console.WriteLine($"After removing the password: {_signupButton.IsEnabled}");

            // The user enters the password again, the button becomes enabled
            _passwordTextBox.Content = "secret";
            Console.WriteLine($"After re-setting the password: {_signupButton.IsEnabled}");
        }
    }
}

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Controls;

namespace DocFxTest
{
    /// <summary>
    /// Interaction logic for TestControl.xaml
    /// </summary>
    [ObservableObject]
    public partial class TestControl : UserControl
    {
        private const string _textA = "A";
        private const string _textB = "B";

        /// <summary>
        /// The button text.
        /// </summary>
        [ObservableProperty]
        private string _buttonText = _textA;

        /// <summary>
        /// The button command.
        /// </summary>
        [RelayCommand]
        private void ButtonClick()
        {
            ButtonText = ButtonText == _textA ? _textB : _textA;
        }

        /// <summary>
        /// The constructor.
        /// </summary>
        public TestControl()
        {
            InitializeComponent();
        }
    }
}

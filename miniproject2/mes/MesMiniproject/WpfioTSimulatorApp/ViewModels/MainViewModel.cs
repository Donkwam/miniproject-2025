using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Media;

namespace WpfIoTSimulatorApp.ViewModels
{
    public partial class MainViewModel : ObservableObject
    {
        private string _greeting;
        // 색상표시할 변수
        private Brush _productBrush;

        public MainViewModel()
        {
            Greeting = "IoT Sorting Simulator";
        }

        public string Greeting
        {
            get => _greeting;
            set => SetProperty(ref _greeting, value);
        }

        public Brush ProductBrush
        {
            get => _productBrush;
            set => SetProperty(ref _productBrush, value);
        }

        public event Action? StartHmiRequested;
        public event Action? StartSensorCheckRequested; // VM에서 View에 있는 이벤트를 호출

        [RelayCommand]
        public void Test()
        {
            ProductBrush = Brushes.Gray;
            StartHmiRequested?.Invoke(); // 컨베이어벨트 애니메이션 요청(View에서 처리)
        }

        [RelayCommand]
        public void Check()
        {
            StartSensorCheckRequested?.Invoke();
        }
    }
}

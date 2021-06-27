using Xamarin.Forms;

namespace TodoREST
{
    public static class Constants
    {
        public static string RestUrl = Device.RuntimePlatform == Device.Android
            ? "http://127.0.0.1:8000/personas/{0}" : "http://localhost:8000/personas/{0}";
    }
}

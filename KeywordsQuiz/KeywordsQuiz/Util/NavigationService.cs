using System.Threading.Tasks;
using Xamarin.Forms;

namespace KeywordsQuiz.Util
{
    public static class NavigationService
    {

        public static async Task NavigateTo(Page page)
        {
            await Application.Current.MainPage.Navigation.PushAsync(page, false);
        }

        public static async Task NavigateToModal(Page page)
        {
            await Application.Current.MainPage.Navigation.PushModalAsync(page, false);
        }

        public static async Task PopPage()
        {
            await Application.Current.MainPage.Navigation.PopAsync();
        }

        public static async Task PopModal()
        {
            await Application.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}

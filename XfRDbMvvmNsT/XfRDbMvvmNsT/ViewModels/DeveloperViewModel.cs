using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using XfRDbMvvmNsT.Views;

namespace XfRDbMvvmNsT.ViewModels
{
    public class DeveloperViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #region MainPage Navigation Commands ---

        public Command NavToListOfDevs
        {
            get
            {
                return new Command(async () =>
                    {
                        await Application.Current.MainPage.Navigation.PushAsync(new ListOfDevelopers());
                    });
            }
        }

        public Command NavToCreateDev
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new CreateDeveloper());
                });
            }
        }

        public Command NavToUpdateDeleteDev
        {
            get
            {
                return new Command(async () =>
                {
                    await Application.Current.MainPage.Navigation.PushAsync(new UpdateDeleteDeveloper());
                });
            }
        }
        #endregion
    }
}
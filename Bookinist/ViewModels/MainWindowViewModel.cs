using Bookinist.DAL.Entityes;
using Bookinist.Interfaces;
using Bookinist.Services.Interfaces;
using Bookinist.ViewModels.Base;

namespace Bookinist.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private readonly IUserDialog _UserDialog;
        private readonly IDataService _DataService;
        private readonly IRepository<Book> _BooksRepository;

        #region Title : string - Заголовок окна

        /// <summary>Заголовок окна</summary>
        private string _Title = "Главное окно программы";

        /// <summary>Заголовок окна</summary>
        public string Title
        {
            get => _Title;
            set => Set(ref _Title, value);
        }

        #endregion

        #region Status : string - Статус

        /// <summary>Статус</summary>
        private string _Status = "Готов!";

        /// <summary>Статус</summary>
        public string Status
        {
            get => _Status;
            set => Set(ref _Status, value);
        }

        #endregion

        public MainWindowViewModel(IUserDialog UserDialog, IDataService DataService, IRepository<Book> BooksRepository)
        {
            _UserDialog = UserDialog;
            _DataService = DataService;
            _BooksRepository = BooksRepository;

            var books = BooksRepository.Items.Take(10).ToArray();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using Proyecto3Recu.ViewModels;

namespace Proyecto3Recu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListaPagos : ContentPage
    {
        public ListaPagos()
        {
            InitializeComponent();
            BindingContext = new ListaViewModel(this);

        }
    }
}
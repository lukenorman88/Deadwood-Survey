using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace deadwood_app.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DeadwoodGuideTabs : TabbedPage
    {
        public DeadwoodGuideTabs ()
        {
            InitializeComponent();
        }

        public DeadwoodGuideTabs(DeadwoodPage1 deadwoodPage1)
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }

        public DeadwoodGuideTabs(DeadwoodPage2 deadwoodPage2)
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }

        public DeadwoodGuideTabs(DeadwoodPage3 deadwoodPage3)
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }

        public DeadwoodGuideTabs(DeadwoodPage4 deadwoodPage4)
        {
            InitializeComponent();
            var pages = Children.GetEnumerator();
            pages.MoveNext();
            pages.MoveNext();
            pages.MoveNext();
            pages.MoveNext();
            CurrentPage = pages.Current;
        }
    }
}
using System;
using System.Windows.Forms;
using TurboWaffle.Helper;
using TurboWaffle.Model;
using TurboWaffle.Presenter;
using TurboWaffle.ViewModel;

namespace TurboWaffle.View
{
    public partial class AccountingForm : Form
    {
        private AccountingPresenter _presenter = null;
        private readonly AccountingModel _model;

        private int _selectedCategory { get { return ((CategoryView)CbxCategory.SelectedItem).Id; } }
        private decimal _amount
        {
            get
            {
                if (!decimal.TryParse(TxtAmount.Text, out decimal amount))
                    return 0;
                return amount;
            }
        }

        public AccountingForm(AccountingModel model)
        {
            _model = model;
            InitializeComponent();
            _presenter = new AccountingPresenter(_model);
            foreach (var cat in _presenter.GetCategories())
            {
                CbxCategory.Items.Add(cat);
            }
            _model.AddEvent += SaveEvent;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _presenter.Add(_selectedCategory, TxtDescription.Text, _amount);
        }

        private void SaveEvent(object sender, InputArgs e)
        {
            var item2 = new ListViewItem(e.Get());
            item2.SubItems[1].Text = _presenter.GetCategoryDescription(e.FkCategory);
            item2.SubItems[1].Tag = e.FkCategory.ToString();
            LstAccounting.Items.Add(item2);
        }
    }
}

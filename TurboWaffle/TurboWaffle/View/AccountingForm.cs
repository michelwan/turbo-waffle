using System;
using System.Linq;
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

        private int _selectedFlowType { get { return ((FlowTypeView)CbxFlowType.SelectedItem).Id; } }
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
            foreach (var ft in _presenter.GetFlowTypes())
                CbxFlowType.Items.Add(ft);
            foreach (var c in _presenter.GetCategories())
                CbxCategory.Items.Add(c);
            _model.AddEvent += SaveEvent;
            _model.UpdateEvent += UpdateEvent;
        }

        private void ClearForm()
        {
            CbxFlowType.SelectedIndex = -1;
            CbxCategory.SelectedIndex = -1;
            TxtDescription.Text = string.Empty;
            TxtAmount.Text = string.Empty;
        }

        private void UpdateDisplay(bool isEditMode = true)
        {
            ClearForm();
            if (isEditMode)
            {
                BtnAdd.Hide();
                BtnUpdate.Show();
                BtnCancel.Show();
            }
            else
            {
                BtnAdd.Show();
                BtnUpdate.Hide();
                BtnCancel.Hide();
            }
        }

        #region Form events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _presenter.Add(_selectedFlowType, _selectedCategory, TxtDescription.Text, _amount);
            ClearForm();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LstAccounting_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateDisplay(true);
            CbxFlowType.SelectedItem = CbxFlowType.Items.Cast<FlowTypeView>().SingleOrDefault(c => c.Id.ToString() == e.Item.SubItems[1].Tag.ToString());
            CbxCategory.SelectedItem = CbxCategory.Items.Cast<CategoryView>().SingleOrDefault(c => c.Id.ToString() == e.Item.SubItems[2].Tag.ToString());
            TxtDescription.Text = e.Item.SubItems[3].Text;
            TxtAmount.Text = e.Item.SubItems[4].Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            UpdateDisplay(false);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.Update(int.Parse(LstAccounting.SelectedItems[0].SubItems[0].Text), _selectedFlowType, _selectedCategory, TxtDescription.Text, _amount);
            UpdateDisplay(false);
        }
        #endregion Form events

        #region Attached events
        private void SaveEvent(object sender, InputArgs e)
        {
            var item = new ListViewItem(e.Get());
            item.SubItems[1].Text = _presenter.GetFlowTypeDescription(e.FkFlowType);
            item.SubItems[1].Tag = e.FkFlowType.ToString();
            item.SubItems[2].Text = _presenter.GetCategoryDescription(e.FkCategory);
            item.SubItems[2].Tag = e.FkCategory.ToString();
            LstAccounting.Items.Add(item);
        }

        void UpdateEvent(object sender, InputArgs e)
        {
            var item = LstAccounting.FindItemWithText(e.Id.ToString());
            item.SubItems[1].Text = _presenter.GetFlowTypeDescription(e.FkFlowType);
            item.SubItems[1].Tag = e.FkFlowType.ToString();
            item.SubItems[2].Text = _presenter.GetCategoryDescription(e.FkCategory);
            item.SubItems[2].Tag = e.FkCategory.ToString();
            item.SubItems[3].Text = e.Description;
            item.SubItems[4].Text = e.Amount.ToString();
        }
        #endregion Attached events
    }
}

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

        private int _selectedId { get { return int.Parse(LstAccounting.SelectedItems[0].Tag.ToString()); } }
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

        private enum IndexColumn
        {
            FlowType = 0,
            Category = 1,
            Date = 2,
            Description = 3,
            Amount = 4
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
            _model.DeleteEvent += DeleteEvent;
        }

        private void ClearForm()
        {
            CbxFlowType.SelectedIndex = -1;
            CbxCategory.SelectedIndex = -1;
            DtpDate.Value = DateTime.Now;
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
                BtnDelete.Show();
            }
            else
            {
                BtnAdd.Show();
                BtnUpdate.Hide();
                BtnCancel.Hide();
                BtnDelete.Hide();
            }
        }

        #region Form events
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            _presenter.Add(_selectedFlowType, _selectedCategory, DtpDate.Value, TxtDescription.Text, _amount);
            ClearForm();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void LstAccounting_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            UpdateDisplay(true);
            CbxFlowType.SelectedItem = CbxFlowType.Items.Cast<FlowTypeView>().SingleOrDefault(c => c.Id.ToString() == e.Item.SubItems[(int)IndexColumn.FlowType].Tag.ToString());
            CbxCategory.SelectedItem = CbxCategory.Items.Cast<CategoryView>().SingleOrDefault(c => c.Id.ToString() == e.Item.SubItems[(int)IndexColumn.Category].Tag.ToString());
            DtpDate.Value = DateTime.ParseExact(e.Item.SubItems[(int)IndexColumn.Date].Text, Constants.DateTimeShortFormat, System.Globalization.CultureInfo.InvariantCulture);
            TxtDescription.Text = e.Item.SubItems[(int)IndexColumn.Description].Text;
            TxtAmount.Text = e.Item.SubItems[(int)IndexColumn.Amount].Text;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            UpdateDisplay(false);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _presenter.Update(_selectedId, _selectedFlowType, _selectedCategory, DtpDate.Value, TxtDescription.Text, _amount);
            UpdateDisplay(false);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            _presenter.Delete(_selectedId);
            UpdateDisplay(false);
        }
        #endregion Form events

        #region Attached events
        private void SaveEvent(object sender, InputArgs e)
        {
            var item = new ListViewItem(e.Get())
            {
                Tag = e.Id
            };
            item.SubItems[(int)IndexColumn.FlowType].Text = _presenter.GetFlowTypeDescription(e.FkFlowType);
            item.SubItems[(int)IndexColumn.FlowType].Tag = e.FkFlowType.ToString();
            item.SubItems[(int)IndexColumn.Category].Text = _presenter.GetCategoryDescription(e.FkCategory);
            item.SubItems[(int)IndexColumn.Category].Tag = e.FkCategory.ToString();
            LstAccounting.Items.Add(item);
        }

        void UpdateEvent(object sender, InputArgs e)
        {
            var item = LstAccounting.Items.Cast<ListViewItem>().SingleOrDefault(x => x.Tag.ToString() == e.Id.ToString());
            item.SubItems[(int)IndexColumn.FlowType].Text = _presenter.GetFlowTypeDescription(e.FkFlowType);
            item.SubItems[(int)IndexColumn.FlowType].Tag = e.FkFlowType.ToString();
            item.SubItems[(int)IndexColumn.Category].Text = _presenter.GetCategoryDescription(e.FkCategory);
            item.SubItems[(int)IndexColumn.Category].Tag = e.FkCategory.ToString();
            item.SubItems[(int)IndexColumn.Date].Text = e.Date.ToString(Constants.DateTimeShortFormat);
            item.SubItems[(int)IndexColumn.Description].Text = e.Description;
            item.SubItems[(int)IndexColumn.Amount].Text = e.Amount.ToString();
        }

        void DeleteEvent(object sender, IdArgs e)
        {
            LstAccounting.FindItemWithText(e.Id.ToString()).Remove();
        }
        #endregion Attached events
    }
}

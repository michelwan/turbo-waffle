using System.Collections.Generic;
using System.Linq;
using TurboWaffle.Model;
using TurboWaffle.ViewModel;

namespace TurboWaffle.Presenter
{
    public class AccountingPresenter
    {
        private AccountingModel m_Model;

        public AccountingPresenter(AccountingModel model)
        {
            this.m_Model = model;
        }

        public void Add(int fkCategory, string description, decimal amount)
        {
            m_Model.AddInput(fkCategory, description, amount);
        }

        public IEnumerable<CategoryView> GetCategories()
        {
            return m_Model.GetCategories()
                .Select(i => new CategoryView(i.Id, i.Description));
        }

        public string GetCategoryDescription(int id)
        {
            return m_Model.GetCategoryById(id).Description;
        }
    }
}

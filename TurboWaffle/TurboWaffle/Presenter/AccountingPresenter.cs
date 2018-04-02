using System;
using System.Collections.Generic;
using System.Linq;
using TurboWaffle.Model;
using TurboWaffle.ViewModel;

namespace TurboWaffle.Presenter
{
    public class AccountingPresenter
    {
        private AccountingModel _model;

        public AccountingPresenter(AccountingModel model)
        {
            this._model = model;
        }

        public void Add(int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            _model.AddInput(fkFlowType, fkCategory, date, description, amount);
        }

        public void Update(int id, int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            _model.UpdateInput(id, fkFlowType, fkCategory, date, description, amount);
        }

        public void Delete(int id)
        {
            _model.DeleteInput(id);
        }

        public IEnumerable<InputView> GetInputs()
        {
            return _model.GetInputs()
                .Select(i => new InputView(i.Id, i.FkFlowType, i.FkCategory,  i.Description, i.Amount));
        }

        public IEnumerable<CategoryView> GetCategories()
        {
            return _model.GetCategories()
                .Select(i => new CategoryView(i.Id, i.Description));
        }

        public IEnumerable<FlowTypeView> GetFlowTypes()
        {
            return _model.GetFlowTypes()
                .Select(i => new FlowTypeView(i.Id, i.Description));
        }

        public string GetCategoryDescription(int id)
        {
            return _model.GetCategoryById(id).Description;
        }

        public string GetFlowTypeDescription(int id)
        {
            return _model.GetFlowTypeById(id).Description;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using TurboWaffle.Helper;

namespace TurboWaffle.Model
{
    public class AccountingModel
    {
        private int _inputIndex;
        private List<InputModel> _inputList;
        private List<CategoryModel> _categoryList;

        public event EventHandler<InputArgs> AddEvent;

        public AccountingModel()
        {
            _inputList = new List<InputModel>();
            _categoryList = new List<CategoryModel>()
            {
                new CategoryModel(1, "Transport"),
                new CategoryModel(2, "Course"),
                new CategoryModel(3, "Restaurant")
            };
            _inputIndex = 1;
        }

        public void AddInput(int fkCategory, string description, decimal amount)
        {
            _inputList.Add(new InputModel(_inputIndex, fkCategory, description, amount));
            _inputIndex++;
            RaiseAddEvent(_inputList.Last());
        }

        public void RaiseAddEvent(InputModel model)
        {
            AddEvent(this, new InputArgs(model.Id, model.FkCategory, model.Description, model.Amount));
        }

        public IList<CategoryModel> GetCategories()
        {
            return _categoryList;
        }

        public CategoryModel GetCategoryById(int id)
        {
            return _categoryList.SingleOrDefault(x => x.Id == id);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using TurboWaffle.Helper;

namespace TurboWaffle.Model
{
    public class AccountingModel
    {
        private int _inputIndex = 1;
        private List<InputModel> _inputList = new List<InputModel>();
        private static readonly List<CategoryModel> _categoryList = new List<CategoryModel>()
            {
                new CategoryModel(1, "Transport"),
                new CategoryModel(2, "Course"),
                new CategoryModel(3, "Restaurant")
            };
        private static readonly List<FlowTypeModel> _flowTypeList = new List<FlowTypeModel>()
            {
                new FlowTypeModel(1, "Out"),
                new FlowTypeModel(2, "In"),
                new FlowTypeModel(3, "Lend"),
                new FlowTypeModel(4, "Borrowing")
            };

        #region Events
        public event EventHandler<InputArgs> AddEvent;
        public event EventHandler<InputArgs> UpdateEvent;
        public event EventHandler<IdArgs> DeleteEvent;
        #endregion Events

        public void AddInput(int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            _inputList.Add(new InputModel(_inputIndex, fkFlowType, fkCategory, date, description, amount));
            _inputIndex++;
            RaiseAddEvent(_inputList.Last());
        }

        public void UpdateInput(int id, int fkFlowType, int fkCategory, DateTime date, string description, decimal amount)
        {
            var item = _inputList.SingleOrDefault(x => x.Id == id);
            item.FkFlowType = fkFlowType;
            item.FkCategory = fkCategory;
            item.Date = date;
            item.Description = description;
            item.Amount = amount;
            RaiseUpdateEvent(item);
        }

        public void DeleteInput(int id)
        {
            _inputList.Remove(_inputList.Single(x => x.Id == id));
            RaiseDeleteEvent(id);
        }

        #region Raise events
        public void RaiseAddEvent(InputModel model)
        {
            AddEvent(this, new InputArgs(model.Id, model.FkFlowType, model.FkCategory, model.Date, model.Description, model.Amount));
        }
        public void RaiseUpdateEvent(InputModel model)
        {
            UpdateEvent(this, new InputArgs(model.Id, model.FkFlowType, model.FkCategory, model.Date, model.Description, model.Amount));
        }
        public void RaiseDeleteEvent(int id)
        {
            DeleteEvent(this, new IdArgs(id));
        }
        #endregion Raise events

        public IList<InputModel> GetInputs()
        {
            return _inputList;
        }

        public IList<CategoryModel> GetCategories()
        {
            return _categoryList;
        }

        public IList<FlowTypeModel> GetFlowTypes()
        {
            return _flowTypeList;
        }

        public CategoryModel GetCategoryById(int id)
        {
            return _categoryList.SingleOrDefault(x => x.Id == id);
        }

        public FlowTypeModel GetFlowTypeById(int id)
        {
            return _flowTypeList.SingleOrDefault(x => x.Id == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using TurboWaffle.Helper;

namespace TurboWaffle.Model
{
    public class AccountingModel
    {
        private int _inputIndex = 1;
        private List<InputModel> _inputList = new List<InputModel>();

        private List<CategoryModel> _categoryList;
        private List<CategoryModel> CategoryList
        {
            get
            {
                if (_categoryList == null)
                {
                    _categoryList = new List<CategoryModel>();
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(Constants.Path.FlowType);
                    foreach (XmlNode c in xmlDoc.GetElementsByTagName("Category"))
                    {
                        _categoryList.Add(new CategoryModel(
                            int.Parse(c.Attributes[Constants.XmlAttribute.Id].Value),
                            c.Attributes[Constants.XmlAttribute.Description].Value
                        ));
                    }
                }
                return _categoryList;
            }
        }

        private List<FlowTypeModel> _flowTypeList;
        private List<FlowTypeModel> FlowTypeList
        {
            get
            {
                if (_flowTypeList == null)
                {
                    _flowTypeList = new List<FlowTypeModel>();
                    var xmlDoc = new XmlDocument();
                    xmlDoc.Load(Constants.Path.FlowType);
                    foreach (XmlNode ft in xmlDoc.GetElementsByTagName("FlowType"))
                    {
                        _flowTypeList.Add(new FlowTypeModel(
                            int.Parse(ft.Attributes[Constants.XmlAttribute.Id].Value),
                            ft.Attributes[Constants.XmlAttribute.Description].Value
                        ));
                    }
                }
                return _flowTypeList;
            }
        }

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
            return CategoryList;
        }

        public IList<FlowTypeModel> GetFlowTypes()
        {
            return FlowTypeList;
        }

        public CategoryModel GetCategoryById(int id)
        {
            return CategoryList.SingleOrDefault(x => x.Id == id);
        }

        public FlowTypeModel GetFlowTypeById(int id)
        {
            return FlowTypeList.SingleOrDefault(x => x.Id == id);
        }
    }
}

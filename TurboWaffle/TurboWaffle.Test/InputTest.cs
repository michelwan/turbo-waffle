using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using TurboWaffle.Helper;
using TurboWaffle.Model;
using TurboWaffle.Presenter;

namespace TurboWaffle.Test
{
    [TestClass]
    public class InputTest
    {
        [TestMethod]
        public void CreateOneInput()
        {
            var model = new AccountingModel();
            model.AddEvent += SaveEvt;
            model.UpdateEvent += UpdateEvt;
            model.DeleteEvent += DeleteEvt;

            var presenter = new AccountingPresenter(model);
            presenter.Add(1, 1, "Test", 10);

            var input = presenter.GetInputs().First();
            presenter.Update(input.Id, 2, 3, "Test2", input.Amount * 2);

            presenter.Delete(1);
            Assert.AreEqual(0, presenter.GetInputs().Count());
        }

        void SaveEvt(object sender, InputArgs e)
        {
            Assert.AreEqual(1, e.FkFlowType);
            Assert.AreEqual(1, e.FkCategory);
            Assert.AreEqual("Test", e.Description);
            Assert.AreEqual(10, e.Amount);
        }

        void UpdateEvt(object sender, InputArgs e)
        {
            Assert.AreEqual(2, e.FkFlowType);
            Assert.AreEqual(3, e.FkCategory);
            Assert.AreEqual("Test2", e.Description);
            Assert.AreEqual(20, e.Amount);
        }

        void DeleteEvt(object sender, IdArgs e)
        {
            Assert.AreEqual(1, e.Id);
        }
    }
}

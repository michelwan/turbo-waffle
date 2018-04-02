using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            var m_Model = new AccountingModel();
            m_Model.AddEvent += SaveEvt;
            var presenter = new AccountingPresenter(m_Model);
            presenter.Add(1, 1, "Test", 10);
        }

        void SaveEvt(object sender, InputArgs e)
        {
            Assert.AreEqual(1, e.FkFlowType);
            Assert.AreEqual(1, e.FkCategory);
            Assert.AreEqual("Test", e.Description);
            Assert.AreEqual(10, e.Amount);
        }
    }
}

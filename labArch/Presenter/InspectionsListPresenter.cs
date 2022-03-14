using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labArch
{
    public class InspectionsListPresenter : IPresenter
    {
        private readonly IInspectionsListModel _model;
        private readonly IInspectionsListView _view;
        private Policeman _policeman;
      public  InspectionsListPresenter(IInspectionsListModel model,IInspectionsListView view, Policeman policeman)
        {
            _model = model;
            _view = view;
            _policeman = policeman;
            _view.UpdateTable(_model.GetTable(policeman.IdToken));
        }
        public void Run()
        {
            _view.Show();
        }
    }
}

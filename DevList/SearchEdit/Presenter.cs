using SearchEditModelSpace;
using SearchEditViewSpace;

namespace SearchEditPresenterSpace
{
    public class SearchEditPresenter
    {
        SearchEditView searchEditView;

        SearchEditModel searchEditModel;

        public SearchEditPresenter(SearchEditView searchEditView)
        {
            this.searchEditView = searchEditView;

            searchEditModel = new SearchEditModel();
        }

        public string[] Get()
        {
            return searchEditModel.Data;
        }

        public void Set()
        {
            searchEditModel.Data[0] = string.Empty;
            searchEditModel.Data[1] = searchEditView.Date.Text;
            searchEditModel.Data[2] = searchEditView.Number.Text;
            searchEditModel.Data[3] = searchEditView.Rooms.Text;
            searchEditModel.Data[4] = searchEditView.Employees.Text;
            searchEditModel.Data[5] = searchEditView.Names.Text;
            searchEditModel.Data[6] = searchEditView.Devices.Text;
            searchEditModel.Data[7] = searchEditView.Status.Text;
            searchEditModel.Data[8] = searchEditView.Inventory.Text;
            searchEditModel.Data[9] = searchEditView.Comment.Text;
            searchEditModel.Data[10] = searchEditView.Hostname.Text;
            searchEditModel.Data[11] = searchEditView.IP.Text;
            searchEditModel.Data[12] = searchEditView.ChangeMan.Text;

            if (searchEditView.AddInEnd.Checked)
            {
                searchEditModel.Data[13] = "1";
            }
            else
            {
                searchEditModel.Data[13] = "0";
            }
        }
    }
}
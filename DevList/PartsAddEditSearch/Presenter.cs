using PartsAddEditSearchViewSpace;
using PartsAddEditSearchModelSpace;

namespace PartsAddEditSearchPresenterSpace
{
    public class PartsAddEditSearchPresenter
    {
        PartsAddEditSearchView partsAddEditSearchView;

        public PartsAddEditSearchModel partsAddEditSearchModel = new();

        public PartsAddEditSearchPresenter(PartsAddEditSearchView partsAddEditSearchView)
        {
            this.partsAddEditSearchView = partsAddEditSearchView;
        }
    }
}
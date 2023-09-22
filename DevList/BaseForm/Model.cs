using DevList;
using INIFileSpace;

namespace BaseFormModelSpace
{
    public class BaseFormModel
    {
        INIFile iniFile;

        DataBase dataBase;

        public BaseFormModel(INIFile iniFile, DataBase dataBase)
        {
            this.iniFile = iniFile;

            this.dataBase = dataBase;
        }
    }
}
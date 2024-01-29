using INIFileSpace;
using ListSpace;
using AbstractAddEditSearchSpace;

namespace AddEditSearchModelSpace
{
    public class AddEditSearchModel : AbstractAddEditSearch
    {
        public List Rooms, Devices, Employees, Names;

        public AddEditSearchModel(INIFile iniFile)
        {
            Rooms = new List(iniFile.Rooms);
            Devices = new List(iniFile.Devices);
            Employees = new List(iniFile.Employees);
            Names = new List(iniFile.Names);
        }
    }
}
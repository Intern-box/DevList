using INIFileSpace;
using ListSpace;

namespace SearchEditModelSpace
{
    public class SearchEditModel
    {
        public List Rooms, Devices, Employees, Names;

        public string[] Data = new string[14];

        public SearchEditModel(INIFile iniFile)
        {
            Rooms = new List(iniFile.Rooms);
            Devices = new List(iniFile.Devices);
            Employees = new List(iniFile.Employees);
            Names = new List(iniFile.Names);
        }
    }
}
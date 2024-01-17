using System;
using BaseFormModelSpace;
using BaseFormViewSpace;
using DataBaseSpace;
using System.ComponentModel;
using System.Windows.Forms;
using INIFileSpace;
using System.IO;
using SearchEditViewSpace;
using TableParametersSpace;

namespace BaseFormPresenterSpace
{
    public class BaseFormPresenter
    {
        BaseFormModel baseFormModel;

        BaseFormView baseFormView;

        public BaseFormPresenter(BaseFormView baseFormView)
        {
            this.baseFormView = baseFormView;

            baseFormModel = new BaseFormModel(new DataBase(baseFormView.iniFile.Base));
        }

        public DataBase DataBase() { return baseFormModel.DataBase; }

        public BindingList<string[]> Table() { return baseFormModel.DataBase.Table; }

        public void Events(string mode)
        {
            switch (mode)
            {
                case "Create": Create(); break;

                case "Open": Open(); break;

                case "Save": Save(); break;

                case "SaveAs": SaveAs(); break;

                case "Add": Add(); break;

                case "EditAll": EditAll(); break;

                case "Up": Up(); break;

                case "Down": Down(); break;
            }
        }

        public void DataBaseChanges()
        {
            if (baseFormModel.DataBase.Change)
            {
                DialogResult result =

                MessageBox.Show
                (
                    "Сохранить изменения?",
                    "Открытие файла",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1
                );

                if (result == DialogResult.Yes) { baseFormModel.DataBase.Save(); }

                baseFormModel.DataBase.Change = false;
            }
        }

        void Create()
        {
            DataBaseChanges();

            FolderBrowserDialog pathNewBase = new FolderBrowserDialog();

            pathNewBase.ShowDialog();

            if (pathNewBase.SelectedPath != string.Empty)
            {
                baseFormView.iniFile = new INIFile(pathNewBase.SelectedPath);

                baseFormModel.DataBase = new DataBase(baseFormView.iniFile.Base);

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }

        void Open()
        {
            DataBaseChanges();

            OpenFileDialog openFileWindow = new OpenFileDialog() { Filter = "*.INI|*.ini" };

            if (openFileWindow.ShowDialog() == DialogResult.OK)
            {
                baseFormView.iniFile = new INIFile(openFileWindow.FileName);

                baseFormModel.DataBase = new DataBase(baseFormView.iniFile.Base);

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }

        void Save()
        {
            baseFormModel.DataBase.Save();

            baseFormModel.DataBase.Change = false;
        }

        void SaveAs()
        {
            FolderBrowserDialog savePath = new FolderBrowserDialog();

            savePath.ShowDialog();

            if (savePath.SelectedPath != string.Empty)
            {
                if (!Directory.Exists($"{savePath.SelectedPath}\\БД")) { Directory.CreateDirectory($"{savePath.SelectedPath}\\БД"); }

                if (!Directory.Exists($"{savePath.SelectedPath}\\История перемещений")) { Directory.CreateDirectory($"{savePath.SelectedPath}\\История перемещений"); }

                File.Copy(baseFormView.iniFile.Path, Path.Combine(savePath.SelectedPath, Path.GetFileName(baseFormView.iniFile.Path)), true);
                File.Copy(baseFormView.iniFile.Base, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Base)), true);
                File.Copy(baseFormView.iniFile.Rooms, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Rooms)), true);
                File.Copy(baseFormView.iniFile.Devices, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Devices)), true);
                File.Copy(baseFormView.iniFile.Employees, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Employees)), true);
                File.Copy(baseFormView.iniFile.Names, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Names)), true);
                File.Copy(baseFormView.iniFile.History, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.History)), true);
                File.Copy(baseFormView.iniFile.Set, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Set)), true);
                File.Copy(baseFormView.iniFile.Parts, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Parts)), true);
            }
        }

        void Add()
        {
            SearchEditView searchEditView = new SearchEditView(baseFormView.iniFile);

            searchEditView.ShowDialog();

            baseFormModel.DataBase.Table.Add(searchEditView.searchEditPresenter.searchEditModel.Data);

            baseFormModel.DataBase.Change = true;

            baseFormView.TableOutput(baseFormModel.DataBase.Table);
        }

        void EditAll()
        {
            if (baseFormView.tableParameters.Coordinates != null && baseFormView.tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                SearchEditView searchEditView = new SearchEditView(baseFormView.iniFile);

                searchEditView.searchEditPresenter.searchEditModel.Data = baseFormModel.DataBase.Table[baseFormView.tableParameters.Id];

                string tmp = baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][3];

                searchEditView.searchEditPresenter.Get();

                searchEditView.ShowDialog();

                if (tmp != searchEditView.searchEditPresenter.searchEditModel.Data[3])
                {
                    File.AppendAllText
                    (
                        $"{Path.GetDirectoryName(Path.GetFullPath(baseFormView.iniFile.Path))}\\История перемещений\\{searchEditView.searchEditPresenter.searchEditModel.Data[3]}.txt",
                        $"Из помещения: {tmp}\r\n" +
                        $"переместили: {DateTime.Now}\r\n" +
                        $"{baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][5]}\r\n" +
                        $"с инв.№: {baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][2]}\r\n\r\n"
                    );
                }

                baseFormModel.DataBase.Table[baseFormView.tableParameters.Id] = searchEditView.searchEditPresenter.searchEditModel.Data;

                baseFormModel.DataBase.Change = true;

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }
        void Up()
        {
            baseFormModel.DataBase.UpDown(baseFormView.tableParameters.Line - 1, baseFormView.tableParameters.Line);

            baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

            baseFormView.Table.Select();
            
            baseFormView.Table.Items[baseFormView.tableParameters.Line - 1].Selected = true;

            baseFormModel.DataBase.Change = true;
        }

        void Down()
        {
            baseFormModel.DataBase.UpDown(baseFormView.tableParameters.Line + 1, baseFormView.tableParameters.Line);

            baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

            baseFormView.Table.Select();

            baseFormView.Table.Items[baseFormView.tableParameters.Line + 1].Selected = true;

            baseFormModel.DataBase.Change = true;
        }
    }
}
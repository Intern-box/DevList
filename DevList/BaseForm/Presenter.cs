using System;
using BaseFormModelSpace;
using BaseFormViewSpace;
using DataBaseSpace;
using System.ComponentModel;
using System.Windows.Forms;
using INIFileSpace;
using System.IO;
using SearchEditViewSpace;
using ReportsSpace;
using RemoveSpace;
using ListsSpace;
using DevList;
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

        public DataBase DataBaseGet() { return baseFormModel.DataBase; }

        public void DataBaseSet(DataBase dataBase) { baseFormModel.DataBase = dataBase; }

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

                case "Remove": Remove(); break;

                case "CommonReport": CommonReport(); break;

                case "SortByTypes": SortByTypes(); break;

                case "SortByRooms": SortByRooms(); break;

                case "SearchAll": SearchAll(); break;

                case "History": History(); break;

                case "Filtr": Filtr(); break;

                case "Lists": Lists(); break;

                case "NomberString": NomberString(); break;
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

                System.IO.File.Copy(baseFormView.iniFile.Path, Path.Combine(savePath.SelectedPath, Path.GetFileName(baseFormView.iniFile.Path)), true);
                System.IO.File.Copy(baseFormView.iniFile.Base, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Base)), true);
                System.IO.File.Copy(baseFormView.iniFile.Rooms, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Rooms)), true);
                System.IO.File.Copy(baseFormView.iniFile.Devices, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Devices)), true);
                System.IO.File.Copy(baseFormView.iniFile.Employees, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Employees)), true);
                System.IO.File.Copy(baseFormView.iniFile.Names, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Names)), true);
                System.IO.File.Copy(baseFormView.iniFile.History, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.History)), true);
                System.IO.File.Copy(baseFormView.iniFile.Set, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Set)), true);
                System.IO.File.Copy(baseFormView.iniFile.Parts, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Parts)), true);
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
                    System.IO.File.AppendAllText
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

        void Remove()
        {
            if (baseFormView.Text == "DevList - История")
            {
                DialogResult result = MessageBox.Show("Удалить полностью?", "Удаление МЦ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Remove remove = new Remove(baseFormModel.DataBase, baseFormView.tableParameters.Coordinates);

                    baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

                    baseFormModel.DataBase.Change = true;
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Удалить МЦ?\r\n\r\nМЦ будет перемещена в Историю!", "Удаление МЦ", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    Remove remove = new Remove(baseFormModel.DataBase, baseFormView.tableParameters.Coordinates, baseFormView.iniFile, true);

                    baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

                    baseFormModel.DataBase.Change = true;
                }
            }
        }

        void SortByTypes() { Reports report = new Reports(baseFormView.iniFile, baseFormModel.DataBase, reportType: "SortByTypes"); report.ShowDialog(); }

        void SortByRooms() { Reports report = new Reports(baseFormView.iniFile, baseFormModel.DataBase, reportType: "SortByRooms"); report.ShowDialog(); }

        void CommonReport()
        {
            System.IO.File.WriteAllText($"{Application.StartupPath}\\Print.htm", string.Empty);

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm",

                "<style>\r\n\r\n" +
                "\ttable {font-family:Verdana; font-size:11px; border-collapse:collapse; border:1px solid #bbbbbb;}\r\n\r\n" +
                "\ttd {text-align:center; vertical-align:middle;}\r\n\r\n" +
                "</style>\r\n\r\n" +
                "<table align=center cellpadding=5 border=1 bordercolor=#bbbbbb>\r\n\r\n"

            );

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t<tr bgcolor=#bbbbbb style=\"color:#0; font-weight:bold;\">\r\n");

            for (int i = 0; i < baseFormView.Table.Columns.Count; i++)
            {
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t\t<td>");
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", baseFormView.Table.Columns[i].Text);
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</td>\r\n");
            }

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t</tr>\r\n\r\n");

            foreach (string[] tr in baseFormModel.DataBase.Table)
            {
                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t<tr>\r\n");

                foreach (string td in tr)
                {
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t\t<td>");
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", td);
                    System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</td>\r\n");
                }

                System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "\t</tr>\r\n\r\n");
            }

            System.IO.File.AppendAllText($"{Application.StartupPath}\\Print.htm", "</table>");

            System.Diagnostics.Process.Start($"{Application.StartupPath}\\Print.htm");
        }

        void SearchAll()
        {
            if (baseFormView.SearchAllBox.Text != string.Empty)
            {
                baseFormView.TableOutput(baseFormModel.DataBase.FindAll(baseFormView.SearchAllBox.Text), false);

                baseFormView.Filter.Visible = true;

                baseFormView.tableParameters.SearchMode = "SearchAll";
            }
        }

        void History()
        {
            DataBase historyBase = new DataBase(baseFormView.iniFile.History);

            BaseFormView history = new BaseFormView(baseFormView.iniFile, historyBase);

            history.WindowState = FormWindowState.Normal;

            history.Create.Visible = false;

            history.Open.Visible = false;

            history.Save.Visible = false;

            history.SaveAs.Visible = false;

            history.Edit.Visible = false;

            history.Lists.Visible = false;

            history.Reports.Visible = false;

            history.History.Visible = false;

            history.CAdd.Visible = false;

            history.CEditAll.Visible = false;

            history.Text = "DevList - История";

            history.Show();
        }

        void Filtr()
        {
            DataBaseChanges();

            if (baseFormView.tableParameters.SearchMode == "Column") { baseFormView.tableParameters.SortingColumns = false; }

            baseFormView.Table.ListViewItemSorter = null;

            baseFormView.TableOutput(baseFormModel.DataBase.Table);

            baseFormView.Filter.Visible = false;

            baseFormView.tableParameters.SearchMode = string.Empty;
        }

        void Lists() { Lists lists = new Lists(baseFormView.iniFile); lists.ShowDialog(); }

        void NomberString()
        {
            UpDownForm upDownForm = new UpDownForm(); upDownForm.ShowDialog();

            if (upDownForm.Result != null)
            {
                baseFormModel.DataBase.Move(baseFormView.tableParameters.Id, int.Parse(upDownForm.Result) - 1);

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }
    }
}
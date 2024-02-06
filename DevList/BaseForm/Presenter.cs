using System;
using BaseFormModelSpace;
using BaseFormViewSpace;
using DataBaseSpace;
using System.ComponentModel;
using System.Windows.Forms;
using INIFileSpace;
using System.IO;
using AddEditSearchViewSpace;
using ReportsSpace;
using RemoveSpace;
using ListsSpace;
using UpDownFormSpace;
using AbstractAddEditSearchSpace;
using PartsAddEditSearchViewSpace;

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

        public void Create()
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

        public void Open()
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

        public void Save()
        {
            baseFormModel.DataBase.Save();

            baseFormModel.DataBase.Change = false;
        }

        public void SaveAs()
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
                System.IO.File.Copy(baseFormView.iniFile.CPUs, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.CPUs)), true);
                System.IO.File.Copy(baseFormView.iniFile.Mainboards, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Mainboards)), true);
                System.IO.File.Copy(baseFormView.iniFile.RAMs, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.RAMs)), true);
                System.IO.File.Copy(baseFormView.iniFile.Storges, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Storges)), true);
                System.IO.File.Copy(baseFormView.iniFile.Videocards, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Videocards)), true);
                System.IO.File.Copy(baseFormView.iniFile.Powers, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Powers)), true);
                System.IO.File.Copy(baseFormView.iniFile.Cases, Path.Combine($"{savePath.SelectedPath}\\БД", Path.GetFileName(baseFormView.iniFile.Cases)), true);
            }
        }

        public void Add()
        {
            //AddEditSearchView addEditsearchView = new AddEditSearchView(baseFormView.iniFile);

            //addEditsearchView.ShowDialog();

            //baseFormModel.DataBase.Table.Add(addEditsearchView.AddEditSearchPresenter.addEditSearchModel.Result);

            //baseFormModel.DataBase.Change = true;

            //baseFormView.TableOutput(baseFormModel.DataBase.Table);

            int saveCoordinates;

            AbstractAddEditSearch addEditsearchView;

            if (baseFormView.tableParameters.Coordinates == null || baseFormView.tableParameters.Coordinates.Item == null)
            {
                baseFormView.tableParameters.Coordinates = baseFormView.Table.HitTest(0, 0);

                if (baseFormView.Text == "DevList 6.9 - Главное окно")
                { addEditsearchView = new AddEditSearchView(baseFormView.iniFile); }

                else { addEditsearchView = new PartsAddEditSearchView(baseFormView.iniFile); }
            }
            else
            {
                saveCoordinates = baseFormView.tableParameters.Coordinates.Item == null ? 0 : baseFormView.tableParameters.Coordinates.Item.Index;

                if (saveCoordinates >= 0)
                {
                    if (baseFormView.Text == "DevList 6.9 - Главное окно")
                    {
                        addEditsearchView = new AddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[saveCoordinates]);
                    }
                    else
                    {
                        addEditsearchView = new PartsAddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[saveCoordinates]);
                    }
                }
                else
                {
                    if (baseFormView.Text == "DevList 6.9 - Главное окно")
                    {
                        addEditsearchView = new AddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[0]);
                    }
                    else
                    {
                        addEditsearchView = new PartsAddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[0]);
                    }
                }
            }

            addEditsearchView.ShowDialog();

            if (addEditsearchView.Result[13] == "1")
            {
                if (addEditsearchView.Result != null)
                {
                    baseFormModel.DataBase.Table.Add(addEditsearchView.Result);

                    baseFormModel.DataBase.Change = true;

                    baseFormView.TableOutput(baseFormModel.DataBase.Table);
                }
            }
        }

        public void EditAll()
        {
            if (baseFormView.tableParameters.Coordinates != null && baseFormView.tableParameters.Coordinates.Location != ListViewHitTestLocations.None)
            {
                AddEditSearchView addEditsearchView = new AddEditSearchView(baseFormView.iniFile);

                addEditsearchView.AddEditSearchPresenter.Result = baseFormModel.DataBase.Table[baseFormView.tableParameters.Id];

                string tmp = baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][3];

                addEditsearchView.AddEditSearchPresenter.Get();

                addEditsearchView.ShowDialog();

                if (tmp != addEditsearchView.AddEditSearchPresenter.Result[3])
                {
                    System.IO.File.AppendAllText
                    (
                        $"{Path.GetDirectoryName(Path.GetFullPath(baseFormView.iniFile.Path))}\\История перемещений\\{addEditsearchView.AddEditSearchPresenter.Result[3]}.txt",
                        $"Из помещения: {tmp}\r\n" +
                        $"переместили: {DateTime.Now}\r\n" +
                        $"{baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][5]}\r\n" +
                        $"с инв.№: {baseFormModel.DataBase.Table[baseFormView.tableParameters.Id][2]}\r\n\r\n"
                    );
                }

                baseFormModel.DataBase.Table[baseFormView.tableParameters.Id] = addEditsearchView.AddEditSearchPresenter.Result;

                baseFormModel.DataBase.Change = true;

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }

        public void Up()
        {
            baseFormModel.DataBase.UpDown(baseFormView.tableParameters.Line - 1, baseFormView.tableParameters.Line);

            baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

            baseFormView.Table.Select();
            
            baseFormView.Table.Items[baseFormView.tableParameters.Line - 1].Selected = true;

            baseFormModel.DataBase.Change = true;
        }

        public void Down()
        {
            baseFormModel.DataBase.UpDown(baseFormView.tableParameters.Line + 1, baseFormView.tableParameters.Line);

            baseFormView.TableOutput(baseFormModel.DataBase.Table, true);

            baseFormView.Table.Select();

            baseFormView.Table.Items[baseFormView.tableParameters.Line + 1].Selected = true;

            baseFormModel.DataBase.Change = true;
        }

        public void Remove()
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

        public void SortByTypes() { Reports report = new Reports(baseFormView.iniFile, baseFormModel.DataBase, reportType: "SortByTypes"); report.ShowDialog(); }

        public void SortByRooms() { Reports report = new Reports(baseFormView.iniFile, baseFormModel.DataBase, reportType: "SortByRooms"); report.ShowDialog(); }

        public void CommonReport()
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

        public void SearchAll()
        {
            baseFormView.TableOutput(baseFormModel.DataBase.FindAll(baseFormView.SearchAllBox.Text), false);

            baseFormView.Filter.Visible = true;
        }

        public void History()
        {
            DataBase historyBase = new DataBase(baseFormView.iniFile.History);

            BaseFormView history = new BaseFormView("DevList - История", baseFormView.iniFile, historyBase);

            history.WindowState = FormWindowState.Normal;

            history.File.Visible = false;

            history.View.Visible = false;

            history.Edit.Visible = false;

            history.Lists.Visible = false;

            history.Reports.Visible = false;

            history.History.Visible = false;

            history.Set.Visible = false;

            history.CAdd.Visible = false;

            history.CEditAll.Visible = false;

            history.Text = "DevList - История";

            history.Show();
        }

        public void Filtr()
        {
            DataBaseChanges();

            baseFormView.Table.ListViewItemSorter = null;

            baseFormView.TableOutput(baseFormModel.DataBase.Table);

            baseFormView.Filter.Visible = false;
        }

        public void Lists() { Lists lists = new Lists(baseFormView.iniFile); lists.ShowDialog(); }

        public void NomberString()
        {
            UpDownForm upDownForm = new UpDownForm(); upDownForm.ShowDialog();

            if (upDownForm.Result != null)
            {
                baseFormModel.DataBase.Move(baseFormView.tableParameters.Id, int.Parse(upDownForm.Result) - 1);

                baseFormView.TableOutput(baseFormModel.DataBase.Table);
            }
        }

        public void Set()
        {
            DataBase setBase = new DataBase(baseFormView.iniFile.Set);

            BaseFormView set = new BaseFormView("DevList - Комплект", baseFormView.iniFile, setBase);

            set.Create.Visible = false;

            set.Open.Visible = false;

            set.View.Visible = false;

            set.Reports.Visible = false;

            set.History.Visible = false;

            set.Set.Visible = false;

            set.Table.Columns.Clear();

            set.Table.Columns.Add(new ColumnHeader() { Name = "ID", Text = "ID", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "InvNomer", Text = "Системный блок Инв. №", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Data", Text = "Приобретено", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "CPU", Text = "Процессор", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Mainboard", Text = "Мат. плата", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "RAM", Text = "ОЗУ", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Disk", Text = "Накопитель", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Videocard", Text = "Видеокарта", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Power", Text = "Блок питания", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "Case", Text = "Корпус", TextAlign = HorizontalAlignment.Center });

            set.Table.Columns.Add(new ColumnHeader() { Name = "GvCPU", Text = "Год выпуска процессора", TextAlign = HorizontalAlignment.Center });

            set.Text = "DevList - Комплект";

            set.WindowState = FormWindowState.Normal;

            set.Show();
        }

        public void Search()
        {
            int saveCoordinates;

            AbstractAddEditSearch search;

            if (baseFormView.tableParameters.Coordinates == null || baseFormView.tableParameters.Coordinates.Item == null)
            {
                baseFormView.tableParameters.Coordinates = baseFormView.Table.HitTest(0, 0);

                if (baseFormView.Text == "DevList 6.9 - Главное окно" || baseFormView.Text == "DevList - История") { search = new AddEditSearchView(baseFormView.iniFile); }

                else { search = new PartsAddEditSearchViewSpace.PartsAddEditSearchView(baseFormView.iniFile); }
            }
            else
            {
                saveCoordinates = baseFormView.tableParameters.Coordinates.Item == null ? 0 : baseFormView.tableParameters.Coordinates.Item.Index;

                if (saveCoordinates >= 0)
                {
                    if (baseFormView.Text == "DevList 6.9 - Главное окно" || baseFormView.Text == "DevList - История")
                    
                    { search = new AddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[saveCoordinates]); }

                    else { search = new PartsAddEditSearchViewSpace.PartsAddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[saveCoordinates]); }
                }
                else
                {
                    if (baseFormView.Text == "DevList 6.9 - Главное окно" || baseFormView.Text == "DevList - История")
                    
                    { search = new AddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[0]); }

                    else { search = new PartsAddEditSearchViewSpace.PartsAddEditSearchView(baseFormView.iniFile, baseFormModel.DataBase.Table[0]); }
                }
            }

            search.ShowDialog();

            if (search.Executed)
            {
                if (search.Result != null)
                {
                    bool stringEmptyCheck = false;

                    foreach (string word in search.Result) { if (word != string.Empty) { stringEmptyCheck = true; } }

                    if (stringEmptyCheck) { baseFormView.TableOutput(baseFormModel.DataBase.StringSearch(search.Result), false); } else { baseFormView.Table.Items.Clear(); }

                    baseFormView.Filter.Visible = true;
                }
            }
        }
    }
}
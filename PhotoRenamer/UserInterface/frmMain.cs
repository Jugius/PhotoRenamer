using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace PhotoRenamer.UserInterface
{
    public partial class frmPhotoRenamer : Models.MetroUIForm
    {
        private List<PhotoIDItem> PhotoIDsItemsList;
        private string PhotosDirectory;
        public frmPhotoRenamer()
        {
            InitializeComponent();
        }
        private void AddMessageToStatus(string message)
        {
            txtStatus.Text += message + Environment.NewLine;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!Verified())
                return;

            PhotoFileNameType kind = rad_format_BrdId.Checked ? PhotoFileNameType.Num : PhotoFileNameType.Num_sep_text;
            PhotoFileNameFormat format = new PhotoFileNameFormat(kind, txtSeparator.Text);

            Renamer renamer = new Renamer(PhotoIDsItemsList, PhotosDirectory, format);
            renamer.SendMessage += delegate (string s)
            {
                if (InvokeRequired) Invoke(new Action<string>(i => AddMessageToStatus(i)), s);
                else AddMessageToStatus(s);
            };
            renamer.ProcessFinished += delegate {
                if (InvokeRequired) Invoke(new Action(OnProcessFinished));
                else OnProcessFinished();
            };
            renamer.ProcessFinshedWithError += delegate (Exception ex)
              {
                  if (InvokeRequired) Invoke(new Action<Exception>(i => OnProcessFinishedWithError(i)), ex);
                  else OnProcessFinishedWithError(ex);
              };

            Thread t = new Thread(renamer.RunRename);
            t.Start();
        }

       
        private bool Verified()
        {
            if (PhotoIDsItemsList == null || PhotoIDsItemsList.Count == 0)
            {
                AddMessageToStatus("Список соответствий пуст, загрузите файл.");
                return false;
            }
            if (string.IsNullOrEmpty(PhotosDirectory))
            {
                AddMessageToStatus("Не указана папка с фотографиями, выберите папку.");
                return false;
            }
            return true;
        }

        private string OpenExcelFile()
        {
            string fileName = null;
            using (OpenFileDialog of = new OpenFileDialog())
            {
                of.Title = "Выберите файл";
                of.Filter = "Файлы Excel|*.xlsx;*.xls;*.xlsm";
                if (of.ShowDialog() == DialogResult.OK)
                    fileName = of.FileName;
            }
            return fileName;
        }
        private List<PhotoIDItem> ReadListExcelFile(string fileName)
        {
            List<PhotoIDItem> items;
            using (UsingExcel excel = new UsingExcel())
            {
                excel.SendMessage += AddMessageToStatus;
                items = excel.ReadExcelFile(fileName);
            }
            return items;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnChangeFile_Click(object sender, EventArgs e)
        {
            string fileName = OpenExcelFile();
            if (!string.IsNullOrEmpty(fileName))
            {
                PhotoIDsItemsList = null;
                try
                {
                    List<PhotoIDItem> items = ReadListExcelFile(fileName);
                    if (items == null || items.Count == 0)
                        throw new Exception("Не найдено записей в файле.");
                    PhotoIDsItemsList = items;
                    lblFileName.Text = System.IO.Path.GetFileName(fileName);
                    AddMessageToStatus("Файл загружен: " + fileName + Environment.NewLine + "Прочитано записей: " + PhotoIDsItemsList.Count);
                }
                catch (Exception ex)
                {
                    lblFileName.Text = "Открыть файл";
                    AddMessageToStatus("Не удалось прочитать файл. Ошибка:" + Environment.NewLine + ex.Message);
                }
            }
        }

        private void btnChangeFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog f = new FolderBrowserDialog())
            {
                if (f.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(f.SelectedPath))
                {
                    PhotosDirectory = f.SelectedPath;
                    lblPhotosDirectory.Text = f.SelectedPath;
                }
            }
        }
        private void OnProcessFinished()
        {
            AddMessageToStatus("Процесс завершен.");
        }
        private void OnProcessFinishedWithError(Exception ex)
        {
            AddMessageToStatus("Процесс закрыт из-за критической ошибки!" + Environment.NewLine + ex.Message);
        }
        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new UserInterface.frmAbout();
            about.ShowDialog();
        }


        #region Dragging Form

        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        #endregion

        
    }
}

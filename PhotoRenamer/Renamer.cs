using System;
using System.Collections.Generic;


namespace PhotoRenamer
{
    public delegate void SendMessageHandler(string message);
    public delegate void ProcessFinshedEventHandler();
    public delegate void ProcessFinshedWithErrorEventHandler(Exception ex);
    class Renamer
    {
        public event SendMessageHandler SendMessage;
        public event ProcessFinshedEventHandler ProcessFinished;
        public event ProcessFinshedWithErrorEventHandler ProcessFinshedWithError;


        private List<PhotoIDItem> PhotoIDsItemsList;
        private string PhotosDirectory;
        private PhotoFileNameFormat FileFormat;

        public Renamer(List<PhotoIDItem> photoIDsItemsList, string photosDirectory, PhotoFileNameFormat fileFormat)
        {
            this.PhotoIDsItemsList = photoIDsItemsList;
            this.PhotosDirectory = photosDirectory;
            this.FileFormat = fileFormat;
        }
        public void RunRename()
        {
            string destFolder = PhotosDirectory + @"\Renamed";
            try {
                string[] files = System.IO.Directory.GetFiles(PhotosDirectory);
                if (files == null || files.Length == 0)
                    throw new Exception("Нет файлов в папке: " + PhotosDirectory);

                int renamed = 0;
                foreach (string s in files)
                {
                    string shortFileName = System.IO.Path.GetFileNameWithoutExtension(s);
                    string supplierID = GetSupplierIDFromFileName(shortFileName);
                    string contractorID = GetContractorID(supplierID);

                    if (!string.IsNullOrEmpty(contractorID))
                    {
                        if (!System.IO.Directory.Exists(destFolder))
                            System.IO.Directory.CreateDirectory(destFolder);

                        string dest = destFolder + @"\" + contractorID + GetFileNameWithoutSupplierID(shortFileName) + System.IO.Path.GetExtension(s);
                        System.IO.File.Copy(s, dest, true);
                        renamed++;
                        SendMessage?.Invoke("для файла " + shortFileName + " найдено соответствие: " + contractorID);
                    }
                }
                SendMessage?.Invoke("Всего обработано файлов: " + renamed.ToString());
                ProcessFinished?.Invoke();
            }
            catch(Exception ex)
            {
                ProcessFinshedWithError?.Invoke(ex);
            }
        }

        

        private string GetContractorID(string supplierID)
        {
            for (int i = 0; i < PhotoIDsItemsList.Count; i++)
                if (supplierID == PhotoIDsItemsList[i].SupplierID)
                    return PhotoIDsItemsList[i].ContractorID;
            return null;
        }

        private string GetSupplierIDFromFileName(string s)
        {
            if (this.FileFormat.Type == PhotoFileNameType.Num || string.IsNullOrEmpty(this.FileFormat.Separator))
                return s.ToUpper();

            int index = s.IndexOf(this.FileFormat.Separator);
            if (index != -1)
                return s.Remove(index).ToUpper();

            return s.ToUpper();
        }
        private string GetFileNameWithoutSupplierID(string s)
        {
            if (this.FileFormat.Type == PhotoFileNameType.Num || string.IsNullOrEmpty(this.FileFormat.Separator))
                return string.Empty;

            int index = s.IndexOf(this.FileFormat.Separator);
            if (index != -1)
                return s.Substring(index);

            return string.Empty;
        }
    }
}

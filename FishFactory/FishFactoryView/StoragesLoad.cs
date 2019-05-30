using FishFactoryServiceDAL.BindingM;
using FishFactoryServiceDAL.Interfaces;
using FishFactoryServiceDAL.ViewM;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace FishFactoryView
{
    public partial class StoragesLoad : Form
    {
        public StoragesLoad()
        {
            InitializeComponent();
        }
        private void StoragesLoad_Load(object sender, EventArgs e)
        {
            try
            {
                var dict = APIClient.GetRequest<List<StoragesLoadViewM>>("api/Rept/GetStoragesLoad");
                if (dict != null)
                {
                    dataGridView.Rows.Clear();
                    foreach (var elem in dict)
                    {
                        dataGridView.Rows.Add(new object[] { elem.StorageNominal, "", "" });
                        foreach (var listElem in elem.TypesOfFish)
                        {
                            dataGridView.Rows.Add(new object[] { "", listElem.Item1, listElem.Item2 });
                        }
                        dataGridView.Rows.Add(new object[] { "Итого", "", elem.TotalTotal });
                        dataGridView.Rows.Add(new object[] { });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void buttonSaveToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "xls|*.xls|xlsx|*.xlsx"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    APIClient.PostRequest<ReptBindingM, bool>("api/Rept/SaveStoragesLoad", new ReptBindingM
                    {
                        FileNominal = sfd.FileName
                    });
                    MessageBox.Show("Выполнено", "Успех", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }
    }
}

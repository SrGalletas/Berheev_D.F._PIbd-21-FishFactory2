using FishFactoryServiceDAL.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryServiceDAL.BindingM;
using FishFactoryServiceDAL.ViewM;

namespace FishFactoryView
{
    public partial class Storage : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        public Storage()
        {
            InitializeComponent();
        }
        private void Storage_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    StorageViewM view = APIClient.GetRequest<StorageViewM>("api/Storage/Get/" + id.Value);
                    if (view != null)
                    {
                        textBoxName.Text = view.StorageName;
                        dataGridView.DataSource = view.StorageFishes;
                        dataGridView.Columns[0].Visible = false;
                        dataGridView.Columns[1].Visible = false;
                        dataGridView.Columns[2].Visible = false;
                        dataGridView.Columns[3].AutoSizeMode =
                        DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните название", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (id.HasValue)
                {
                    APIClient.PostRequest<StorageBindingM, bool>("api/Storage/UpdElement", new StorageBindingM
                    {
                        Id = id.Value,
                        StorageName = textBoxName.Text
                    });
                }
                else
                {
                    APIClient.PostRequest<StorageBindingM, bool>("api/Storage/AddElement", new StorageBindingM
                    {
                        StorageName = textBoxName.Text
                    });
                }
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}


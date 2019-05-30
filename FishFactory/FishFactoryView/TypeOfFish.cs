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
using FishFactoryServiceDAL.Interfaces;

namespace FishFactoryView
{
    public partial class TypeOfFish : Form
    {
        public int Id { set { id = value; } }
        private int? id;
        public TypeOfFish()
        {
            InitializeComponent();
        }
        private void TypeOfFish_Load(object sender, EventArgs e)
        {
            if (id.HasValue)
            {
                try
                {
                    TypeOfFishViewM view = APIClient.GetRequest<TypeOfFishViewM>("api/TypeOfFish/Get/" + id.Value); ;
                    if (view != null)
                    {
                        textBoxName.Text = view.TypeOfFishName;
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
                    APIClient.PostRequest<TypeOfFishBindingM, bool>("api/TypeOfFish/UpdElement", new TypeOfFishBindingM
                    {
                        Id = id.Value,
                        TypeOfFishName = textBoxName.Text
                    });
                }
                else
                {
                    APIClient.PostRequest<TypeOfFishBindingM, bool>("api/TypeOfFish/AddElement", new TypeOfFishBindingM
                    {
                        TypeOfFishName = textBoxName.Text
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

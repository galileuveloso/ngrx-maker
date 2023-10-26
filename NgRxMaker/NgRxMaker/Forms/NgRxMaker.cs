using System;
using System.Windows.Forms;

namespace NgRxMaker
{
    public partial class NgRxMaker : Form
    {
        public NgRxMaker()
        {
            InitializeComponent();
        }

        private void BrowseFolderBtn_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                Maker.CreateFeature
                (
                    folderBrowserDialog.SelectedPath,
                    EntityTxt.Text
                );

                MessageBox.Show("Success!");

                EntityTxt.Text = string.Empty;
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool IsValid()
            =>  !String.IsNullOrEmpty(EntityTxt.Text)
                && folderBrowserDialog.ShowDialog().Equals(DialogResult.OK);
    }
}

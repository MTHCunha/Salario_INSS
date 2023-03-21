namespace _9
{
    public partial class Form1 : Form
    {
        List<Func> funcionários = new List<Func>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                funcionários.Add(new Func(
                            Convert.ToInt32(txtCod.Value),
                            txtNom.Text,
                            txtrrgg.Text,
                            Convert.ToDouble(txtbru.Value),
                            Convert.ToDouble(txtbru.Value),
                            Convert.ToDouble(txtbru.Value)));
                MessageBox.Show("Salvo!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcionários;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


    }
}
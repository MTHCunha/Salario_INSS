namespace _9
{
    public partial class Form1 : Form
    {
        List<Func> funcion�rios = new List<Func>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                funcion�rios.Add(new Func(
                            Convert.ToInt32(txtCod.Value),
                            txtNom.Text,
                            txtrrgg.Text,
                            Convert.ToDouble(txtbru.Value),
                            Convert.ToDouble(txtbru.Value),
                            Convert.ToDouble(txtbru.Value)));
                MessageBox.Show("Salvo!");

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = funcion�rios;

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }


    }
}
using Microsoft.Data.SqlClient;
using System.Data;
namespace EtapaRaliu
{
    public partial class Form1 : Form
    {
        SqlConnection cs = new SqlConnection("Data Source=LAPTOP-LO9O0L3V\\SQLEXPRESS;Initial Catalog=EtapaRaliu;Integrated Security=True;TrustServerCertificate=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds1 = new DataSet();
        int generatedId = 0;


        public Form1()
        {
            InitializeComponent();
        }





        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                da.SelectCommand = new SqlCommand("Select * from CATEGORIE", cs);
                ds.Clear();
                da.Fill(ds);
                CategorieGridView.DataSource = ds.Tables[0];

                DataSet ds2 = new DataSet();
                da.SelectCommand = new SqlCommand("Select max(ID_MASINA) from MASINA", cs);
                ds2.Clear();
                da.Fill(ds2);
                generatedId = ds2.Tables[0].Rows[0].Field<int>(0) + 1;
                ds2.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }
        private void LoadChild()
        {
            try
            {

                da.SelectCommand = new SqlCommand("Select * from MASINA", cs);
                ds1.Clear();
                da.Fill(ds1);
                MasinaGridView.DataSource = ds1.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void CategorieGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                da.SelectCommand = new SqlCommand("Select * from MASINA where NUME_CAT=@id", cs);
                String id = CategorieGridView.SelectedRows[0].Cells[0].Value.ToString();
                da.SelectCommand.Parameters.Add("@id", SqlDbType.VarChar).Value = id;
                ds1.Clear();
                da.Fill(ds1);
                MasinaGridView.DataSource = ds1.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                da.InsertCommand = new SqlCommand("Insert into MASINA(ID_MASINA,NUME_CAT,CAPACITATE_MOTOR,MARCA,MODEL)values(@id,@c1,@c2,@c3,@c4)", cs);

                da.InsertCommand.Parameters.Add("@id", SqlDbType.Int).Value = generatedId;
                generatedId = generatedId + 1;
                da.InsertCommand.Parameters.Add("@c1", SqlDbType.VarChar).Value = CategorieGridView.SelectedRows[0].Cells[0].Value.ToString();
                da.InsertCommand.Parameters.Add("@c2", SqlDbType.Int).Value = int.Parse(textBox1.Text.Trim());
                da.InsertCommand.Parameters.Add("c3", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                da.InsertCommand.Parameters.Add("c4", SqlDbType.VarChar).Value = textBox3.Text.Trim();
                cs.Open();
                da.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Inserted succesfull!");
                cs.Close();
                LoadChild();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                da.UpdateCommand = new SqlCommand("Update MASINA set CAPACITATE_MOTOR =@c1,MARCA=@c2,MODEL=@c3 where ID_MASINA=@id", cs);
                da.UpdateCommand.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(MasinaGridView.SelectedRows[0].Cells[0].Value.ToString());
                da.UpdateCommand.Parameters.Add("@c1", SqlDbType.Int).Value = int.Parse(textBox1.Text.Trim());
                da.UpdateCommand.Parameters.Add("@c2", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                da.UpdateCommand.Parameters.Add("c3", SqlDbType.VarChar).Value = textBox3.Text.Trim();
                cs.Open();
                da.UpdateCommand.ExecuteNonQuery();
                MessageBox.Show("Update succesfull!");
                cs.Close();
                LoadChild();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                da.DeleteCommand = new SqlCommand("Delete from MASINA where ID_MASINA=@id", cs);
                da.DeleteCommand.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(MasinaGridView.SelectedRows[0].Cells[0].Value.ToString());
                cs.Open();
                da.DeleteCommand.ExecuteNonQuery();
                MessageBox.Show("Delete succesfull!");
                cs.Close();
                LoadChild();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                cs.Close();
            }
        }

        private void MasinaGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = MasinaGridView.SelectedRows[0].Cells[2].Value.ToString();
            textBox2.Text = MasinaGridView.SelectedRows[0].Cells[3].Value.ToString();
            textBox3.Text = MasinaGridView.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
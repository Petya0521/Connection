using MySqlConnector;

namespace ConnectMySQL11d
{
    public partial class Form1 : Form
    {
        string connstr = "server=192.168.1.235" +
            "port=3306;" +
            "user=REMOTE;" +
            "password=Aa123456@;" +
            "datebase=monions";
        MySqlConnection connestion;
        MySqlCommand query;
        public Form1()
        {
            InitializeComponent();
        }

        

		private void Form1_Load(object sender, EventArgs e)
		{
            connestion = new MySqlConnection(connstr);
            if (connestion.State == 0)
            {
                connestion.Open();
            }
            MessageBox.Show("Connection open!");
            string sql = "Select minions.id,minions.Name,minions.Age" + "From minions";
            MySqlDataReader reader = query.ExecuteReader();
            while (reader.Read()) 
            {
                listBox1.Items.Add($"{reader[0]}-->{reader[1]}is{reader[2]}years old");
            }
            reader.Close();
            connestion.Close();
		}

		private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}                                             
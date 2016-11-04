using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ControleFaculdade
{

    class BDconnection
    {
        public DataSet bdDataSet;
        public string stringConnection;
        public SqlConnection bdConn;


        public void OpenConnection(){
            bdDataSet = new DataSet();
            stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SampleDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            bdConn = new SqlConnection(stringConnection);

            try
            {
                bdConn.Open();
            }
            catch
            {
                MessageBox.Show("Impossível conectar ao banco de dados!");
            }

        }

        public void CloseConnection(){

            bdDataSet = new DataSet();
            stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SampleDataBase.mdf;Integrated Security=True;Connect Timeout=30";
            bdConn = new SqlConnection(stringConnection);

            try
            {
                bdConn.Close();
            }
            catch
            {
                
            }
        }

        
    }
}

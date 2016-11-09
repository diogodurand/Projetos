using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace ControleFaculdade
{

    class BD
    {
        public DataSet bdDataSet;
        public string stringConnection;
        public static SqlConnection bdConn;
        public SqlCommand command;
        StringBuilder errorMessages = new StringBuilder();
        SqlDataReader retorno;
        

        public SqlDataReader Select(string sql)
        {

            OpenConnection();

            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = bdConn;

            try
            {
                retorno = command.ExecuteReader();
                CloseConnection();
                return retorno;
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                return retorno;
            }

        }

        public string Update(string sql)
        {

            OpenConnection();
            string retorno;

            command.CommandText = sql;
            command.CommandType = CommandType.Text;
            command.Connection = bdConn;
            

            try
            {
                command.ExecuteNonQuery();
                CloseConnection();
                return retorno = "Realizado Update com sucesso";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                return retorno = "Erro ao realizar Update: " + errorMessages;
            }

        }

        public string Insert(string sql)
        {
            
            string retorno;
            
            try
            {
                OpenConnection();
                
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                command.Connection = bdConn;
                

                command.ExecuteNonQuery();
                CloseConnection();


                return retorno = "Realizado Insert com sucesso";
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());

                return retorno = "Erro ao realizar Insert: " + errorMessages;
            }

        }

        public void OpenConnection()
        {
            bdDataSet = new DataSet();
            stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diogo.ventura.durand\Source\Repos\Projetos\ControleFaculdade\ControleFaculdade\DBControleFaculdade.mdf;Integrated Security=True;Connect Timeout=30";
            bdConn = new SqlConnection(stringConnection);
            
            try
            {
                bdConn.Open();
                command = bdConn.CreateCommand();
                
            }
            catch
            {
                MessageBox.Show("Impossível conectar ao banco de dados!");
            }

        }

        public void CloseConnection()
        {

            bdDataSet = new DataSet();
            stringConnection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\diogo.ventura.durand\Source\Repos\Projetos\ControleFaculdade\ControleFaculdade\DBControleFaculdade.mdf;Integrated Security=True;Connect Timeout=30";
            bdConn = new SqlConnection(stringConnection);

            try
            {
                bdConn.Close();
            }
            catch (SqlException ex)
            {
                for (int i = 0; i < ex.Errors.Count; i++)
                {
                    errorMessages.Append("Index #" + i + "\n" +
                        "Message: " + ex.Errors[i].Message + "\n" +
                        "LineNumber: " + ex.Errors[i].LineNumber + "\n" +
                        "Source: " + ex.Errors[i].Source + "\n" +
                        "Procedure: " + ex.Errors[i].Procedure + "\n");
                }
                Console.WriteLine(errorMessages.ToString());
            }
        }


    }
}

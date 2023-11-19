using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using luvo.erp.ngerp1;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.AccessControl;
using System.CodeDom;

namespace FrmCOFLabel.API
{
    public class CHW_HK
    {
        //public DataTable CheckResetExist(string cc, string year, string month)
        //{
        //    DataTable tblresetExist = new DataTable();
        //    string yearMonth = year + month;
        //    CModule.cnn.Open();
        //    string query = "SELECT * from tblPanel WHERE cc = '" + cc + "' AND yearMonth = '" + yearMonth + "' AND runningCode = 0 ";
        //    SqlCommand cmd = new SqlCommand(query, CModule.cnn);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(tblresetExist);
        //    CModule.cnn.Close();
        //    return tblresetExist;
        //}

        public DataTable GetUserRecord(string cc)
        {
            DataTable tblUser = new DataTable();

            try
            {
                if (CModule.cnn.State != ConnectionState.Open)
                {
                    CModule.cnn.Open();
                }

                string query = "select * from tblUser WHERE cc = '" + cc + "'";
                SqlCommand cmd = new SqlCommand(query, CModule.cnn);
                // create data adapter
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                // this will query your database and return the result to your datatable
                da.Fill(tblUser); 
            }
            catch (Exception ex)
            {
                // Handle the exception here, for example, display an error message
                Console.WriteLine("Error while connecting to SQL: " + ex.Message);
                // You can also throw the exception if needed
                // throw ex;
            }
            finally
            {
                if (CModule.cnn.State == ConnectionState.Open)
                {
                    CModule.cnn.Close();
                }
            }
            return tblUser;
        }

        public String GetUserRecord(string cc, string un)
        {
            DataTable tblUser = new DataTable();
            string role = ""; 
            CModule.cnn.Open();
            string query = "select * from tblUser WHERE cc = '" + cc + "' and un = '" + un + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblUser);
            CModule.cnn.Close();
            if (tblUser.Rows.Count > 0)
            {
                role = tblUser.Rows[0]["role"].ToString();
            } else
            {
                role = ""; 
            }

            return role; 

        }

        public int GetUserRecordName(string cc, string un)
        {
            DataTable tblUser = new DataTable();
            int result  = 0;
            CModule.cnn.Open();
            string query = "select * from tblUser WHERE cc = '" + cc + "' and un = '" + un + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblUser);
            CModule.cnn.Close();
            if (tblUser.Rows.Count > 0)
            {
                result = 1; 
            }
            else
            {
                result = 0; 
            }

            return result;

        }

        public DataTable GettblIncidentTicketRecordAssign(string cc)
        {
            DataTable tblIncidentTicket = new DataTable();
            CModule.cnn.Open();
            string query = "select * from tblIncidentTicket WHERE cc = '" + cc + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblIncidentTicket);
            CModule.cnn.Close();
            //tbl = table1; 
            return tblIncidentTicket;
        }

        public DataTable GettblEnhancementTicketRecordAssign(string cc)
        {
            DataTable tblEnhancementTicket = new DataTable();
            CModule.cnn.Open();
            string query = "select * from tblEnhancementTicket WHERE cc = '" + cc + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblEnhancementTicket);
            CModule.cnn.Close();
            //tbl = table1; 
            return tblEnhancementTicket;
        }

        public DataTable GettblIncidentTicketRecordSubmit(string cc, string un)
        {
            DataTable tblIncidentTicket = new DataTable();
            CModule.cnn.Open();
            string query = "select * from tblIncidentTicket WHERE cc = '" + cc + "' and createdBy = '" + un + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblIncidentTicket);
            CModule.cnn.Close();
            //tbl = table1; 
            return tblIncidentTicket;
        }

        public DataTable GettblEnhancementTicketRecordSubmit(string cc, string un)
        {
            DataTable tblEnhancementTicket = new DataTable();
            CModule.cnn.Open();
            string query = "select * from tblEnhancementTicket WHERE cc = '" + cc + "' and createdBy = '" + un + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            // create data adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            // this will query your database and return the result to your datatable
            da.Fill(tblEnhancementTicket);
            CModule.cnn.Close();
            //tbl = table1; 
            return tblEnhancementTicket;
        }



        public DataTable GetLastRecordTblIncident(string cc)
        {
            DataTable tblIncidentTicket = new DataTable();
            CModule.cnn.Open();
            string query = "SELECT TOP 1 * FROM tblIncidentTicket where cc = '" + cc + "' order by id desc";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblIncidentTicket);
            CModule.cnn.Close();
            return tblIncidentTicket;
        }

        public DataTable GetRecordByUsingTicketNo(string cc, string ticketNo)
        {
            DataTable tblIncidentTicket = new DataTable();
            CModule.cnn.Open();
            string query = "SELECT TOP 1 * FROM tblIncidentTicket where cc = '" + cc + "' and ticketNo = '" + ticketNo +"'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblIncidentTicket);
            CModule.cnn.Close();
            return tblIncidentTicket;

        }

        public DataTable GetRecordByUsingEncTicketNo(string cc, string ticketNo)
        {
            DataTable tblEnhancementTicket = new DataTable();
            CModule.cnn.Open();
            string query = "SELECT TOP 1 * FROM tblEnhancementTicket where cc = '" + cc + "' and ticketNo = '" + ticketNo + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblEnhancementTicket);
            CModule.cnn.Close();
            return tblEnhancementTicket;

        }



        public DataTable GetAllRecordsTblIncident (string cc, string un)
        {
            DataTable tblIncidentTicket = new DataTable();
            CModule.cnn.Open();
            string query = "SELECT  * FROM tblIncidentTicket where cc = '" + cc + "' and createdBy = '" + un + "' order by id desc";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblIncidentTicket);
            CModule.cnn.Close();
            return tblIncidentTicket;
        }



        public DataTable GetLastRecordTblEnhancement(string cc)
        {
            DataTable tblEnhancementTicket = new DataTable();
            CModule.cnn.Open();
            string query = "SELECT TOP 1 * FROM tblEnhancementTicket where cc = '" + cc + "' order by id desc";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(tblEnhancementTicket);
            CModule.cnn.Close();
            return tblEnhancementTicket;
        }

        public string insertTblUser(string cc, string un, string pw, string dept, string role, string mobile, string createdDate,  string createdBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "Insert into tblUser (cc, un, pw, dept, role, mobile, createdDate, updatedDate, createdBy, updatedBy) values ('" + cc + "', '" + un + "', '" + pw + "', '" + dept + "', '" + role + "', '" + mobile + "', '" + createdDate + "', '" + createdDate + "', '" + createdBy + "', '" + createdBy + "')";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
            CModule.cnn.Open();
            string id2 = "";
            using (SqlCommand command2 = new SqlCommand("Select id from tblUser where un = '" + un + "' AND cc = '" + cc + "'", CModule.cnn))
            {
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    reader.Read();
                    id2 = reader["id"].ToString();
                }
            }
            CModule.cnn.Close();
            return id2;
        }

        //public void updateTblUser(string id, string cc, string un, string pw, string dept, string role, string mobile, string updatedDate, string updatedBy)
        //{
        //    CModule.cnn.Open();
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    string sql = "";
        //    sql = "UPDATE tblUser SET cc = '" + cc + "', un = '" + un + "', pw = '" + pw + "', dept = '" + dept + "', role = '" + role + "', mobile = '" + mobile + "', updatedDate = '" + updatedDate + "', updatedBy = '" + updatedBy + "' WHERE id = " + id;
        //    command = new SqlCommand(sql, CModule.cnn);
        //    adapter.UpdateCommand = new SqlCommand(sql, CModule.cnn);
        //    adapter.UpdateCommand.ExecuteNonQuery();
        //    command.Dispose();
        //    CModule.cnn.Close();
        //}

        public bool updateTblUser(string cc, string un, string pw, string dept, string role, string mobile, string updatedDate, string updatedBy)
        {
            bool updateSuccessful = false;

            try
            {
                CModule.cnn.Open();
                SqlCommand command;
                SqlDataAdapter adapter = new SqlDataAdapter();
                string sql = "UPDATE tblUser SET cc = @cc, un = @un, pw = @pw, dept = @dept, role = @role, mobile = @mobile, updatedDate = @updatedDate, updatedBy = @updatedBy WHERE un = @un AND cc = @cc";

                command = new SqlCommand(sql, CModule.cnn);
                command.Parameters.AddWithValue("@cc", cc);
                command.Parameters.AddWithValue("@un", un);
                command.Parameters.AddWithValue("@pw", pw);
                command.Parameters.AddWithValue("@dept", dept);
                command.Parameters.AddWithValue("@role", role);
                command.Parameters.AddWithValue("@mobile", mobile);
                command.Parameters.AddWithValue("@updatedDate", updatedDate);
                command.Parameters.AddWithValue("@updatedBy", updatedBy);
             

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    updateSuccessful = true;
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or throw a custom exception)
                // You may also want to return false in case of an exception
                updateSuccessful = false;
            }
            finally
            {
                CModule.cnn.Close();
            }

            return updateSuccessful;
        }


        public bool deleteTblUser(string un, string cc)
        {
            bool deleteSuccessful = false;

            try
            {
                CModule.cnn.Open();
                SqlCommand command;
                string sql = "DELETE FROM tblUser WHERE un = @un AND cc = @cc";

                command = new SqlCommand(sql, CModule.cnn);
                command.Parameters.AddWithValue("@un", un);
                command.Parameters.AddWithValue("@cc", cc);

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    deleteSuccessful = true;
                }

                command.Dispose();
            }
            catch (Exception ex)
            {
                // Handle the exception (e.g., log it or throw a custom exception)
                // You may also want to return false in case of an exception
                deleteSuccessful = false;
            }
            finally
            {
                CModule.cnn.Close();
            }

            return deleteSuccessful;
        }



        public string insertTblIncidentTicket(string cc, string ticketNo, string priority, string title, string status, string description, string type, string location, string assignGroup, string shift, string chat, string createdBy, string updatedBy, string createdDate, string updatedDate)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "Insert into tblIncidentTicket (cc, ticketNo,  priority,  title,  status,  description, type, location, assignGroup, shift, chat,createdBy, updatedBy, createdDate,updatedDate ) values ('" + cc + "', '" + ticketNo + "', '" + priority + "', '" + title + "', '" + status + "', '" + description + "', '" + type + "', '" + location + "', '" + assignGroup + "', '" + shift + "', '" + chat + "', '" + createdBy + "', '" + updatedBy + "', '" + createdDate + "', '" + updatedDate + "')";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
            CModule.cnn.Open();
            string id2 = "";
            using (SqlCommand command2 = new SqlCommand("Select id from tblIncidentTicket where  ticketNo = '" + ticketNo + "' AND cc = '" + cc + "'", CModule.cnn))
            {
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    reader.Read();
                    id2 = reader["id"].ToString();
                }
            }
            CModule.cnn.Close();
            return id2;
        }

        public void UpdtblIncidentSolution(string cc,string ticketNo, string status, string chat, string solution, string comment, string solveDate,  string solvedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblIncidentTicket SET status = '" + status + "', chat = '"+ chat + "', solution = '" + solution + "', comment = '" + comment +"', solveDate = '" + solveDate + "',updatedDate = '" + solveDate + "', solvedBy = '" + solvedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }

        public void UpdtblIncidentChat(string cc, string ticketNo,  string chat, string updatedDate, string updatedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblIncidentTicket SET chat = '" + chat + "',  updatedDate = '" + updatedDate + "', updatedBy = '" + updatedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }

        public void UpdtblEnhancementChat(string cc, string ticketNo, string chat, string updatedDate, string updatedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblEnhancementTicket SET chat = '" + chat + "',  updatedDate = '" + updatedDate + "', updatedBy = '" + updatedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }


        public void UpdtblIncidentClose(string cc, string ticketNo, string status, string chat, string solution, string comment, string closeDate, string closedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblIncidentTicket SET status = '" + status + "', chat = '" + chat + "', solution = '" + solution + "', comment = '" + comment + "', closeDate = '" + closeDate + "',updatedDate = '" + closeDate + "', closedBy = '" + closedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }
        public string insertTblEnhancementTicket(string cc, string ticketNo, string type, string status, string objective, string description, string chat, string assignGroup, string createdBy, string updatedBy, string requiredDate, string createdDate, string updatedDate)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "Insert into tblEnhancementTicket (cc, ticketNo, type, status, objective, description, chat, assignGroup, createdBy, updatedBy, requiredDate, createdDate, updatedDate ) values ('" + cc + "', '" + ticketNo + "', '" + type + "', '" + status + "', '" + objective + "', '" + description + "',  '" + chat + "', '" + assignGroup + "',   '" + createdBy + "', '" + updatedBy + "', '" + requiredDate + "', '" + createdDate + "', '" + updatedDate + "')";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
            CModule.cnn.Open();
            string id2 = "";
            using (SqlCommand command2 = new SqlCommand("Select id from tblEnhancementTicket where  ticketNo = '" + ticketNo + "' AND cc = '" + cc + "'", CModule.cnn))
            {
                using (SqlDataReader reader = command2.ExecuteReader())
                {
                    reader.Read();
                    id2 = reader["id"].ToString();
                }
            }
            CModule.cnn.Close();
            return id2;
        }


        public string GetRoleData(string cc, string un)
        {
            string role = "";
            CModule.cnn.Open();
            string query = "SELECT role FROM tblUser WHERE cc = '" + cc + "' AND un = '" + un + "'";
            SqlCommand cmd = new SqlCommand(query, CModule.cnn);
            SqlDataReader sReader;
            cmd.Parameters.Clear();
            sReader = cmd.ExecuteReader(0);
            while (sReader.Read())
            {
                role = sReader["role"].ToString();
            }
            CModule.cnn.Close();
            return role;
        }


        public void UpdtblEnhancementDeveloping(string cc, string ticketNo, string status, string chat, string developing, string estimateDate,  string dtNow, string updatedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblEnhancementTicket SET status = '" + status + "', chat = '" + chat + "', developing = '" + developing + "',estimateDate = '" + estimateDate + "', updatedDate = '" + dtNow + "', updatedBy = '" + updatedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }

        public void UpdtblEnhancementComplete(string cc, string ticketNo, string status, string chat, string complete, string completeDate, string dtNow, string updatedBy)
        {
            CModule.cnn.Open();
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            string sql = "";
            sql = "UPDATE tblEnhancementTicket SET status = '" + status + "', chat = '" + chat + "', complete = '" + complete + "',completeDate = '" + completeDate + "', updatedDate = '" + dtNow + "', updatedBy = '" + updatedBy + "' WHERE cc = '" + cc + "' AND ticketNo = '" + ticketNo + "'";
            command = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
            CModule.cnn.Close();
        }


        //public DataTable GetTblDiode (string cc,string partNumber )
        //{
        //    DataTable tblDiode = new DataTable();
        //    CModule.cnn.Open();
        //    string query = "SELECT * from tblDiode WHERE cc = '" + cc + "' AND partNumber = '" + partNumber + "'";
        //    SqlCommand cmd = new SqlCommand(query, CModule.cnn); 
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    da.Fill(tblDiode);
        //    CModule.cnn.Close();
        //    return tblDiode;
        //}


        //public string GetYearCode(string cc, int year)
        //{
        //    string yearcode = ""; 
        //    CModule.cnn.Open();
        //    string query = "SELECT code from tblYear WHERE cc = '" + cc + "' AND year = '" + year + "'";
        //    SqlCommand cmd = new SqlCommand(query, CModule.cnn);
        //    SqlDataReader sReader;
        //    cmd.Parameters.Clear();
        //    sReader = cmd.ExecuteReader(); 
        //    while(sReader.Read())
        //    {
        //        yearcode = sReader["code"].ToString(); 
        //    }
        //    CModule.cnn.Close();
        //    return yearcode; 
        //}

        //public string GetMonthCode(string cc, int month)
        //{
        //    string monthcode = "";
        //    CModule.cnn.Open();
        //    string query = "SELECT code from tblMonth WHERE cc = '" + cc + "' AND month = '" + month + "'";
        //    SqlCommand cmd = new SqlCommand(query, CModule.cnn);
        //    SqlDataReader sReader;
        //    cmd.Parameters.Clear();
        //    sReader = cmd.ExecuteReader();
        //    while (sReader.Read())
        //    {
        //        monthcode = sReader["code"].ToString();
        //    }
        //    CModule.cnn.Close();
        //    return monthcode;
        //}

        //public string InsertTblPanel(string cc, string partNumber, string panelSN, string year, string month, int runningCode, DateTime updatedDate, DateTime createdDate, string pre, string cre)
        //{
        //    string tempyearmonth = year + month;
        //    int yearmonth = int.Parse(tempyearmonth);
        //    CModule.cnn.Open();
        //    SqlCommand command;
        //    SqlDataAdapter adapter = new SqlDataAdapter();
        //    string sql = "";
        //    sql = "Insert into tblPanel(cc, partNumber, panelSN, yearMonth, runningCode, updatedDate, createdDate, pre, cre ) values ('" + cc + "', '" + partNumber + "', '" + panelSN + "', '" + yearmonth + "', '" + runningCode + "', '" + updatedDate + "', '" + createdDate + "', '" + pre + "', '" + cre + "')";
        //    command = new SqlCommand(sql, CModule.cnn);
        //    adapter.InsertCommand = new SqlCommand(sql, CModule.cnn);
        //    adapter.InsertCommand.ExecuteNonQuery();
        //    command.Dispose(); 
        //    CModule.cnn.Close();
        //    CModule.cnn.Open();
        //    string id2 = ""; 
        //    using(SqlCommand command2 = new SqlCommand("Select id from tblPanel where panelSN = '" + panelSN + "' AND cc = '" + cc + "' AND createdDate = '" + createdDate + "'"  , CModule.cnn))
        //    {
        //        using (SqlDataReader reader = command2.ExecuteReader())
        //        {
        //            reader.Read();
        //            id2 = reader["id"].ToString(); 
        //        }
        //    }
        //    CModule.cnn.Close();
        //    return id2; 
        //}

        //public int GetRunningCode (string cc)
        //{
        //    int runningCode = 0;
        //    CModule.cnn.Open();
        //    string query = "SELECT TOP 1 runningCode from tblPanel WHERE cc = '" + cc + "' ORDER BY id desc";
        //    SqlCommand cmd = new SqlCommand(query, CModule.cnn);
        //    SqlDataReader sReader;
        //    cmd.Parameters.Clear();
        //    sReader = cmd.ExecuteReader(); 
        //    while(sReader.Read())
        //    {
        //        runningCode = int.Parse(sReader["runningCode"].ToString()); 
        //    }
        //    CModule.cnn.Close(); 
        //    return runningCode;
        //}
    }
}

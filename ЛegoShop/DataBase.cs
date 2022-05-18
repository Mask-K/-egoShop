using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ЛegoShop
{
    internal class DataBase
    {
        SqlConnection sqlConnection = new SqlConnection(@"Data Source = TEMP1; Initial Catalog = Лego; Integrated Security = True;");

        ~DataBase()
        {
            CloseConnection();
        }
        void OpenConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Closed)
            {
                sqlConnection.Open();
            }
        }
        void CloseConnection()
        {
            if(sqlConnection.State == System.Data.ConnectionState.Open)
            {
                sqlConnection.Close();
            }
        }

        public SqlConnection GetConnection() => sqlConnection;
        private void ReadValue(SqlCommand com, out int? value)
        {
            value = null;
            using (SqlDataReader reader = com.ExecuteReader())
            {
                while (reader.Read())
                {
                    value = Convert.ToInt32(reader["id"]);
                }
            }
        }

        internal void InsertCollection(string name)
        {
            try
            {
                string command = "SELECT id FROM Collection WHERE LOWER(collection_name) = @name";

                SqlCommand CollectionCmd = new SqlCommand(command, sqlConnection);
                CollectionCmd.Parameters.AddWithValue("@name", name.ToLower());

                this.OpenConnection();
                int? collectionId = null;
                ReadValue(CollectionCmd, out collectionId);
                if(collectionId != null)
                {
                    throw new Exception("Дана тематика вже наявна в базі.");
                }
                SqlDataAdapter insertcmd = new SqlDataAdapter();
                command = "INSERT INTO Collection(collection_name) VALUES(@name)";

                CollectionCmd = new SqlCommand(command, sqlConnection);
                CollectionCmd.Parameters.AddWithValue("@name", name);
                this.OpenConnection();
                insertcmd.InsertCommand = CollectionCmd;
                insertcmd.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Тематика успішно додана", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        internal void InsertTarget(string name)
        {
            try
            {
                string command = "SELECT id FROM Target WHERE LOWER(target_name) = @name";

                SqlCommand TargetCmd = new SqlCommand(command, sqlConnection);
                TargetCmd.Parameters.AddWithValue("@name", name.ToLower());

                this.OpenConnection();
                int? targetId = null;
                ReadValue(TargetCmd, out targetId);
                if (targetId != null)
                {
                    throw new Exception("Дана аудиторія вже наявна в базі.");
                }
                SqlDataAdapter insertcmd = new SqlDataAdapter();
                command = "INSERT INTO Target(target_name) VALUES(@name)";

                TargetCmd = new SqlCommand(command, sqlConnection);
                TargetCmd.Parameters.AddWithValue("@name", name);
                this.OpenConnection();
                insertcmd.InsertCommand = TargetCmd;
                insertcmd.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Аудиторія успішно додана", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal DataTable QuerryString(string command, string v)
        {
            try
            {
                command = command.Replace("@X", v);
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
                
                var dtbl = new DataTable();
                sqlDataAdapter.Fill(dtbl);
                this.CloseConnection();
                return dtbl;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
        }

        internal void InsertUser(string user_name, string email)
        {
            try
            {
                string command = "SELECT id FROM Users WHERE LOWER(email) = @email";
                SqlCommand Usercmd = new SqlCommand(command, sqlConnection);
                Usercmd.Parameters.AddWithValue("email", email.ToLower());

                this.OpenConnection();
                int? userid = null;
                ReadValue(Usercmd, out userid);
                if(userid != null)
                {
                    throw new Exception("Користувач з такою поштою вже наявний в базі.");
                }
                SqlDataAdapter insertcmd = new SqlDataAdapter();
                command = "INSERT INTO Users(name, email) VALUES(@user_name, @email)";
                Usercmd = new SqlCommand(command, sqlConnection);
                Usercmd.Parameters.AddWithValue("@user_name", user_name);
                Usercmd.Parameters.AddWithValue("@email", email);
                this.OpenConnection();
                insertcmd.InsertCommand = Usercmd;
                insertcmd.InsertCommand.ExecuteNonQuery();

                MessageBox.Show("Користувач успішно доданий", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void InsertLego(string legoName, int targetId, double price, int collectionId)
        {
            try
            {
                string command = "SELECT id FROM Constructor WHERE LOWER(name) = @legoName";
                SqlCommand Legocmd = new SqlCommand(command, sqlConnection);
                Legocmd.Parameters.AddWithValue("@legoName", legoName);
                this.OpenConnection();
                int? legoid = null;
                ReadValue(Legocmd, out legoid);
                if(legoid != null)
                {
                    throw new Exception("Конструктор з такою назвою вже наявний в базі.");
                }
                
                command = "SELECT id FROM Target WHERE id = @targetId";
                Legocmd = new SqlCommand(command, sqlConnection);
                Legocmd.Parameters.AddWithValue("@targetId", targetId);
                this.OpenConnection();
                int? target = null;
                ReadValue(Legocmd, out target);
                if(target == null)
                    throw new Exception("Такого айді аудиторії немає в базі");

                command = "SELECT id FROM Collection WHERE id = @collectionId";
                Legocmd = new SqlCommand(command, sqlConnection);
                Legocmd.Parameters.AddWithValue("@collectionId", collectionId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Legocmd, out collection);
                if(collection == null)
                    throw new Exception("Такого айді тематики немає в базі");

                SqlDataAdapter insertcmd = new SqlDataAdapter();
                command = "INSERT INTO Constructor(name, target_id, price, collection_id) VALUES(@legoName, @targetId, @price, @collectionId)";
                Legocmd = new SqlCommand(command, sqlConnection);
                Legocmd.Parameters.AddWithValue("@legoName", legoName);
                Legocmd.Parameters.AddWithValue("@price", price);
                Legocmd.Parameters.AddWithValue("@targetId", targetId);
                Legocmd.Parameters.AddWithValue("@collectionId", collectionId);

                insertcmd.InsertCommand = Legocmd;
                insertcmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Конструктор успішно доданий", " ", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        

        internal void InsertUsersLego(int userId, int legoId)
        {
            try
            {
                string command = "SELECT id FROM Users WHERE id = @userId";
                SqlCommand Cmd = new SqlCommand(command, sqlConnection);
                Cmd.Parameters.AddWithValue("@userId", userId);
                this.OpenConnection();
                int? id = null;
                ReadValue(Cmd, out id);
                if (id == null)
                    throw new Exception("Такого айді користувача немає в базі");

                command = "SELECT id FROM Constructor WHERE id = @legoId";
                Cmd = new SqlCommand(command, sqlConnection);
                Cmd.Parameters.AddWithValue("@legoId", legoId);
                this.OpenConnection();
                id = null;
                ReadValue(Cmd, out id);
                if (id == null)
                    throw new Exception("Такого айді конструктора немає в базі");

                SqlDataAdapter insertcmd = new SqlDataAdapter();
                command = "INSERT INTO UserBoughtЛego(userid, constructorid) VALUES(@userId, @legoId)";
                Cmd = new SqlCommand(command, sqlConnection);
                Cmd.Parameters.AddWithValue("@legoId", legoId);
                Cmd.Parameters.AddWithValue("@userId", userId);
                insertcmd.InsertCommand = Cmd;
                insertcmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Користувача успішно з'єднано з конструктором", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }

        }

        internal void UpdateUser(int id, string text2, int cs)
        {
            try
            {
                var command = "SELECT id FROM Users WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", id);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді користувача немає в базі");
                command = "UPDATE User SET name = @text WHERE id = @id";
                if (cs == 1)
                    command = "UPDATE Users SET email = @text WHERE id = @id";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@id", id);
                Collectioncmd.Parameters.AddWithValue("@text", text2);
                SqlDataAdapter updatecmd = new SqlDataAdapter();
                updatecmd.InsertCommand = Collectioncmd;
                updatecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Користувач успішно оновлений", " ", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void UpdateConstructor(int id, string text4, int cs2)
        {
            try
            {
                var command = "SELECT id FROM Constructor WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", id);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді лего немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                int el = 0;
                if(cs2 == 0)
                    command = "UPDATE Constructor SET name = @text WHERE id = @collectionId";
                else if (cs2 == 1)
                {
                    if(!int.TryParse(text4, out el))
                        throw new Exception("Невірний вміст поля Айді аудиторії");
                    command = "UPDATE Constructor SET target_id = @text WHERE id = @collectionId";
                }
                else if(cs2 == 2)
                {
                    if (!int.TryParse(text4, out el))
                        throw new Exception("Невірний вміст поля Ціна");
                    command = "UPDATE Constructor SET price = @text WHERE id = @collectionId";
                }
                else if(cs2 == 3)
                {
                    if (!int.TryParse(text4, out el))
                        throw new Exception("Невірний вміст поля Айді тематики");
                    command = "UPDATE Constructor SET collection_id = @text WHERE id = @collectionId";
                }
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", id);
                if(cs2 == 0)
                    Collectioncmd.Parameters.AddWithValue("@text", text4);
                else
                    Collectioncmd.Parameters.AddWithValue("@text", el.ToString());
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Набір лего успішно оновлено", " ", MessageBoxButtons.OK);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void UpdateTarget(int id, string text2)
        {
            try
            {
                var command = "SELECT id FROM Target WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", id);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді аудиторії немає в базі");

                command = "UPDATE Target SET target_name = @text WHERE id = @id";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@id", id);
                Collectioncmd.Parameters.AddWithValue("@text", text2);
                SqlDataAdapter updatecmd = new SqlDataAdapter();
                updatecmd.InsertCommand = Collectioncmd;
                updatecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Аудиторія успішно оновлена", " ", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void UpdateCollection(int id, string text)
        {
            try
            {
                var command = "SELECT id FROM Collection WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", id);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді тематики немає в базі");

                command = "UPDATE Collection SET collection_name = @text WHERE id = @id";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@id", id);
                Collectioncmd.Parameters.AddWithValue("@text", text);
                SqlDataAdapter updatecmd = new SqlDataAdapter();
                updatecmd.InsertCommand = Collectioncmd;
                updatecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Тематика успішно оновлена", " ", MessageBoxButtons.OK);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal DataTable GetInfo(string name)
        {
            this.OpenConnection();
            string command = "SELECT * FROM " + name;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(command, sqlConnection);
            var dtbl = new DataTable();
            sqlDataAdapter.Fill(dtbl);
            this.CloseConnection();
            return dtbl;
        }

        internal void DeleteCollection(int collectionId)
        {
            try
            {

                var command = "SELECT id FROM Collection WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", collectionId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді тематики немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                command = "DELETE FROM Collection WHERE id = @collectionId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", collectionId);
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Тематика успішно видалена", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void DeleteTarget(int oldId)
        {
            try
            {
                //Лінь було міняти, в більшості копіював з DeleteCollection
                var command = "SELECT id FROM Target WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", oldId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді аудиторії немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                command = "DELETE FROM Target WHERE id = @collectionId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", oldId);
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Аудиторія успішно видалена", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }

        internal void DeleteUser(int userId)
        {
            try
            {
                //Лінь було міняти, в більшості копіював з DeleteCollection
                var command = "SELECT id FROM Users WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", userId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді користувача немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                command = "DELETE FROM Users WHERE id = @collectionId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", userId);
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Користувач успішно видалений", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        internal void DeleteConstructor(int legoId)
        {
            try
            {
                //Лінь було міняти, в більшості копіював з DeleteCollection
                var command = "SELECT id FROM Constructor WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", legoId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді лего немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                command = "DELETE FROM Constructor WHERE id = @collectionId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", legoId);
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Набір лего успішно видалений", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }
        internal void DeleteUsersLego(int userId, int legoId)
        {
            try
            {
                //Лінь було міняти, в більшості копіював з DeleteCollection
                var command = "SELECT id FROM Constructor WHERE id = @collectionId";
                var Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", legoId);
                this.OpenConnection();
                int? collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді лего немає в базі");
                command = "SELECT id FROM Users WHERE id = @collectionId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@collectionId", userId);
                this.OpenConnection();
                collection = null;
                ReadValue(Collectioncmd, out collection);
                if (collection == null)
                    throw new Exception("Такого айді користувача немає в базі");

                SqlDataAdapter deletecmd = new SqlDataAdapter();
                command = "DELETE FROM UserBoughtЛego WHERE userid = @userId AND constructorid = @legoId";
                Collectioncmd = new SqlCommand(command, sqlConnection);
                Collectioncmd.Parameters.AddWithValue("@userId", userId);
                Collectioncmd.Parameters.AddWithValue("@legoId", legoId);
                deletecmd.InsertCommand = Collectioncmd;
                deletecmd.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Набір лего успішно видалений", " ", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                this.CloseConnection();
            }
        }
    }
}

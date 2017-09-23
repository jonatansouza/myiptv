using Myiptv.models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myiptv.database
{
    public class DatabaseSqliteController
    {
        private static String myConnection = "Data Source=myiptv.sqlite";
        private static String databaseName = "myiptv.sqlite";
        public User UserSession { get; set; }



        public void InitializeDatabase()
        {
            
            if (!File.Exists(databaseName))
            {
                SQLiteConnection.CreateFile(databaseName);
                SQLiteConnection connection = new SQLiteConnection(myConnection);
                connection.Open();

                StringBuilder channelSql = new StringBuilder();
                channelSql.AppendLine("CREATE TABLE IF NOT EXISTS CHANNELS(ID INTEGER PRIMARY KEY AUTOINCREMENT, ");
                channelSql.AppendLine("NAME TEXT NOT NULL,");
                channelSql.AppendLine("CODE TEXT,");
                channelSql.AppendLine("URL TEXT NOT NULL,");
                channelSql.AppendLine("ICON BLOB)");

                StringBuilder userSql = new StringBuilder();
                userSql.AppendLine("CREATE TABLE IF NOT EXISTS USERS (USERNAME TEXT PRIMARY KEY, ");
                userSql.AppendLine("NAME TEXT NOT NULL,");
                userSql.AppendLine("PASSWORD TEXT)");

                Console.WriteLine(userSql);
                Console.WriteLine(channelSql);


                SQLiteCommand cmd = new SQLiteCommand(channelSql.ToString(), connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("channels$$$$$$"+ex.Message);
                }
                cmd = new SQLiteCommand(userSql.ToString(), connection);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("USERS TABLE$$$$"+ex.Message);
                }
            }
            PopulateTable();
            
        }

        public void PopulateTable()
        {
            if(SelectAllChannels().Count == 0)
            {
                //Stream str =  Myiptv.Properties.Resources.redetv.ToString() ;

                //InsertChannel(new Channel(0, "Sbt", "", "http://www.sbt.com.br/aovivo/", );

               /* Myiptv.Properties.Resources.redetv.Save(ms, Myiptv.Properties.Resources.redetv.RawFormat);
                InsertChannel(new Channel(0, "Rede TV", "", "http://www.redetv.uol.com.br/aovivo", ms.ToArray()));

                Myiptv.Properties.Resources.adult.Save(ms, Myiptv.Properties.Resources.adult.RawFormat);
                InsertChannel(new Channel(0, "Adult Tv", "123", "http://faketestpropose.com", ms.ToArray()));*/
            }
            if(SelectAllUsers().Count == 0)
            {
                InsertUser(new User("admin", "Administrador myiptv", "adm123"));
            }
            
        }

       
        public bool InsertUser(User user)
        {
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO USERS (USERNAME, NAME, PASSWORD) VALUES (?,?,?)", connection))
                {
                    insertSQL.Parameters.Add(new SQLiteParameter("USERNAME", user.Username));
                    insertSQL.Parameters.Add(new SQLiteParameter("NAME", user.Name));
                    insertSQL.Parameters.Add(new SQLiteParameter("PASSWORD", user.Password));
                    try
                    {
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("args1: {0}", ex.Message);
                        connection.Close();
                        return false;
                    }
                }
                
            }
            
        }

       

        public bool InsertChannel(Channel channel)
        {
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand insertSQL = new SQLiteCommand("INSERT INTO CHANNELS (NAME, CODE, URL, ICON) VALUES (?,?,?,?)", connection))
                {
                    insertSQL.Parameters.Add(new SQLiteParameter("NAME", channel.Name));
                    insertSQL.Parameters.Add(new SQLiteParameter("CODE", channel.Code));
                    insertSQL.Parameters.Add(new SQLiteParameter("URL", channel.Url));
                    insertSQL.Parameters.Add("ICON", System.Data.DbType.Binary, channel.Icon.Length);
                    insertSQL.Parameters["ICON"].Value = channel.Icon;
                    try
                    {
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        connection.Close();
                        return false;
                    }
                    
                }

            }
        }

        public bool UpdateChannel(Channel channel)
        {
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand insertSQL = new SQLiteCommand("UPDATE CHANNELS SET NAME=?, CODE=?, URL=? WHERE ID=?", connection))
                {
                    insertSQL.Parameters.Add(new SQLiteParameter("NAME", channel.Name));
                    insertSQL.Parameters.Add(new SQLiteParameter("CODE", channel.Code));
                    insertSQL.Parameters.Add(new SQLiteParameter("URL", channel.Url));
                    insertSQL.Parameters.Add("ID", System.Data.DbType.Int32);
                    insertSQL.Parameters["ID"].Value = channel.Id;
                    try
                    {
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        connection.Close();
                        return false;
                    }

                }

            }
        }

        public bool RemoveChannel(int Id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand insertSQL = new SQLiteCommand("DELETE FROM CHANNELS WHERE ID=?", connection))
                {
                    insertSQL.Parameters.Add("ID", System.Data.DbType.Int32);
                    insertSQL.Parameters["ID"].Value = Id;
                    try
                    {
                        insertSQL.ExecuteNonQuery();
                        connection.Close();
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        connection.Close();
                        return false;
                    }

                }

            }
        }

        public List<User> SelectAllUsers()
        {
            List<User> users = new List<User>();
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT * FROM USERS", connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            users.Add(new User(reader.GetString(0), reader.GetString(1), reader.GetString(2)));
                        }
                    }
                }
                return users;
            }
        }

        public User SelectUserById(string username)
        {
            User user = null;
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT * FROM USERS WHERE USERNAME='"+username+"'", connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            user = new User(reader.GetString(0), reader.GetString(1), reader.GetString(2));
                        }
                    }
                }
                return user;
            }
        }

        public List<Channel> SelectAllChannels()
        {
            List<Channel> channels = new List<Channel>();
            
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT ID, NAME, CODE, URL FROM CHANNELS", connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            channels.Add(new Channel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3),  IconByteArray(reader.GetInt32(0))));
                        }
                    }
                }
                return channels;
            }
        }

        public List<Channel> SelectAllGuestChannels()
        {
            List<Channel> channels = new List<Channel>();

            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT ID, NAME FROM CHANNELS", connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            channels.Add(new Channel(reader.GetInt32(0), reader.GetString(1)));
                        }
                    }
                }
                return channels;
            }
        }

        public List<Channel> SelectAllChannelsByPatern(string patern)
        {
            List<Channel> channels = new List<Channel>();

            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT ID, NAME, CODE, URL FROM CHANNELS WHERE NAME LIKE '"+patern+"%'", connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            channels.Add(new Channel(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), IconByteArray(reader.GetInt32(0))));
                        }
                    }
                }
                return channels;
            }
        }

        public byte[] IconByteArray(int id)
        {
            byte[] data;
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT ICON FROM CHANNELS WHERE ID=" + id, connection))
                {
                    data = (byte[])read.ExecuteScalar();
                }
                return data;
            }
        }

        public Channel SelectChannelsById(int id)
        {
            Channel  channel = null;
            using (SQLiteConnection connection = new SQLiteConnection(myConnection))
            {
                connection.Open();
                using (SQLiteCommand read = new SQLiteCommand("SELECT ID, NAME, CODE, URL FROM CHANNELS WHERE ID=" + id, connection))
                {
                    using (SQLiteDataReader reader = read.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            channel = new Channel();
                            channel.Id = reader.GetInt32(0);
                            channel.Name = reader.GetString(1);
                            channel.Code = reader.GetString(2);
                            channel.Url = reader.GetString(3);
                            Console.WriteLine(channel.ToString());
                            channel.Icon = IconByteArray(channel.Id);
                        }
                    }
                }
                return channel;
            }
        }
    }
}

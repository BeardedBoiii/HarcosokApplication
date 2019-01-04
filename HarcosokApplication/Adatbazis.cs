using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HarcosokApplication
{
    class Adatbazis
    {
        private string connString = "server=localhost;uid=root;pwd=;database=cs_harcosok";
        private MySqlConnection conn;

        public Adatbazis()
        {
            try
            {
                conn = new MySqlConnection(this.connString);
                conn.Open();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
                Environment.Exit(1);
            }
        }

        public void tablakLetrehozas()
        {
            var harcosok = conn.CreateCommand();
            harcosok.CommandText = @"CREATE TABLE IF NOT EXISTS harcosok (
                            id int NOT NULL AUTO_INCREMENT,
                            nev VARCHAR(150),
                            letrehozas DATETIME,
                            PRIMARY KEY (id),
                            UNIQUE(nev)                            
                        );";
            var kepessegek = conn.CreateCommand();
            kepessegek.CommandText = @"
                                    CREATE TABLE IF NOT EXISTS kepessegek(
	                                        id int AUTO_INCREMENT,
                                            nev VARCHAR(255),
                                            leiras TEXT,
                                            harcos_id int,
                                            PRIMARY KEY(id),
                                            FOREIGN KEY (`harcos_id`) REFERENCES `harcosok`(`id`)
                                    )";
            harcosok.ExecuteNonQuery();
            kepessegek.ExecuteNonQuery();
        }

        

        public void kepessegHozzaadas(string kepessegNev, string kepessegLeiras, int harcosId)
        {
            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO kepessegek
                (nev,leiras,harcos_id)
                VALUES
                (@nev,@leiras,@harcos_id)
            ";
            command.Parameters.AddWithValue("@nev", kepessegNev);
            command.Parameters.AddWithValue("@leiras", kepessegLeiras);
            command.Parameters.AddWithValue("@harcos_id", harcosId);
            command.ExecuteNonQuery();
        }

        public void tesztAdatok()
        {
            try
            {
                var kepessegek = conn.CreateCommand();
                kepessegek.CommandText = @"INSERT INTO `kepessegek` (`id`, `nev`, `leiras`, `harcos_id`) VALUES (NULL, 'Agyoncsap', 'Fogja a botját és megüt vele', '1'), (NULL, 'Sör', 'Sörért mindent, instant elpusztítja az ellenfelet', '2')";


                var harcosok = conn.CreateCommand();
                harcosok.CommandText = @"INSERT INTO `harcosok` (`id`, `nev`, `letrehozas`) VALUES (NULL, 'Jani', CURRENT_TIME()), (NULL, 'Karcsi', CURRENT_TIME())";

                harcosok.ExecuteNonQuery();
                kepessegek.ExecuteNonQuery();
                MessageBox.Show("A teszt adatok betöltődtek!");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("A teszt adatok betöltődtek!");
            }
        }

        

        public void harcosLetrehozasa(string nev)
        {
            var lekerdezesCommand = conn.CreateCommand();
            lekerdezesCommand.CommandText = @"
                SELECT COUNT(*) FROM harcosok WHERE nev = @nev
            ";
            lekerdezesCommand.Parameters.AddWithValue("@nev", nev);
            long db = (long)lekerdezesCommand.ExecuteScalar();
            if (db > 0)
            {
                MessageBox.Show("Ilyen nevű harcos már létezik, találj ki más nevet!");
                return;
            }

            var command = conn.CreateCommand();
            command.CommandText = @"INSERT INTO harcosok
                (nev,letrehozas)
                VALUES
                (@nev,CURRENT_TIME())
            ";
            command.Parameters.AddWithValue("@nev", nev);
            command.ExecuteNonQuery();
        }

        public Dictionary<int, string> selectHarcosokComboBox()
        {
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev,id FROM `harcosok`";

            Dictionary<int, string> tmp = new Dictionary<int, string>();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev = reader.GetString("nev");
                    int id = reader.GetInt32("id");
                    tmp.Add(id, nev);
                }
            }
            return tmp;
        }
        public Dictionary<int, string> selectHarcosokListBox()
        {
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev,id,letrehozas FROM `harcosok`";

            Dictionary<int, string> tmp = new Dictionary<int, string>();

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string nev_datum = reader.GetString("nev")+"\t"+reader.GetString("letrehozas");
                    int id = reader.GetInt32("id");
                    tmp.Add(id, nev_datum);
                }
            }
            return tmp;
        }

        public Dictionary<int, string> selectKepessegListBox(int harcosId)
        {
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT nev,id FROM `kepessegek` WHERE harcos_id = @id";
            command.Parameters.AddWithValue("@id", harcosId);

            Dictionary<int, string> tmp = new Dictionary<int, string>();

            using (var reader = command.ExecuteReader())
            {
                if (!reader.HasRows) tmp.Add(0, "Nincs Képessége");
                while (reader.Read())
                {
                    string nev_datum = reader.GetString("nev");
                    int id = reader.GetInt32("id");
                    tmp.Add(id, nev_datum);
                }
            }
            return tmp;
        }

        public string kepessegLeiras(int id)
        {
            var command = conn.CreateCommand();
            command.CommandText = @"SELECT leiras FROM `kepessegek` WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);

            using (var reader = command.ExecuteReader())
            {
                reader.Read();
                return reader.GetString("leiras");
            }
        }
        public int torles(int id)
        {
            var command = conn.CreateCommand();
            command.CommandText = @"DELETE FROM `kepessegek` WHERE id = @id";
            command.Parameters.AddWithValue("@id", id);
            return command.ExecuteNonQuery();
        }
        public int modosit(int id, string leiras)
        {
            var command = conn.CreateCommand();
            command.CommandText = @"UPDATE `kepessegek` SET `leiras` = @leiras WHERE `kepessegek`.`id` = @id";
            command.Parameters.AddWithValue("@id", id);
            command.Parameters.AddWithValue("@leiras", leiras);
            return command.ExecuteNonQuery();
        }
    }
}

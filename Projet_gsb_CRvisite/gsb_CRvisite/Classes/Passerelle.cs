using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace gsb_CRvisite.Classes
{
    public class Passerelle
    {
        private static MySqlConnection connection = null;
        public static MySqlConnection InitConnection()
        {
            string connectionString = "SERVER=localhost; DATABASE=gsb_cptr_visit; UID=root; PASSWORD=";
            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("erreur connexion : " + ex.Message);
            }
            return connection;
        }
        public static Medicament GetMedicament(string idMedicament)
        {
            Medicament m = null;
            MySqlConnection cnx = InitConnection();
            if(cnx != null)
            {
                string query = "Select * from medicament where id = @id";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", idMedicament);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    m = MapperLigneMedicament(dataReader);
                }
                dataReader.Close();
            }
            return m;
        }

        public static List<Medicament> GetLesMedicament()
        {
            List<Medicament> listeMed = new List<Medicament>();

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select * from medicament";
                MySqlCommand cmd = new MySqlCommand(query, cnx);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        listeMed.Add(MapperLigneMedicament(dataReader));
                    }
                }
                dataReader.Close();
            }
            return listeMed;
        }

        private static Medicament MapperLigneMedicament(MySqlDataReader reader)
        {
            string id, nomCommercial, compo,effets, contreindications;

            id = (string)reader["id"];
            nomCommercial = (string)reader["nomCommercial"];
            effets = (string)reader["effets"];
            compo = (string)reader["composition"];
            contreindications = (string)reader["contreIndications"];

            Medicament med = new Medicament(id, nomCommercial, compo, effets, contreindications);

            return med;
        }
        public static Famille GetFamilleMedicament(string idMedicament)
        {
            Famille famille = null;
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select famille.* from famille, medicament where medicament.idFamille = famille.id AND medicament.id = @id";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", idMedicament);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        famille = MapperLigneFamille(dataReader);
                    }
                }
                dataReader.Close();
            }
            return famille;
        }
        
        private static Famille MapperLigneFamille(MySqlDataReader reader)
        {
            string id, libelle;

            id = (string)reader["id"];
            libelle = (string)reader["libelle"];

            Famille laFamille = new Famille(id, libelle);
            return laFamille;
        }

        //Medecin
        public static List<Medecin> GetLesMedecins()
        {
            List<Medecin> listeMedecins = new List<Medecin>();

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select * from medecin";
                MySqlCommand cmd = new MySqlCommand(query, cnx);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        listeMedecins.Add(MapperLigneMedecin(dataReader));
                    }
                }
                dataReader.Close();
            }
            return listeMedecins;
        }
        public static Medecin GetMedecin(string idMedecin)
        {
            Medecin medecin = null;
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "select * from medecin where id = @idMedecin";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@idMedecin", idMedecin);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        medecin = MapperLigneMedecin(reader);
                    }
                }
                reader.Close();
            }

            return medecin;
        }

        private static Medecin MapperLigneMedecin (MySqlDataReader reader)
        {
            string nom, prenom, adresse, tel, id ;
            int departement;

            id = reader["id"].ToString();
            nom = (string)reader["nom"];
            prenom = (string)reader["prenom"];
            adresse = (string)reader["adresse"];
            tel = (string)reader["tel"];
            departement = (int)reader["departement"];

            Medecin med = new Medecin(id, nom, prenom, adresse, tel, departement);
            return med;
        }

        public static Specialite GetSpeMedecin(string idMed)
        {
            Specialite specialite = null;
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select specialite.* from specialite, medecin where medecin.idSpecialite = specialite.id AND medecin.id = @id";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", idMed);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        specialite = MapperLigneSpecialite(dataReader);
                    }
                }
                dataReader.Close();
            }
            return specialite;
        }
        private static Specialite MapperLigneSpecialite(MySqlDataReader reader)
        {
            string id, spe;

            id = (string)reader["id"];
            spe = (string)reader["specialite"];

            Specialite laSpecialite = new Specialite(id, spe);
            return laSpecialite;
        }

        public static bool AddMedicament(Medicament med)
        {
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "INSERT INTO medicament (id, nomCommercial, idFamille, composition, effets, contreIndications, prixEch) VALUES (@id, @nomC, @idFamille, @composition, @effets, @contreIndications, @prixEch)";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", med.Id);
                cmd.Parameters.AddWithValue("@nomC", med.NomCommercial);
                cmd.Parameters.AddWithValue("@idFamille", med.Famille.Id);
                cmd.Parameters.AddWithValue("@composition", med.Composition);
                cmd.Parameters.AddWithValue("@effets", med.Effets);
                cmd.Parameters.AddWithValue("@contreIndications", med.Contreindications);
                cmd.Parameters.AddWithValue("@prixEch", 5);

                cmd.ExecuteNonQuery();
                return true;
            }   
            else return false;
        }
        public static List<Famille> ChargerFamilles()
        {
            List<Famille> listeFamille = new List<Famille>();

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select * from famille";
                MySqlCommand cmd = new MySqlCommand(query, cnx);

                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (dataReader.HasRows)
                {
                    while (dataReader.Read())
                    {
                        listeFamille.Add(MapperLigneFamille(dataReader));
                    }
                }
                dataReader.Close();
            }
            return listeFamille;
        }

        public static List<Int32> GetIdsRapportsMedecin(string idMedecin)
        {
            List<Int32> Ids = new List<Int32>();

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select id from rapport where idMedecin = @id Order By date DESC";

                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", idMedecin);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Ids.Add((int)reader["id"]);
                    }
                }
                reader.Close();
            }
            return Ids;
        }

        //Visiteur
        public static List<Visiteur> GetLesVisiteurs()
        {
            List<Visiteur> listeVisiteur = new List<Visiteur>();
            MySqlConnection cnx = InitConnection();
            if(cnx != null)
            {
                string query = "select * from visiteur";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        listeVisiteur.Add(MapperLigneVisiteur(reader));
                    }
                }
                reader.Close();
            }

            return listeVisiteur;
        }
        public static Visiteur GetVisiteur(string idVisiteur)
        {
            Visiteur visiteur = null;
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "select * from visiteur where id = @idVisiteur";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@idVisiteur", idVisiteur);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        visiteur = MapperLigneVisiteur(reader);
                    }
                }
                reader.Close();
            }

            return visiteur;
        }
        private static Visiteur MapperLigneVisiteur(MySqlDataReader reader)
        {
            string nom, prenom, login, mdp, adresse, cp, ville, id;
            DateTime dateEmbauche;

            id = (string)reader["id"];
            nom = (string)reader["nom"];
            prenom = (string)reader["prenom"];
            adresse = (string)reader["adresse"];
            login = (string)reader["login"];
            mdp = (string)reader["mdp"];
            cp = (string)reader["cp"];
            ville = (string)reader["ville"];
            dateEmbauche = (DateTime)reader["dateEmbauche"];

            Visiteur vis = new Visiteur(id, nom, prenom, login, mdp, adresse , cp, ville, dateEmbauche);
            return vis;
        }
        public static List<Int32> GetIdsRapportsVisiteur(string idVisiteur)
        {
            List<Int32> Ids = new List<Int32>();

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select id from rapport where idVisiteur = @id Order By date DESC";

                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@id", idVisiteur);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Ids.Add((int)reader["id"]);
                    }
                }
                reader.Close();
            }
            return Ids;
        }
        public static Rapport GetRapportFromId(int idRapport)
        {
            Rapport rapport = null;

            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "Select * from rapport where id = @idRapport";

                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@idRapport", idRapport);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        rapport = MapperLigneRapport(reader);
                    }
                }
                reader.Close();
            }
            return rapport; 
        }
        private static Rapport MapperLigneRapport(MySqlDataReader reader)
        {
            int id;
            DateTime date;
            string motif, bilan, idVisiteur, idMedecin;

            id = (int)reader["id"];
            idMedecin = reader["idMedecin"].ToString();
            date = (DateTime)reader["date"];
            motif = (string)reader["motif"];
            bilan = (string)reader["bilan"];
            idVisiteur = (string)reader["idVisiteur"];

            Rapport rapport = new Rapport(id, date, motif, bilan, idVisiteur, idMedecin);
            return rapport;
        }

        //Echantillons
        public static List<EchantillonOffert> GetLesEchantillonsOfferts(int idRapport)
        {
            List<EchantillonOffert> listeEchantillons = new List<EchantillonOffert>();
            EchantillonOffert echantillon = null;
            MySqlConnection cnx = InitConnection();
            if (cnx != null)
            {
                string query = "select medicament.*, offrir.quantite from medicament, offrir where offrir.idRapport = @idRapport AND offrir.idMedicament = medicament.id ORDER BY nomCommercial";
                MySqlCommand cmd = new MySqlCommand(query, cnx);
                cmd.Parameters.AddWithValue("@idRapport", idRapport);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Medicament unMed = MapperLigneMedicament(reader);
                        int quantite = (int)reader["quantite"];
                        echantillon = new EchantillonOffert(unMed, quantite);
                        listeEchantillons.Add(echantillon);
                    }
                }
                reader.Close();
            }
            return listeEchantillons;
        }
    }
}

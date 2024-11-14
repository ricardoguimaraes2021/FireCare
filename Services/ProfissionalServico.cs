using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Text.RegularExpressions;
using FireCare.Models;

namespace FireCare.Services
{
    public class ProfissionalServico
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Ricardo\\source\\repos\\FireCare\\DB\\database_firecare.db;Version=3;";

        public int ObterProximoId()
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IFNULL(MAX(Id), 0) + 1 FROM Profissionais";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        public bool AdicionarProfissional(Profissional profissional)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Profissionais 
                                 (Nome, DataNascimento, Genero, Email, Senha, TipoSanguineo, Cargo, Disponivel, NumeroTelefone, Endereco) 
                                 VALUES (@Nome, @DataNascimento, @Genero, @Email, @Senha, @TipoSanguineo, @Cargo, @Disponivel, @NumeroTelefone, @Endereco)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", profissional.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", profissional.DataNascimento);
                    command.Parameters.AddWithValue("@Genero", profissional.Genero.ToString());
                    command.Parameters.AddWithValue("@Email", profissional.Email);
                    command.Parameters.AddWithValue("@Senha", profissional.Senha);
                    command.Parameters.AddWithValue("@TipoSanguineo", profissional.TipoSanguineo.ToString());
                    command.Parameters.AddWithValue("@Cargo", profissional.Cargo.ToString());
                    command.Parameters.AddWithValue("@Disponivel", profissional.Disponivel);
                    command.Parameters.AddWithValue("@NumeroTelefone", profissional.NumeroTelefone);
                    command.Parameters.AddWithValue("@Endereco", profissional.Endereco);

                    command.ExecuteNonQuery();
                    return true;
                }
            }
        }

        public List<Profissional> ObterTodosProfissionais()
        {
            List<Profissional> profissionais = new List<Profissional>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Profissionais";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Profissional profissional = new Profissional(
                            reader.GetString(reader.GetOrdinal("Nome")),
                            reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                            (Genero)Enum.Parse(typeof(Genero), reader.GetString(reader.GetOrdinal("Genero"))),
                            reader.GetString(reader.GetOrdinal("Email")),
                            reader.GetString(reader.GetOrdinal("Senha")),
                            (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), reader.GetString(reader.GetOrdinal("TipoSanguineo"))),
                            (CargoProfissional)Enum.Parse(typeof(CargoProfissional), reader.GetString(reader.GetOrdinal("Cargo")))
                        )
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Disponivel = reader.GetBoolean(reader.GetOrdinal("Disponivel")),
                            NumeroTelefone = reader.GetString(reader.GetOrdinal("NumeroTelefone")),
                            Endereco = reader.GetString(reader.GetOrdinal("Endereco"))
                        };

                        profissionais.Add(profissional);
                    }
                }
            }

            return profissionais;
        }

        public Profissional ObterProfissionalPorId(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Profissionais WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Profissional(
                                reader.GetString(reader.GetOrdinal("Nome")),
                                reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                                (Genero)Enum.Parse(typeof(Genero), reader.GetString(reader.GetOrdinal("Genero"))),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("Senha")),
                                (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), reader.GetString(reader.GetOrdinal("TipoSanguineo"))),
                                (CargoProfissional)Enum.Parse(typeof(CargoProfissional), reader.GetString(reader.GetOrdinal("Cargo")))
                            )
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Disponivel = reader.GetBoolean(reader.GetOrdinal("Disponivel")),
                                NumeroTelefone = reader.GetString(reader.GetOrdinal("NumeroTelefone")),
                                Endereco = reader.GetString(reader.GetOrdinal("Endereco"))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public bool AtualizarProfissional(Profissional profissional)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Profissionais SET 
                                 Nome = @Nome, 
                                 DataNascimento = @DataNascimento, 
                                 Genero = @Genero, 
                                 Email = @Email, 
                                 Senha = @Senha, 
                                 TipoSanguineo = @TipoSanguineo, 
                                 Cargo = @Cargo, 
                                 Disponivel = @Disponivel, 
                                 NumeroTelefone = @NumeroTelefone, 
                                 Endereco = @Endereco 
                                 WHERE Id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", profissional.Nome);
                    command.Parameters.AddWithValue("@DataNascimento", profissional.DataNascimento);
                    command.Parameters.AddWithValue("@Genero", profissional.Genero.ToString());
                    command.Parameters.AddWithValue("@Email", profissional.Email);
                    command.Parameters.AddWithValue("@Senha", profissional.Senha);
                    command.Parameters.AddWithValue("@TipoSanguineo", profissional.TipoSanguineo.ToString());
                    command.Parameters.AddWithValue("@Cargo", profissional.Cargo.ToString());
                    command.Parameters.AddWithValue("@Disponivel", profissional.Disponivel);
                    command.Parameters.AddWithValue("@NumeroTelefone", profissional.NumeroTelefone);
                    command.Parameters.AddWithValue("@Endereco", profissional.Endereco);
                    command.Parameters.AddWithValue("@Id", profissional.Id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EliminarProfissional(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Profissionais WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool ValidarEmail(string email)
        {
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern);
        }

        public Profissional Autenticar(string email, string senha)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Profissionais WHERE Email = @Email AND Senha = @Senha";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Senha", senha);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            var profissional = new Profissional(
                                reader.GetString(reader.GetOrdinal("Nome")),
                                reader.GetDateTime(reader.GetOrdinal("DataNascimento")),
                                (Genero)Enum.Parse(typeof(Genero), reader.GetString(reader.GetOrdinal("Genero"))),
                                reader.GetString(reader.GetOrdinal("Email")),
                                reader.GetString(reader.GetOrdinal("Senha")),
                                (TipoSanguineo)Enum.Parse(typeof(TipoSanguineo), reader.GetString(reader.GetOrdinal("TipoSanguineo"))),
                                (CargoProfissional)Enum.Parse(typeof(CargoProfissional), reader.GetString(reader.GetOrdinal("Cargo")))
                            )
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Disponivel = reader.GetBoolean(reader.GetOrdinal("Disponivel")),
                                NumeroTelefone = reader.GetString(reader.GetOrdinal("NumeroTelefone")),
                                Endereco = reader.GetString(reader.GetOrdinal("Endereco"))
                            };

                            MessageBox.Show("Autenticação bem-sucedida!");
                            return profissional;
                        }
                    }
                }
            }

            MessageBox.Show("Credenciais incorretas.");
            return null;
        }
    }
}

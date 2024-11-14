using System;
using System.Collections.Generic;
using System.Data.SQLite;
using FireCare.Models;

namespace FireCare.Services
{
    public class OcorrenciaServico
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Ricardo\\source\\repos\\FireCare\\DB\\database_firecare.db;Version=3;";

        public bool AdicionarOcorrencia(Ocorrencia ocorrencia)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Ocorrencias 
                                 (Descricao, Localizacao, Latitude, Longitude, DataHora, Severidade, Estado, Tipo) 
                                 VALUES (@Descricao, @Localizacao, @Latitude, @Longitude, @DataHora, @Severidade, @Estado, @Tipo)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descricao", ocorrencia.Descricao);
                    command.Parameters.AddWithValue("@Localizacao", ocorrencia.Localizacao);
                    command.Parameters.AddWithValue("@Latitude", ocorrencia.Latitude);
                    command.Parameters.AddWithValue("@Longitude", ocorrencia.Longitude);
                    command.Parameters.AddWithValue("@DataHora", ocorrencia.DataHora);
                    command.Parameters.AddWithValue("@Severidade", ocorrencia.Severidade.ToString());
                    command.Parameters.AddWithValue("@Estado", ocorrencia.Estado.ToString());
                    command.Parameters.AddWithValue("@Tipo", ocorrencia.Tipo.ToString());

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AtualizarOcorrencia(Ocorrencia ocorrencia)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Ocorrencias SET 
                                 Descricao = @Descricao, 
                                 Localizacao = @Localizacao, 
                                 Latitude = @Latitude, 
                                 Longitude = @Longitude, 
                                 DataHora = @DataHora, 
                                 Severidade = @Severidade, 
                                 Estado = @Estado, 
                                 Tipo = @Tipo,
                                 UltimaAtualizacao = CURRENT_TIMESTAMP 
                                 WHERE Id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Descricao", ocorrencia.Descricao);
                    command.Parameters.AddWithValue("@Localizacao", ocorrencia.Localizacao);
                    command.Parameters.AddWithValue("@Latitude", ocorrencia.Latitude);
                    command.Parameters.AddWithValue("@Longitude", ocorrencia.Longitude);
                    command.Parameters.AddWithValue("@DataHora", ocorrencia.DataHora);
                    command.Parameters.AddWithValue("@Severidade", ocorrencia.Severidade.ToString());
                    command.Parameters.AddWithValue("@Estado", ocorrencia.Estado.ToString());
                    command.Parameters.AddWithValue("@Tipo", ocorrencia.Tipo.ToString());
                    command.Parameters.AddWithValue("@Id", ocorrencia.Id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool EliminarOcorrencia(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Ocorrencias WHERE Id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public Ocorrencia ObterOcorrenciaPorId(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ocorrencias WHERE Id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Ocorrencia
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Descricao = reader.GetString(reader.GetOrdinal("Descricao")),
                                Localizacao = reader.GetString(reader.GetOrdinal("Localizacao")),
                                Latitude = reader.GetString(reader.GetOrdinal("Latitude")),
                                Longitude = reader.GetString(reader.GetOrdinal("Longitude")),
                                DataHora = reader.GetDateTime(reader.GetOrdinal("DataHora")),
                                Severidade = (SeveridadeOcorrencia)Enum.Parse(typeof(SeveridadeOcorrencia), reader.GetString(reader.GetOrdinal("Severidade"))),
                                Estado = (EstadoOcorrencia)Enum.Parse(typeof(EstadoOcorrencia), reader.GetString(reader.GetOrdinal("Estado"))),
                                Tipo = (TipodeOcorrencia)Enum.Parse(typeof(TipodeOcorrencia), reader.GetString(reader.GetOrdinal("Tipo")))
                            };
                        }
                    }
                }
            }
            return null;
        }

        public List<Ocorrencia> ObterTodasOcorrencias()
        {
            List<Ocorrencia> ocorrencias = new List<Ocorrencia>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Ocorrencias";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Ocorrencia ocorrencia = new Ocorrencia
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Descricao = reader.GetString(reader.GetOrdinal("Descricao")),
                            Localizacao = reader.GetString(reader.GetOrdinal("Localizacao")),
                            Latitude = reader.GetString(reader.GetOrdinal("Latitude")),
                            Longitude = reader.GetString(reader.GetOrdinal("Longitude")),
                            DataHora = reader.GetDateTime(reader.GetOrdinal("DataHora")),
                            Severidade = (SeveridadeOcorrencia)Enum.Parse(typeof(SeveridadeOcorrencia), reader.GetString(reader.GetOrdinal("Severidade"))),
                            Estado = (EstadoOcorrencia)Enum.Parse(typeof(EstadoOcorrencia), reader.GetString(reader.GetOrdinal("Estado"))),
                            Tipo = (TipodeOcorrencia)Enum.Parse(typeof(TipodeOcorrencia), reader.GetString(reader.GetOrdinal("Tipo")))
                        };
                        ocorrencias.Add(ocorrencia);
                    }
                }
            }

            return ocorrencias;
        }
    }
}

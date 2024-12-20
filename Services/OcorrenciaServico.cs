using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using FireCare.Models;

namespace FireCare.Services
{
    public class OcorrenciaServico
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Ricardo\\source\\repos\\FireCare\\DB\\database_firecare.db;Version=3;";
        private readonly ProfissionalServico profissionalService = new ProfissionalServico();

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

                    bool resultado = command.ExecuteNonQuery() > 0;

                    if (resultado)
                    {
                        int ocorrenciaId = (int)connection.LastInsertRowId;
                        AlocarProfissionais(ocorrenciaId, ocorrencia.Severidade);
                    }

                    return resultado;
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
                                 Tipo = @Tipo
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

                    bool resultado = command.ExecuteNonQuery() > 0;

                    if (resultado && ocorrencia.Estado == EstadoOcorrencia.Resolvido)
                    {
                        LiberarProfissionais(ocorrencia.Id);
                    }

                    return resultado;
                }
            }
        }

        public bool EliminarOcorrencia(int id)
        {
            LiberarProfissionais(id);

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

        // NOVO MÉTODO: Obter o número de profissionais alocados a uma ocorrência
        public int ObterNumeroProfissionaisAlocados(int ocorrenciaId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT COUNT(*) FROM Ocorrencias_Profissionais WHERE OcorrenciaId = @OcorrenciaId";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OcorrenciaId", ocorrenciaId);
                    return Convert.ToInt32(command.ExecuteScalar());
                }
            }
        }

        private void AlocarProfissionais(int ocorrenciaId, SeveridadeOcorrencia severidade)
        {
            List<Profissional> disponiveis = profissionalService.ObterTodosProfissionais().Where(p => p.Disponivel).ToList();

            int quantidade = severidade == SeveridadeOcorrencia.Alta ? 5 :
                             severidade == SeveridadeOcorrencia.Media ? 3 : 1;

            for (int i = 0; i < quantidade && i < disponiveis.Count; i++)
            {
                Profissional profissional = disponiveis[i];
                profissional.Disponivel = false;

                profissionalService.AtualizarProfissional(profissional);

                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string query = @"INSERT INTO Ocorrencias_Profissionais (OcorrenciaId, ProfissionalId) 
                                     VALUES (@OcorrenciaId, @ProfissionalId)";

                    using (SQLiteCommand command = new SQLiteCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OcorrenciaId", ocorrenciaId);
                        command.Parameters.AddWithValue("@ProfissionalId", profissional.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        private void LiberarProfissionais(int ocorrenciaId)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"SELECT ProfissionalId FROM Ocorrencias_Profissionais WHERE OcorrenciaId = @OcorrenciaId";

                List<int> profissionaisIds = new List<int>();

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@OcorrenciaId", ocorrenciaId);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            profissionaisIds.Add(reader.GetInt32(0));
                        }
                    }
                }

                foreach (int profissionalId in profissionaisIds)
                {
                    Profissional profissional = profissionalService.ObterProfissionalPorId(profissionalId);
                    if (profissional != null)
                    {
                        profissional.Disponivel = true;
                        profissionalService.AtualizarProfissional(profissional);
                    }
                }

                // Remover relação de profissionais da tabela Ocorrencias_Profissionais
                string deleteQuery = "DELETE FROM Ocorrencias_Profissionais WHERE OcorrenciaId = @OcorrenciaId";

                using (SQLiteCommand command = new SQLiteCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@OcorrenciaId", ocorrenciaId);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}

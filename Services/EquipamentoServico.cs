using System;
using System.Collections.Generic;
using System.Data.SQLite;
using FireCare.Models;

namespace FireCare.Services
{
    public class EquipamentoServico
    {
        private readonly string connectionString = "Data Source=C:\\Users\\Ricardo\\source\\repos\\FireCare\\DB\\database_firecare.db;Version=3;";

        public List<Equipamento> ObterTodosEquipamentos()
        {
            List<Equipamento> equipamentos = new List<Equipamento>();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Equipamentos";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Equipamento equipamento = new Equipamento
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            Nome = reader.GetString(reader.GetOrdinal("Nome")),
                            Categoria = reader.GetString(reader.GetOrdinal("Categoria")),
                            Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade")),
                            Origem = reader.GetString(reader.GetOrdinal("Origem")),
                            Estado = (Estado)Enum.Parse(typeof(Estado), reader.GetString(reader.GetOrdinal("Estado")))
                        };
                        equipamentos.Add(equipamento);
                    }
                }
            }
            return equipamentos;
        }

        public Equipamento ObterEquipamentoPorId(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM Equipamentos WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Equipamento
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                Nome = reader.GetString(reader.GetOrdinal("Nome")),
                                Categoria = reader.GetString(reader.GetOrdinal("Categoria")),
                                Quantidade = reader.GetInt32(reader.GetOrdinal("Quantidade")),
                                Origem = reader.GetString(reader.GetOrdinal("Origem")),
                                Estado = (Estado)Enum.Parse(typeof(Estado), reader.GetString(reader.GetOrdinal("Estado")))
                            };
                        }
                    }
                }
            }
            return null;
        }


        public bool AdicionarEquipamento(Equipamento equipamento)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Equipamentos 
                                 (Nome, Categoria, Quantidade, Origem, Estado) 
                                 VALUES (@Nome, @Categoria, @Quantidade, @Origem, @Estado)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", equipamento.Nome);
                    command.Parameters.AddWithValue("@Categoria", equipamento.Categoria);
                    command.Parameters.AddWithValue("@Quantidade", equipamento.Quantidade);
                    command.Parameters.AddWithValue("@Origem", equipamento.Origem);
                    command.Parameters.AddWithValue("@Estado", equipamento.Estado.ToString());

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool AtualizarEquipamento(Equipamento equipamento)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"UPDATE Equipamentos SET 
                         Nome = @Nome, 
                         Categoria = @Categoria, 
                         Quantidade = @Quantidade, 
                         Origem = @Origem, 
                         Estado = @Estado 
                         WHERE Id = @Id";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nome", equipamento.Nome);
                    command.Parameters.AddWithValue("@Categoria", equipamento.Categoria);
                    command.Parameters.AddWithValue("@Quantidade", equipamento.Quantidade);
                    command.Parameters.AddWithValue("@Origem", equipamento.Origem);
                    command.Parameters.AddWithValue("@Estado", equipamento.Estado.ToString());
                    command.Parameters.AddWithValue("@Id", equipamento.Id);

                    return command.ExecuteNonQuery() > 0;
                }
            }
        }


        public bool EliminarEquipamento(int id)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "DELETE FROM Equipamentos WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

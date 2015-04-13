using System;
using System.Collections.Generic;
using System.Data.SQLite;
using EnglishStudyHelper.Entities;
using EnglishStudyHelper.Services;

namespace EnglishStudyHelper.DAL
{
    public class CategoriesRepo : BaseContext, IRepository<Category>
    {

        public IEnumerable<Category> GetListAll()
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText =
                        "SELECT Id, Name, IsSelected FROM Categories";

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var categories = new Category(reader.GetInt32(0), reader.GetString(1), reader.GetBoolean(2));

                        yield return categories;
                    }
                }
            }
        }

     

        public void Insert(Category category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "insert into categories (name, isSelected) values (@name, @isSelect)";

                    command.Parameters.AddWithValue("@name", category.CategoryName);
                    command.Parameters.AddWithValue("@isSelect", category.IsSelected);
                    command.ExecuteNonQuery();

                    command.Parameters.Clear();
                    command.CommandText = "SELECT max(id) FROM categories";

                    category.CategoryId = Convert.ToInt32(command.ExecuteScalar());
              

                }
            }
        }

        public void Update(Category category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "update categories set name = @name where id = @id";

                    command.Parameters.AddWithValue("@id", category.CategoryId);
                    command.Parameters.AddWithValue("@name", category.CategoryName);
                    command.ExecuteNonQuery();

                }
            }
        }


        public void UpdateFlag(Category category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "update categories set isSelected = @flag where id = @id";

                    command.Parameters.AddWithValue("@id", category.CategoryId);
                    command.Parameters.AddWithValue("@flag", category.IsSelected);
                    command.ExecuteNonQuery();

                }
            }
        }



        public void Delete(Category category)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand commandDelete = connection.CreateCommand(), 
                    commandUpdateWords = connection.CreateCommand())
                {

                    commandDelete.CommandText = "delete from categories where id = @id";
                    commandDelete.Parameters.AddWithValue("@id", category.CategoryId);

                    if (category.WordsInCategory != 0)
                    {
                        commandUpdateWords.CommandText = "update words set catId = 0 where catId = @id";
                        commandUpdateWords.Parameters.AddWithValue("@id", category.CategoryId);
                    } else commandUpdateWords.CommandText = "";

                    SQLiteTransaction tran = null;

                    try
                    {
                        tran = connection.BeginTransaction();

                        if (commandUpdateWords.CommandText != "")
                            commandUpdateWords.ExecuteNonQuery();

                        commandDelete.ExecuteNonQuery();

                     

                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();
                        MessageService msServ = new MessageService();
                        msServ.ShowError("Ошибка удаления категории. " + ex.StackTrace);
                     }

                }
            }
        }
    }
}

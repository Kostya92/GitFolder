using System;
using System.Collections.Generic;
using System.Data.SQLite;
using EnglishStudyHelper.Entities;
using EnglishStudyHelper.Services;

namespace EnglishStudyHelper.DAL
{
    public class WordsRepo : BaseContext, IRepository<Word>
    {
      
        public IEnumerable<Word> GetListAll()
        {
             using (var connection = new SQLiteConnection(ConnectionString))
                {
                    connection.Open();

                    using (var command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT w.id, w.wordEN, ifnull(t.id, 0), ifnull(t.wordRU, ''), ifnull(c.id, 0), ifnull(c.name, '') as category FROM words w"
                                               + " LEFT OUTER JOIN translates t ON w.Id = t.idWordEn"
                                               + " LEFT OUTER JOIN categories c ON w.catId = c.id";

                        using (var reader = command.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                var words = new Word(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));

                                yield return words;
                            }
                        }
                    }
                }
           
        }

        public void Insert(Word word)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (var command = connection.CreateCommand())
                {
                    command.CommandText = "insert into words (wordEN, catId) values (@word, @catId)";

                    command.Parameters.AddWithValue("@word", word.WordName);
                    command.Parameters.AddWithValue("@catId", word.CategoryId);

                    SQLiteTransaction tran = null;

                    try
                    {
                        tran = connection.BeginTransaction();

                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.CommandText = "SELECT max(id) FROM words";

                        word.WordId = Convert.ToInt32(command.ExecuteScalar());

                        command.Parameters.Clear();
                        command.CommandText = "insert into translates (wordRU, idWordEn) values (@trans, @idWord)";
                        command.Parameters.AddWithValue("@trans", word.Translate);
                        command.Parameters.AddWithValue("@idWord", word.WordId);
                        command.ExecuteNonQuery();

                        command.Parameters.Clear();
                        command.CommandText = "SELECT max(id) FROM translates";

                        word.TranslateId = Convert.ToInt32(command.ExecuteScalar());

                        tran.Commit();
                    }
                    catch(Exception ex)
                    {
                        tran.Rollback();

                        MessageService msServ = new MessageService();
                        msServ.ShowError("Ошибка добавления слова. " + ex.Message);
                    }
               

                }
            }
        }

        public void Delete(Word word)
        {
            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                using (SQLiteCommand commandWord = connection.CreateCommand(), 
                        commandTrans = connection.CreateCommand())
                {
                    commandWord.CommandText = "delete from words where id = @id";
                    commandWord.Parameters.AddWithValue("@id", word.WordId);

                    commandTrans.CommandText = "delete from translates where idWordEn = @id";
                    commandTrans.Parameters.AddWithValue("@id", word.WordId);
                
                    SQLiteTransaction tran = null;

                    try
                    {
                        tran = connection.BeginTransaction();

                        commandTrans.ExecuteNonQuery();
                        commandWord.ExecuteNonQuery();
                        
                        tran.Commit();
                    }
                    catch (Exception ex)
                    {
                        tran.Rollback();

                        MessageService msServ = new MessageService();
                        msServ.ShowError("Ошибка удаления слова. " + ex.Message);
                    }


                }
            }
        }

      
        public void Update(Word word) { throw new NotImplementedException(); }

    


    }
}

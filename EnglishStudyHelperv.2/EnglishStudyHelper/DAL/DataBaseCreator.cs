using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Data.SQLite;
using EnglishStudyHelper.Entities;

namespace EnglishStudyHelper.DAL
{
    class DataBaseCreator : BaseContext
    {
        public void CreateDB()
        {
            var dbDirName = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var dbFileName = Path.Combine(dbDirName, "helper.db");

            if (!File.Exists(dbFileName))
            {
                SQLiteConnection.CreateFile(dbFileName);

                using (var connection = new SQLiteConnection(ConnectionString))
                {
                   
                    connection.Open();

                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = @"create table words (id integer primary key autoincrement, wordEN text, catId int);";
                        query.ExecuteNonQuery();
                    }

                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = @"create table translates (id integer primary key autoincrement, wordRU text, idWordEn int);";

                        query.ExecuteNonQuery();
                    }

                    using (var query = connection.CreateCommand())
                    {
                        query.CommandText = @"create table categories (id integer primary key autoincrement, name text, isSelected int);";
                        query.ExecuteNonQuery();
                    }

                    var categoryRepo = new CategoriesRepo();
                    var wordRepo = new WordsRepo();


                    categoryRepo.Insert(new Category("Animals", true));
                    categoryRepo.Insert(new Category("Clothing", true));
                    categoryRepo.Insert(new Category("IT", true));


                    List<Category> categories = categoryRepo.GetListAll().ToList();
                    
                    int id = categories.Find(x => x.CategoryName.Contains("Animals")).CategoryId;
                    
                    wordRepo.Insert(new Word("cat", "кот", id));
	                wordRepo.Insert(new Word("dog", " собака", id));
	                wordRepo.Insert(new Word("elephant", " слон", id));
	                wordRepo.Insert(new Word("lion", " лев", id));
	                wordRepo.Insert(new Word("wolf", " волк", id));

                    id = categories.Find(x => x.CategoryName.Contains("Clothing")).CategoryId;

                    wordRepo.Insert(new Word("sweater", "свитер", id));
	                wordRepo.Insert(new Word("hat", "шапка", id));
	                wordRepo.Insert(new Word("pants", "штаны", id));
	                wordRepo.Insert(new Word("shirt", "рубашка", id));
	                wordRepo.Insert(new Word("пиджак", "jacket", id));

                    id = categories.Find(x => x.CategoryName.Contains("IT")).CategoryId;

                    wordRepo.Insert(new Word("notebook", "ноутбук", id));
	                wordRepo.Insert(new Word("планшет", "board", id));
	                wordRepo.Insert(new Word("computer", "компьютер", id));
	                wordRepo.Insert(new Word("клавиатура", "keyboard", id));
                    wordRepo.Insert(new Word("программы", "programs", id));


                }
            }
        }
    }
}

using System.Collections.Generic;
using System.Linq;
using EnglishStudyHelper.Entities;
using EnglishStudyHelper.DAL;


namespace EnglishStudyHelper.Services
{
    public interface IDataApp
    {
        List<Word> Words { get; set; }
        List<Category> Categories { get; set; }
    }

    public class ApplicationDataService: IDataApp
    {
        private static ApplicationDataService _instance;
        private WordsRepo _wordsRepo = new WordsRepo();
        private CategoriesRepo _categoriesRepo = new CategoriesRepo();

        public List<Word> Words { get; set; }
        public List<Category> Categories { get; set; }

        public ApplicationDataService() {}

        public void InitLists()
        {
            Words = _wordsRepo.GetListAll().ToList();
            Categories = _categoriesRepo.GetListAll().ToList();
            CountWordsInCategories();
     
        }

        public static ApplicationDataService Instance
        {
            get
            {
                if (_instance == null)
                {
                  _instance = new ApplicationDataService();
                  
                }

                return _instance;
            }

        }
   

        public List<Word> GetWordsByCategory(int categoryId)
        {
            var filterWords = new List<Word>();
            
            foreach (var word in Words)
            {
                if (word.CategoryId == categoryId)
                    filterWords.Add(word);
            }

            return filterWords;
        }


        public List<Word> GetWordsFromSelectedCategories()
        {
            var filteredList = new List<Word>();

            foreach (var category in Categories)
            {
                if (category.IsSelected)
                    filteredList.AddRange(GetWordsByCategory(category.CategoryId));
            }

            return filteredList;
        }


        public void InsertWord(Word word)
        {
            _wordsRepo.Insert(word);
            InitLists();
        }

        public void DeleteWord(Word word)
        {
            _wordsRepo.Delete(word);
            InitLists();
        }

        public void InserCategory(Category category)
        {
            _categoriesRepo.Insert(category);
            InitLists();
        }

        public void DeleteCategory(Category category)
        {
            _categoriesRepo.Delete(category);
            InitLists();
        }

        public void UpdateCategoryFlag(Category category)
        {
            _categoriesRepo.UpdateFlag(category);
            InitLists();
        }


        public void CountWordsInCategories()
        {
            foreach (var category in Instance.Categories)
            {
                var wordsInCategory =
                    from word in Instance.Words
                    where word.CategoryId == category.CategoryId
                    select word;

                category.WordsInCategory = wordsInCategory.ToList().Count;  
            }
        }

        public void UpdateWordCategory(Word word)
        {
            foreach (var category in Instance.Categories)
            {
                if (word.CategoryId == category.CategoryId)
                    word.CategoryName = category.CategoryName;                
            }
        }

        
    }
}

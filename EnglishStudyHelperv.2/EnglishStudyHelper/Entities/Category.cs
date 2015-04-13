
namespace EnglishStudyHelper.Entities
{
    public class Category
    {
        public int CategoryId { get; set; }
        public bool IsSelected { get; set; }
        public string CategoryName { get; set; }
        public int WordsInCategory { get; set; }

        public Category() { }

        public Category(int categoryId, string categoryName, bool isSelected)
        {
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.IsSelected = isSelected;
 
        }

        public Category(string categoryName) : this(0, categoryName, false) { }

       public Category(string categoryName, bool isSelected) : this(0, categoryName, isSelected) { }

    }
}

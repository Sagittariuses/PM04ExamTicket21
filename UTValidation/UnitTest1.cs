using WpfTicket21Books.Classes;

namespace UTValidation
{
    public class Tests
    {
        ValidationFunc func = new ValidationFunc();

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AuthorTest()
        {
            Assert.AreEqual(true, func.AuthorValidate("Толстой Лев Николаевич"), "Bad Author");
        }
        [Test]
        public void TitleTest()
        {
            Assert.AreEqual(true, func.TitleValidate("Очень длинное название книги"), "Bad Title");
        }
        [Test]
        public void yearTest()
        {
            Assert.AreEqual(true, func.YearValidate("2058"), "Bad year");
        }
    }
}
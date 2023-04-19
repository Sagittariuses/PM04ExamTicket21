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
            Assert.That(func.AuthorValidate("Толстой Лев Николаевич"), Is.EqualTo(true), "Bad Author");
        }
        [Test]
        public void TitleTest()
        {
            Assert.That(func.TitleValidate("Очень длинное название книги"), Is.EqualTo(true), "Bad Title");
        }
        [Test]
        public void yearTest()
        {
            Assert.That(func.YearValidate("2058"), Is.EqualTo(true), "Bad year");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfTicket21Books.Classes
{
    public class ValidationFunc
    {

        public  bool AuthorValidate(string author)
        {
            return author.Length >= 20 && author.Length <= 75;
        }

        public  bool TitleValidate(string title)
        {
            return title.Length >= 10 && title.Length <= 100;
        }

        public  bool YearValidate(string year)
        {
            if (year.Contains(",") || year.Contains(".") || year.Contains("-") || year.StartsWith("0"))
                return false;

            try
            {
                var intYear = Convert.ToInt32(year);

                return true;

            }
            catch
            {
                return false;
            }
        }

    }
}

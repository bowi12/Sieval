using System.ComponentModel.DataAnnotations;

namespace Sieval_API.Models
{
    public class Article
    {
        private string _sku;
        private string _name;

        public int id { get; set; }

        [Required]
        public string sku 
        { get { return _sku; } 
            set 
            { 
                if (value.Length > 10)
                {
                    throw new ArgumentOutOfRangeException("sku can not be longer than 10 characters");
                }
                else
                {
                    _sku = value;
                }
            }
        }
        [Required]
        public string name 
        {
            get { return _name; }
            set 
            { 
                if (value.Length > 50)
                {
                    throw new ArgumentOutOfRangeException("name can not be longer than 50 character");
                }
                else
                {
                    _name = value;
                }
            }
        }
        [Required]
        public decimal price { get; set; }

    }
}

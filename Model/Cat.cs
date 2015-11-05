using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        public Cat(int age, CatColor color)
        {
            _heath = 5;
            Age = age;
            Color = color;
        }

        private int _heath;
        private string _name;
        public int Age { get; }
        public CatColor Color { get; set; }
        public string CurrentColor => _heath >= 5 ? Color.HeathyColor : Color.SickColor;

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
                else
                {
                    throw new Exception("Вы пытаетесть повторно задать значение Write first Property, прочтите документацию");
                }
            }
        }

        public void Feed()
        {
            _heath++;
        }

        public void Punish()
        {
            _heath--;
        }
    }
}

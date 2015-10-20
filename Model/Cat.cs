using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat
    {
        //Где можно прочитать про правильную компановку класса? 
        private int _heath;
        private string _name;
        public string CurrentColor;

        /// <summary>
        /// read only Property;
        /// </summary>
        private string Age { get; set; } //Age - String????
        /// <summary>
        /// read/write property;
        /// </summary>
        public CatColor Color { get; set; }

        public Cat(string age)
        {
            _heath = 5;
            Age = age;
        }

        /// <summary>
        /// write first Property;
        /// </summary>
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
            if (_heath >= 5)
            {
                CurrentColor = Color.HeathyColor;
            }
        }

        public void Punish()
        {
            _heath--;
            if (_heath < 5)
            {
                CurrentColor = Color.SickColor;
            }
        }
    }
}

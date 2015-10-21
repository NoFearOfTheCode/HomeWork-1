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
        private readonly string _age; //Age - String????
        public string CurrentColor;
        public CatColor Color { get; set; }
        
        public Cat(string age, CatColor color)
        {
            _heath = 5;
            _age = age;
            Color = color;
        }

        public string GetAge()
        {
            return _age;
        }

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

using System;

namespace HomeworkKovshov5.Entity
{
    /// <summary>
    /// Класс смартфон
    /// </summary>
    public class Smartphone
    {
        /// <summary>
        /// Цвет смартфона
        /// </summary>
        private readonly string _color;

        /// <summary>
        /// Бренд смартфона
        /// </summary>
        private readonly string _brand;

        /// <summary>
        /// Количество камер в смартфоне
        /// </summary>
        private readonly int _numberOfCameras;

        /// <summary>
        /// Конструктор для смартфона
        /// </summary>
        /// <param name="color">Цвет</param>
        /// <param name="brand">Бренд</param>
        /// <param name="numberOfCameras">Количество камер</param>
        public Smartphone(string color, string brand, int numberOfCameras)
        {
            _color = color;
            _brand = brand;
            _numberOfCameras = numberOfCameras;
        }

        /// <summary>
        /// Получить цвет смартфона
        /// </summary>
        /// <returns>Цвет смартфона</returns>
        public string GetColor()
        {
            return _color;
        }

        /// <summary>
        /// Получить бренд смартфона
        /// </summary>
        /// <returns>Бренд смартфон</returns>
        public string GetBrand()
        {
            return _brand;
        }

        /// <summary>
        /// Получить количесвто камер смартфона
        /// </summary>
        /// <returns>Количество камер смартфона</returns>
        public int GetNumberOfCameras()
        {
            return _numberOfCameras;
        }

        /// <summary>
        /// Переопредленеи метода превращения в строку
        /// </summary>
        /// <returns>Красивую строку с цветом, брендом и количеством камер</returns>
        public override string ToString()
        {
            return "[color=" + _color + ",\tbrand=" + _brand + ",\tnumberOfCameras=" + _numberOfCameras + "]";
        }
    }
}
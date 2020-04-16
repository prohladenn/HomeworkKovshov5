using HomeworkKovshov5.Entity;
using HomeworkKovshov5.Specification.Basic;

namespace HomeworkKovshov5.Specification
{
    /// <summary>
    /// Класс спецификация для цвета
    /// </summary>
    public class ColorSpecification : CompositeSpecification<Smartphone>
    {
        /// <summary>
        /// Название цвета
        /// </summary>
        private readonly string _color;

        /// <summary>
        /// Конструктор класса спецификации для цвета
        /// </summary>
        /// <param name="color">Искомый цвет</param>
        public ColorSpecification(string color)
        {
            _color = color;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <param name="smartphone">Входящий смартфон</param>
        /// <returns>Совпадает ли у входящего смартфона цвет с искомым</returns>
        public override bool IsSatisfiedBy(Smartphone smartphone)
        {
            return smartphone.GetColor().Equals(_color);
        }
    }
}
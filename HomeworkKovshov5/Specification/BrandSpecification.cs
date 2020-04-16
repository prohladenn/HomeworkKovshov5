using HomeworkKovshov5.Entity;
using HomeworkKovshov5.Specification.Basic;

namespace HomeworkKovshov5.Specification
{
    /// <summary>
    /// Класс спецификация для бренда
    /// </summary>
    public class BrandSpecification : CompositeSpecification<Smartphone>
    {
        /// <summary>
        /// Название бренда
        /// </summary>
        private readonly string _brand;

        /// <summary>
        /// Конструктор класса спецификации для количества камер
        /// </summary>
        /// <param name="brand">Искомый бренд</param>
        public BrandSpecification(string brand)
        {
            _brand = brand;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <param name="smartphone">Входящий смартфон</param>
        /// <returns>Совпадает ли у входящего смартфона бренд с искомым</returns>
        public override bool IsSatisfiedBy(Smartphone smartphone)
        {
            return smartphone.GetBrand().Equals(_brand);
        }
    }
}
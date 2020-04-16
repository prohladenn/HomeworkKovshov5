using HomeworkKovshov5.Entity;
using HomeworkKovshov5.Specification.Basic;

namespace HomeworkKovshov5.Specification
{
    /// <summary>
    /// Класс спецификация для количества камер
    /// </summary>
    public class NumberOfCamerasSpecification : CompositeSpecification<Smartphone>
    {
        /// <summary>
        /// Количество камер
        /// </summary>
        private readonly int _numberOfCameras;

        /// <summary>
        /// Конструктор класса спецификации для количества камер
        /// </summary>
        /// <param name="numberOfCameras">Искомое количество камер</param>
        public NumberOfCamerasSpecification(int numberOfCameras)
        {
            _numberOfCameras = numberOfCameras;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <param name="smartphone">Входящий смартфон</param>
        /// <returns>Совпадает ли у входящего смартфона количество камер с искомым</returns>
        public override bool IsSatisfiedBy(Smartphone smartphone)
        {
            return smartphone.GetNumberOfCameras().Equals(_numberOfCameras);
        }
    }
}
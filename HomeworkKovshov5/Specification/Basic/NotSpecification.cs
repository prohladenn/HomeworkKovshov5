namespace HomeworkKovshov5.Specification.Basic
{
    public class NotSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// Состояние
        /// </summary>
        private readonly ISpecification<T> _condition;

        /// <summary>
        /// Конструктор
        /// </summary>
        public NotSpecification(ISpecification<T> condition)
        {
            _condition = condition;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <returns>Состояние НЕ удовлетворяет</returns>
        public override bool IsSatisfiedBy(T candidate)
        {
            return !_condition.IsSatisfiedBy(candidate);
        }
    }
}
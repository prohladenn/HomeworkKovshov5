namespace HomeworkKovshov5.Specification.Basic
{
    public class OrSpecification<T> : CompositeSpecification<T>
    {
        /// <summary>
        /// Первое состояние
        /// </summary>
        private readonly ISpecification<T> _firstCondition;
        
        /// <summary>
        /// Второе состояние
        /// </summary>
        private readonly ISpecification<T> _secondCondition;

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="firstCondition">Первое состояние</param>
        /// <param name="secondCondition">Второе состояние</param>
        public OrSpecification(ISpecification<T> firstCondition, ISpecification<T> secondCondition)
        {
            _firstCondition = firstCondition;
            _secondCondition = secondCondition;
        }

        /// <summary>
        /// Реализация нашего главного булевого метода
        /// </summary>
        /// <returns>Первое состояние ИЛИ второе состояние удовлетворяет</returns>
        public override bool IsSatisfiedBy(T candidate)
        {
            return _firstCondition.IsSatisfiedBy(candidate) || _secondCondition.IsSatisfiedBy(candidate);
        }
    }
}
namespace HomeworkKovshov5.Specification.Basic
{
    /// <summary>
    /// Абстрактный класс с базовыми бинарными операциями
    /// </summary>
    /// <typeparam name="T">Дженерик</typeparam>
    public abstract class CompositeSpecification<T> : ISpecification<T>
    {
        /// <summary>
        /// Наш главный булевый метод для реализации
        /// </summary>
        public abstract bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// Реализация булевого оператор И
        /// </summary>
        /// <returns>this && condition</returns>
        public ISpecification<T> And(ISpecification<T> condition)
            => new AndSpecification<T>(this, condition);

        /// <summary>
        /// Реализация булевого оператор ИЛИ
        /// </summary>
        /// /// <returns>this || condition</returns>
        public ISpecification<T> Or(ISpecification<T> condition)
            => new OrSpecification<T>(this, condition);

        /// <summary>
        /// Реализация булевого оператор НЕ
        /// </summary>
        /// /// <returns>!this</returns>
        public ISpecification<T> Not()
            => new NotSpecification<T>(this);
    }
}
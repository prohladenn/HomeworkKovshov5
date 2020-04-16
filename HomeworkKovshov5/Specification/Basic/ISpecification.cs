namespace HomeworkKovshov5.Specification.Basic
{
    public interface ISpecification<T>
    {
        /// <summary>
        /// Наш главный булевый метод для имплементации
        /// </summary>
        bool IsSatisfiedBy(T candidate);

        /// <summary>
        /// Булевый оператор И
        /// </summary>
        ISpecification<T> And(ISpecification<T> condition);

        /// <summary>
        /// Булевый оператор ИЛИ
        /// </summary>
        ISpecification<T> Or(ISpecification<T> condition);

        /// <summary>
        /// Булевый оператор НЕ
        /// </summary>
        ISpecification<T> Not();
    }
}
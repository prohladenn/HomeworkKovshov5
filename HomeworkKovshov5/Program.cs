using System;
using System.Collections.Generic;
using HomeworkKovshov5.Entity;
using HomeworkKovshov5.Specification;
using HomeworkKovshov5.Specification.Basic;

namespace HomeworkKovshov5
{
    internal static class Program
    {
        private static void Main()
        {
            Smartphone[] smartphones =
            {
                new Smartphone("white", "xiaomi", 12),
                new Smartphone("white", "samsung", 8),
                new Smartphone("black", "motorolla", 2),
                new Smartphone("red", "apple", 128),
                new Smartphone("blue", "xiaomi", 8),
                new Smartphone("blue", "sony", 8)
            };

            ISpecification<Smartphone> whiteSpec = new ColorSpecification("white");
            Console.WriteLine("Smartphones with color=white");
            PrintResult(whiteSpec, smartphones);

            var appleOrBlackSpec
                = new BrandSpecification("apple").Or(new ColorSpecification("black"));
            Console.WriteLine("Smartphones with brand=apple or color=black=");
            PrintResult(appleOrBlackSpec, smartphones);

            var whiteAndEightCamerasSpec
                = new NumberOfCamerasSpecification(8).And(new ColorSpecification("white"));
            Console.WriteLine("Smartphones with color=white and numberOfCameras=8");
            PrintResult(whiteAndEightCamerasSpec, smartphones);

            var notBlueAndWhiteSpec
                = new ColorSpecification("blue").Or(new ColorSpecification("white")).Not();
            Console.WriteLine("Smartphones with color=!blue and color=!white");
            PrintResult(notBlueAndWhiteSpec, smartphones);
        }

        private static void PrintResult(ISpecification<Smartphone> specification, IEnumerable<Smartphone> smartphones)
        {
            foreach (var smartphone in smartphones)
                if (specification.IsSatisfiedBy(smartphone))
                    Console.WriteLine(smartphone);
            Console.WriteLine();
        }
    }
}
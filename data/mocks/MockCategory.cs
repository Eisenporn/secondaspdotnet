using secondaspdotnet.data.interferes;
using secondaspdotnet.data.modeles;

namespace secondaspdotnet.data.mocks;

public class MockCategory : IcarsCategory
{
    public IEnumerable<category> Allcategories
    {
        get
        {
            return new List<category> {
                new category {categoryName = "Электромобили", desc="Современный вид транспорта"},
                new category {categoryName="Обысные ДВС", desc="Машины с двигателем внутреннего сгорания"}
            };
        }
    }
}

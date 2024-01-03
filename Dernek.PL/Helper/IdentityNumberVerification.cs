
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace Dernek.PL.Helper
{
    public static class IdentityNumberVerification
    {
        public static bool Check(string tc)
        {
            /*
                * 11 hanelidir.
                * Her hanesi rakamsal değer içerir.
                * İlk hane 0 olamaz.
                * 1. 3. 5. 7. ve 9. hanelerin toplamının 7 katından, 2. 4. 6. ve 8. hanelerin toplamı çıkartıldığında, 
                    elde edilen sonucun 10’a bölümünden kalan, yani Mod 10’u bize 10. haneyi verir.
                * 1. 2. 3. 4. 5. 6. 7. 8. 9. ve 10. hanelerin toplamından elde edilen sonucun 10’a bölümünden kalan, 
                    yani Mod10’u bize 11. haneyi verir.
            */
            // 11 Haneli olma durumu regex ile kontrol edildi.
            // Her hanesinin rakam olma durumu, ilk hanesinin 0 olmama durumu ve son hanesinin çift olma durumu regex ile kontrol edildi.
            Regex tcRegex = new(@"^[1-9]{1}[0-9]{9}[02468]{1}$");
            Match match = tcRegex.Match(tc);
            if (match.Success)
            {

                List<int> listTC = Regex.Replace(tc, "[^0-9]", "")
                    .Select(x => (int)Char.GetNumericValue(x)).ToList();

                // Burada çift indisli ve tek indise sahip rakamları iki diziye böldük
                // diziler c# ta 0. indisten başladığı için tersine bir atama yaptık.
                List<int> oddTC = listTC.Where((x, i) => i % 2 == 0).ToList(); // Tek indisli sayılar 11. indis hariç
                List<int> evenTC = listTC.Where((x, i) => i % 2 != 0).ToList(); // Çift indisli sayılar 10. indis hariç

                oddTC.RemoveAt(oddTC.Count - 1);
                evenTC.RemoveAt(evenTC.Count - 1);

                int check10Th = (oddTC.Sum() * 7 - evenTC.Sum()) % 10;
                if (check10Th == listTC[9]) // 4. adım 10. haneyi doğrulama
                {
                    int check11th = (listTC.Sum() - listTC[listTC.Count - 1]) % 10;

                    return check11th == listTC[10];
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}

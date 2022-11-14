//iç içe iki forla yazmak , O(n^2) time , 0(1) space complexitysi,
//sort edip, x ve y diye 2 değişkende değerleri tutup 2 şerli karşılaştırmak , O(NlogN) ve 0(1),
//daha da düşürerek , O(n) yapmak için ; aşağıdaki yol.

//hashset, unique değerler alacağı için, tekrar eklemeye calısılan eleman var mı yok mu önceden ona bakıp t/f döndürdük. aynı eleman 2. defa eklenmez HATA FIRLATMAZ.
//( tabii herhangi bir diziyle listeyle de olur aslında )

 static bool isDuplicate()
{
    List<int> sayilar = new List<int>() { 1, 2, 3, 1};
    HashSet<int> hS = new HashSet<int>();

    foreach (var tekSayi in sayilar)
    {

        if (hS.Contains(tekSayi))
        {
            return false;

        }
        hS.Add(tekSayi);
    }
    return true;
}

var returned=isDuplicate();
Console.WriteLine(returned);




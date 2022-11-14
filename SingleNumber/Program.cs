//uç örneklere, senaryolara edge case deniyor.
//bit manuplation yaparak O(n) ve O(1) ' de çözüm olabiliyor.
//XOR kapısı kullanılarak çözüm ;

List<int> myList = new List<int>(){1,2,2,3,3,9,9,1,23};
int comparator = 0;
foreach (var singNum in myList)
{
    comparator = singNum ^ comparator; // 3^2 giriyor gibi aslında ama bu da 1-0 ' lar mertebesinde gerçekleşiyor. eninde sonunda aynı olanlar eliycek birbirini 0 dönücek.

}

Console.WriteLine(comparator);
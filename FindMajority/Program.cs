//boyer moore algoritmasıyla majorite olan sayıyı bulacağız.
//bu algoritma, majorite olayı yoksa ÇALIŞMAZ.

// kafadan dedik ki en başta result ilk sayı olsun , sonra baktık 2. sayı aynıysa counter ++ , değilse -- dedik.
//en son resultta kalan sayı sonuc olcak. counter 0 a indiginde result da degisicek.


List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 5, 5, 5, 5 };
int result = 0;
int count = 0;

foreach (var item in myList)
{
	if (count == 0)
		result = item;
	if (item == result)
		count++;
	else
		count--;	
	
}

return result;

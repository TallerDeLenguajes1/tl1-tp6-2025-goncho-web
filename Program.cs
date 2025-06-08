int i = 0;
string s = "123";
bool resultado = int.TryParse(s, out i);
int x = 0;
while (i > 0)
{
    x = i % 10;
    Console.Write(x);
    i = i / 10;

}

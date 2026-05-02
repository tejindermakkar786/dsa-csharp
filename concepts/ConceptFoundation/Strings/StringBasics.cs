using System.Globalization;

public class StringBasics
{
    public void print()
    {
        string str="Hello World";
        Console.WriteLine(str[0]);
        Console.WriteLine(str.Length);
        
        for(int i=0;i<str.Length;i++)
        {
            Console.WriteLine(str[i]);
        }

        Char[] ary=str.ToCharArray();
        ary[0]='H';
        string newStr=new String(ary);
        Console.WriteLine(newStr);
        Console.WriteLine(newStr.ToLower());
        Console.WriteLine(newStr.ToUpper());
        TextInfo textInfo=CultureInfo.CurrentCulture.TextInfo;
        Console.WriteLine(textInfo.ToTitleCase(newStr));
    }
}
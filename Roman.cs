using System;

public class Hiker
{
    public static string getRoman(int x)
    {
        String romanValue = "";
        int dec = 0;
        for (int i = x; i > 0; i = i - dec)
        {
            if (i / 10 > 0)
            {
                romanValue += "X";
                dec = 10;
            }
            else if (i < 10)
            {
                switch (i)
                {
                    case 1:
                        romanValue += "I";
                        dec = 1;
                        break;
                    case 2:
                        romanValue += "II";
                        dec = 2;
                        break;
                    case 3:
                        romanValue += "III";
                        dec = 3;
                        break;
                    case 4:
                        romanValue += "IV";
                        dec = 4;
                        break;
                    default:
                        break;
                }
            }
        }

        return romanValue;
    }
}

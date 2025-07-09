// See https://aka.ms/new-console-template for more information


int widght = 120;
int hight = 30;
float ratio = (float)widght / hight;
float pixel = 11f / 24f;
int a = 0;
float b = 0;
char[] gradient = ['.', '-', '^', '+', '*', '%', '$', 'a', '#', '@'];
int gradient_len = gradient.Length;
//char[] chars = new char[widght *  hight + 1];

while (true)
{
    Console.Clear();
    a++;
    if (b < 100000)
    {
        b += 0.1f;
    }
    else
    {
        b *= -1;
    }
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < widght; j++)
        {

            float x = ((float)j / widght * 2 - 1);
            float y = ((float)i / hight * 2 - 1);
            char CHAR = ' ';
            x *= ratio * pixel;
            var function = (x - Math.Sin(b)) * (x / Math.Cos(b)) + y * y;

            if (function < 0.92)
            {
                function = Math.Abs(Math.Round(function * 10));
                //Console.WriteLine(function);
                if (function > gradient_len - 1)
                {
                    function = gradient_len - 1;
                    //Console.WriteLine(function + "dabsdbad");
                }
                CHAR = gradient[Convert.ToInt32(function)];


            }
            //chars[j + i * widght] = CHAR;
            Console.Write(CHAR);
        }
    }

    //Console.WriteLine(chars);
    Console.Clear();
}

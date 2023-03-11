do
{
    try
    {
        Console.WriteLine("zehmet olmasa daxil etmek istediyiniz ededlerin sayini qeyd edin");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[n];

        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine("zehmet olmasa" + (i + 1) + "-ci ededi daxil edin");
                int x = int.Parse(Console.ReadLine());
                array[i] = x;
            }
        }

        int sum = 0;
        for (int i = 0; i < n; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }

        Console.WriteLine(sum);

    }
    catch (Exception)
    {
        Console.WriteLine("zehmet olmasa duzgun eded daxil edin");
    }
}
while (true);



do
{
    try
    {
        Console.WriteLine("nece eded daxil elemek isteyirsen?");
        int num = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[num];
        for (int i = 0; i < num; i++)
        {
            if (array[i] % 2 == 0)
            {
                Console.WriteLine((i + 1) + "ci ededi daxil ele blet");
                int x = Convert.ToInt32(Console.ReadLine());
                array[i] = x;
            }
        }

        int sum = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                sum += array[i];
            }
        }
        int result;
        result = sum * sum;
        Console.WriteLine("cut ededlerin ceminin kvadrati->" + result);

    }
    catch (Exception)
    {
        Console.WriteLine("mezelenirsen gijdillax?");
    }

}
while (true);



do
{
    try
    {
        Console.WriteLine("birinci ededi daxil et");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("ikinci ededi daxil edin");
        int number2 = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i < 2; i++)
        {
            Console.WriteLine("cavab--->" + Math.Pow(number1, number2));
        }


    }
    catch (Exception)
    {
        Console.WriteLine("zehmet olmasa duzgun eded daxil et");
    }

}
while (true);



do
{
    try
    {
        Console.WriteLine("zehmet olmasa nece dene eded daxil etmek istediyinizi qeyd edin");
        int number = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[number];

        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("zehmet olmasa " + (i + 1) + "-ci ededi daxil edin");
            int x = int.Parse(Console.ReadLine());
            array[i] = x;
        }
        int biggest = 0;

        for (int i = 0; i < number; i++)
        {
            if (array[i] > biggest)
            {
                biggest = array[i];
            }
        }
        Console.WriteLine("en boyuk eded-->" + biggest + "dir");
    }
    catch (Exception)
    {
        Console.WriteLine("zehmet olmasa duzgun eded daxil edin");
    }
}
while (true);



do
{
    try
    {
        Console.WriteLine("nece eded yazmaq istediyinizi qeyd edin");
        int numbers = int.Parse(Console.ReadLine());
        int[] array = new int[numbers];

        for (int i = 0; i < numbers; i++)
        {
            Console.WriteLine("zehmet olmasa " + (i + 1) + "-ci ededi daxil edin");
            int x = int.Parse(Console.ReadLine());
            array[i] = x;
        }
        int odd_counter = 0;
        int odd_sum = 0;

        for (int i = 0; i < numbers; i++)
        {
            if (array[i] % 2 == 1)
            {
                odd_counter++;
                odd_sum += array[i];
            }
        }
        int result;
        result = odd_sum / odd_counter;
        Console.WriteLine("tek ededlerin ededi ortasi-->" + result);
    }
    catch (Exception)
    {
        Console.WriteLine("zehmet olmasa duzgun eded daxil edin");
    }

}
while (true);





do
{
    try
    {
        Console.WriteLine("ededi daxil edin");
        int number = Convert.ToInt32(Console.ReadLine());
        int i = 0;
        int counter = 0;
        for (; number >= 10;)
        {
            number = number / 10;
            counter++;
        }

        Console.WriteLine("daxil etdiyiniz eded " + (counter + 1) + " reqemlidir");



    }
    catch (Exception)
    {
        Console.WriteLine("zehmet olmsa duzgun eded daxil edin");
    }
}
while (true);


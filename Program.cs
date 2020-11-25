using System;

namespace MedionTest
{
    class Program
    {
        static int satuan(string satuan)
        {
            int res = 0;
            switch (satuan.ToLower())
            {
                case "satu":
                    // code block
                    res = 1;
                    break;
                case "dua":
                    res = 2;
                    break;
                case "tiga":
                    res = 3;
                    break;
                case "empat":
                    res = 4;
                    break;
                case "lima":
                    res = 5;
                    break;
                case "enam":
                    res = 6;
                    break;
                case "tujuh":
                    res = 7;
                    break;
                case "delapan":
                    res = 8;
                    break;
                case "sembilan":
                    res = 9;
                    break;
                default:
                    // code block
                    break;
            }
            return res;
        }
        static int multiplier(string mult)
        {
            int res = 0;
            if (mult == "puluh")
            {
                res = 10;
            }
            else if (mult == "ratus")
            {
                res = 100;
            }
            else if (mult == "ribu")
            {
                res = 1000;
            }
            else if (mult == "juta")
            {
                res = 1000000;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Masukan pembilang yang akan di konversl :");
            String input = Console.ReadLine();
            String[] inputsplit = input.Split(" ");
            int res = 0;
            int num;
            int temp = 0;
            int hasil = 0;
            bool end = false;
            for (int i = 0; i < inputsplit.Length; i++)
            {
                if (inputsplit[i].Substring(0, 2).ToLower() == "se" && inputsplit[i].ToLower() != "sembilan")
                {
                    if (inputsplit[i].Substring(2).ToLower() == "puluh")
                    {
                        res = 10;
                    }
                    if (inputsplit[i].Substring(2).ToLower() == "belas")
                    {
                        res = 11;
                    }
                    else if (inputsplit[i].Substring(2).ToLower() == "ratus")
                    {
                        res = 100;
                    }
                    else if (inputsplit[i].Substring(2).ToLower() == "ribu")
                    {
                        res = 1000;
                    }
                    if (i == inputsplit.Length - 1)
                    {
                        end = true;
                    }
                    else if (inputsplit[i + 1].Substring(0, 2).ToLower() == "se")
                    {
                        end = true;
                    }

                    
                }
                else
                {
                    inputsplit[i] = inputsplit[i].ToLower();
                    num = satuan(inputsplit[i]);
                    if (num == 0)
                    {
                        if (inputsplit[i] == "belas")
                        {
                            res += 10;
                            if (i == inputsplit.Length - 1)
                            {
                                end = true;
                            }
                        }
                        else
                        {
                            res = res * multiplier(inputsplit[i]);
                            if (res > hasil)
                            {
                                hasil = hasil * multiplier(inputsplit[i]);
                            }
                            if (i == inputsplit.Length - 1)
                            {
                                end = true;
                            }
                            else if (satuan(inputsplit[i + 1]) > 0 || inputsplit[i + 1].Substring(0, 2).ToLower() == "se")
                            {
                                end = true;
                            }
                        }
                    }
                    else
                    {
                        res = num;
                        if (i == inputsplit.Length -1)
                        {
                            end = true;
                        }
                    }
                }
                if (end)
                {
                    hasil = hasil + res;
                    if (hasil> 1000000 || i == inputsplit.Length - 1)
                    {
                        temp += hasil;
                        hasil = 0;
                    }
                    end = false;
                }
              //  Console.WriteLine(res);
            }
            //Console.WriteLine(hasil);
            Console.WriteLine(temp);


        }
    }
}

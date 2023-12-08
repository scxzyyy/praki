using System;

class CaesarCipher
{
    private int shift;

    public CaesarCipher(int shift)
    {
        this.shift = shift;
    }

    public string Encrypt(string input)
    {
        char[] result = input.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                result[i] = (char)((result[i] + shift - offset) % 26 + offset);
            }
        }

        return new string(result);
    }

    public string Decrypt(string input)
    {
        return Encrypt(input);
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для шифрования:");
        string inputString = Console.ReadLine();

        Console.WriteLine("Введите значение сдвига для шифра Цезаря:");
        int shiftValue = Convert.ToInt32(Console.ReadLine());

        CaesarCipher cipher = new CaesarCipher(shiftValue);
        string encryptedString = cipher.Encrypt(inputString);
        string decryptedString = cipher.Decrypt(encryptedString);

        Console.WriteLine($"Зашифровано: {encryptedString}");
        Console.WriteLine($"Расшифровано: {decryptedString}");
    }
}

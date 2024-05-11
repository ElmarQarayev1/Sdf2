using System.Numerics;
using System.Runtime.ConstrainedExecution;
using SdfElmar;
using SdfElmar.Exception;
using static System.Runtime.InteropServices.JavaScript.JSType;


//3."Map" qebul edib "Key" ve "Value" print eden generic method yazin. Nezere alin ki, methodun input type'i Map olmalidir.
//#region Task3

//Dictionary<string, int> telebeQiymetleri = new Dictionary<string, int>()
//        {
//            {"Elmar", 90},
//            {"Ilham", 85},
//            {"Behrem", 95}
//        };
//static void PrintKeyValue<TKey, TValue>(Dictionary<TKey, TValue> map)
//{
//    foreach (var telebe in map)
//    {
//        Console.WriteLine($"Adi: {telebe.Key}, Qiymeti: {telebe.Value}");
//    }
//}
//PrintKeyValue(telebeQiymetleri);
//#endregion


//4.Fayldan sozlerin siyahisini oxuyub uzunluqu 5 den boyuk olan soz tapdiqda "exception" atan proqram yazin. Bu methodu "main" methoddan cagirib throw olunan exception'i tutaraq eger exception olarsa "Failure", yox eger throw olmasa "Done" print edin.



//#region MyRegion

//try
//{
//    CheckWordLength("/Users/elmar/Desktop/SdfElmar/SdfElmar/File/elmar.txt");
//    Console.WriteLine("Done");
//}
//catch (FileLengthException)
//{
//    Console.WriteLine("Failure");
//}

//static void CheckWordLength(string filename)
//{
//    string line;
//    using (StreamReader reader = new StreamReader(filename))
//    {
//        while ((line = reader.ReadLine()) != null)
//        {
//            if (line.Length > 5)
//            {
//                throw new FileLengthException("Soz 5 xarakterden boyukdur!");
//            }
//        }
//    }
//}


//#endregion


//1. .Faylda olan en boyuk uzunluga malik sozu tapib eyni fayla yazan bir Java proqrami yazin.  Sozler line-by-line test.txt faylinda hazir qeyd olunmus varsayilacaq.
//#region MyRegion
//string filePath = "/Users/elmar/Desktop/SdfElmar/SdfElmar/File/elmar.txt";
//try
//{
//    string longestWord = "";
//    string[] lines = File.ReadAllLines(filePath);
//    foreach (string line in lines)
//    {
//        string[] words = line.Split(' ');
//        foreach (string word in words)
//        {
//            if (word.Length > longestWord.Length)
//            {
//                longestWord = word;
//            }
//        }
//    }
//    using (StreamWriter sw = File.AppendText(filePath))
//    {
//        sw.WriteLine(longestWord);
//    }
//    Console.WriteLine("en uzun soz: " + longestWord);
//}
//catch (IOException ex)
//{
//    Console.WriteLine("error: " + ex.Message);
//}
//#endregion


//String deyiseninin sonune A, B, C elave eden bir proqram yazin. Egger herf elave edilerken exception/error hal bas vererse(error hali imitasiya edilecek. Sadece prosesde exception throw oluna bilmelidir) elave olmus evvelki herfleri silib input string'i evvelki halina qaytarin.
//Meselen:
// -No error case
//Input string : Hello
//Output: HelloABC
//- Error case:
//    Input string : Hello
//    Output: Hello
//    Nezere alin ki, Chain of Responsibility design pattern istifade etmelisiniz ve her bir herf elave edilmesi ayri bir prosess hesab olunur(Her bir herfin elave olunmasi ve ya silinmesi ayri ayri classlarda bas vermelidir).Meselen: Istifadeci login olduqda daxil etdiyi input(username/ password) bir nece zencirvari merhelelerden kecmelidir: Username verifikasiyasi, password verifikasiyasi, login olma cehdlerinin sayi, heqiqeten bele istifadeci olub olmamasinin yoixlanilmasi.Bu prosesler her biri ayri - ayri componentdir ve zencirvari olaraq birlesdirile biler(Eyniyle her bir herfin string'e concatenate(birlesdirilmesi/sonuna elave olunmasi/silinmesi) kimi .


//#region MyRegion
//Console.Write("soz daxil edin: ");
//    string input = Console.ReadLine();

//    string output = AppendLetters(input);

//    Console.WriteLine("Output: " + output);
//    static string AppendLetters(string inputString)
//    {
//        if (inputString.ToLower().EndsWith("abc"))
//        {
//            return inputString;
//        }
//        string tempString = inputString;
//        try
//        {
//            tempString += "A";
//            tempString += "B";
//            tempString += "C";
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine("error: " + ex.Message);
//            tempString = inputString;
//        }
//        return tempString;
//    }
//    #endregion


/// 2ci versiya Chain of responsibility istifade ederek
//#region MyRegion

//string input = "Hello";

//IStringProcessor processorChain = new AppendProcessor(new BAppendProcessor(new AddCProcessor(null)));

//string result = processorChain.ProcessString(input);

//Console.WriteLine("Output: " + result);
//#endregion

#region MyRegion
// 5 ci suali txt faylinda qeyd etmisem
#endregion

Console.ReadLine();
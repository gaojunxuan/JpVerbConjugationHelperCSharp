using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JpVerbConjugationHelperCSharp.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Causative:");
            Console.WriteLine(VerbConjugationHelper.GetCausative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetCausative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetCausative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetCausative("使う"));
            Console.WriteLine("NegativeCausative:");
            Console.WriteLine(VerbConjugationHelper.GetNegativeCausative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeCausative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeCausative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeCausative("使う"));
            Console.WriteLine("Eba");
            Console.WriteLine(VerbConjugationHelper.GetEbaForm("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetEbaForm("くる"));
            Console.WriteLine(VerbConjugationHelper.GetEbaForm("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetEbaForm("使う"));
            Console.WriteLine("Imperative:");
            Console.WriteLine(VerbConjugationHelper.GetImperative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("使う"));
            Console.WriteLine("NegativeImperative:");
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("使う"));
            Console.WriteLine("Negative:");
            Console.WriteLine(VerbConjugationHelper.GetNegative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegative("使う"));
            Console.WriteLine("PastNeg:");
            Console.WriteLine(VerbConjugationHelper.GetPastNegative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetPastNegative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetPastNegative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetPastNegative("使う"));
            Console.WriteLine("Passive:");
            Console.WriteLine(VerbConjugationHelper.GetPassive("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetPassive("くる"));
            Console.WriteLine(VerbConjugationHelper.GetPassive("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetPassive("使う"));
            Console.WriteLine("NegativePassive:");
            Console.WriteLine(VerbConjugationHelper.GetNegativePassive("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePassive("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePassive("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePassive("使う"));
            Console.WriteLine("Potential:");
            Console.WriteLine(VerbConjugationHelper.GetPotential("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetPotential("くる"));
            Console.WriteLine(VerbConjugationHelper.GetPotential("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetPotential("使う"));
            Console.WriteLine("NegativePotential:");
            Console.WriteLine(VerbConjugationHelper.GetNegativePotential("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePotential("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePotential("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativePotential("使う"));
            Console.WriteLine("Ta:");
            Console.WriteLine(VerbConjugationHelper.GetTaForm("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetTaForm("くる"));
            Console.WriteLine(VerbConjugationHelper.GetTaForm("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetTaForm("使う"));
            Console.WriteLine("Te:");
            Console.WriteLine(VerbConjugationHelper.GetTeForm("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetTeForm("くる"));
            Console.WriteLine(VerbConjugationHelper.GetTeForm("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetTeForm("使う"));
            Console.WriteLine("Imperative:");
            Console.WriteLine(VerbConjugationHelper.GetImperative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetImperative("使う"));
            Console.WriteLine("NegativeImperative:");
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("くる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetNegativeImperative("使う"));
            Console.WriteLine("Volitional:");
            Console.WriteLine(VerbConjugationHelper.GetVolitional("運転する"));
            Console.WriteLine(VerbConjugationHelper.GetVolitional("くる"));
            Console.WriteLine(VerbConjugationHelper.GetVolitional("食べる"));
            Console.WriteLine(VerbConjugationHelper.GetVolitional("使う"));
            Console.ReadLine();
        }
    }
}

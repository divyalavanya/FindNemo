using System;

class Program {

  public const string Nemo = "Nemo";

  public static void Main (string[] args) {
   
   if(FindNemo(new string[]{"Random","No","Divya"}))
   {
     Console.WriteLine("Found Nemo");
   }
   else
   {
       Console.WriteLine("Not Found Nemo"); 
   }
  }

  public static bool FindNemo(string[] Names)
  {
    for(int i = 0 ; i < Names.Length; i++)
    {
      if(Names[i] == Nemo)
      {
        return true;
      }
    }

    return false;
  }


}
/*void ShowArray (string[] args)
    {
    string[] words; 
    int count; 
    string s;
    string[] words2;
    Console.WriteLine("Enter strings:");
    count = 0; 
    words = new string[count];
    do
      {
        s = Console.ReadLine();
        if (s!="")
        {
          count++;
          words2 = new string[count];
          for (int i = 0; i < words2.Length - 1; i++)
            words2[i] = words[i];
         words2[count - 1] = s;
          words = words2;
        }
      } while (s != "");
      for (int i = 0; i < words.Length; i++)
        Console.Write(words[i] + " ");
        Console.ReadKey();
      
    }
 */
void CreateNewString(string[] args)
{
  
  string[] animals = { "cat", "dog", "cow", "bird","elefante", "pig", "2", "1000"};
  for (int i =0; i< animals.Length; i++)
  Console.Write(animals [i] +" "); 
  Console.WriteLine(); 
  int count = 0;
  string[] animalsnew = new string [count];
  string [] animalstemp;
  for (int k =0; k< animals.Length; k++)
  {
  char[] arr;
  arr = animals [k].ToCharArray();
    {
    if (arr.Length <= 3)
    {
    count++;
    string Str = new string(arr);
    animalstemp = new string [count];
    for (int l = 0; l < animalstemp.Length -1; l++)
      animalstemp[l] = animalsnew[l];
    animalstemp[count -1] = Str;
    animalsnew = animalstemp;
    }
    }
  }
  
   
}
CreateNewString (args); 
  
  

    
    
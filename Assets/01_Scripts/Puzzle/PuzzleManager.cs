   using UnityEngine;

   public class PuzzleManager : MonoBehaviour
   {
       [SerializeField] private string[] validCodes = { "1234", "4321" };
       [SerializeField] private int maxAttempts = 3;
       [SerializeField] private ChestController chest;

       private int attempts;

       public bool CheckCode(string input)
       {
           attempts++;

           foreach (string code in validCodes)
           {
               if (input == code)
               {
                   Debug.Log("Puzzle resuelto.");

                   if (chest != null)
                   {
                       chest.Unlock();
                   }

                   return true;
               }
           }

           Debug.Log("Intento fallido " + attempts + " de " + maxAttempts);
           return false;
       }
   }
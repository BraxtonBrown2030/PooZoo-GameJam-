using System.Collections;
using UnityEngine;

public class AnimalEssesseSpawning : MonoBehaviour
{
   public animalScriptibleObject animal;
   
   private void Start()
   {
      StartCoroutine(TimerCoroutine());
   }

   private IEnumerator TimerCoroutine()
   {
      while (true)
      {
         yield return new WaitForSeconds(animal.essenseSpawntime);
         spawnEssense();
      }
   }

   public void spawnEssense()
   {
      Debug.Log("Essense Spawned!" + animal.animalName);
   }
    
    
}

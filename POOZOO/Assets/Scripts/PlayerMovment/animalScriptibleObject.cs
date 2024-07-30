using UnityEngine;

[CreateAssetMenu(menuName = "Animal",fileName = "New Animal",order = 1)]
public class animalScriptibleObject : ScriptableObject
{
    
    public string animalName;
    public float aniamalSpeed;
    public float essenseSpawntime;
    public float essenseSpawnAmount;
    public GameObject animalEssesnceObject;
    public Sprite animalSprite;
    

}

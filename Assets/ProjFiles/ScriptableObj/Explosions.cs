using UnityEngine;

[CreateAssetMenu(fileName = "Explosion", menuName = "Scriptable Objects/Explosions")]
public class Explosions : ScriptableObject
{
    public GameObject[] explosionsList = new GameObject[1];
}

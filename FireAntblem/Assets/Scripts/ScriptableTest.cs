using UnityEngine;

[CreateAssetMenu(fileName = "UnitData", menuName = "UnitData", order = 1)]
public class ScriptableTest : ScriptableObject
{
    public string unitName;
    public float health;
    public float strength;

    public Color color;
}

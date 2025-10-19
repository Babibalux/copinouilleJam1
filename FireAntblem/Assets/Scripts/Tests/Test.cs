using UnityEngine;

public class Test : MonoBehaviour
{
    public ScriptableTest unitData;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        GetComponent<MeshRenderer>().material.color = unitData.color;
    }
}

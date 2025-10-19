using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;

public class SquadEXAMPLE : MonoBehaviour
{
    public float moveSpeed;
    public Vector3 movement;
    public float occupationRange;
    public SphereCollider occupationCollider;

    public List<UnitEntity> units;

    void Start()
    {
        occupationCollider.radius = occupationRange;

        foreach (UnitEntity unit in units)
        {
            unit.squad = this;
        }
    }

    void Update()
    {
        Vector3 movementVector = movement * moveSpeed * Time.deltaTime;
        this.gameObject.transform.Translate(movementVector);

        foreach (UnitEntity unit in units)
        {
            unit.Move(movementVector);
        }

    }
}

using UnityEngine;

public class UnitEntity : MonoBehaviour
{
    public UnitSO unitData;

    public SquadEXAMPLE squad;

    void Start()
    {

    }

    void Update()
    {
        
    }

    public void Move(Vector3 moveDir)
    {
        float bonusSpeed = 1f;

        if(Vector3.Distance(squad.transform.position,this.transform.position) <= squad.occupationRange)
        {
            bonusSpeed = unitData.PassiveSpeed;
        }

        this.transform.Translate(moveDir * bonusSpeed);
    }
}

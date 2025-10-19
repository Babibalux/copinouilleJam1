using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SquadSO", menuName = "Scriptable Objects/SquadSO")]
public class SquadSO : ScriptableObject
{
    #region Properties
    [SerializeField, HideInInspector] private string id;
    private List<UnitSO> units;
    #endregion

    #region Getters
    public List<UnitSO> Units => units;
    #endregion

    #region Setters
    public void SetUnits(List<UnitSO> value) => units = value;
    #endregion

    #region Validation
    private void OnValidate()
    {
        new IdValidator().ValidateID(this);
    }
    #endregion
}

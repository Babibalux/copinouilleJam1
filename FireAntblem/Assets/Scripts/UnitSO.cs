using UnityEngine;

[CreateAssetMenu(fileName = "UnitSO", menuName = "Scriptable Objects/UnitSO")]
public class UnitSO : ScriptableObject
{
    #region Properties
    [SerializeField, HideInInspector] private string id;
    [SerializeField] private string unitName;
    [SerializeField, TextArea] private string description;
    [SerializeField] private Sprite icon;
    [SerializeField] private Color color;
    [SerializeField] private float health;
    [SerializeField] private float maxHealth;
    [SerializeField] private float passiveSpeed;
    [SerializeField] private float offensiveSpeed;
    [SerializeField] private float attackDamage;
    [SerializeField] private float attackSpeed;
    [SerializeField] private float attackRange;
    #endregion

    #region Getters
    public string Id => id;
    public string UnitName => unitName;
    public string Description => description;
    public Sprite Icon => icon;
    public Color Color => color;
    public float Health => health;
    public float MaxHealth => maxHealth;
    public float PassiveSpeed => passiveSpeed;
    public float OffensiveSpeed => offensiveSpeed;
    public float AttackDamage => attackDamage;
    public float AttackSpeed => attackSpeed;
    public float AttackRange => attackRange;
    #endregion

    #region Setters
    public void SetId(string value) => id = value;
    public void SetUnitName(string value) => unitName = value;
    public void SetDescription(string value) => description = value;
    public void SetIcon(Sprite value) => icon = value;
    public void SetColor(Color value) => color = value;
    public void SetHealth(float value) => health = value;
    public void SetMaxHealth(float value) => maxHealth = value;
    public void SetPassiveSpeed(float value) => passiveSpeed = value;
    public void SetOffensiveSpeed(float value) => offensiveSpeed = value;
    public void SetAttackDamage(float value) => attackDamage = value;
    public void SetAttackSpeed(float value) => attackSpeed = value;
    public void SetAttackRange(float value) => attackRange = value;
    #endregion

    #region Validation
    private void OnValidate()
    {
        new IdValidator().ValidateID(this);
    }
    #endregion
}

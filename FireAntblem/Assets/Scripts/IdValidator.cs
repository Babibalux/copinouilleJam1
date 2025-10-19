using UnityEngine;

public class IdValidator
{
    public void ValidateID(ScriptableObject so)
    {
        var idField = so.GetType().GetField("id", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        if (idField != null)
        {
            string idValue = (string)idField.GetValue(so);
            if (string.IsNullOrEmpty(idValue))
            {
                idField.SetValue(so, System.Guid.NewGuid().ToString());
                #if UNITY_EDITOR
                UnityEditor.EditorUtility.SetDirty(so);
                #endif
            }
        }
    }
}

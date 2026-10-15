using UnityEngine;

public class PuzzleManager : MonoBehaviour
{
    [SerializeField] private string[] validCodes = { "1234" };
    [SerializeField] private int maxAttempts = 3;
    [SerializeField] private ChestController chest;

    private int attempts;

    public bool ValidateCode(string code)
    {
        if (string.IsNullOrWhiteSpace(code)) return false;
        code = code.Trim();
        attempts++;

        foreach (string valid in validCodes)
        {
            if (code == valid)
            {
                Debug.Log("Código correcto.");

                if (chest != null)
                {
                    chest.Unlock();
                }

                return true;
            }
        }

        Debug.Log("Código incorrecto. Intento " + attempts + " de " + maxAttempts);
        return false;
    }
    [ContextMenu("Probar codigo 1234 (prueba)")]
    private void TestCorrectCode() { ValidateCode("1234"); }
}
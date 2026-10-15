using UnityEngine;

public class PuzzleCodeInput : MonoBehaviour
{
    [SerializeField] private PuzzleManager puzzleManager;

    private string code = "";

    private void OnGUI()
    {
        GUI.Label(new Rect(10, 10, 200, 25), "Código:");
        code = GUI.TextField(new Rect(10, 35, 150, 25), code, 4);

        if (GUI.Button(new Rect(10, 65, 150, 25), "Probar"))
        {
            puzzleManager.ValidateCode(code);
        }
    }
}
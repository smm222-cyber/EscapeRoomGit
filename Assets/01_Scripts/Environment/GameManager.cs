using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    public bool HasKey { get; private set; }
    private int initCount;

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        Initialize();
    }

    public void Initialize()
    {
        initCount++;
        Debug.Log("GameManager.Initialize ejecutado. Veces: " + initCount);
        if (initCount > 1)
            Debug.LogError("Initialize se ejecutó más de una vez");
    }

    public void ObtainKey()
    {
        HasKey = true;
    }

    [ContextMenu("Dar llave (prueba)")]
    private void GiveKeyForTest()
    {
        ObtainKey();
        Debug.Log("Llave entregada.");
    }
}
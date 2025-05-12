using UnityEngine;

public class GameState : MonoBehaviour
{
    public static GameState Instance;

    public int pickCount = 0;
    public int putCount = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

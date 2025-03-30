using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool isRadioOn = false;
    public bool isTVOn = false;

    public bool isBoardOn = false;

    public bool isStreetLampOn = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // 씬이 변경돼도 유지
        }
        else
        {
            Destroy(gameObject); // 씬을 이동할 때 GameManager가 중복 생성되지 않도록 방지
        }
    }

    public void SaveState(string objName, bool state)
    {
        switch (objName)
        {
            case "Radio":
                isRadioOn = state;
                break;
            case "monitor":
                isTVOn = state;
                break;
            case "DisplayBoard":
                isBoardOn = state;
                break;
            case "StreetLamp":
                isStreetLampOn = state;
                break;
        }
    }

    public bool LoadState(string objName)
    {
        return objName switch
        {
            "Radio" => isRadioOn,
            "monitor" => isTVOn,
            "StreetLamp" => isStreetLampOn,
            "DisplayBoard" => isBoardOn,
            _ => false
        };
    }
}

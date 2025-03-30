using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                // 씬에 GameManager가 없으면 자동 생성
                GameObject obj = new GameObject("GameManager");
                _instance = obj.AddComponent<GameManager>();
                DontDestroyOnLoad(obj);
            }
            return _instance;
        }
    }

    public bool isRadioOn = false;
    public bool isTVOn = false;
    public bool isBoardOn = false;
    public bool isStreetLampOn = false;

    private void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instance != this)
        {
            Destroy(gameObject); // 중복 방지
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

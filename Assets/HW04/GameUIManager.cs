using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro; // TextMeshPro용 네임스페이스 추가

public class GameUIManager : MonoBehaviour
{
    public TextMeshProUGUI pickText;
    public TextMeshProUGUI putText;
    public Button goToScene02Button;

    void Start()
    {
        UpdateUI();
        goToScene02Button.onClick.AddListener(() => {
            SceneManager.LoadScene("Scene02");
        });
    }

    void UpdateUI()
    {
        pickText.text = $"Pick: {GameState.Instance.pickCount}";
        putText.text = $"Put: {GameState.Instance.putCount}";
    }

    void Update()
    {
        UpdateUI(); // 실시간 갱신
    }
}


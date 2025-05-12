using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameUIManager : MonoBehaviour
{
    public Text pickText;
    public Text putText;
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

using UnityEngine;
using TMPro;

public class ResultScoreViewer : MonoBehaviour
{
    private TextMeshProUGUI textResultScore;

    private void Awake()
    {
        textResultScore = GetComponent<TextMeshProUGUI>();
        // Stage에서 저자한 점수를 불러와서 score 변수에 저장
        int score = PlayerPrefs.GetInt("Score");
        textResultScore.text = "Result Score " + score;
    }
}
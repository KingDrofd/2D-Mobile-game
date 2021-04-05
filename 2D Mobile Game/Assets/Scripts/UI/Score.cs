using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public static int livesValue = 3;

    public TextMeshProUGUI livesNo;
    public TextMeshProUGUI scoreNo;
    void Start()
    {
        //scoreNo = GetComponent<TextMeshProUGUI>();
        //
    }


    void Update()
    {
        scoreNo.text = scoreValue.ToString();
        livesNo.text = "x" + livesValue.ToString();
    }
}

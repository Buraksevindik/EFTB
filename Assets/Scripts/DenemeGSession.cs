using UnityEngine;
using UnityEngine.UI;

public class DenemeGSession : MonoBehaviour
{
    [SerializeField] Text scoreText;
    [SerializeField] int _score = 1;
    void Start()
    {
        scoreText.text = _score.ToString();
    }
    public void AddToScore(int poinsToAdd)
    {
        _score += poinsToAdd;
        scoreText.text = _score.ToString();
    }
}

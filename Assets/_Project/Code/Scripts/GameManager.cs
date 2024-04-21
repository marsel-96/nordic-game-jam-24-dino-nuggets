using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    [SerializeField] private int scoreIncreaser = 2;
    [SerializeField] private int scoreDecreaser = 15;
    
    [SerializeField] private int multiplier = 3;
    
    public BeamGenerator generator;
    public TextMeshProUGUI uiText;
    
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        }
    }
    
    public void AddPlanet()
    {
        scoreIncreaser += 1;
    }
    
    public void DecreasePlanet()
    {
        scoreIncreaser -= 1;
    }
    
    public void IncreaseScore()
    {
        _playerScore += scoreIncreaser * multiplier * 2;
        uiText.text = $"{_playerScore:D8}";
    }
    
    public void DecreaseScore()
    {
        _playerScore -= scoreDecreaser;
        if (_playerScore < 0)
        {
            _playerScore = 0;
        }
        uiText.text = $"{_playerScore:D8}";
    }
    
}

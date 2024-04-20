using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private int _playerScore;
    private int _scoreIncreaser = 2;
    private int _scoreDecreaser = 15;
    
    private int multiplier = 3;
    
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
        _scoreIncreaser += 1;
    }
    
    public void DecreasePlanet()
    {
        _scoreIncreaser -= 1;
    }
    
    public void IncreaseScore()
    {
        _playerScore += _scoreIncreaser * multiplier;
        uiText.text = $"{_playerScore:D8}";
    }
    
    public void DecreaseScore()
    {
        _playerScore -= _scoreDecreaser;
        if (_playerScore < 0)
        {
            _playerScore = 0;
        }
        uiText.text = $"{_playerScore:D8}";
    }
    
}
